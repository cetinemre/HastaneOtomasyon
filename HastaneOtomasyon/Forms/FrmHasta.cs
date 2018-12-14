using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmHasta : Form
    {
        
        public FrmHasta()
        {
            InitializeComponent();
        }
      
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var hastaListesi = Kisi.HastaList;
            var doktorListesi = Kisi.DoktorList;
            var personelListesi = Kisi.PersonelList;

            Hasta yeniHasta = new Hasta();
            try
            {
                yeniHasta.Ad = txtAd.Text;
                yeniHasta.Soyad = txtSoyad.Text;
                yeniHasta.DogumTarihi = dateTimePicker1.Value;
                yeniHasta.TcNo = txtTCNo.Text;

                hastaListesi.Add(yeniHasta);


              if (hastaListesi != null) lstHasta.Items.AddRange(hastaListesi.ToArray());
                // gbHasta.Visible = false;
                gbHastaList.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
           var seciliHasta = (Hasta) lstHasta.SelectedItem;
           lstHasta.DataSource = Kisi.DoktorList;
        }

        private void btnDoktorOnayla_Click(object sender, EventArgs e)
        {

        }

        private void btnRandevuBitir_Click(object sender, EventArgs e)
        {

        }
    }
}
