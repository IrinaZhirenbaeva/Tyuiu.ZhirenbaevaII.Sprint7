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
using System.IO;

namespace Tyuiu.ZhirenbaevaII.Sprint7.Project.V12
{
    public partial class FormFirm : Form
    {
        public FormFirm()
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
        public static string path = @"C:\project\Фирмы-реализаторы.csv";

        private void buttonGetMatrix_ZII_Click(object sender, EventArgs e)
        {
            openFileDialogData_ZII.ShowDialog();
            string FileName = openFileDialogData_ZII.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName);

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

        private void dataGridViewData_ZII_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddNote_ZII_Click(object sender, EventArgs e)
        {
            string[,] DataTable = ds.GetMatrix(path);
            bool b = true;
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                if (DataTable[i, 0] == textBoxID_ZII.Text)
                    b = false;
            }

            if (textBoxNote_ZII.Text == "" || textBoxID_ZII.Text == "")
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (b)
                MessageBox.Show("Нет такого ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";
                string[] strRows = File.ReadAllLines(path);
                for (int i = 1; i < strRows.Length; i++)
                {
                    string[] strElements = strRows[i].Split(';');
                    if (strElements[0] == textBoxID_ZII.Text)
                    {
                        strElements[4] = textBoxNote_ZII.Text;
                        for (int j = 0; j < strElements.Length; j++)
                        {
                            if (j != strElements.Length - 1)
                                str += strElements[j] + ";";
                            else
                                str += strElements[j];
                        }
                    }
                }
                for (int i = 1; i < strRows.Length; i++)
                {
                    string[] strElements = strRows[i].Split(';');
                    if (strElements[0] == textBoxID_ZII.Text)
                    {
                        strRows[i] = str;
                        break;
                    }
                }

                saveFileDialogData_ZII.FileName = "Фирмы-реализаторы.csv";
                saveFileDialogData_ZII.ShowDialog();

                path = saveFileDialogData_ZII.FileName;

                File.WriteAllLines(path, strRows, Encoding.UTF8);

                DataTable = ds.GetMatrix(path);

                for (int i = 0; i < DataTable.GetLength(0); i++)
                {
                    for (int j = 0; j < DataTable.GetLength(1); j++)
                    {
                        dataGridViewData_ZII.Rows[i].Cells[j].Value = DataTable[i, j];
                    }
                }
            }
            textBoxID_ZII.Text = "";
            textBoxNote_ZII.Text = "";
        }
    }
}
