namespace HastaneOtomasyon.Forms
{
    partial class Duzenleme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(3, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 20);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(116, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 20);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(229, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 20);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(342, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(107, 20);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(455, 4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(107, 20);
            this.txtArama.TabIndex = 4;
            // 
            // Duzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "Duzenleme";
            this.Size = new System.Drawing.Size(571, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtArama;
    }
}
