using System;
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

        private void btnDoktorEkle_Click(object sender, System.EventArgs e)
        {
            var hastaListesi = Kisi.HastaList;
            var doktorListesi = Kisi.DoktorList;
            var personelListesi = Kisi.PersonelList;

            Doktor yeniDoktor = new Doktor();
            try
            {
                yeniDoktor.Ad = txtAd.Text;
                yeniDoktor.Soyad = txtSoyad.Text;
                yeniDoktor.DogumTarihi = dateTimePicker1.Value;
                yeniDoktor.TcNo = txtTcNo.Text;
                yeniDoktor.Brans = cbBrans.SelectedText;

                doktorListesi.Add(yeniDoktor);

                 FormuTemizle();

                 if (doktorListesi != null) lstDoktor.Items.AddRange(doktorListesi.ToArray());
                // gbHasta.Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtAra")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is CheckBox box)
                    box.Checked = false;
                else if (control is ListBox lstBox)
                    lstBox.Items.Clear();
                else if (control is PictureBox pbox)
                    pbox.Image = null;
            }
        }

        private void btnDoktorSil_Click(object sender, System.EventArgs e)
        {

        }

        private void btnDoktorGuncelle_Click(object sender, System.EventArgs e)
        {

        }

        private void FrmDoktor_Load(object sender, System.EventArgs e)
        {
            cbBrans.DataSource = Enum.GetValues(typeof(Kisi.BranslarDoktor));
           // lstDoktor.DataSource = Kisi.DoktorList;
        }
    }
}
