namespace Tyuiu.BatTI.Sprint6.TaskReview.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLeft = new Panel();
            buttonResult = new Button();
            buttonMatrix = new Button();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxArraySize = new GroupBox();
            labelColumns = new Label();
            textBoxM = new TextBox();
            labelRows = new Label();
            textboxN = new TextBox();
            groupBoxSumSize = new GroupBox();
            label_R = new Label();
            textBoxColum_C = new TextBox();
            labelMinusStop = new Label();
            textBoxMinusStop = new TextBox();
            labelMinusStart = new Label();
            textBoxMinusStart = new TextBox();
            groupBoxRandomSize = new GroupBox();
            labelRandomStop = new Label();
            textBoxRandomStop = new TextBox();
            labelRandomStart = new Label();
            textBoxRandomStart = new TextBox();
            dataGridViewMatrix = new DataGridView();
            panelLeft.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxArraySize.SuspendLayout();
            groupBoxSumSize.SuspendLayout();
            groupBoxRandomSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(buttonResult);
            panelLeft.Controls.Add(buttonMatrix);
            panelLeft.Controls.Add(groupBoxResult);
            panelLeft.Controls.Add(groupBoxArraySize);
            panelLeft.Controls.Add(groupBoxSumSize);
            panelLeft.Controls.Add(groupBoxRandomSize);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(366, 595);
            panelLeft.TabIndex = 4;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(13, 543);
            buttonResult.Margin = new Padding(4, 3, 4, 3);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(345, 53);
            buttonResult.TabIndex = 3;
            buttonResult.Text = "Выполнить вычисление ";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonMatrix
            // 
            buttonMatrix.Location = new Point(13, 483);
            buttonMatrix.Margin = new Padding(4, 3, 4, 3);
            buttonMatrix.Name = "buttonMatrix";
            buttonMatrix.Size = new Size(345, 53);
            buttonMatrix.TabIndex = 3;
            buttonMatrix.Text = "Вывести матрицу ";
            buttonMatrix.UseVisualStyleBackColor = true;
            buttonMatrix.Click += buttonMatrix_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(14, 417);
            groupBoxResult.Margin = new Padding(4, 3, 4, 3);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Padding = new Padding(4, 3, 4, 3);
            groupBoxResult.Size = new Size(344, 60);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(10, 22);
            textBoxResult.Margin = new Padding(4, 3, 4, 3);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(184, 23);
            textBoxResult.TabIndex = 1;
            // 
            // groupBoxArraySize
            // 
            groupBoxArraySize.Controls.Add(labelColumns);
            groupBoxArraySize.Controls.Add(textBoxM);
            groupBoxArraySize.Controls.Add(labelRows);
            groupBoxArraySize.Controls.Add(textboxN);
            groupBoxArraySize.Location = new Point(14, 14);
            groupBoxArraySize.Margin = new Padding(4, 3, 4, 3);
            groupBoxArraySize.Name = "groupBoxArraySize";
            groupBoxArraySize.Padding = new Padding(4, 3, 4, 3);
            groupBoxArraySize.Size = new Size(232, 118);
            groupBoxArraySize.TabIndex = 2;
            groupBoxArraySize.TabStop = false;
            groupBoxArraySize.Text = "Укажите размерность массива:";
            // 
            // labelColumns
            // 
            labelColumns.AutoSize = true;
            labelColumns.Location = new Point(7, 63);
            labelColumns.Margin = new Padding(4, 0, 4, 0);
            labelColumns.Name = "labelColumns";
            labelColumns.Size = new Size(180, 15);
            labelColumns.TabIndex = 0;
            labelColumns.Text = "Количество столбцов M (M>1):";
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(10, 82);
            textBoxM.Margin = new Padding(4, 3, 4, 3);
            textBoxM.Name = "textBoxM";
            textBoxM.Size = new Size(184, 23);
            textBoxM.TabIndex = 1;
            textBoxM.Text = "10";
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Location = new Point(7, 18);
            labelRows.Margin = new Padding(4, 0, 4, 0);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(155, 15);
            labelRows.TabIndex = 0;
            labelRows.Text = "Количество строк N (N>1):";
            // 
            // textboxN
            // 
            textboxN.Location = new Point(8, 36);
            textboxN.Margin = new Padding(4, 3, 4, 3);
            textboxN.Name = "textboxN";
            textboxN.Size = new Size(184, 23);
            textboxN.TabIndex = 1;
            textboxN.Text = "10";
            // 
            // groupBoxSumSize
            // 
            groupBoxSumSize.Controls.Add(label_R);
            groupBoxSumSize.Controls.Add(textBoxColum_C);
            groupBoxSumSize.Controls.Add(labelMinusStop);
            groupBoxSumSize.Controls.Add(textBoxMinusStop);
            groupBoxSumSize.Controls.Add(labelMinusStart);
            groupBoxSumSize.Controls.Add(textBoxMinusStart);
            groupBoxSumSize.Location = new Point(21, 258);
            groupBoxSumSize.Margin = new Padding(4, 3, 4, 3);
            groupBoxSumSize.Name = "groupBoxSumSize";
            groupBoxSumSize.Padding = new Padding(4, 3, 4, 3);
            groupBoxSumSize.Size = new Size(344, 153);
            groupBoxSumSize.TabIndex = 2;
            groupBoxSumSize.TabStop = false;
            groupBoxSumSize.Text = "Укажите диапазон произведения чётных значений";
            // 
            // label_R
            // 
            label_R.AutoSize = true;
            label_R.Location = new Point(7, 108);
            label_R.Margin = new Padding(4, 0, 4, 0);
            label_R.Name = "label_R";
            label_R.Size = new Size(103, 15);
            label_R.TabIndex = 0;
            label_R.Text = "Укажите строку R";
            // 
            // textBoxColum_C
            // 
            textBoxColum_C.Location = new Point(10, 123);
            textBoxColum_C.Margin = new Padding(4, 3, 4, 3);
            textBoxColum_C.Name = "textBoxColum_C";
            textBoxColum_C.Size = new Size(184, 23);
            textBoxColum_C.TabIndex = 1;
            textBoxColum_C.Text = "1";
            // 
            // labelMinusStop
            // 
            labelMinusStop.AutoSize = true;
            labelMinusStop.Location = new Point(7, 63);
            labelMinusStop.Margin = new Padding(4, 0, 4, 0);
            labelMinusStop.Name = "labelMinusStop";
            labelMinusStop.Size = new Size(34, 15);
            labelMinusStop.TabIndex = 0;
            labelMinusStop.Text = "До L:";
            // 
            // textBoxMinusStop
            // 
            textBoxMinusStop.Location = new Point(10, 82);
            textBoxMinusStop.Margin = new Padding(4, 3, 4, 3);
            textBoxMinusStop.Name = "textBoxMinusStop";
            textBoxMinusStop.Size = new Size(184, 23);
            textBoxMinusStop.TabIndex = 1;
            textBoxMinusStop.Text = "2";
            // 
            // labelMinusStart
            // 
            labelMinusStart.AutoSize = true;
            labelMinusStart.Location = new Point(7, 18);
            labelMinusStart.Margin = new Padding(4, 0, 4, 0);
            labelMinusStart.Name = "labelMinusStart";
            labelMinusStart.Size = new Size(34, 15);
            labelMinusStart.TabIndex = 0;
            labelMinusStart.Text = "От K:";
            // 
            // textBoxMinusStart
            // 
            textBoxMinusStart.Location = new Point(10, 37);
            textBoxMinusStart.Margin = new Padding(4, 3, 4, 3);
            textBoxMinusStart.Name = "textBoxMinusStart";
            textBoxMinusStart.Size = new Size(184, 23);
            textBoxMinusStart.TabIndex = 1;
            textBoxMinusStart.Text = "0";
            // 
            // groupBoxRandomSize
            // 
            groupBoxRandomSize.Controls.Add(labelRandomStop);
            groupBoxRandomSize.Controls.Add(textBoxRandomStop);
            groupBoxRandomSize.Controls.Add(labelRandomStart);
            groupBoxRandomSize.Controls.Add(textBoxRandomStart);
            groupBoxRandomSize.Location = new Point(14, 138);
            groupBoxRandomSize.Margin = new Padding(4, 3, 4, 3);
            groupBoxRandomSize.Name = "groupBoxRandomSize";
            groupBoxRandomSize.Padding = new Padding(4, 3, 4, 3);
            groupBoxRandomSize.Size = new Size(232, 118);
            groupBoxRandomSize.TabIndex = 2;
            groupBoxRandomSize.TabStop = false;
            groupBoxRandomSize.Text = "Укажите диапазон значений:";
            // 
            // labelRandomStop
            // 
            labelRandomStop.AutoSize = true;
            labelRandomStop.Location = new Point(7, 63);
            labelRandomStop.Margin = new Padding(4, 0, 4, 0);
            labelRandomStop.Name = "labelRandomStop";
            labelRandomStop.Size = new Size(41, 15);
            labelRandomStop.TabIndex = 0;
            labelRandomStop.Text = "До n2:";
            // 
            // textBoxRandomStop
            // 
            textBoxRandomStop.Location = new Point(10, 82);
            textBoxRandomStop.Margin = new Padding(4, 3, 4, 3);
            textBoxRandomStop.Name = "textBoxRandomStop";
            textBoxRandomStop.Size = new Size(184, 23);
            textBoxRandomStop.TabIndex = 1;
            textBoxRandomStop.Text = "9";
            // 
            // labelRandomStart
            // 
            labelRandomStart.AutoSize = true;
            labelRandomStart.Location = new Point(7, 18);
            labelRandomStart.Margin = new Padding(4, 0, 4, 0);
            labelRandomStart.Name = "labelRandomStart";
            labelRandomStart.Size = new Size(40, 15);
            labelRandomStart.TabIndex = 0;
            labelRandomStart.Text = "От n1:";
            // 
            // textBoxRandomStart
            // 
            textBoxRandomStart.Location = new Point(10, 37);
            textBoxRandomStart.Margin = new Padding(4, 3, 4, 3);
            textBoxRandomStart.Name = "textBoxRandomStart";
            textBoxRandomStart.Size = new Size(184, 23);
            textBoxRandomStart.TabIndex = 1;
            textBoxRandomStart.Text = "1";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Dock = DockStyle.Fill;
            dataGridViewMatrix.Location = new Point(366, 0);
            dataGridViewMatrix.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.Size = new Size(694, 595);
            dataGridViewMatrix.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 595);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(panelLeft);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт ревью | Вариант 23 | Бат Т.И.";
            panelLeft.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxArraySize.ResumeLayout(false);
            groupBoxArraySize.PerformLayout();
            groupBoxSumSize.ResumeLayout(false);
            groupBoxSumSize.PerformLayout();
            groupBoxRandomSize.ResumeLayout(false);
            groupBoxRandomSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonMatrix;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxArraySize;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.TextBox textboxN;
        private System.Windows.Forms.GroupBox groupBoxSumSize;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.TextBox textBoxColum_C;
        private System.Windows.Forms.Label labelMinusStop;
        private System.Windows.Forms.TextBox textBoxMinusStop;
        private System.Windows.Forms.Label labelMinusStart;
        private System.Windows.Forms.TextBox textBoxMinusStart;
        private System.Windows.Forms.GroupBox groupBoxRandomSize;
        private System.Windows.Forms.Label labelRandomStop;
        private System.Windows.Forms.TextBox textBoxRandomStop;
        private System.Windows.Forms.Label labelRandomStart;
        private System.Windows.Forms.TextBox textBoxRandomStart;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
    }
}