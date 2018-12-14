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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemsireIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iceriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemsireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disariAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hemsireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaIslemleriToolStripMenuItem,
            this.doctorIslemleriToolStripMenuItem,
            this.hemsireIslemleriToolStripMenuItem,
            this.personelIslemleriToolStripMenuItem,
            this.iceriAktarToolStripMenuItem,
            this.disariAktarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaIslemleriToolStripMenuItem
            // 
            this.hastaIslemleriToolStripMenuItem.Image = global::HastaneOtomasyon.Properties.Resources.Graphicloads_Medical_Health_Patient;
            this.hastaIslemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hastaIslemleriToolStripMenuItem.Name = "hastaIslemleriToolStripMenuItem";
            this.hastaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.hastaIslemleriToolStripMenuItem.Text = "Hasta Islemleri";
            this.hastaIslemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaIslemleriToolStripMenuItem_Click);
            // 
            // doctorIslemleriToolStripMenuItem
            // 
            this.doctorIslemleriToolStripMenuItem.Image = global::HastaneOtomasyon.Properties.Resources.Graphicloads_Medical_Health_Doctor;
            this.doctorIslemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doctorIslemleriToolStripMenuItem.Name = "doctorIslemleriToolStripMenuItem";
            this.doctorIslemleriToolStripMenuItem.Size = new System.Drawing.Size(134, 36);
            this.doctorIslemleriToolStripMenuItem.Text = "Doktor Islemleri";
            this.doctorIslemleriToolStripMenuItem.Click += new System.EventHandler(this.doctorIslemleriToolStripMenuItem_Click);
            // 
            // hemsireIslemleriToolStripMenuItem
            // 
            this.hemsireIslemleriToolStripMenuItem.Image = global::HastaneOtomasyon.Properties.Resources.Webalys_Kameleon_pics_Nurse_1;
            this.hemsireIslemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hemsireIslemleriToolStripMenuItem.Name = "hemsireIslemleriToolStripMenuItem";
            this.hemsireIslemleriToolStripMenuItem.Size = new System.Drawing.Size(142, 36);
            this.hemsireIslemleriToolStripMenuItem.Text = "Hemsire Islemleri";
            this.hemsireIslemleriToolStripMenuItem.Click += new System.EventHandler(this.hemsireIslemleriToolStripMenuItem_Click);
            // 
            // personelIslemleriToolStripMenuItem
            // 
            this.personelIslemleriToolStripMenuItem.Image = global::HastaneOtomasyon.Properties.Resources.Graphicloads_Medical_Health_Hospital;
            this.personelIslemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelIslemleriToolStripMenuItem.Name = "personelIslemleriToolStripMenuItem";
            this.personelIslemleriToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.personelIslemleriToolStripMenuItem.Text = "Personel Islemleri";
            this.personelIslemleriToolStripMenuItem.Click += new System.EventHandler(this.personelIslemleriToolStripMenuItem_Click);
            // 
            // iceriAktarToolStripMenuItem
            // 
            this.iceriAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemsireToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.hastaToolStripMenuItem});
            this.iceriAktarToolStripMenuItem.Name = "iceriAktarToolStripMenuItem";
            this.iceriAktarToolStripMenuItem.Size = new System.Drawing.Size(69, 36);
            this.iceriAktarToolStripMenuItem.Text = "İceriAktar";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // hemsireToolStripMenuItem
            // 
            this.hemsireToolStripMenuItem.Name = "hemsireToolStripMenuItem";
            this.hemsireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hemsireToolStripMenuItem.Text = "Hemsire";
            this.hemsireToolStripMenuItem.Click += new System.EventHandler(this.hemsireToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hastaToolStripMenuItem.Text = "Hasta";
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // disariAktarToolStripMenuItem
            // 
            this.disariAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem1,
            this.hemsireToolStripMenuItem1,
            this.personelToolStripMenuItem1,
            this.hastaToolStripMenuItem1});
            this.disariAktarToolStripMenuItem.Name = "disariAktarToolStripMenuItem";
            this.disariAktarToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.disariAktarToolStripMenuItem.Text = "DisariAktar";
            // 
            // doktorToolStripMenuItem1
            // 
            this.doktorToolStripMenuItem1.Name = "doktorToolStripMenuItem1";
            this.doktorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.doktorToolStripMenuItem1.Text = "Doktor";
            this.doktorToolStripMenuItem1.Click += new System.EventHandler(this.doktorToolStripMenuItem1_Click);
            // 
            // hemsireToolStripMenuItem1
            // 
            this.hemsireToolStripMenuItem1.Name = "hemsireToolStripMenuItem1";
            this.hemsireToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hemsireToolStripMenuItem1.Text = "Hemsire";
            this.hemsireToolStripMenuItem1.Click += new System.EventHandler(this.hemsireToolStripMenuItem1_Click);
            // 
            // personelToolStripMenuItem1
            // 
            this.personelToolStripMenuItem1.Name = "personelToolStripMenuItem1";
            this.personelToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem1.Text = "Personel";
            this.personelToolStripMenuItem1.Click += new System.EventHandler(this.personelToolStripMenuItem1_Click);
            // 
            // hastaToolStripMenuItem1
            // 
            this.hastaToolStripMenuItem1.Name = "hastaToolStripMenuItem1";
            this.hastaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hastaToolStripMenuItem1.Text = "Hasta";
            this.hastaToolStripMenuItem1.Click += new System.EventHandler(this.hastaToolStripMenuItem1_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(830, 457);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.FrmAna_Load);
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
        private System.Windows.Forms.ToolStripMenuItem iceriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemsireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disariAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hemsireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
    }
}