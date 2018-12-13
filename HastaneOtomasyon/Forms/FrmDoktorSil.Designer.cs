namespace HastaneOtomasyon.Forms
{
    partial class FrmDoktorSil
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
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.lstboxDoktor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Location = new System.Drawing.Point(188, 152);
            this.btnDoktorSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(100, 35);
            this.btnDoktorSil.TabIndex = 15;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            // 
            // lstboxDoktor
            // 
            this.lstboxDoktor.FormattingEnabled = true;
            this.lstboxDoktor.ItemHeight = 16;
            this.lstboxDoktor.Location = new System.Drawing.Point(12, 13);
            this.lstboxDoktor.Name = "lstboxDoktor";
            this.lstboxDoktor.Size = new System.Drawing.Size(276, 132);
            this.lstboxDoktor.TabIndex = 16;
            // 
            // FrmDoktorSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 200);
            this.Controls.Add(this.lstboxDoktor);
            this.Controls.Add(this.btnDoktorSil);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorSil";
            this.ShowIcon = false;
            this.Text = "Dokturu Silme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.ListBox lstboxDoktor;
    }
}