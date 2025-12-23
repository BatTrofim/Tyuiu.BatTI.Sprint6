namespace Tyuiu.BatTI.Sprint6.Task4.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.labelStopStep = new System.Windows.Forms.Label();
            this.labelStartStep = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition.Size = new System.Drawing.Size(571, 110);
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
            this.textBoxCondition.Size = new System.Drawing.Size(562, 83);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.textBoxStopStep);
            this.groupBoxInPut.Controls.Add(this.textBoxStartStep);
            this.groupBoxInPut.Controls.Add(this.labelStopStep);
            this.groupBoxInPut.Controls.Add(this.labelStartStep);
            this.groupBoxInPut.Location = new System.Drawing.Point(589, 12);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(255, 110);
            this.groupBoxInPut.TabIndex = 1;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных";
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(132, 42);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(116, 22);
            this.textBoxStopStep.TabIndex = 3;
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(10, 42);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(116, 22);
            this.textBoxStartStep.TabIndex = 2;
            // 
            // labelStopStep
            // 
            this.labelStopStep.AutoSize = true;
            this.labelStopStep.Location = new System.Drawing.Point(129, 22);
            this.labelStopStep.Name = "labelStopStep";
            this.labelStopStep.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep.TabIndex = 1;
            this.labelStopStep.Text = "Конец шага:";
            this.labelStopStep.Click += new System.EventHandler(this.labelStopStep_Click);
            // 
            // labelStartStep
            // 
            this.labelStartStep.AutoSize = true;
            this.labelStartStep.Location = new System.Drawing.Point(7, 22);
            this.labelStartStep.Name = "labelStartStep";
            this.labelStartStep.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep.TabIndex = 0;
            this.labelStartStep.Text = "Старт шага:";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.Location = new System.Drawing.Point(860, 24);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(124, 92);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(990, 24);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 92);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.Location = new System.Drawing.Point(1120, 24);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(124, 92);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.textBoxResult);
            this.groupBoxOutPut.Location = new System.Drawing.Point(12, 128);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(340, 542);
            this.groupBoxOutPut.TabIndex = 5;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 21);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(328, 515);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(358, 128);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(905, 542);
            this.chartFunction.TabIndex = 0;
            this.chartFunction.Text = "chartFunction";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title1.Name = "TitleCos";
            title1.Text = "График функции F(x)";
            this.chartFunction.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxCondition);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| Таск 4| Вариант 6|Бат Т.И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.Label labelStopStep;
        private System.Windows.Forms.Label labelStartStep;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
