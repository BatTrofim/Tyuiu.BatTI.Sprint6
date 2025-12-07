namespace Tyuiu.BatTI.Sprint6.Task2.V3
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
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            dataGridViewRes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataServiceBindingSource = new BindingSource(components);
            buttonResult = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(30, 356);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(86, 44);
            textBoxStart.TabIndex = 0;
            textBoxStart.Text = "textBoxStart";
            textBoxStart.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(122, 356);
            textBoxEnd.Multiline = true;
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(86, 44);
            textBoxEnd.TabIndex = 1;
            textBoxEnd.Text = "textBoxEnd";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.AutoGenerateColumns = false;
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewRes.DataSource = dataServiceBindingSource;
            dataGridViewRes.Location = new Point(294, 12);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.Size = new Size(240, 294);
            dataGridViewRes.TabIndex = 2;
            dataGridViewRes.CellContentClick += dataGridViewRes_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // dataServiceBindingSource
            // 
            dataServiceBindingSource.DataSource = typeof(Lib.DataService);
            // 
            // buttonResult
            // 
            buttonResult.BackColor = SystemColors.GrayText;
            buttonResult.Location = new Point(262, 356);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(86, 44);
            buttonResult.TabIndex = 3;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult);
            Controls.Add(dataGridViewRes);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataServiceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private DataGridView dataGridViewRes;
        private Button buttonResult;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private BindingSource dataServiceBindingSource;
    }
}
