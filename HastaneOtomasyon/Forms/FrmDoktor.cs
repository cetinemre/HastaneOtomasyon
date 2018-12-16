using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmDoktor : Form
    {
        public FrmDoktor()
        {
            InitializeComponent();
        }

        List<Doktor> _aramalar = new List<Doktor>();

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            var doktorListesi = Kisi.DoktorList;
            Doktor yeniDoktor = new Doktor();

            try
            {
                yeniDoktor.Ad = txtAd.Text;
                yeniDoktor.Soyad = txtSoyad.Text;
                yeniDoktor.DogumTarihi = dateTimePicker1.Value;
                yeniDoktor.TcNo = txtTcNo.Text;
                yeniDoktor.Brans = cbBrans.Text;
                yeniDoktor.Maas = (int) Enum.Parse(typeof(Maaslar), yeniDoktor.Brans);
                doktorListesi.Add(yeniDoktor);


                FrmAna.FormuTemizle(gbDoktorEkle);

                if (doktorListesi != null) lstDoktor.Items.AddRange(doktorListesi.ToArray());
             
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
       

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;

            Doktor seciliDoktor = (Doktor)lstDoktor.SelectedItem;

            Kisi.DoktorList.Remove(seciliDoktor);

            MessageBox.Show($@"{seciliDoktor.Ad} {seciliDoktor.Soyad} doktoru silindi.",@"Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            FrmAna.FormuTemizle(gbDoktorEkle);

            lstDoktor.Items.AddRange(Kisi.DoktorList.ToArray());
        }
        
        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;

            Doktor seciliDoktor = (Doktor)lstDoktor.SelectedItem;

            try
            {
                seciliDoktor.Ad = txtAd.Text;
                seciliDoktor.Soyad = txtSoyad.Text;
                seciliDoktor.TcNo = txtTcNo.Text;
                seciliDoktor.Brans = cbBrans.Text;
                seciliDoktor.DogumTarihi = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FrmAna.FormuTemizle(gbDoktorEkle);
            lstDoktor.Items.AddRange(Kisi.DoktorList.ToArray());
        }

        private void FrmDoktor_Load(object sender, EventArgs e)
        {
            FrmAna.FormuTemizle(gbDoktorEkle);
            cbBrans.Items.AddRange(Enum.GetNames(typeof(Kisi.BranslarDoktor)));
            var doktorListesi = Kisi.DoktorList;
            if (Kisi.DoktorList != null) doktorListesi.AddRange(doktorListesi.ToArray());
            // lstDoktor.DataSource = Kisi.DoktorList;
        }

        private void lstDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;
            
            var seciliDoktor = (Doktor)lstDoktor.SelectedItem;
            txtAd.Text = seciliDoktor.Ad;
            txtSoyad.Text = seciliDoktor.Soyad;
            txtTcNo.Text = seciliDoktor.TcNo;
            cbBrans.SelectedItem = seciliDoktor.Brans;
            dateTimePicker1.Value = seciliDoktor.DogumTarihi;
            
        }

        private void TxtArama_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = TxtArama.Text.ToLower();
            _aramalar = new List<Doktor>();

            foreach (Doktor dr in Kisi.DoktorList)
            {
                if (dr.Ad.ToLower().Contains(ara) || dr.Soyad.ToLower().Contains(ara) ||
                    dr.TcNo.StartsWith(ara))
                {
                    _aramalar.Add(dr);
                }
            }
            FrmAna.FormuTemizle(gbDoktorEkle);
            lstDoktor.Items.AddRange(_aramalar.ToArray());
        }

        
    }
}
