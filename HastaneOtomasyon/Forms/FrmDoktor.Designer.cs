﻿namespace HastaneOtomasyon.Forms
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
            this.gbDoktorEkle = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.lstDoktor = new System.Windows.Forms.ListBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbBrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.gbDoktorEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDoktorEkle
            // 
            this.gbDoktorEkle.Controls.Add(this.label6);
            this.gbDoktorEkle.Controls.Add(this.btnYenile);
            this.gbDoktorEkle.Controls.Add(this.TxtArama);
            this.gbDoktorEkle.Controls.Add(this.btnDoktorSil);
            this.gbDoktorEkle.Controls.Add(this.btnDoktorGuncelle);
            this.gbDoktorEkle.Controls.Add(this.lstDoktor);
            this.gbDoktorEkle.Controls.Add(this.btnDoktorEkle);
            this.gbDoktorEkle.Controls.Add(this.dateTimePicker1);
            this.gbDoktorEkle.Controls.Add(this.cbBrans);
            this.gbDoktorEkle.Controls.Add(this.label5);
            this.gbDoktorEkle.Controls.Add(this.label4);
            this.gbDoktorEkle.Controls.Add(this.label3);
            this.gbDoktorEkle.Controls.Add(this.label2);
            this.gbDoktorEkle.Controls.Add(this.label1);
            this.gbDoktorEkle.Controls.Add(this.txtTcNo);
            this.gbDoktorEkle.Controls.Add(this.txtSoyad);
            this.gbDoktorEkle.Controls.Add(this.txtAd);
            this.gbDoktorEkle.Location = new System.Drawing.Point(12, 12);
            this.gbDoktorEkle.Name = "gbDoktorEkle";
            this.gbDoktorEkle.Size = new System.Drawing.Size(780, 437);
            this.gbDoktorEkle.TabIndex = 0;
            this.gbDoktorEkle.TabStop = false;
            this.gbDoktorEkle.Text = "Doktor Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doktor Listesinde Arama:";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(608, 41);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(46, 23);
            this.btnYenile.TabIndex = 11;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(408, 43);
            this.TxtArama.MaxLength = 100;
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(194, 20);
            this.TxtArama.TabIndex = 9;
            this.TxtArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtArama_KeyUp);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Location = new System.Drawing.Point(175, 232);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(162, 53);
            this.btnDoktorSil.TabIndex = 7;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(175, 291);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(162, 53);
            this.btnDoktorGuncelle.TabIndex = 8;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // lstDoktor
            // 
            this.lstDoktor.FormattingEnabled = true;
            this.lstDoktor.Location = new System.Drawing.Point(408, 67);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(246, 277);
            this.lstDoktor.TabIndex = 10;
            this.lstDoktor.SelectedIndexChanged += new System.EventHandler(this.lstDoktor_SelectedIndexChanged);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(175, 173);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(162, 53);
            this.btnDoktorEkle.TabIndex = 6;
            this.btnDoktorEkle.Text = "Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 117);
            this.dateTimePicker1.MaxDate = new System.DateTime(1994, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1923, 10, 29, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(1994, 12, 31, 0, 0, 0, 0);
            // 
            // cbBrans
            // 
            this.cbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Location = new System.Drawing.Point(175, 141);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(162, 21);
            this.cbBrans.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branşı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
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
            this.txtTcNo.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(175, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(162, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 20);
            this.txtAd.TabIndex = 1;
            // 
            // FrmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.gbDoktorEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.FrmDoktor_Load);
            this.gbDoktorEkle.ResumeLayout(false);
            this.gbDoktorEkle.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox gbDoktorEkle;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbBrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.ListBox lstDoktor;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label6;
    }
}