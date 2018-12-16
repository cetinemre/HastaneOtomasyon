using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;
using System;
using System.Drawing;
using System.Windows.Forms;
// ReSharper disable NotAccessedVariable
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantAssignment

namespace HastaneOtomasyon.Forms
{
    public partial class FrmHasta : Form
    {
        
        public FrmHasta()
        {
            InitializeComponent();
        }
            Hasta seciliHasta;
            Doktor seciliDoktor;
        public string seciliServis;
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

                FrmAna.FormuTemizle(gbHastaList);
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
            gbServisList.Visible = false;
            flowLayoutPanel1.Visible = false;
            btnRandevuBitir.Visible = false;

            Button btn;
            DateTime muayeneSaati = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
            int kontrolSaat;
            for (int i = 1; i <= 20; i++)
            {

                btn = new Button();
                btn.Size = new Size(flowLayoutPanel1.Size.Width / 5, (flowLayoutPanel1.Size.Height - 10) / 8);
                btn.FlatStyle = FlatStyle.Popup;
                btn.Text = muayeneSaati.ToShortTimeString();

                if (muayeneSaati.ToShortTimeString() == "11:45") muayeneSaati = muayeneSaati.AddHours(1);
               
                // if (dtpMuayene.Value.DayOfYear > DateTime.Now.DayOfYear) btn.Enabled = true;
                else
                {
                    kontrolSaat = TimeSpan.Compare(muayeneSaati.TimeOfDay, DateTime.Now.TimeOfDay);
                    if (kontrolSaat == -1) btn.Enabled = true;
                }

                muayeneSaati = muayeneSaati.AddMinutes(15);

                flowLayoutPanel1.Controls.Add(btn);

            }
        }

        private void btnHastaOnayla_Click(object sender, EventArgs e)
        {
          //  FrmAna.FormuTemizle(gbHastaList);
          //  FrmAna.FormuTemizle(gbServisList);
            gbServisList.Visible = true;
            seciliHasta = (Hasta) lstHasta.SelectedItem;
            lstHasta.DataSource = Kisi.HastaList;
            lstServis.Items.AddRange(Enum.GetNames(typeof(Kisi.BranslarDoktor)));
        }

        private void btnDoktorOnayla_Click(object sender, EventArgs e)
        {
            FrmAna.FormuTemizle(gbDoktor);
            seciliDoktor = (Doktor)lstDoktor.SelectedItem;
            flowLayoutPanel1.Visible = true;
            btnRandevuBitir.Visible = true;
        }

        private void btnRandevuBitir_Click(object sender, EventArgs e)
        {
            var randevuListesi = Kisi.RandevuList;
            var yeniRandevu = new Randevu();

            try
            {
                yeniRandevu.Hasta = seciliHasta;
                yeniRandevu.Doktor = seciliDoktor;
                yeniRandevu.Tarih=DateTime.Now;
                yeniRandevu.Durum = true;
                yeniRandevu.Saat = flowLayoutPanel1.ToString();
                
                // randevuListesi.Add(yeniRandevu);
              
                if (randevuListesi != null) lstDoktor.Items.AddRange(randevuListesi?.ToArray());
                // gbHasta.Visible = false;
                // gbHastaList.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnServisOnayla_Click(object sender, EventArgs e)
        {
            seciliServis = lstServis.SelectedItem.ToString();
            gbDoktor.Visible = true;
            FrmAna.FormuTemizle(gbDoktor);
            foreach (var doktor in Kisi.DoktorList)
            {
                if (doktor.Brans==seciliServis)
                {
                    lstDoktor.Items.Add(doktor);
                }
            }
        }
    }
}
