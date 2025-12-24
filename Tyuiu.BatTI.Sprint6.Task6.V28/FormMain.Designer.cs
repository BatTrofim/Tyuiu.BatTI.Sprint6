namespace Tyuiu.BatTI.Sprint6.Task6.V28
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
            components = new System.ComponentModel.Container();
            panelTop_BTI = new Panel();
            buttonInfo_BTI = new Button();
            buttonDone_BTI = new Button();
            buttonOpen_BTI = new Button();
            groupBoxUslovie_BTI = new GroupBox();
            textBoxUslovie_BTI = new TextBox();
            panelLeft_BTI = new Panel();
            groupBoxInput_BTI = new GroupBox();
            textBoxIn_BTI = new TextBox();
            splitterLeftRight_BTI = new Splitter();
            panelRight_BTI = new Panel();
            groupBoxOutput_BTI = new GroupBox();
            textBoxOut_BTI = new TextBox();
            openFileDialogTask_BTI = new OpenFileDialog();
            toolTipInfo_BTI = new ToolTip(components);
            panelTop_BTI.SuspendLayout();
            groupBoxUslovie_BTI.SuspendLayout();
            panelLeft_BTI.SuspendLayout();
            groupBoxInput_BTI.SuspendLayout();
            panelRight_BTI.SuspendLayout();
            groupBoxOutput_BTI.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BTI
            // 
            panelTop_BTI.BorderStyle = BorderStyle.FixedSingle;
            panelTop_BTI.Controls.Add(buttonInfo_BTI);
            panelTop_BTI.Controls.Add(buttonDone_BTI);
            panelTop_BTI.Controls.Add(buttonOpen_BTI);
            panelTop_BTI.Dock = DockStyle.Top;
            panelTop_BTI.Location = new Point(0, 0);
            panelTop_BTI.Margin = new Padding(4, 3, 4, 3);
            panelTop_BTI.Name = "panelTop_BTI";
            panelTop_BTI.Size = new Size(933, 61);
            panelTop_BTI.TabIndex = 0;
            // 
            // buttonInfo_BTI
            // 
            buttonInfo_BTI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_BTI.FlatStyle = FlatStyle.Flat;
            buttonInfo_BTI.Image = Properties.Resources.information;
            buttonInfo_BTI.Location = new Point(854, 3);
            buttonInfo_BTI.Margin = new Padding(4, 3, 4, 3);
            buttonInfo_BTI.Name = "buttonInfo_BTI";
            buttonInfo_BTI.Size = new Size(74, 48);
            buttonInfo_BTI.TabIndex = 2;
            toolTipInfo_BTI.SetToolTip(buttonInfo_BTI, "О программе");
            buttonInfo_BTI.UseVisualStyleBackColor = true;
            buttonInfo_BTI.Click += buttonInfo_BTI_Click;
            // 
            // buttonDone_BTI
            // 
            buttonDone_BTI.Enabled = false;
            buttonDone_BTI.FlatStyle = FlatStyle.Flat;
            buttonDone_BTI.Image = Properties.Resources.accept;
            buttonDone_BTI.Location = new Point(85, 3);
            buttonDone_BTI.Margin = new Padding(4, 3, 4, 3);
            buttonDone_BTI.Name = "buttonDone_BTI";
            buttonDone_BTI.Size = new Size(74, 48);
            buttonDone_BTI.TabIndex = 1;
            toolTipInfo_BTI.SetToolTip(buttonDone_BTI, "Выводит предпоследнее слово каждой строки в\r\nрезультатирующую строку");
            buttonDone_BTI.UseVisualStyleBackColor = true;
            buttonDone_BTI.Click += buttonDone_BTI_Click;
            // 
            // buttonOpen_BTI
            // 
            buttonOpen_BTI.FlatStyle = FlatStyle.Flat;
            buttonOpen_BTI.Image = Properties.Resources.folder_explore;
            buttonOpen_BTI.Location = new Point(5, 5);
            buttonOpen_BTI.Margin = new Padding(4, 3, 4, 3);
            buttonOpen_BTI.Name = "buttonOpen_BTI";
            buttonOpen_BTI.Size = new Size(74, 48);
            buttonOpen_BTI.TabIndex = 0;
            toolTipInfo_BTI.SetToolTip(buttonOpen_BTI, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_BTI.UseVisualStyleBackColor = true;
            buttonOpen_BTI.Click += buttonOpen_BTI_Click;
            // 
            // groupBoxUslovie_BTI
            // 
            groupBoxUslovie_BTI.Controls.Add(textBoxUslovie_BTI);
            groupBoxUslovie_BTI.Dock = DockStyle.Top;
            groupBoxUslovie_BTI.Location = new Point(0, 61);
            groupBoxUslovie_BTI.Margin = new Padding(4, 3, 4, 3);
            groupBoxUslovie_BTI.Name = "groupBoxUslovie_BTI";
            groupBoxUslovie_BTI.Padding = new Padding(4, 3, 4, 3);
            groupBoxUslovie_BTI.Size = new Size(933, 103);
            groupBoxUslovie_BTI.TabIndex = 1;
            groupBoxUslovie_BTI.TabStop = false;
            groupBoxUslovie_BTI.Text = "Условие";
            // 
            // textBoxUslovie_BTI
            // 
            textBoxUslovie_BTI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUslovie_BTI.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUslovie_BTI.Location = new Point(15, 22);
            textBoxUslovie_BTI.Margin = new Padding(4, 3, 4, 3);
            textBoxUslovie_BTI.Multiline = true;
            textBoxUslovie_BTI.Name = "textBoxUslovie_BTI";
            textBoxUslovie_BTI.ReadOnly = true;
            textBoxUslovie_BTI.Size = new Size(910, 73);
            textBoxUslovie_BTI.TabIndex = 0;
            // 
            // panelLeft_BTI
            // 
            panelLeft_BTI.BorderStyle = BorderStyle.FixedSingle;
            panelLeft_BTI.Controls.Add(groupBoxInput_BTI);
            panelLeft_BTI.Dock = DockStyle.Left;
            panelLeft_BTI.Location = new Point(0, 164);
            panelLeft_BTI.Margin = new Padding(4, 3, 4, 3);
            panelLeft_BTI.Name = "panelLeft_BTI";
            panelLeft_BTI.Size = new Size(449, 355);
            panelLeft_BTI.TabIndex = 2;
            // 
            // groupBoxInput_BTI
            // 
            groupBoxInput_BTI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInput_BTI.Controls.Add(textBoxIn_BTI);
            groupBoxInput_BTI.Location = new Point(5, 5);
            groupBoxInput_BTI.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_BTI.Name = "groupBoxInput_BTI";
            groupBoxInput_BTI.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_BTI.Size = new Size(436, 336);
            groupBoxInput_BTI.TabIndex = 0;
            groupBoxInput_BTI.TabStop = false;
            groupBoxInput_BTI.Text = "Ввод";
            // 
            // textBoxIn_BTI
            // 
            textBoxIn_BTI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIn_BTI.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn_BTI.Location = new Point(9, 23);
            textBoxIn_BTI.Margin = new Padding(4, 3, 4, 3);
            textBoxIn_BTI.Multiline = true;
            textBoxIn_BTI.Name = "textBoxIn_BTI";
            textBoxIn_BTI.ReadOnly = true;
            textBoxIn_BTI.ScrollBars = ScrollBars.Vertical;
            textBoxIn_BTI.Size = new Size(419, 305);
            textBoxIn_BTI.TabIndex = 0;
            // 
            // splitterLeftRight_BTI
            // 
            splitterLeftRight_BTI.Location = new Point(449, 164);
            splitterLeftRight_BTI.Margin = new Padding(4, 3, 4, 3);
            splitterLeftRight_BTI.Name = "splitterLeftRight_BTI";
            splitterLeftRight_BTI.Size = new Size(4, 355);
            splitterLeftRight_BTI.TabIndex = 3;
            splitterLeftRight_BTI.TabStop = false;
            // 
            // panelRight_BTI
            // 
            panelRight_BTI.BorderStyle = BorderStyle.FixedSingle;
            panelRight_BTI.Controls.Add(groupBoxOutput_BTI);
            panelRight_BTI.Dock = DockStyle.Fill;
            panelRight_BTI.Location = new Point(453, 164);
            panelRight_BTI.Margin = new Padding(4, 3, 4, 3);
            panelRight_BTI.Name = "panelRight_BTI";
            panelRight_BTI.Size = new Size(480, 355);
            panelRight_BTI.TabIndex = 4;
            // 
            // groupBoxOutput_BTI
            // 
            groupBoxOutput_BTI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutput_BTI.Controls.Add(textBoxOut_BTI);
            groupBoxOutput_BTI.Location = new Point(7, 7);
            groupBoxOutput_BTI.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_BTI.Name = "groupBoxOutput_BTI";
            groupBoxOutput_BTI.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_BTI.Size = new Size(465, 333);
            groupBoxOutput_BTI.TabIndex = 0;
            groupBoxOutput_BTI.TabStop = false;
            groupBoxOutput_BTI.Text = "Вывод";
            // 
            // textBoxOut_BTI
            // 
            textBoxOut_BTI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut_BTI.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOut_BTI.Location = new Point(8, 21);
            textBoxOut_BTI.Margin = new Padding(4, 3, 4, 3);
            textBoxOut_BTI.Multiline = true;
            textBoxOut_BTI.Name = "textBoxOut_BTI";
            textBoxOut_BTI.ReadOnly = true;
            textBoxOut_BTI.ScrollBars = ScrollBars.Vertical;
            textBoxOut_BTI.Size = new Size(450, 305);
            textBoxOut_BTI.TabIndex = 0;
            // 
            // openFileDialogTask_BTI
            // 
            openFileDialogTask_BTI.FileName = "openFileDialog1";
            // 
            // toolTipInfo_BTI
            // 
            toolTipInfo_BTI.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo_BTI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelRight_BTI);
            Controls.Add(splitterLeftRight_BTI);
            Controls.Add(panelLeft_BTI);
            Controls.Add(groupBoxUslovie_BTI);
            Controls.Add(panelTop_BTI);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(581, 39);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 28 | Бат Т.И.";
            panelTop_BTI.ResumeLayout(false);
            groupBoxUslovie_BTI.ResumeLayout(false);
            groupBoxUslovie_BTI.PerformLayout();
            panelLeft_BTI.ResumeLayout(false);
            groupBoxInput_BTI.ResumeLayout(false);
            groupBoxInput_BTI.PerformLayout();
            panelRight_BTI.ResumeLayout(false);
            groupBoxOutput_BTI.ResumeLayout(false);
            groupBoxOutput_BTI.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_BTI;
        private System.Windows.Forms.GroupBox groupBoxUslovie_BTI;
        private System.Windows.Forms.TextBox textBoxUslovie_BTI;
        private System.Windows.Forms.Panel panelLeft_BTI;
        private System.Windows.Forms.Splitter splitterLeftRight_BTI;
        private System.Windows.Forms.Panel panelRight_BTI;
        private System.Windows.Forms.GroupBox groupBoxInput_BTI;
        private System.Windows.Forms.GroupBox groupBoxOutput_BTI;
        private System.Windows.Forms.TextBox textBoxIn_BTI;
        private System.Windows.Forms.TextBox textBoxOut_BTI;
        private System.Windows.Forms.Button buttonInfo_BTI;
        private System.Windows.Forms.Button buttonDone_BTI;
        private System.Windows.Forms.Button buttonOpen_BTI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BTI;
        private System.Windows.Forms.ToolTip toolTipInfo_BTI;
    }
}