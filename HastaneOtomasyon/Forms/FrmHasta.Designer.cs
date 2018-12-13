namespace HastaneOtomasyon.Forms
{
    partial class FrmHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHasta));
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lstServis = new System.Windows.Forms.ListBox();
            this.lstDoktor = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.randevuSaatleri1 = new HastaneOtomasyon.Forms.RandevuSaatleri();
            this.gbServis = new System.Windows.Forms.GroupBox();
            this.gbDoktor = new System.Windows.Forms.GroupBox();
            this.gbSaat = new System.Windows.Forms.GroupBox();
            this.gbHasta = new System.Windows.Forms.GroupBox();
            this.gbServis.SuspendLayout();
            this.gbDoktor.SuspendLayout();
            this.gbSaat.SuspendLayout();
            this.gbHasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(94, 70);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 20);
            this.txtTCNo.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 44);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(15, 99);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(70, 13);
            this.lblDT.TabIndex = 2;
            this.lblDT.Text = "Doğum Tarihi";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(15, 73);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(35, 13);
            this.lblTCNo.TabIndex = 3;
            this.lblTCNo.Text = "TCNo";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(15, 47);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(17, 21);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad";
            // 
            // lstServis
            // 
            this.lstServis.FormattingEnabled = true;
            this.lstServis.Location = new System.Drawing.Point(6, 19);
            this.lstServis.Name = "lstServis";
            this.lstServis.Size = new System.Drawing.Size(222, 212);
            this.lstServis.TabIndex = 5;
            // 
            // lstDoktor
            // 
            this.lstDoktor.FormattingEnabled = true;
            this.lstDoktor.Location = new System.Drawing.Point(6, 19);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(222, 212);
            this.lstDoktor.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(94, 122);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 92);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // randevuSaatleri1
            // 
            this.randevuSaatleri1.Location = new System.Drawing.Point(6, 13);
            this.randevuSaatleri1.Name = "randevuSaatleri1";
            this.randevuSaatleri1.Size = new System.Drawing.Size(345, 159);
            this.randevuSaatleri1.TabIndex = 7;
            // 
            // gbServis
            // 
            this.gbServis.Controls.Add(this.lstServis);
            this.gbServis.Location = new System.Drawing.Point(220, 22);
            this.gbServis.Name = "gbServis";
            this.gbServis.Size = new System.Drawing.Size(245, 242);
            this.gbServis.TabIndex = 8;
            this.gbServis.TabStop = false;
            this.gbServis.Text = "Servis Seçiniz";
            this.gbServis.Visible = false;
            // 
            // gbDoktor
            // 
            this.gbDoktor.Controls.Add(this.lstDoktor);
            this.gbDoktor.Location = new System.Drawing.Point(471, 22);
            this.gbDoktor.Name = "gbDoktor";
            this.gbDoktor.Size = new System.Drawing.Size(242, 242);
            this.gbDoktor.TabIndex = 9;
            this.gbDoktor.TabStop = false;
            this.gbDoktor.Text = "Doktor Seçiniz";
            this.gbDoktor.Visible = false;
            // 
            // gbSaat
            // 
            this.gbSaat.Controls.Add(this.randevuSaatleri1);
            this.gbSaat.Location = new System.Drawing.Point(220, 270);
            this.gbSaat.Name = "gbSaat";
            this.gbSaat.Size = new System.Drawing.Size(375, 172);
            this.gbSaat.TabIndex = 10;
            this.gbSaat.TabStop = false;
            this.gbSaat.Text = "Randevu Saatleri";
            this.gbSaat.Visible = false;
            // 
            // gbHasta
            // 
            this.gbHasta.Controls.Add(this.lblAd);
            this.gbHasta.Controls.Add(this.lblSoyad);
            this.gbHasta.Controls.Add(this.lblTCNo);
            this.gbHasta.Controls.Add(this.lblDT);
            this.gbHasta.Controls.Add(this.btnKaydet);
            this.gbHasta.Controls.Add(this.txtAd);
            this.gbHasta.Controls.Add(this.dateTimePicker1);
            this.gbHasta.Controls.Add(this.txtSoyad);
            this.gbHasta.Controls.Add(this.txtTCNo);
            this.gbHasta.Location = new System.Drawing.Point(12, 22);
            this.gbHasta.Name = "gbHasta";
            this.gbHasta.Size = new System.Drawing.Size(208, 170);
            this.gbHasta.TabIndex = 11;
            this.gbHasta.TabStop = false;
            this.gbHasta.Text = "Hasta Bilgileri";
            // 
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.gbHasta);
            this.Controls.Add(this.gbSaat);
            this.Controls.Add(this.gbDoktor);
            this.Controls.Add(this.gbServis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta İşlemleri";
            this.gbServis.ResumeLayout(false);
            this.gbDoktor.ResumeLayout(false);
            this.gbSaat.ResumeLayout(false);
            this.gbHasta.ResumeLayout(false);
            this.gbHasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ListBox lstServis;
        private System.Windows.Forms.ListBox lstDoktor;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private RandevuSaatleri randevuSaatleri1;
        private System.Windows.Forms.GroupBox gbServis;
        private System.Windows.Forms.GroupBox gbDoktor;
        private System.Windows.Forms.GroupBox gbSaat;
        private System.Windows.Forms.GroupBox gbHasta;
    }
}