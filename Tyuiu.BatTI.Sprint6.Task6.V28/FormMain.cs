using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BatTI.Sprint6.Task6.V28.Lib;

namespace Tyuiu.BatTI.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_BTI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BTI.ShowDialog();
            openFilePath = openFileDialogTask_BTI.FileName;
            textBoxIn_BTI.Text = File.ReadAllText(openFilePath);
            groupBoxInput_BTI.Text = groupBoxInput_BTI.Text + " " + openFileDialogTask_BTI.FileName; ;
            buttonDone_BTI.Enabled = true;
        }

        private void buttonDone_BTI_Click(object sender, EventArgs e)
        {
            textBoxOut_BTI.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_BTI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}