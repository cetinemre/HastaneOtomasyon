namespace HastaneOtomasyon.Forms
{
    partial class FrmHemsire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHemsire));
            this.gbHemsire = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.btnHemsireGuncelle = new System.Windows.Forms.Button();
            this.btnHemsireSil = new System.Windows.Forms.Button();
            this.lstHemsire = new System.Windows.Forms.ListBox();
            this.btnHemsireEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbDoktoru = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.gbHemsire.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHemsire
            // 
            this.gbHemsire.Controls.Add(this.label6);
            this.gbHemsire.Controls.Add(this.button1);
            this.gbHemsire.Controls.Add(this.TxtArama);
            this.gbHemsire.Controls.Add(this.btnHemsireGuncelle);
            this.gbHemsire.Controls.Add(this.btnHemsireSil);
            this.gbHemsire.Controls.Add(this.lstHemsire);
            this.gbHemsire.Controls.Add(this.btnHemsireEkle);
            this.gbHemsire.Controls.Add(this.dateTimePicker1);
            this.gbHemsire.Controls.Add(this.cbDoktoru);
            this.gbHemsire.Controls.Add(this.label7);
            this.gbHemsire.Controls.Add(this.cbBrans);
            this.gbHemsire.Controls.Add(this.label5);
            this.gbHemsire.Controls.Add(this.label4);
            this.gbHemsire.Controls.Add(this.label3);
            this.gbHemsire.Controls.Add(this.label2);
            this.gbHemsire.Controls.Add(this.label1);
            this.gbHemsire.Controls.Add(this.txtTcNo);
            this.gbHemsire.Controls.Add(this.txtSoyad);
            this.gbHemsire.Controls.Add(this.txtAd);
            this.gbHemsire.Location = new System.Drawing.Point(16, 15);
            this.gbHemsire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHemsire.Name = "gbHemsire";
            this.gbHemsire.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHemsire.Size = new System.Drawing.Size(1040, 538);
            this.gbHemsire.TabIndex = 0;
            this.gbHemsire.TabStop = false;
            this.gbHemsire.Text = "Hemsire Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hemsire Listesinde Arama:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(544, 53);
            this.TxtArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtArama.MaxLength = 100;
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(257, 22);
            this.TxtArama.TabIndex = 9;
            this.TxtArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtArama_KeyUp);
            // 
            // btnHemsireGuncelle
            // 
            this.btnHemsireGuncelle.Location = new System.Drawing.Point(233, 383);
            this.btnHemsireGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHemsireGuncelle.Name = "btnHemsireGuncelle";
            this.btnHemsireGuncelle.Size = new System.Drawing.Size(216, 65);
            this.btnHemsireGuncelle.TabIndex = 8;
            this.btnHemsireGuncelle.Text = "Güncelle";
            this.btnHemsireGuncelle.Click += new System.EventHandler(this.btnHemsireGuncelle_Click);
            // 
            // btnHemsireSil
            // 
            this.btnHemsireSil.Location = new System.Drawing.Point(233, 311);
            this.btnHemsireSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHemsireSil.Name = "btnHemsireSil";
            this.btnHemsireSil.Size = new System.Drawing.Size(216, 65);
            this.btnHemsireSil.TabIndex = 7;
            this.btnHemsireSil.Text = "Sil";
            this.btnHemsireSil.UseVisualStyleBackColor = true;
            this.btnHemsireSil.Click += new System.EventHandler(this.btnHemsireSil_Click);
            // 
            // lstHemsire
            // 
            this.lstHemsire.FormattingEnabled = true;
            this.lstHemsire.ItemHeight = 16;
            this.lstHemsire.Location = new System.Drawing.Point(544, 82);
            this.lstHemsire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstHemsire.Name = "lstHemsire";
            this.lstHemsire.Size = new System.Drawing.Size(327, 340);
            this.lstHemsire.TabIndex = 10;
            this.lstHemsire.SelectedIndexChanged += new System.EventHandler(this.lstHemsire_SelectedIndexChanged);
            // 
            // btnHemsireEkle
            // 
            this.btnHemsireEkle.Location = new System.Drawing.Point(233, 240);
            this.btnHemsireEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHemsireEkle.Name = "btnHemsireEkle";
            this.btnHemsireEkle.Size = new System.Drawing.Size(216, 65);
            this.btnHemsireEkle.TabIndex = 6;
            this.btnHemsireEkle.Text = "Ekle";
            this.btnHemsireEkle.Click += new System.EventHandler(this.btnHemsireEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 144);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1923, 10, 29, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // cbDoktoru
            // 
            this.cbDoktoru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoktoru.FormattingEnabled = true;
            this.cbDoktoru.Location = new System.Drawing.Point(233, 207);
            this.cbDoktoru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDoktoru.Name = "cbDoktoru";
            this.cbDoktoru.Size = new System.Drawing.Size(215, 24);
            this.cbDoktoru.TabIndex = 5;
            //
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doktoru";
            // 
            // cbBrans
            // 
            this.cbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Location = new System.Drawing.Point(233, 174);
            this.cbBrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(215, 24);
            this.cbBrans.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branşı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DoğumTarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(233, 112);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(215, 22);
            this.txtTcNo.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(233, 82);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(215, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(233, 53);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(215, 22);
            this.txtAd.TabIndex = 1;
            // 
            // FrmHemsire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1072, 567);
            this.Controls.Add(this.gbHemsire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHemsire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hemşire İşlemleri";
            this.Load += new System.EventHandler(this.FrmHemsire_Load);
            this.gbHemsire.ResumeLayout(false);
            this.gbHemsire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHemsire;
        private System.Windows.Forms.Button btnHemsireEkle;
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
        private System.Windows.Forms.Button btnHemsireSil;
        private System.Windows.Forms.ListBox lstHemsire;
        private System.Windows.Forms.Button btnHemsireGuncelle;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDoktoru;
        private System.Windows.Forms.Label label7;
    }
}