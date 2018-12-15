using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        List<Personel> _aramalar = new List<Personel>();

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

            var personelListesi = Kisi.PersonelList;
            Personel yeniPersonel = new Personel();

            try
            {
                yeniPersonel.Ad = txtAd.Text;
                yeniPersonel.Soyad = txtSoyad.Text;
                yeniPersonel.DogumTarihi = dateTimePicker1.Value;
                yeniPersonel.TcNo = txtTcNo.Text;
                yeniPersonel.Brans = cbBrans.Text;
                yeniPersonel.Maas = (int)Enum.Parse(typeof(Maaslar), yeniPersonel.Brans);
                personelListesi.Add(yeniPersonel);

                FrmAna.FormuTemizle(gbPersonel);

                if (personelListesi != null) lstPersonel.Items.AddRange(personelListesi.ToArray());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (lstPersonel.SelectedItem == null) return;

            Personel seciliPersonel = (Personel)lstPersonel.SelectedItem;

            Kisi.PersonelList.Remove(seciliPersonel);

            MessageBox.Show($@"{seciliPersonel.Ad} {seciliPersonel.Soyad} doktoru silindi.", @"Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            FrmAna.FormuTemizle(gbPersonel);

            lstPersonel.Items.AddRange(Kisi.PersonelList.ToArray());
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (lstPersonel.SelectedItem == null) return;

            Personel seciliPersonel = (Personel)lstPersonel.SelectedItem;

            try
            {
                seciliPersonel.Ad = txtAd.Text;
                seciliPersonel.Soyad = txtSoyad.Text;
                seciliPersonel.TcNo = txtTcNo.Text;
                seciliPersonel.Brans = cbBrans.Text;
                seciliPersonel.DogumTarihi = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FrmAna.FormuTemizle(gbPersonel);
            lstPersonel.Items.AddRange(Kisi.PersonelList.ToArray());
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            FrmAna.FormuTemizle(gbPersonel);
            cbBrans.Items.AddRange(Enum.GetNames(typeof(Kisi.BranslarPersonel)));
            var personelListesi = Kisi.PersonelList;
            if (Kisi.PersonelList != null) personelListesi.AddRange(personelListesi.ToArray());
            // lstPersonel.DataSource = Kisi.PersonelList;
        }

        private void lstPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonel.SelectedItem == null) return;

            var seciliPersonel = (Personel)lstPersonel.SelectedItem;
            txtAd.Text = seciliPersonel.Ad;
            txtSoyad.Text = seciliPersonel.Soyad;
            txtTcNo.Text = seciliPersonel.TcNo;
            cbBrans.SelectedItem = seciliPersonel.Brans;
            dateTimePicker1.Value = seciliPersonel.DogumTarihi;
        }

        private void TxtArama_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = TxtArama.Text.ToLower();
            _aramalar = new List<Personel>();

            foreach (Personel pr in Kisi.PersonelList)
            {
                if (pr.Ad.ToLower().Contains(ara) || pr.Soyad.ToLower().Contains(ara) ||
                    pr.TcNo.StartsWith(ara))
                {
                    _aramalar.Add(pr);
                }
            }
            FrmAna.FormuTemizle(gbPersonel);
            lstPersonel.Items.AddRange(_aramalar.ToArray());
        }
    }
}
