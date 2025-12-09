using System.Linq.Expressions;
using Tyuiu.BatTI.Sprint6.Task7.V30.Lib;

namespace Tyuiu.BatTI.Sprint6.Task7.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_AAI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_AAI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        //метод чтения данных из файла
        public static int[,] LoadFromFileData(string filePath)
        {
            //считываем все из файлa
            string fileData = File.ReadAllText(filePath);

            // Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //Определяем кол-во строк и столбцов
            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            //Выдкляем массив данныч
            int[,] arraysValues = new int[rows, cols];

            //Заполняем массив
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arraysValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arraysValues;

        }

        private void buttonLoadFile_AAI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AAI.ShowDialog();
            openFilePath = openFileDialogTask_AAI.FileName;

            int[,] arraysValues = new int[rows, cols];

            arraysValues = LoadFromFileData(openFilePath);

            dataGridViewIn_AAI.ColumnCount = cols;
            dataGridViewIn_AAI.RowCount = rows;
            dataGridViewOut_AAI.ColumnCount = cols;
            dataGridViewOut_AAI.RowCount = rows;

            //Задаем ширину столбца dataGridViewIn
            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn_AAI.Columns[i].Width = 25;
                dataGridViewOut_AAI.Columns[i].Width = 25;
            }



            // Добавляем данные в dataGridViewIn
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < cols; i++)
                {
                    dataGridViewIn_AAI.Rows[j].Cells[i].Value = arraysValues[j, i];
                }
            }
            arraysValues = LoadFromFileData(openFilePath);
            buttonDone_AAI.Enabled = true;



        }

        private void buttonDone_AAI_Click(object sender, EventArgs e)
        {
            int[,] arraysValues = new int[rows, cols];
            arraysValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOut_AAI.Rows[i].Cells[j].Value = arraysValues[i, j];
                }
            }
            buttonSave_AAI.Enabled = true;
        }


        private void buttonSave_AAI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_AAI.FileName = @"OutPutFileTask7.csv";
            saveFileDialogMatrix_AAI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_AAI.ShowDialog();

            string path = saveFileDialogMatrix_AAI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_AAI.RowCount;//Кол-во строк
            int cols = dataGridViewOut_AAI.ColumnCount; // Кол-во столбцов

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOut_AAI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_AAI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }


        }

        private void buttonLoadFile_AAI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_AAI.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_AAI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_AAI.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_AAI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_AAI.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_AAI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_AAI.ToolTipTitle = "Справка";
        }
    }
}