namespace HastaneOtomasyon.Forms
{
    partial class FrmAna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemsireIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaIslemleriToolStripMenuItem,
            this.doctorIslemleriToolStripMenuItem,
            this.hemsireIslemleriToolStripMenuItem,
            this.personelIslemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaIslemleriToolStripMenuItem
            // 
            this.hastaIslemleriToolStripMenuItem.Name = "hastaIslemleriToolStripMenuItem";
            this.hastaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.hastaIslemleriToolStripMenuItem.Text = "Hasta Islemleri";
            this.hastaIslemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaIslemleriToolStripMenuItem_Click);
            // 
            // doctorIslemleriToolStripMenuItem
            // 
            this.doctorIslemleriToolStripMenuItem.Name = "doctorIslemleriToolStripMenuItem";
            this.doctorIslemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.doctorIslemleriToolStripMenuItem.Text = "Doktor Islemleri";
            this.doctorIslemleriToolStripMenuItem.Click += new System.EventHandler(this.doctorIslemleriToolStripMenuItem_Click);
            // 
            // hemsireIslemleriToolStripMenuItem
            // 
            this.hemsireIslemleriToolStripMenuItem.Name = "hemsireIslemleriToolStripMenuItem";
            this.hemsireIslemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hemsireIslemleriToolStripMenuItem.Text = "Hemsire Islemleri";
            this.hemsireIslemleriToolStripMenuItem.Click += new System.EventHandler(this.hemsireIslemleriToolStripMenuItem_Click);
            // 
            // personelIslemleriToolStripMenuItem
            // 
            this.personelIslemleriToolStripMenuItem.Name = "personelIslemleriToolStripMenuItem";
            this.personelIslemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelIslemleriToolStripMenuItem.Text = "Personel Islemleri";
            this.personelIslemleriToolStripMenuItem.Click += new System.EventHandler(this.personelIslemleriToolStripMenuItem_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAna";
            this.Text = "Hastane Otomasyonu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemsireIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelIslemleriToolStripMenuItem;
    }
}