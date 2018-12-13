namespace HastaneOtomasyon.Forms
{
    partial class FrmDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktor));
            this.duzenleme1 = new HastaneOtomasyon.Forms.Duzenleme();
            this.duzenleme2 = new HastaneOtomasyon.Forms.Duzenleme();
            this.SuspendLayout();
            // 
            // duzenleme1
            // 
            this.duzenleme1.Location = new System.Drawing.Point(-2, -1);
            this.duzenleme1.Name = "duzenleme1";
            this.duzenleme1.Size = new System.Drawing.Size(571, 30);
            this.duzenleme1.TabIndex = 0;
            // 
            // duzenleme2
            // 
            this.duzenleme2.Location = new System.Drawing.Point(-3, -1);
            this.duzenleme2.Name = "duzenleme2";
            this.duzenleme2.Size = new System.Drawing.Size(571, 30);
            this.duzenleme2.TabIndex = 0;
            // 
            // FrmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.duzenleme2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private Duzenleme duzenleme1;
        private Duzenleme duzenleme2;
    }
}