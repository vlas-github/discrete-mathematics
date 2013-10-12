using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Collections;

namespace DM_lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] A;
        int[] B;

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

            Random r = new Random(new DateTime().Millisecond);

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
            dgTable.Columns.Add(new DataGridTextColumn());
            
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                dgTable.Columns.Add(new DataGridTextColumn());
            }

            for (int i = 0; i < mas.GetLength(1); i++)
            {
                dgTable.
            }
        }

        private void generateA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbSizeA.Text.ToString());
                A = createdArray(size);

                lblViewA.Content = "Множество A: " + showArray(A);
            }
            catch (Exception)
            {
                int size = 10;
                tbSizeA.Text = size.ToString();
                A = createdArray(size);

                lblViewA.Content = "Множество A: " + showArray(A);
            }
        }
        private void generateB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbSizeB.Text.ToString());
                B = createdArray(size);

                lblViewB.Content = "Множество A: " + showArray(B);
            }
            catch (Exception)
            {
                int size = 10;
                tbSizeB.Text = size.ToString();
                B = createdArray(size);

                lblViewB.Content = "Множество A: " + showArray(B);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbAction.Text = "Выберете действие: ";
            cbAction.Items.Add("1. A > B");
            cbAction.Items.Add("2. A >= B");
            cbAction.Items.Add("3. A = B");
            cbAction.Items.Add("4. A mad B = 0");
            cbAction.Items.Add("5. A mod 2 = 0 или B mod 2 = 0");
            cbAction.Items.Add("6. A mod 2 = 0 и B mod 2 = 0");
        }

        private void cbAction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //try
            //{
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
            //}
            //catch (Exception)
            //{
            //    label1.Content = "Error";
            //}
        }
    }
}
