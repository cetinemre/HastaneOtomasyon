namespace HastaneOtomasyon.Forms
{
    partial class FrmPersonelSil
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
            this.lstboxPersonel = new System.Windows.Forms.ListBox();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstboxPersonel
            // 
            this.lstboxPersonel.FormattingEnabled = true;
            this.lstboxPersonel.ItemHeight = 16;
            this.lstboxPersonel.Location = new System.Drawing.Point(12, 11);
            this.lstboxPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstboxPersonel.Name = "lstboxPersonel";
            this.lstboxPersonel.Size = new System.Drawing.Size(276, 132);
            this.lstboxPersonel.TabIndex = 18;
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Location = new System.Drawing.Point(188, 150);
            this.btnDoktorSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(100, 34);
            this.btnDoktorSil.TabIndex = 17;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            // 
            // FrmPersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 212);
            this.Controls.Add(this.lstboxPersonel);
            this.Controls.Add(this.btnDoktorSil);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelSil";
            this.Text = "Personeli Silme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxPersonel;
        private System.Windows.Forms.Button btnDoktorSil;
    }
}