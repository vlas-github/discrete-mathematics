using System;
using System.Text;
using System.Windows.Forms;

namespace DM_lab3_2
{
    public partial class Form1 : Form
    {
        int[] A;
        int[] B;

        public Form1()
        {
            InitializeComponent();
        }

        int[,] more(int[] A, int[] B)
        {
            int[,] result = new int[A.Length, B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] > B[j])
                        result[i, j] = 1;
                    else
                        result[i, j] = 0;
                }
            }

            return result;
        }
        int[,] moreOrEqual(int[] A, int[] B)
        {
            int[,] result = new int[A.Length, B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] >= B[j])
                        result[i, j] = 1;
                    else
                        result[i, j] = 0;
                }
            }

            return result;
        }
        int[,] equal(int[] A, int[] B)
        {
            int[,] result = new int[A.Length, B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                        result[i, j] = 1;
                    else
                        result[i, j] = 0;
                }
            }

            return result;
        }
        int[,] AModB(int[] A, int[] B)
        {
            int[,] result = new int[A.Length, B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] % B[j] == 0)
                        result[i, j] = 1;
                    else
                        result[i, j] = 0;
                }
            }

            return result;
        }
        int[,] AMod2OrBMod2(int[] A, int[] B)
        {
            int[,] result = new int[A.Length, B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] % 2 == 0 || B[j] % 2 == 0)
                        result[i, j] = 1;
                    else
                        result[i, j] = 0;
                }
            }

            return result;
        }
        int[,] AMod2AndBMod2(int[] A, int[] B)
        {
            int[,] result = new int[A.Length, B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] % 2 == 0 && B[j] % 2 == 0)
                        result[i, j] = 1;
                    else
                        result[i, j] = 0;
                }
            }

            return result;
        }

        int[] createdArray(int size)
        {
            int[] result = new int[size];

            Random r = new Random();

            for (int i = 0; i < size; i++)
            {
                result[i] = r.Next() % 10;
            }

            return result;
        }

        String showArray(int[] mas)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");

            for (int i = 0; i < mas.Length; i++)
            {
                if (i == mas.Length - 1)
                    sb.Append(mas[i].ToString() + " }");
                else
                    sb.Append(mas[i] + ", ");
            }

            return sb.ToString();
        }

        void creatreDateGreed(int[,] mas)
        {
            dgvArray.ColumnCount = mas.GetLength(0);
            dgvArray.RowCount = mas.GetLength(1);
            dgvArray.AutoResizeColumns();
            dgvArray.RowHeadersWidth = 50;

            for (int i = 0; i < A.Length; i++)
            {
                dgvArray.Columns[i].HeaderCell.Value = A[i].ToString();
                dgvArray.Columns[i].Width = (dgvArray.Width - 44) / (A.Length);
            }

            for (int i = 0; i < B.Length; i++)
                dgvArray.Rows[i].HeaderCell.Value = B[i].ToString();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    dgvArray[i, j].Value = mas[i, j].ToString();
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cbAction.Text = "Выберете действие: ";
            cbAction.Items.Add("1. A > B");
            cbAction.Items.Add("2. A >= B");
            cbAction.Items.Add("3. A = B");
            cbAction.Items.Add("4. A mad B = 0");
            cbAction.Items.Add("5. A mod 2 = 0 или B mod 2 = 0");
            cbAction.Items.Add("6. A mod 2 = 0 и B mod 2 = 0");
        }
        private void btnGenerateA_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbSizeA.Text.ToString());
                A = createdArray(size);

                lblSetA.Text = "Множество A: " + showArray(A);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно, использованны данные по умолчанию!",
                        "Неверные данные",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                int size = 10;
                tbSizeA.Text = size.ToString();
                A = createdArray(size);

                lblSetA.Text = "Множество A: " + showArray(A);
            }
        }
        private void btnGenerateB_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbSizeB.Text.ToString());
                B = createdArray(size);

                lblSetB.Text = "Множество A: " + showArray(B);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно, использованны данные по умолчанию!",
                        "Неверные данные",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                int size = 10;
                tbSizeB.Text = size.ToString();
                B = createdArray(size);

                lblSetB.Text = "Множество B: " + showArray(B);
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            int[,] result = new int[A.Length, B.Length];
            switch (cbAction.SelectedIndex)
            {
                case 0:
                    result = more(A, B);
                    break;
                case 1:
                    result = moreOrEqual(A, B);
                    break;
                case 2:
                    result = equal(A, B);
                    break;
                case 3:
                    result = AModB(A, B);
                    break;
                case 4:
                    result = AMod2OrBMod2(A, B);
                    break;
                case 5:
                    result = AMod2AndBMod2(A, B);
                    break;
            }

            creatreDateGreed(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные не введены или введены неверно!",
                        "Неверные данные",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                tbSizeA.Text = "";
                tbSizeB.Text = "";

                lblSetA.Text = "Множество А:";
                lblSetB.Text = "Множество B:";

                cbAction.Text = "Выберете действие: ";
            }
        }

        private void dgvArray_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
