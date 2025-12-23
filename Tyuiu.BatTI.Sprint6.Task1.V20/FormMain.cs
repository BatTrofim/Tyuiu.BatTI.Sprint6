using System.Globalization;
using Tyuiu.BatTI.Sprint6.Task1.V20.Lib;

namespace Tyuiu.BatTI.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnExecute.Click += BtnExecute_Click;
            btnHelp.Click += BtnHelp_Click;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Выполнено студентом группы ПИНб-25-1 Бат Т.И.\n",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            // ×èòàåì äèàïàçîí
            if (!double.TryParse(txtStart.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double start))
            {
                MessageBox.Show("Введено неправильное значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtEnd.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double end))
            {
                MessageBox.Show("Введено неправильное значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double step = start <= end ? 1.0 : -1.0; 

            txtResult.AppendText(string.Format("{0,-10} {1,12}\r\n", "x", "f(x)"));
            txtResult.AppendText(new string('-', 26) + "\r\n");

            const double eps = 1e-12;

            for (double x = start; step > 0 ? x <= end + 1e-9 : x >= end - 1e-9; x += step)
            {
                double denom = Math.Cos(x) - 2.0 * x;
                double fx;

                if (Math.Abs(denom) < eps)
                {
                    fx = 0.0; 
                }
                else
                {
                    fx = (2.0 * x - 3.0) / denom + 5.0 * x - Math.Sin(x);
                }

                double fxRounded = Math.Round(fx, 2);

                
                string xs = (Math.Abs(x - Math.Round(x)) < 1e-9) ? ((int)Math.Round(x)).ToString() : x.ToString("F2", CultureInfo.CurrentCulture);
                string fxs = fxRounded.ToString("F2", CultureInfo.CurrentCulture);

                txtResult.AppendText(string.Format("{0,-10} {1,12}\r\n", xs, fxs));
            }
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {

        }
    }
}
