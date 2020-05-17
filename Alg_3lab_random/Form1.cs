using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alg_3lab_random
{
    public partial class lab3 : Form
    {
        public lab3()
        {
            InitializeComponent();
        }

        private static int[,] Random_matrix(ListBox listBox)
        {
            int[,] matrix = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rnd.Next(50);
                }
            }
            string zer = Convert.ToString(matrix[0, 0]);
            string fir = Convert.ToString(matrix[0, 1]);
            string sec = Convert.ToString(matrix[0, 2]);
            string[] values = new string[] { zer, fir, sec };
            String row = String.Join(" ", values);

            string zer1 = Convert.ToString(matrix[1, 0]);
            string fir1 = Convert.ToString(matrix[1, 1]);
            string sec1 = Convert.ToString(matrix[1, 2]);
            string[] values1 = new string[] { zer1, fir1, sec1 };
            String row1 = String.Join(" ", values1);

            string zer2 = Convert.ToString(matrix[2, 0]);
            string fir2 = Convert.ToString(matrix[2, 1]);
            string sec2 = Convert.ToString(matrix[2, 2]);
            string[] values2 = new string[] { zer2, fir2, sec2 };
            String row2 = String.Join(" ", values2);

            listBox.Items.Insert(0, row);
            listBox.Items.Insert(1, row1);
            listBox.Items.Insert(2, row2);

            return matrix;
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            if (first_matrix.Items.Count == 0)
            {
                int[,] matrix = Random_matrix(first_matrix);
                //int[,] matrix = { {2,9,13 }, {4,3,5 }, { 18, 0, 7} }; for debugging
                bool brk = false;
                int flag = 0;
                int col = 0;
                int num = 0; //for debugging
                for (int i = 0; i < 3; i++)
                {
                    if (brk == true) { break; }
                    if (flag < 3) { flag = 0; }
                    for (int j = 0; j < 3; j++)
                    {
                        num = matrix[j, i]; //for debugging
                        if ((matrix[j, i] % 2) == 0)
                        {
                            if (flag < 3)
                            {
                                flag += 1;
                            }
                            if (flag == 3)
                            {
                                col = i + 1;
                                brk = true;
                                break;
                            }
                        }
                        else
                        {
                            flag = 0;
                        }                    
                    }
                }
                if (flag == 3)
                {
                    col_exists.Visible = true;
                    column.Visible = true;
                    col_exists.Text = "column exists";
                    column.Text = col.ToString() + " " + "column";
                }
                else
                {
                    col_exists.Text = "column doesn't exist";
                    column.Text = "";
                }
            }
            else {
                first_matrix.Items.Clear();
                column.Visible = false;
                col_exists.Text = "list has been cleared,\n press again ";
            }
        }

        private void sec_btn_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue, max = int.MinValue;

            if (second_matrix.Items.Count == 0)
            {
                int[,] matrix2 = Random_matrix(second_matrix);
                for (int row = 0; row < 3; row++)
                    for (int col = 3 - row; col < 3; col++)
                        if (matrix2[row, col] > max)
                            max = matrix2[row, col];
                max_label.Text = max.ToString() + " - " + "maximum number";

                for (int row = 0; row < 3; row++)
                    for (int col = row + 1; col < 3; col++)
                        if (matrix2[row, col] < min) 
                            min = matrix2[row, col];
                min_label.Visible = true;
                min_label.Text = min.ToString() + " - " + "minimum nuber";
            }
            else {
                second_matrix.Items.Clear();
                min_label.Visible = false;
                max_label.Text = "list has been cleared,\n press again ";
            }      
        }
    }
}
