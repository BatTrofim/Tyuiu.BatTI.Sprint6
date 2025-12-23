using Tyuiu.BatTI.Sprint6.Task4.V6.Lib;

namespace Tyuiu.BatTI.Sprint6.Task4.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void labelStopStep_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStartStep.Text);
                int StopStep = Convert.ToInt32(textBoxStopStep.Text);

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult.Text = "";

                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(StartStep, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    StartStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V6.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПИНб-25-1 Бат Трофим Иванович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
