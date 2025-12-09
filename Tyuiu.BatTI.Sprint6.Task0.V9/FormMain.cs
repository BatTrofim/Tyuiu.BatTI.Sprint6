using Tyuiu.BatTI.Sprint6.Task0.V9.Lib;

namespace Tyuiu.BatTI.Sprint6.Task0.V9
{
    
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            DataService ds = new DataService();
            try
            {
                textBox2.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1.Text)));
            }
            catch
            {
                MessageBox.Show("Неправльное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
