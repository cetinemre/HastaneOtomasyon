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
            this.personelIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemsireIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaIslemleriToolStripMenuItem,
            this.doctorIslemleriToolStripMenuItem,
            this.hemsireIslemleriToolStripMenuItem,
            this.personelIslemleriToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
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
            // personelIslemleriToolStripMenuItem
            // 
            this.personelIslemleriToolStripMenuItem.Image = global::HastaneOtomasyon.Properties.Resources.Webalys_Kameleon_pics_Road_Worker_1;
            this.personelIslemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelIslemleriToolStripMenuItem.Name = "personelIslemleriToolStripMenuItem";
            this.personelIslemleriToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.personelIslemleriToolStripMenuItem.Text = "Personel Islemleri";
            this.personelIslemleriToolStripMenuItem.Click += new System.EventHandler(this.personelIslemleriToolStripMenuItem_Click);
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
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 36);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doktorToolStripMenuItem.Text = "Doktor";
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hemşireToolStripMenuItem.Text = "Hemşire";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem1,
            this.hemşireToolStripMenuItem1,
            this.personelToolStripMenuItem1});
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(31, 36);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // doktorToolStripMenuItem1
            // 
            this.doktorToolStripMenuItem1.Name = "doktorToolStripMenuItem1";
            this.doktorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.doktorToolStripMenuItem1.Text = "Doktor";
            // 
            // hemşireToolStripMenuItem1
            // 
            this.hemşireToolStripMenuItem1.Name = "hemşireToolStripMenuItem1";
            this.hemşireToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hemşireToolStripMenuItem1.Text = "Hemşire";
            // 
            // personelToolStripMenuItem1
            // 
            this.personelToolStripMenuItem1.Name = "personelToolStripMenuItem1";
            this.personelToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem1.Text = "Personel";
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem2,
            this.hemşireToolStripMenuItem2,
            this.personelToolStripMenuItem2});
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(65, 36);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // doktorToolStripMenuItem2
            // 
            this.doktorToolStripMenuItem2.Name = "doktorToolStripMenuItem2";
            this.doktorToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.doktorToolStripMenuItem2.Text = "Doktor";
            // 
            // hemşireToolStripMenuItem2
            // 
            this.hemşireToolStripMenuItem2.Name = "hemşireToolStripMenuItem2";
            this.hemşireToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.hemşireToolStripMenuItem2.Text = "Hemşire";
            // 
            // personelToolStripMenuItem2
            // 
            this.personelToolStripMenuItem2.Name = "personelToolStripMenuItem2";
            this.personelToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem2.Text = "Personel";
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
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem2;
    }
}