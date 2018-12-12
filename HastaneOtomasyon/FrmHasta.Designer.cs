namespace HastaneOtomasyon
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
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lstServis = new System.Windows.Forms.ListBox();
            this.lstDoktor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(88, 84);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 20);
            this.txtDT.TabIndex = 6;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(89, 58);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 20);
            this.txtTCNo.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(89, 32);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(89, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 9;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(10, 87);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(70, 13);
            this.lblDT.TabIndex = 2;
            this.lblDT.Text = "Doğum Tarihi";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(10, 61);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(35, 13);
            this.lblTCNo.TabIndex = 3;
            this.lblTCNo.Text = "TCNo";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(10, 35);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad";
            // 
            // lstServis
            // 
            this.lstServis.FormattingEnabled = true;
            this.lstServis.Location = new System.Drawing.Point(223, 6);
            this.lstServis.Name = "lstServis";
            this.lstServis.Size = new System.Drawing.Size(222, 212);
            this.lstServis.TabIndex = 10;
            // 
            // lstDoktor
            // 
            this.lstDoktor.FormattingEnabled = true;
            this.lstDoktor.Location = new System.Drawing.Point(468, 6);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(222, 212);
            this.lstDoktor.TabIndex = 10;
            // 
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDoktor);
            this.Controls.Add(this.lstServis);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "FrmHasta";
            this.Text = "Hasta İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ListBox lstServis;
        private System.Windows.Forms.ListBox lstDoktor;
    }
}