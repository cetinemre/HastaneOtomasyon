﻿namespace HastaneOtomasyon.Forms
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbBrans = new System.Windows.Forms.ComboBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonel
            // 
            this.gbPersonel.Controls.Add(this.button1);
            this.gbPersonel.Controls.Add(this.label5);
            this.gbPersonel.Controls.Add(this.label6);
            this.gbPersonel.Controls.Add(this.cbBrans);
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
            this.gbPersonel.Location = new System.Drawing.Point(12, 12);
            this.gbPersonel.Name = "gbPersonel";
            this.gbPersonel.Size = new System.Drawing.Size(780, 437);
            this.gbPersonel.TabIndex = 0;
            this.gbPersonel.TabStop = false;
            this.gbPersonel.Text = "Personel Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Branşı";
            // 
            // cbBrans
            // 
            this.cbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Location = new System.Drawing.Point(175, 141);
            this.cbBrans.Margin = new System.Windows.Forms.Padding(2);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(162, 21);
            this.cbBrans.TabIndex = 4;
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(408, 43);
            this.TxtArama.MaxLength = 100;
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(194, 20);
            this.TxtArama.TabIndex = 8;
            this.TxtArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtArama_KeyUp);
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.Location = new System.Drawing.Point(408, 67);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(246, 277);
            this.lstPersonel.TabIndex = 9;
            this.lstPersonel.SelectedIndexChanged += new System.EventHandler(this.lstPersonel_SelectedIndexChanged);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(175, 291);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(162, 53);
            this.btnPersonelGuncelle.TabIndex = 7;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(175, 232);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(162, 53);
            this.btnPersonelSil.TabIndex = 6;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(175, 173);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(162, 53);
            this.btnPersonelEkle.TabIndex = 5;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 117);
            this.dateTimePicker1.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1923, 10, 29, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2000, 12, 13, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DoğumTarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(175, 91);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(162, 20);
            this.txtTcNo.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(175, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(162, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 20);
            this.txtAd.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Personel Listesinde Arama:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.gbPersonel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox cbBrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}