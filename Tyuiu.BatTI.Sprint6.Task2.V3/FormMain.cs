using Tyuiu.BatTI.Sprint6.Task2.V3.Lib;
namespace Tyuiu.BatTI.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                // Î÷èùàåì äàííûå
                dataGridViewFunction.Rows.Clear();
                chartFunction.Series[0].Points.Clear();

                // Ïîëó÷àåì çíà÷åíèÿ
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                int len = stopStep - startStep + 1;
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                // Íàñòðàèâàåì çàãîëîâêè
                chartFunction.Titles.Clear();
                chartFunction.Titles.Add("sin(x)/(x+1.2) + cos(x)*7x - 2");

                chartFunction.ChartAreas[0].AxisX.Title = "X";
                chartFunction.ChartAreas[0].AxisY.Title = "Y";

               
                for (int i = 0; i < len; i++)
                {
                   
                    dataGridViewFunction.Rows.Add(
                        Convert.ToString(startStep + i),
                        Convert.ToString(valueArray[i])
                    );

                   
                    chartFunction.Series[0].Points.AddXY(startStep + i, valueArray[i]);
                }

                
                buttonDone.Text = "Успешно!";
            }
            catch
            {
                MessageBox.Show("Введено неправильное значение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 200, 0); 
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 192, 0); 
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 150, 0); 
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Построить график:\r\n" +
                          "F(x) = sin(x)/(x+1.2) + cos(x)*7x - 2\r\n" +
                          "\r\nВыполнил: Бат Трофим Иванович, ПИНб-25-1\r\n" +
                          "Вариант 3",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {
            // Îáðàáîò÷èê êëèêà ïî ãðàôèêó (ìîæíî îñòàâèòü ïóñòûì)
        }
    }
}