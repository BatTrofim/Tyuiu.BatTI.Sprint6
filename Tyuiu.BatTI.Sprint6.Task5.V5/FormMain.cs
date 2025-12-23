using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BatTI.Sprint6.Task5.V5.Lib;

namespace Tyuiu.BatTI.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Lenovo\source\repos\Tyuiu.BatTI.Sprint6\Tyuiu.BatTI.Sprint6.Task5.V5\bin\Debug\InPutFileTask5V5.txt";



        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut.ColumnCount = 2;
            dataGridViewOutPut.Columns[0].Width = 20;
            dataGridViewOutPut.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПИНб-25-1 Бат Трофим Иванович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}