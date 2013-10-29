using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DM_lab5_2.RPN;
using DM_lab5_2.ExpressionClasses;

namespace DM_lab5_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnConverseImplecation, "Обратная имплекация");
            toolTip1.SetToolTip(btnEquivalence, "Эквивалентность");
            toolTip1.SetToolTip(btnImplecation, "Имплекация");
            toolTip1.SetToolTip(btnInterselection, "Конъюнкция");
            toolTip1.SetToolTip(btnModulo2, "Сумма Жигалкина");
            toolTip1.SetToolTip(btnNegation, "Отрицание");
            toolTip1.SetToolTip(btnPierceArrow, "Стрелка Пирса");
            toolTip1.SetToolTip(btnShefferStroke, "Штрих Шеффера");
            toolTip1.SetToolTip(btnUnion, "Дезъюнкция");
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text = "";
        }

        private void btnFALSE_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "0";
        }

        private void btnTRUE_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "1";
        }

        private void btnBKT2_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += ")";
        }

        private void btnBKT1_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "(";
        }

        private void btnShefferStroke_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "|";
        }

        private void btnPierceArrow_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "↓";
        }

        private void btnModulo2_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "⊕";
        }

        private void btnEquivalence_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "↔";
        }

        private void btnConverseImplecation_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "←";
        }

        private void btnImplecation_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "→";
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "ᐯ";
        }

        private void btnInterselection_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "ᐱ";
        }

        private void btnNegation_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "¬";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "I";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "H";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "G";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "F";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "E";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "D";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "C";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "B";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text += "A";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            tbOriginalFunction.Text = tbOriginalFunction.Text.ToString()
                .Substring(0, tbOriginalFunction.Text.ToString().Length - 1);
        }

        private void initializeDataGridView(List<string> var)
        {
            dgvTableTrue.Columns.Clear();

            int n = var.Count;

            dgvTableTrue.ColumnCount = n + 1;
            dgvTableTrue.RowCount = (int)Math.Pow((double)2, (double)n);

            for (int i = 0; i < n + 1; i++)
            {
                dgvTableTrue.Columns[i].Width = 50;

                if (i < n)
                    dgvTableTrue.Columns[i].HeaderText = var[i];
                else
                    dgvTableTrue.Columns[i].HeaderText = "f(...)";
            }

            for (int i = 0; i < (int)Math.Pow((double)2, (double)n); i++)
            {

                string binaryCode = Convert.ToString(i, 2);

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

        private void calculusExpression(PostfixNotation pn)
        {
            int n = pn.getVar().Count;
            Expression exp = pn.convertToExpression();

            for (int i = 0; i < dgvTableTrue.RowCount; i++)
            {

                List<bool> tmp = new List<bool>();

                for (int j = 0; j < dgvTableTrue.ColumnCount - 1; j++)
                {
                    tmp.Add(dgvTableTrue[j, i].Value.ToString() == "True");
                }

                dgvTableTrue[n, i].Value = exp.calculate(tmp) ? "True" : "0";
            }
        }

        private void btnCalculus_Click(object sender, EventArgs e)
        {
            PostfixNotation pn = new PostfixNotation(tbOriginalFunction.Text.ToString());

            List<string> var = pn.getVar();

            initializeDataGridView(var);

            calculusExpression(pn);




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
