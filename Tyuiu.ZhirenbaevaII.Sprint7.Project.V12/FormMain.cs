using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZhirenbaevaII.Sprint7.Project.V12.Lib;      

namespace Tyuiu.ZhirenbaevaII.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridViewData_ZII.RowCount = 100;
            dataGridViewData_ZII.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewData_ZII.Columns[i].Width = 130;
            }
            dataGridViewData_ZII.Columns[2].Width = 180;
        }
        DataService ds = new DataService();
        public static string path = @"C:\project\Персональные ЭВМ.csv";

        private void buttonGetMatrix_ZII_Click(object sender, EventArgs e)
        {
            openFileDialogData_ZII.ShowDialog();
            string FileName = openFileDialogData_ZII.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName); // данные из excel

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }

            buttonSortDiscMin_ZII.Enabled = true;
            buttonSearch_ZII.Enabled = true;
            buttonSortDiscMax_ZII.Enabled = true;
            buttonSortIdMax_ZII.Enabled = true;
            buttonSortIdMin_ZII.Enabled = true;
            buttonSortOZYMax_ZII.Enabled = true;
            buttonSortOZYMin_ZII.Enabled = true;
            buttonSortTactMax_ZII.Enabled = true;
            buttonSortTactMin_ZII.Enabled = true;

        }

        private void buttonStrartMatrix_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
        }

        private void buttonSortIdMin_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSortIdMax_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSortTactMin_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortDoubleMax(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSortTactMax_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortDoubleMin(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSortOZYMin_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 4);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSortOZYMax_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 4);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSortDiscMin_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 5);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSortDiscMax_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 5);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewData_ZII.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonStrartMatrix_ZII.Enabled = true;
        }

        private void buttonSearch_ZII_Click(object sender, EventArgs e)
        {
            if (textBoxSearch_ZII.Text == "")
                MessageBox.Show("Поле поиска пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[,] DataMatrix = ds.GetMatrix(path);

                string[,] str = ds.Search(DataMatrix, textBoxSearch_ZII.Text);
                try
                {
                    if (str[0, 0] == null)
                        MessageBox.Show("Такого производителя нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        for (int r = 1; r < DataMatrix.GetLength(0); r++)
                        {
                            for (int c = 0; c < DataMatrix.GetLength(1); c++)
                            {
                                dataGridViewData_ZII.Rows[r].Cells[c].Value = "";
                            }
                        }

                        for (int r = 0; r < str.GetLength(0); r++)
                        {
                            for (int c = 0; c < str.GetLength(1); c++)
                            {
                                dataGridViewData_ZII.Rows[r + 1].Cells[c].Value = str[r, c];
                            }
                        }

                        buttonStrartMatrix_ZII.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Такого производителя нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSearch_ZII.Text = "";
                }

            }
        }

        private void buttonChartBrands_ZII_Click(object sender, EventArgs e)
        {
            chartInfo_ZII.Series[0].Points.Clear();

            this.chartInfo_ZII.ChartAreas[0].AxisX.Title = "Производитель";
            this.chartInfo_ZII.ChartAreas[0].AxisY.Title = "Количество ЭВМ";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrWordsElements(DataTable, 1);

            int[] ArraySumWords = ds.ArraySumWords(DataTable, ArrayWords, 1);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartInfo_ZII.Series[0].Points.AddXY(ArrayWords[i], ArraySumWords[i]);
            }
        }

        private void buttonChartOZY_ZII_Click(object sender, EventArgs e)
        {
            chartInfo_ZII.Series[0].Points.Clear();

            this.chartInfo_ZII.ChartAreas[0].AxisX.Title = "Объем ОЗУ";
            this.chartInfo_ZII.ChartAreas[0].AxisY.Title = "Количество ЭВМ";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayOZY = ds.ArrayStrElements(DataTable, 4);

            int[] ArraySumOZY = ds.ArraySumOZY(DataTable, ArrayOZY, 4);

            for (int i = 0; i < ArrayOZY.Length; i++)
            {
                chartInfo_ZII.Series[0].Points.AddXY(ArrayOZY[i], ArraySumOZY[i]);
            }
        }

        private void buttonDisc_ZII_Click(object sender, EventArgs e)
        {
            chartInfo_ZII.Series[0].Points.Clear();

            this.chartInfo_ZII.ChartAreas[0].AxisX.Title = "Объем жесткого диска";
            this.chartInfo_ZII.ChartAreas[0].AxisY.Title = "Количество ЭВМ";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayOZY = ds.ArrayStrElements(DataTable, 5);

            int[] ArraySumOZY = ds.ArraySumOZY(DataTable, ArrayOZY, 5);

            for (int i = 0; i < ArrayOZY.Length; i++)
            {
                chartInfo_ZII.Series[0].Points.AddXY(ArrayOZY[i], ArraySumOZY[i]);
            }
        }

        private void ToolStripMenuItemFirms_ZII_Click(object sender, EventArgs e)
        {
            FormFirm formfirm = new FormFirm();
            formfirm.Show();
        }

        private void ToolStripMenuItemGuide_ZII_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.Show();
        }

        private void ToolStripMenuItemAbout_ZII_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void toolTipInfo_ZII_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}   