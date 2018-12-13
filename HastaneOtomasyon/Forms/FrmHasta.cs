using HastaneOtomasyon.Concretes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }
        List<Hasta> hastaListesi = new List<Hasta>();

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

              //  MessageBox.Show($@"Hosgeldin {yeniHasta.Ad} {yeniHasta.Soyad}");

              //  if (hastaListesi != null) lstServis.Items.AddRange(hastaListesi.ToArray());

                gbServis.Visible = true;
                gbHasta.Visible = false;
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
            lstServis.Items.Clear();
        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {
            gbHasta.Visible = true;
            gbServis.Visible = false;
            gbDoktor.Visible = false;
            gbSaat.Visible = false;
        }
    }
}
