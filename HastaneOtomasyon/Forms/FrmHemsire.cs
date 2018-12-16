using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmHemsire : Form
    {
        public FrmHemsire()
        {
            InitializeComponent();
        }
        List<Hemsire> _aramalar = new List<Hemsire>();

        private void btnHemsireEkle_Click(object sender, System.EventArgs e)
        {

            var hemsireListesi = Kisi.HemsireList;
            Hemsire yeniHemsire = new Hemsire();

            try
            {
                yeniHemsire.Doktor = cbDoktoru.SelectedText;
                yeniHemsire.Ad = txtAd.Text;
                yeniHemsire.Soyad = txtSoyad.Text;
                yeniHemsire.DogumTarihi = dateTimePicker1.Value;
                yeniHemsire.TcNo = txtTcNo.Text;
                yeniHemsire.Brans = cbBrans.Text;
                yeniHemsire.Maas = (int)Enum.Parse(typeof(Maaslar), yeniHemsire.Brans);
                hemsireListesi.Add(yeniHemsire);

                FrmAna.FormuTemizle(gbHemsire);

                if (hemsireListesi != null) lstHemsire.Items.AddRange(hemsireListesi.ToArray());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnHemsireSil_Click(object sender, EventArgs e)
        {
            if (lstHemsire.SelectedItem == null) return;

            Hemsire seciliHemsire = (Hemsire)lstHemsire.SelectedItem;

            Kisi.HemsireList.Remove(seciliHemsire);

            MessageBox.Show($@"{seciliHemsire.Ad} {seciliHemsire.Soyad} hemsire silindi.", @"Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            FrmAna.FormuTemizle(gbHemsire);

            lstHemsire.Items.AddRange(Kisi.HemsireList.ToArray());
        }

        private void btnHemsireGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHemsire.SelectedItem == null) return;

            Hemsire seciliHemsire = (Hemsire)lstHemsire.SelectedItem;

            try
            {
                seciliHemsire.Ad = txtAd.Text;
                seciliHemsire.Soyad = txtSoyad.Text;
                seciliHemsire.TcNo = txtTcNo.Text;
                seciliHemsire.Brans = cbBrans.Text;
                seciliHemsire.DogumTarihi = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FrmAna.FormuTemizle(gbHemsire);
            lstHemsire.Items.AddRange(Kisi.HemsireList.ToArray());
        }

        private void FrmHemsire_Load(object sender, EventArgs e)
        {
            FrmAna.FormuTemizle(gbHemsire);
            cbBrans.Items.AddRange(Enum.GetNames(typeof(Kisi.BranslarHemsire)));
            cbDoktoru.Items.AddRange(Kisi.DoktorList.ToArray());
            var hemsireListesi = Kisi.HemsireList;
            if (Kisi.HemsireList != null) hemsireListesi.AddRange(hemsireListesi.ToArray());

        }

        private void lstHemsire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHemsire.SelectedItem == null) return;

            var seciliHemsire = (Hemsire)lstHemsire.SelectedItem;
            txtAd.Text = seciliHemsire.Ad;
            txtSoyad.Text = seciliHemsire.Soyad;
            txtTcNo.Text = seciliHemsire.TcNo;
            cbBrans.SelectedItem = seciliHemsire.Brans;
            dateTimePicker1.Value = seciliHemsire.DogumTarihi;
            cbBrans.SelectedItem = seciliHemsire.Doktor;
        }   

        private void TxtArama_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = TxtArama.Text.ToLower();
            _aramalar = new List<Hemsire>();

            foreach (Hemsire hm in Kisi.HemsireList)
            {
                if (hm.Ad.ToLower().Contains(ara) || hm.Soyad.ToLower().Contains(ara) ||
                    hm.TcNo.StartsWith(ara))
                {
                    _aramalar.Add(hm);
                }
            }
            FrmAna.FormuTemizle(gbHemsire);
            lstHemsire.Items.AddRange(_aramalar.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAna.FormuTemizle(gbHemsire);
            if (Kisi.HemsireList != null) lstHemsire.Items.AddRange(Kisi.HemsireList.ToArray());
        }
    }
}
