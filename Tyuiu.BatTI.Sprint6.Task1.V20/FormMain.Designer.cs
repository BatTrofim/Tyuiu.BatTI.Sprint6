namespace Tyuiu.BatTI.Sprint6.Task1.V20
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
            textBoxVarStart = new TextBox();;
            textBoxVarStop = new TextBox();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // textBoxVarStart
            // 
            textBoxVarStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVarStart.Location = new Point(12, 361);
            textBoxVarStart.Name = "textBoxVarStart";
            textBoxVarStart.Size = new Size(124, 33);
            textBoxVarStart.TabIndex = 0;
            // 
            // label1
            // 
            // 
            // label2
            // 
            // 
            // textBoxVarStop
            // 
            textBoxVarStop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVarStop.Location = new Point(142, 361);
            textBoxVarStop.Name = "textBoxVarStop";
            textBoxVarStop.Size = new Size(124, 33);
            textBoxVarStop.TabIndex = 3;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(272, 167);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(167, 227);
            textBoxResult.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(272, 139);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 5;
            label3.Text = "Ответ";
            // 
            // buttonDone
            // 

            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(label3);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxVarStop);

            Controls.Add(textBoxVarStart);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxVarStart;

        private TextBox textBoxVarStop;
        private TextBox textBoxResult;
        private Label label3;

    }
}
