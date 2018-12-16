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
            this.lstHasta = new System.Windows.Forms.ListBox();
            this.lstDoktor = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbHastaList = new System.Windows.Forms.GroupBox();
            this.btnHastaOnayla = new System.Windows.Forms.Button();
            this.gbDoktor = new System.Windows.Forms.GroupBox();
            this.btnDoktorOnayla = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbHasta = new System.Windows.Forms.GroupBox();
            this.gbServisList = new System.Windows.Forms.GroupBox();
            this.btnServisOnayla = new System.Windows.Forms.Button();
            this.lstServis = new System.Windows.Forms.ListBox();
            this.btnRandevuBitir = new System.Windows.Forms.Button();
            this.gbHastaList.SuspendLayout();
            this.gbDoktor.SuspendLayout();
            this.gbHasta.SuspendLayout();
            this.gbServisList.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(92, 80);
            this.txtTCNo.MaxLength = 11;
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(125, 20);
            this.txtTCNo.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(92, 54);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(92, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 20);
            this.txtAd.TabIndex = 1;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(13, 109);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(70, 13);
            this.lblDT.TabIndex = 0;
            this.lblDT.Text = "Doğum Tarihi";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(13, 83);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(35, 13);
            this.lblTCNo.TabIndex = 0;
            this.lblTCNo.Text = "TCNo";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(13, 57);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(15, 31);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lstHasta
            // 
            this.lstHasta.FormattingEnabled = true;
            this.lstHasta.Location = new System.Drawing.Point(6, 19);
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(211, 108);
            this.lstHasta.TabIndex = 6;
            // 
            // lstDoktor
            // 
            this.lstDoktor.FormattingEnabled = true;
            this.lstDoktor.Location = new System.Drawing.Point(6, 19);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(211, 108);
            this.lstDoktor.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(117, 131);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Hasta Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 102);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // gbHastaList
            // 
            this.gbHastaList.Controls.Add(this.btnHastaOnayla);
            this.gbHastaList.Controls.Add(this.lstHasta);
            this.gbHastaList.Location = new System.Drawing.Point(314, 22);
            this.gbHastaList.Name = "gbHastaList";
            this.gbHastaList.Size = new System.Drawing.Size(224, 174);
            this.gbHastaList.TabIndex = 0;
            this.gbHastaList.TabStop = false;
            this.gbHastaList.Text = "Hasta Seçiniz";
            // 
            // btnHastaOnayla
            // 
            this.btnHastaOnayla.Location = new System.Drawing.Point(141, 131);
            this.btnHastaOnayla.Name = "btnHastaOnayla";
            this.btnHastaOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnHastaOnayla.TabIndex = 7;
            this.btnHastaOnayla.Text = "Onayla";
            this.btnHastaOnayla.UseVisualStyleBackColor = true;
            this.btnHastaOnayla.Click += new System.EventHandler(this.btnHastaOnayla_Click);
            // 
            // gbDoktor
            // 
            this.gbDoktor.Controls.Add(this.btnDoktorOnayla);
            this.gbDoktor.Controls.Add(this.lstDoktor);
            this.gbDoktor.Location = new System.Drawing.Point(46, 202);
            this.gbDoktor.Name = "gbDoktor";
            this.gbDoktor.Size = new System.Drawing.Size(224, 174);
            this.gbDoktor.TabIndex = 0;
            this.gbDoktor.TabStop = false;
            this.gbDoktor.Text = "Doktor Seçiniz";
            // 
            // btnDoktorOnayla
            // 
            this.btnDoktorOnayla.Location = new System.Drawing.Point(141, 132);
            this.btnDoktorOnayla.Name = "btnDoktorOnayla";
            this.btnDoktorOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorOnayla.TabIndex = 11;
            this.btnDoktorOnayla.Text = "Onayla";
            this.btnDoktorOnayla.UseVisualStyleBackColor = true;
            this.btnDoktorOnayla.Click += new System.EventHandler(this.btnDoktorOnayla_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(314, 202);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 205);
            this.flowLayoutPanel1.TabIndex = 12;
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
            this.gbHasta.Location = new System.Drawing.Point(46, 22);
            this.gbHasta.Name = "gbHasta";
            this.gbHasta.Size = new System.Drawing.Size(224, 174);
            this.gbHasta.TabIndex = 0;
            this.gbHasta.TabStop = false;
            this.gbHasta.Text = "Hasta Bilgileri";
            // 
            // gbServisList
            // 
            this.gbServisList.Controls.Add(this.btnServisOnayla);
            this.gbServisList.Controls.Add(this.lstServis);
            this.gbServisList.Location = new System.Drawing.Point(563, 22);
            this.gbServisList.Name = "gbServisList";
            this.gbServisList.Size = new System.Drawing.Size(224, 174);
            this.gbServisList.TabIndex = 0;
            this.gbServisList.TabStop = false;
            this.gbServisList.Text = "Servis Seçiniz";
            // 
            // btnServisOnayla
            // 
            this.btnServisOnayla.Location = new System.Drawing.Point(141, 131);
            this.btnServisOnayla.Name = "btnServisOnayla";
            this.btnServisOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnServisOnayla.TabIndex = 9;
            this.btnServisOnayla.Text = "Onayla";
            this.btnServisOnayla.UseVisualStyleBackColor = true;
            this.btnServisOnayla.Click += new System.EventHandler(this.btnServisOnayla_Click);
            // 
            // lstServis
            // 
            this.lstServis.FormattingEnabled = true;
            this.lstServis.Location = new System.Drawing.Point(0, 19);
            this.lstServis.Name = "lstServis";
            this.lstServis.Size = new System.Drawing.Size(211, 108);
            this.lstServis.TabIndex = 8;
            // 
            // btnRandevuBitir
            // 
            this.btnRandevuBitir.Location = new System.Drawing.Point(720, 278);
            this.btnRandevuBitir.Name = "btnRandevuBitir";
            this.btnRandevuBitir.Size = new System.Drawing.Size(75, 34);
            this.btnRandevuBitir.TabIndex = 13;
            this.btnRandevuBitir.Text = "Tamamla";
            this.btnRandevuBitir.UseVisualStyleBackColor = true;
            this.btnRandevuBitir.Click += new System.EventHandler(this.btnRandevuBitir_Click);
            // 
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.btnRandevuBitir);
            this.Controls.Add(this.gbServisList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbHasta);
            this.Controls.Add(this.gbDoktor);
            this.Controls.Add(this.gbHastaList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta İşlemleri";
            this.Load += new System.EventHandler(this.FrmHasta_Load);
            this.gbHastaList.ResumeLayout(false);
            this.gbDoktor.ResumeLayout(false);
            this.gbHasta.ResumeLayout(false);
            this.gbHasta.PerformLayout();
            this.gbServisList.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lstHasta;
        private System.Windows.Forms.ListBox lstDoktor;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbHastaList;
        private System.Windows.Forms.GroupBox gbDoktor;
        private System.Windows.Forms.GroupBox gbHasta;
        private System.Windows.Forms.Button btnHastaOnayla;
        private System.Windows.Forms.Button btnDoktorOnayla;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbServisList;
        private System.Windows.Forms.ListBox lstServis;
        private System.Windows.Forms.Button btnServisOnayla;
        private System.Windows.Forms.Button btnRandevuBitir;
    }
}