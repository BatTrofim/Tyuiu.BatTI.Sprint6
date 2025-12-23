namespace Tyuiu.BatTI.Sprint6.Task5.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut = new System.Windows.Forms.DataGridView();
            this.chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(503, 92);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(492, 65);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. Вывести в" +
    "се числа, кратные 2. Построить диаграмму по этим значениям. \r\n\r\n\r\n\r\n";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.Location = new System.Drawing.Point(521, 21);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(117, 77);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить ";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.Location = new System.Drawing.Point(767, 21);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(117, 77);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.dataGridViewOutPut);
            this.groupBoxOutPut.Location = new System.Drawing.Point(12, 104);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(178, 454);
            this.groupBoxOutPut.TabIndex = 4;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных";
            // 
            // dataGridViewOutPut
            // 
            this.dataGridViewOutPut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewOutPut.Name = "dataGridViewOutPut";
            this.dataGridViewOutPut.RowHeadersWidth = 51;
            this.dataGridViewOutPut.RowTemplate.Height = 24;
            this.dataGridViewOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut.Size = new System.Drawing.Size(166, 427);
            this.dataGridViewOutPut.TabIndex = 0;
            // 
            // chartDiag
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiag.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDiag.Legends.Add(legend4);
            this.chartDiag.Location = new System.Drawing.Point(196, 110);
            this.chartDiag.Name = "chartDiag";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Green;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiag.Series.Add(series4);
            this.chartDiag.Size = new System.Drawing.Size(695, 448);
            this.chartDiag.TabIndex = 5;
            this.chartDiag.Text = "chart1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile.Location = new System.Drawing.Point(644, 21);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(117, 77);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 562);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.chartDiag);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| Таск 5| Вариант 5| Бат Т.И.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.DataGridView dataGridViewOutPut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}