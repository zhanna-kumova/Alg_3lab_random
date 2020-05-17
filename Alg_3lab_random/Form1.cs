using System;
using System.Windows.Forms;

namespace Alg_3lab_random
{
    public partial class lab3 : Form
    {
        public lab3()
        {
            InitializeComponent();
        }

        private static int[,] Random_matrix(DataGridView dataGrid)
        {
            Random rnd = new Random();
            int mtrxSize = rnd.Next(2, 5);
            dataGrid.RowCount = mtrxSize;
            dataGrid.ColumnCount = mtrxSize;
            int[,] matrix = new int[mtrxSize, mtrxSize];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(50);
                    dataGrid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            return matrix;
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            if (matrix1dGV.Rows.Count <= 1)
            {
                int[,] matrix = Random_matrix(matrix1dGV);
                bool brk = false;
                int flag = 0;
                int col = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (brk == true) { break; }
                    if (flag < matrix.GetLength(1)) { flag = 0; }
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if ((matrix[j, i] % 2) == 0)
                        {
                            if (flag < matrix.GetLength(1))
                            {
                                flag += 1;
                            }
                            if (flag == matrix.GetLength(1))
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
                if (flag == matrix.GetLength(1))
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
            else
            {
                matrix1dGV.Rows.Clear();
                column.Visible = false;
                col_exists.Text = "matrix has been cleared,\n press again ";
            }
        }

        private void sec_btn_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue, max = int.MinValue;

            if (matrix2dGV.Rows.Count <= 1)
            {
                int[,] matrix2 = Random_matrix(matrix2dGV);
                for (int row = 0; row < matrix2.GetLength(0); row++)
                {
                    for (int col = matrix2.GetLength(0) - row; col < matrix2.GetLength(1); col++)
                    {
                        if (matrix2[row, col] > max)
                        {
                            max = matrix2[row, col];
                        }                        
                    }
                }
                max_label.Text = max.ToString() + " - " + "maximum number";
                for (int row = 0; row < matrix2.GetLength(0); row++)
                {
                    for (int col = row + 1; col < matrix2.GetLength(1); col++)
                    {
                        if (matrix2[row, col] < min)
                        {
                            min = matrix2[row, col];
                        }                        
                    }
                }
                min_label.Visible = true;
                min_label.Text = min.ToString() + " - " + "minimum nuber";
            }
            else
            {
                matrix2dGV.Rows.Clear();
                min_label.Visible = false;
                max_label.Text = "matrix has been cleared,\n press again ";
            }
        }
    }
}
