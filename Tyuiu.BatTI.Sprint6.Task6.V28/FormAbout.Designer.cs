namespace Tyuiu.BatTI.Sprint6.Task6.V28
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAutor_BTI = new System.Windows.Forms.PictureBox();
            this.labelAbout_BTI = new System.Windows.Forms.Label();
            this.buttonOK_BTI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_BTI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAutor_BTI
            // 
            this.pictureBoxAutor_BTI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAutor_BTI.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAutor_BTI.Name = "pictureBoxAutor_BTI";
            this.pictureBoxAutor_BTI.Size = new System.Drawing.Size(135, 184);
            this.pictureBoxAutor_BTI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAutor_BTI.TabIndex = 0;
            this.pictureBoxAutor_BTI.TabStop = false;
            // 
            // labelAbout_BTI
            // 
            this.labelAbout_BTI.AutoSize = true;
            this.labelAbout_BTI.Location = new System.Drawing.Point(155, 13);
            this.labelAbout_BTI.Name = "labelAbout_BTI";
            this.labelAbout_BTI.Size = new System.Drawing.Size(265, 117);
            this.labelAbout_BTI.TabIndex = 1;
            this.labelAbout_BTI.Text = resources.GetString("labelAbout_BTI.Text");
            // 
            // buttonOK_BTI
            // 
            this.buttonOK_BTI.Location = new System.Drawing.Point(345, 174);
            this.buttonOK_BTI.Name = "buttonOK_BTI";
            this.buttonOK_BTI.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_BTI.TabIndex = 2;
            this.buttonOK_BTI.Text = "Ок";
            this.buttonOK_BTI.UseVisualStyleBackColor = true;
            this.buttonOK_BTI.Click += new System.EventHandler(this.buttonOK_BTI_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 209);
            this.Controls.Add(this.buttonOK_BTI);
            this.Controls.Add(this.labelAbout_BTI);
            this.Controls.Add(this.pictureBoxAutor_BTI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(451, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(451, 248);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_BTI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAutor_BTI;
        private System.Windows.Forms.Label labelAbout_BTI;
        private System.Windows.Forms.Button buttonOK_BTI;
    }
}