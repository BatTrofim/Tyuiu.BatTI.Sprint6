namespace Tyuiu.BatTI.Sprint6.Task7.V30
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_AAI = new Panel();
            buttonDone_AAI = new Button();
            buttonSave_AAI = new Button();
            buttonLoadFile_AAI = new Button();
            panelTask_AAI = new Panel();
            groupBoxCondition_AAI = new GroupBox();
            textBoxTask_AAI = new TextBox();
            panelOutPutdata_AAI = new Panel();
            groupBoxOutPutData_AAI = new GroupBox();
            dataGridViewOut_AAI = new DataGridView();
            splitter1 = new Splitter();
            panelInPutData_AAI = new Panel();
            groupBoxInPutData_AAI = new GroupBox();
            dataGridViewIn_AAI = new DataGridView();
            openFileDialogTask_AAI = new OpenFileDialog();
            saveFileDialogMatrix_AAI = new SaveFileDialog();
            toolTip_AAI = new ToolTip(components);
            panelTop_AAI.SuspendLayout();
            panelTask_AAI.SuspendLayout();
            groupBoxCondition_AAI.SuspendLayout();
            panelOutPutdata_AAI.SuspendLayout();
            groupBoxOutPutData_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AAI).BeginInit();
            panelInPutData_AAI.SuspendLayout();
            groupBoxInPutData_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AAI).BeginInit();
            SuspendLayout();
            // 
            // panelTop_AAI
            // 
            panelTop_AAI.Controls.Add(buttonDone_AAI);
            panelTop_AAI.Controls.Add(buttonSave_AAI);
            panelTop_AAI.Controls.Add(buttonLoadFile_AAI);
            panelTop_AAI.Dock = DockStyle.Top;
            panelTop_AAI.Location = new Point(0, 0);
            panelTop_AAI.Margin = new Padding(4, 3, 4, 3);
            panelTop_AAI.Name = "panelTop_AAI";
            panelTop_AAI.Size = new Size(1206, 92);
            panelTop_AAI.TabIndex = 0;
            // 
            // buttonDone_AAI
            // 
            buttonDone_AAI.Enabled = false;
            buttonDone_AAI.FlatStyle = FlatStyle.Flat;
            buttonDone_AAI.Location = new Point(110, 8);
            buttonDone_AAI.Margin = new Padding(4, 3, 4, 3);
            buttonDone_AAI.Name = "buttonDone_AAI";
            buttonDone_AAI.Size = new Size(88, 77);
            buttonDone_AAI.TabIndex = 4;
            toolTip_AAI.SetToolTip(buttonDone_AAI, "Нажмите, чтобы изменить в первом столбце значения не равные 4 на 8 . ");
            buttonDone_AAI.UseVisualStyleBackColor = true;
            buttonDone_AAI.Click += buttonDone_AAI_Click;
            buttonDone_AAI.MouseEnter += buttonDone_AAI_MouseEnter;
            // 
            // buttonSave_AAI
            // 
            buttonSave_AAI.Enabled = false;
            buttonSave_AAI.FlatStyle = FlatStyle.Flat;
            buttonSave_AAI.Location = new Point(204, 8);
            buttonSave_AAI.Margin = new Padding(4, 3, 4, 3);
            buttonSave_AAI.Name = "buttonSave_AAI";
            buttonSave_AAI.Size = new Size(88, 77);
            buttonSave_AAI.TabIndex = 2;
            toolTip_AAI.SetToolTip(buttonSave_AAI, "Нажмите, чтобы сохранить файл");
            buttonSave_AAI.UseVisualStyleBackColor = true;
            buttonSave_AAI.Click += buttonSave_AAI_Click;
            buttonSave_AAI.MouseEnter += buttonSave_AAI_MouseEnter;
            // 
            // buttonLoadFile_AAI
            // 
            buttonLoadFile_AAI.FlatStyle = FlatStyle.Flat;
            buttonLoadFile_AAI.Location = new Point(7, 8);
            buttonLoadFile_AAI.Margin = new Padding(4, 3, 4, 3);
            buttonLoadFile_AAI.Name = "buttonLoadFile_AAI";
            buttonLoadFile_AAI.Size = new Size(96, 77);
            buttonLoadFile_AAI.TabIndex = 1;
            toolTip_AAI.SetToolTip(buttonLoadFile_AAI, "Откройте нужный файл для обработки\r\n");
            buttonLoadFile_AAI.UseVisualStyleBackColor = true;
            buttonLoadFile_AAI.Click += buttonLoadFile_AAI_Click;
            buttonLoadFile_AAI.MouseEnter += buttonLoadFile_AAI_MouseEnter;
            // 
            // panelTask_AAI
            // 
            panelTask_AAI.Controls.Add(groupBoxCondition_AAI);
            panelTask_AAI.Dock = DockStyle.Top;
            panelTask_AAI.Location = new Point(0, 92);
            panelTask_AAI.Margin = new Padding(4, 3, 4, 3);
            panelTask_AAI.Name = "panelTask_AAI";
            panelTask_AAI.Size = new Size(1206, 90);
            panelTask_AAI.TabIndex = 1;
            // 
            // groupBoxCondition_AAI
            // 
            groupBoxCondition_AAI.Controls.Add(textBoxTask_AAI);
            groupBoxCondition_AAI.Dock = DockStyle.Fill;
            groupBoxCondition_AAI.Location = new Point(0, 0);
            groupBoxCondition_AAI.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition_AAI.Name = "groupBoxCondition_AAI";
            groupBoxCondition_AAI.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition_AAI.Size = new Size(1206, 90);
            groupBoxCondition_AAI.TabIndex = 1;
            groupBoxCondition_AAI.TabStop = false;
            groupBoxCondition_AAI.Text = "Условие:";
            // 
            // textBoxTask_AAI
            // 
            textBoxTask_AAI.Location = new Point(7, 22);
            textBoxTask_AAI.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_AAI.Multiline = true;
            textBoxTask_AAI.Name = "textBoxTask_AAI";
            textBoxTask_AAI.Size = new Size(951, 64);
            textBoxTask_AAI.TabIndex = 0;
            textBoxTask_AAI.Text = resources.GetString("textBoxTask_AAI.Text");
            // 
            // panelOutPutdata_AAI
            // 
            panelOutPutdata_AAI.Controls.Add(groupBoxOutPutData_AAI);
            panelOutPutdata_AAI.Controls.Add(splitter1);
            panelOutPutdata_AAI.Dock = DockStyle.Fill;
            panelOutPutdata_AAI.Location = new Point(632, 182);
            panelOutPutdata_AAI.Margin = new Padding(4, 3, 4, 3);
            panelOutPutdata_AAI.Name = "panelOutPutdata_AAI";
            panelOutPutdata_AAI.Size = new Size(574, 350);
            panelOutPutdata_AAI.TabIndex = 1;
            // 
            // groupBoxOutPutData_AAI
            // 
            groupBoxOutPutData_AAI.Controls.Add(dataGridViewOut_AAI);
            groupBoxOutPutData_AAI.Dock = DockStyle.Fill;
            groupBoxOutPutData_AAI.Location = new Point(4, 0);
            groupBoxOutPutData_AAI.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            groupBoxOutPutData_AAI.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPutData_AAI.Size = new Size(570, 350);
            groupBoxOutPutData_AAI.TabIndex = 1;
            groupBoxOutPutData_AAI.TabStop = false;
            groupBoxOutPutData_AAI.Text = "Вывод:";
            // 
            // dataGridViewOut_AAI
            // 
            dataGridViewOut_AAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_AAI.ColumnHeadersVisible = false;
            dataGridViewOut_AAI.Dock = DockStyle.Fill;
            dataGridViewOut_AAI.Location = new Point(4, 19);
            dataGridViewOut_AAI.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOut_AAI.Name = "dataGridViewOut_AAI";
            dataGridViewOut_AAI.RowHeadersVisible = false;
            dataGridViewOut_AAI.Size = new Size(562, 328);
            dataGridViewOut_AAI.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 350);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panelInPutData_AAI
            // 
            panelInPutData_AAI.Controls.Add(groupBoxInPutData_AAI);
            panelInPutData_AAI.Dock = DockStyle.Left;
            panelInPutData_AAI.Location = new Point(0, 182);
            panelInPutData_AAI.Margin = new Padding(4, 3, 4, 3);
            panelInPutData_AAI.Name = "panelInPutData_AAI";
            panelInPutData_AAI.Size = new Size(632, 350);
            panelInPutData_AAI.TabIndex = 1;
            // 
            // groupBoxInPutData_AAI
            // 
            groupBoxInPutData_AAI.Controls.Add(dataGridViewIn_AAI);
            groupBoxInPutData_AAI.Dock = DockStyle.Fill;
            groupBoxInPutData_AAI.Location = new Point(0, 0);
            groupBoxInPutData_AAI.Margin = new Padding(4, 3, 4, 3);
            groupBoxInPutData_AAI.Name = "groupBoxInPutData_AAI";
            groupBoxInPutData_AAI.Padding = new Padding(4, 3, 4, 3);
            groupBoxInPutData_AAI.Size = new Size(632, 350);
            groupBoxInPutData_AAI.TabIndex = 0;
            groupBoxInPutData_AAI.TabStop = false;
            groupBoxInPutData_AAI.Text = "Ввод:";
            // 
            // dataGridViewIn_AAI
            // 
            dataGridViewIn_AAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_AAI.ColumnHeadersVisible = false;
            dataGridViewIn_AAI.Dock = DockStyle.Fill;
            dataGridViewIn_AAI.Location = new Point(4, 19);
            dataGridViewIn_AAI.Margin = new Padding(4, 3, 4, 3);
            dataGridViewIn_AAI.Name = "dataGridViewIn_AAI";
            dataGridViewIn_AAI.RowHeadersVisible = false;
            dataGridViewIn_AAI.Size = new Size(624, 328);
            dataGridViewIn_AAI.TabIndex = 0;
            // 
            // openFileDialogTask_AAI
            // 
            openFileDialogTask_AAI.FileName = "openFileDialogTask_AAI";
            // 
            // toolTip_AAI
            // 
            toolTip_AAI.ForeColor = SystemColors.Highlight;
            toolTip_AAI.IsBalloon = true;
            toolTip_AAI.ToolTipIcon = ToolTipIcon.Info;
            toolTip_AAI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 532);
            Controls.Add(panelOutPutdata_AAI);
            Controls.Add(panelInPutData_AAI);
            Controls.Add(panelTask_AAI);
            Controls.Add(panelTop_AAI);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1222, 571);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6  | Таск 7 | Вариант 30 | Бат Т.И. ";
            panelTop_AAI.ResumeLayout(false);
            panelTask_AAI.ResumeLayout(false);
            groupBoxCondition_AAI.ResumeLayout(false);
            groupBoxCondition_AAI.PerformLayout();
            panelOutPutdata_AAI.ResumeLayout(false);
            groupBoxOutPutData_AAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AAI).EndInit();
            panelInPutData_AAI.ResumeLayout(false);
            groupBoxInPutData_AAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AAI).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAI;
        private System.Windows.Forms.Panel panelTask_AAI;
        private System.Windows.Forms.GroupBox groupBoxCondition_AAI;
        private System.Windows.Forms.TextBox textBoxTask_AAI;
        private System.Windows.Forms.Button buttonLoadFile_AAI;
        private System.Windows.Forms.Button buttonSave_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Panel panelOutPutdata_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelInPutData_AAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_AAI;
        private System.Windows.Forms.DataGridView dataGridViewOut_AAI;
        private System.Windows.Forms.DataGridView dataGridViewIn_AAI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_AAI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_AAI;
        private System.Windows.Forms.ToolTip toolTip_AAI;
    }
}
