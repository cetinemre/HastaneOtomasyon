using HastaneOtomasyon.Concretes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }
        List<Hasta> hastaListesi = new List<Hasta>();
        Hasta seciliHasta = new Hasta();
        List<Doktor> doktorListesi = new List<Doktor>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hasta yeniHasta = new Hasta();
            try
            {
                yeniHasta.Ad = txtAd.Text;
                yeniHasta.Soyad = txtSoyad.Text;
                yeniHasta.DogumTarihi = dateTimePicker1.Value;
                yeniHasta.TcNo = txtTCNo.Text;

                hastaListesi.Add(yeniHasta);
                FormuTemizle();

              if (hastaListesi != null) lstHasta.Items.AddRange(hastaListesi.ToArray());
                // gbHasta.Visible = false;
                gbHastaList.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void FormuTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCNo.Clear();
            dateTimePicker1.ResetText();
            lstHasta.Items.Clear();
        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {
            gbHasta.Visible = true;
            gbHastaList.Visible = false;
            gbDoktor.Visible = false;
            gbSaat.Visible = false;
        }

        private void btnHastaOnayla_Click(object sender, EventArgs e)
        {
            seciliHasta = (Hasta) lstHasta.SelectedItem;
            
        }

        private void btnDoktorOnayla_Click(object sender, EventArgs e)
        {

        }

        private void btnRandevuBitir_Click(object sender, EventArgs e)
        {

        }
    }
}
