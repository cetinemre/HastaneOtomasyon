namespace HastaneOtomasyon.Forms
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.gbPersonel = new System.Windows.Forms.GroupBox();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.gbPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonel
            // 
            this.gbPersonel.Controls.Add(this.TxtArama);
            this.gbPersonel.Controls.Add(this.lstPersonel);
            this.gbPersonel.Controls.Add(this.btnPersonelGuncelle);
            this.gbPersonel.Controls.Add(this.btnPersonelSil);
            this.gbPersonel.Controls.Add(this.btnPersonelEkle);
            this.gbPersonel.Controls.Add(this.dateTimePicker1);
            this.gbPersonel.Controls.Add(this.label4);
            this.gbPersonel.Controls.Add(this.label3);
            this.gbPersonel.Controls.Add(this.label2);
            this.gbPersonel.Controls.Add(this.label1);
            this.gbPersonel.Controls.Add(this.txtTcNo);
            this.gbPersonel.Controls.Add(this.txtSoyad);
            this.gbPersonel.Controls.Add(this.txtAd);
            this.gbPersonel.Location = new System.Drawing.Point(16, 15);
            this.gbPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.gbPersonel.Name = "gbPersonel";
            this.gbPersonel.Padding = new System.Windows.Forms.Padding(4);
            this.gbPersonel.Size = new System.Drawing.Size(1039, 537);
            this.gbPersonel.TabIndex = 0;
            this.gbPersonel.TabStop = false;
            this.gbPersonel.Text = "Personel Bilgileri";
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(548, 52);
            this.TxtArama.Margin = new System.Windows.Forms.Padding(4);
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(311, 22);
            this.TxtArama.TabIndex = 29;
            this.TxtArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtArama_KeyUp);
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.ItemHeight = 16;
            this.lstPersonel.Location = new System.Drawing.Point(548, 84);
            this.lstPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(311, 372);
            this.lstPersonel.TabIndex = 28;
            this.lstPersonel.SelectedIndexChanged += new System.EventHandler(this.lstPersonel_SelectedIndexChanged);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(263, 322);
            this.btnPersonelGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(203, 58);
            this.btnPersonelGuncelle.TabIndex = 27;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(263, 257);
            this.btnPersonelSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(203, 58);
            this.btnPersonelSil.TabIndex = 26;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(263, 192);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(203, 58);
            this.btnPersonelEkle.TabIndex = 25;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1923, 10, 29, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2000, 12, 13, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "DoğumTarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ad";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(263, 146);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(201, 22);
            this.txtTcNo.TabIndex = 23;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(263, 82);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(201, 22);
            this.txtSoyad.TabIndex = 22;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(263, 52);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(201, 22);
            this.txtAd.TabIndex = 17;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1072, 567);
            this.Controls.Add(this.gbPersonel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.gbPersonel.ResumeLayout(false);
            this.gbPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonel;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.TextBox TxtArama;
    }
}