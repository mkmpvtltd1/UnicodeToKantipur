namespace UnicodeToKantipurTestData
{
    partial class frmUnicodeToKantipur
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
            this.txtUnicodeData = new System.Windows.Forms.RichTextBox();
            this.txtKatifurFontData = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtKantipur = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtUnicodeData
            // 
            this.txtUnicodeData.Location = new System.Drawing.Point(12, 12);
            this.txtUnicodeData.Name = "txtUnicodeData";
            this.txtUnicodeData.Size = new System.Drawing.Size(494, 130);
            this.txtUnicodeData.TabIndex = 0;
            this.txtUnicodeData.Text = "";
            // 
            // txtKatifurFontData
            // 
            this.txtKatifurFontData.Location = new System.Drawing.Point(12, 173);
            this.txtKatifurFontData.Name = "txtKatifurFontData";
            this.txtKatifurFontData.Size = new System.Drawing.Size(494, 116);
            this.txtKatifurFontData.TabIndex = 1;
            this.txtKatifurFontData.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 148);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtKantipur
            // 
            this.txtKantipur.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKantipur.Location = new System.Drawing.Point(12, 311);
            this.txtKantipur.Name = "txtKantipur";
            this.txtKantipur.Size = new System.Drawing.Size(494, 116);
            this.txtKantipur.TabIndex = 3;
            this.txtKantipur.Text = "";
            // 
            // frmUnicodeToKantipur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 438);
            this.Controls.Add(this.txtKantipur);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtKatifurFontData);
            this.Controls.Add(this.txtUnicodeData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmUnicodeToKantipur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unicode To Kantipur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtUnicodeData;
        private System.Windows.Forms.RichTextBox txtKatifurFontData;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox txtKantipur;
    }
}

