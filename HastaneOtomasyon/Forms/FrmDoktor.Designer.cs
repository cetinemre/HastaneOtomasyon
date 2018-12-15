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
            this.gbDoktorEkle = new System.Windows.Forms.GroupBox();
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
            this.gbDoktorEkle.Location = new System.Drawing.Point(16, 15);
            this.gbDoktorEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDoktorEkle.Name = "gbDoktorEkle";
            this.gbDoktorEkle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDoktorEkle.Size = new System.Drawing.Size(1040, 538);
            this.gbDoktorEkle.TabIndex = 0;
            this.gbDoktorEkle.TabStop = false;
            this.gbDoktorEkle.Text = "Doktor Bilgileri";
            this.gbDoktorEkle.Enter += new System.EventHandler(this.gbDoktorEkle_Enter);
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(544, 47);
            this.TxtArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(327, 22);
            this.TxtArama.TabIndex = 19;
            this.TxtArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtArama_KeyUp);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Location = new System.Drawing.Point(233, 286);
            this.btnDoktorSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(216, 65);
            this.btnDoktorSil.TabIndex = 17;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(233, 358);
            this.btnDoktorGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(216, 65);
            this.btnDoktorGuncelle.TabIndex = 18;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // lstDoktor
            // 
            this.lstDoktor.FormattingEnabled = true;
            this.lstDoktor.ItemHeight = 16;
            this.lstDoktor.Location = new System.Drawing.Point(544, 82);
            this.lstDoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(327, 340);
            this.lstDoktor.TabIndex = 17;
            this.lstDoktor.SelectedIndexChanged += new System.EventHandler(this.lstDoktor_SelectedIndexChanged);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(233, 213);
            this.btnDoktorEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(216, 65);
            this.btnDoktorEkle.TabIndex = 16;
            this.btnDoktorEkle.Text = "Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 144);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.MaxDate = new System.DateTime(1994, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1923, 10, 29, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(1994, 12, 31, 0, 0, 0, 0);
            // 
            // cbBrans
            // 
            this.cbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Location = new System.Drawing.Point(233, 174);
            this.cbBrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(215, 24);
            this.cbBrans.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Branşı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "DoğumTarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(233, 112);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(215, 22);
            this.txtTcNo.TabIndex = 13;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(233, 82);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(215, 22);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(233, 53);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(215, 22);
            this.txtAd.TabIndex = 6;
            // 
            // FrmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1072, 567);
            this.Controls.Add(this.gbDoktorEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}