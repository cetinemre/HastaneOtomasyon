using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;
using System;
using System.Drawing;
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
            flowLayoutPanel1.Visible = false;
            Button btn;
            DateTime muayeneSaati = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
            int kontrol;
            for (int i = 1; i <= 20; i++)
            {

                btn = new Button();
                btn.Size = new Size(flowLayoutPanel1.Size.Width / 5, (flowLayoutPanel1.Size.Height - 10) / 8);
                btn.FlatStyle = FlatStyle.Popup;
                btn.Text = muayeneSaati.ToShortTimeString();

                if (muayeneSaati.ToShortTimeString() == "11:45") muayeneSaati = muayeneSaati.AddHours(1);

                kontrol = TimeSpan.Compare(muayeneSaati.TimeOfDay, DateTime.Now.TimeOfDay);

                //if (kontrol == -1) btn.Enabled = false;

                muayeneSaati = muayeneSaati.AddMinutes(15);

                flowLayoutPanel1.Controls.Add(btn);

            }
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
