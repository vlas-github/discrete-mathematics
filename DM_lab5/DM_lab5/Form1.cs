using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DM_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void initializeDataGridView(int n)
        {
            dgvTableTrue.Columns.Clear();

            dgvTableTrue.ColumnCount = n + 1;
            dgvTableTrue.RowCount = (int)Math.Pow((double)2, (double)n);
            
            for (int i = 0; i < n + 1; i++)
            {
                dgvTableTrue.Columns[i].Width = 50;
            }

            for (int i = 0; i < (int)Math.Pow((double)2, (double)n); i++)
            {

                string binaryCode = Convert.ToString(i, 2);
                Debug.WriteLine(binaryCode);

                for (int j = 0; j < n; j++)
                {
                    if (n - j <= binaryCode.Length)
                        dgvTableTrue[j, i].Value = 
                            binaryCode[binaryCode.Length - n + j] == '1' ? "True" : "0";
                    else
                        dgvTableTrue[j, i].Value = "0";
                }
            }
        }

        private Expression createExpression()
        {
            List<List<bool>> list = new List<List<bool>>();

            for (int i = 0; i < dgvTableTrue.RowCount; i++)
            {
                list.Add(new List<bool>());

                for (int j = 0; j < dgvTableTrue.ColumnCount; j++)
                    list[i].Add(dgvTableTrue[j, i].Value == "True" ? true : false);
            }

            int A = dgvTableTrue.ColumnCount - 4 + 0;
            int B = dgvTableTrue.ColumnCount - 4 + 1;
            int C = dgvTableTrue.ColumnCount - 4 + 2;

            dgvTableTrue.Columns[dgvTableTrue.ColumnCount - 1].HeaderText = "F(A,B,C)";
            dgvTableTrue.Columns[dgvTableTrue.ColumnCount - 2].HeaderText = "C";
            dgvTableTrue.Columns[dgvTableTrue.ColumnCount - 3].HeaderText = "B";
            dgvTableTrue.Columns[dgvTableTrue.ColumnCount - 4].HeaderText = "A";

            return new Modulo2(
                new Modulo2(
                    new Intersection(
                        new Union(
                            new Variable(list, A),
                            new Variable(list, B)),
                        new Union(
                            new Negation(new Variable(list, B)),
                            new Variable(list, C))),
                    new Equivalence(
                        new Variable(list, A),
                        new Variable(list, C))),
                new Implication(
                    new Variable(list, B), 
                    new Negation(new Variable(list, C))));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                initializeDataGridView(Convert.ToInt32(tbN.Text));
                Expression exp = createExpression();

                for (int i = 0; i < dgvTableTrue.RowCount; i++)
                {
                    dgvTableTrue[dgvTableTrue.ColumnCount - 1, i].Value = 
                        exp.calculate(i) ? "True" : "0";
                }
            }
            catch (Exception)
            {
                Debug.WriteLine(Convert.ToString(5, 2));

            }
        }
    }
}
