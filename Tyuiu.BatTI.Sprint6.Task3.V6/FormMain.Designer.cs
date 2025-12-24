namespace Tyuiu.BatTI.Sprint6.Task3.V6
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
            groupBoxTask_BTI = new GroupBox();
            dataGridViewMatrix_BTI = new DataGridView();
            textBoxTask_BTI = new TextBox();
            groupBoxOutPutData_BTI = new GroupBox();
            dataGridViewResult_BTI = new DataGridView();
            labelRes_BTI = new Label();
            buttonHelp_BTI = new Button();
            buttonDone_BTI = new Button();
            groupBoxTask_BTI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BTI).BeginInit();
            groupBoxOutPutData_BTI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BTI
            // 
            groupBoxTask_BTI.Controls.Add(dataGridViewMatrix_BTI);
            groupBoxTask_BTI.Controls.Add(textBoxTask_BTI);
            groupBoxTask_BTI.Location = new Point(14, 14);
            groupBoxTask_BTI.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_BTI.Name = "groupBoxTask_BTI";
            groupBoxTask_BTI.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_BTI.Size = new Size(433, 241);
            groupBoxTask_BTI.TabIndex = 0;
            groupBoxTask_BTI.TabStop = false;
            groupBoxTask_BTI.Text = "Условие";
            // 
            // dataGridViewMatrix_BTI
            // 
            dataGridViewMatrix_BTI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_BTI.ColumnHeadersVisible = false;
            dataGridViewMatrix_BTI.Location = new Point(235, 18);
            dataGridViewMatrix_BTI.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMatrix_BTI.Name = "dataGridViewMatrix_BTI";
            dataGridViewMatrix_BTI.RowHeadersVisible = false;
            dataGridViewMatrix_BTI.Size = new Size(190, 216);
            dataGridViewMatrix_BTI.TabIndex = 1;
            dataGridViewMatrix_BTI.CellContentClick += dataGridViewMatrix_BTI_CellContentClick;
            // 
            // textBoxTask_BTI
            // 
            textBoxTask_BTI.BorderStyle = BorderStyle.None;
            textBoxTask_BTI.Location = new Point(7, 22);
            textBoxTask_BTI.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_BTI.Multiline = true;
            textBoxTask_BTI.Name = "textBoxTask_BTI";
            textBoxTask_BTI.ReadOnly = true;
            textBoxTask_BTI.Size = new Size(231, 147);
            textBoxTask_BTI.TabIndex = 0;
            // 
            // groupBoxOutPutData_BTI
            // 
            groupBoxOutPutData_BTI.Controls.Add(dataGridViewResult_BTI);
            groupBoxOutPutData_BTI.Controls.Add(labelRes_BTI);
            groupBoxOutPutData_BTI.Location = new Point(454, 14);
            groupBoxOutPutData_BTI.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPutData_BTI.Name = "groupBoxOutPutData_BTI";
            groupBoxOutPutData_BTI.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPutData_BTI.Size = new Size(233, 209);
            groupBoxOutPutData_BTI.TabIndex = 1;
            groupBoxOutPutData_BTI.TabStop = false;
            groupBoxOutPutData_BTI.Text = "Вывод данных";
            // 
            // dataGridViewResult_BTI
            // 
            dataGridViewResult_BTI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BTI.ColumnHeadersVisible = false;
            dataGridViewResult_BTI.Location = new Point(10, 37);
            dataGridViewResult_BTI.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResult_BTI.Name = "dataGridViewResult_BTI";
            dataGridViewResult_BTI.RowHeadersVisible = false;
            dataGridViewResult_BTI.Size = new Size(216, 165);
            dataGridViewResult_BTI.TabIndex = 2;
            // 
            // labelRes_BTI
            // 
            labelRes_BTI.AutoSize = true;
            labelRes_BTI.Location = new Point(7, 18);
            labelRes_BTI.Margin = new Padding(4, 0, 4, 0);
            labelRes_BTI.Name = "labelRes_BTI";
            labelRes_BTI.Size = new Size(63, 15);
            labelRes_BTI.TabIndex = 1;
            labelRes_BTI.Text = "Результат:";
            labelRes_BTI.Click += labelRes_BTI_Click;
            // 
            // buttonHelp_BTI
            // 
            buttonHelp_BTI.Location = new Point(554, 230);
            buttonHelp_BTI.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_BTI.Name = "buttonHelp_BTI";
            buttonHelp_BTI.Size = new Size(31, 27);
            buttonHelp_BTI.TabIndex = 2;
            buttonHelp_BTI.Text = "?";
            buttonHelp_BTI.UseVisualStyleBackColor = true;
            buttonHelp_BTI.Click += buttonHelp_BTI_Click;
            // 
            // buttonDone_BTI
            // 
            buttonDone_BTI.Location = new Point(593, 230);
            buttonDone_BTI.Margin = new Padding(4, 3, 4, 3);
            buttonDone_BTI.Name = "buttonDone_BTI";
            buttonDone_BTI.Size = new Size(88, 27);
            buttonDone_BTI.TabIndex = 3;
            buttonDone_BTI.Text = "Выполнить";
            buttonDone_BTI.UseVisualStyleBackColor = true;
            buttonDone_BTI.Click += buttonDone_BTI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 270);
            Controls.Add(buttonDone_BTI);
            Controls.Add(buttonHelp_BTI);
            Controls.Add(groupBoxOutPutData_BTI);
            Controls.Add(groupBoxTask_BTI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Бат Т.И.";
            Load += FormMain_Load;
            groupBoxTask_BTI.ResumeLayout(false);
            groupBoxTask_BTI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BTI).EndInit();
            groupBoxOutPutData_BTI.ResumeLayout(false);
            groupBoxOutPutData_BTI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTI).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BTI;
        private System.Windows.Forms.TextBox textBoxTask_BTI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_BTI;
        private System.Windows.Forms.Button buttonHelp_BTI;
        private System.Windows.Forms.Button buttonDone_BTI;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_BTI;
        private System.Windows.Forms.Label labelRes_BTI;
        private System.Windows.Forms.DataGridView dataGridViewResult_BTI;
    }
}