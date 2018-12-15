using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;
using Newtonsoft.Json;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmAna : Form
    {
        public static void FormuTemizle(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is TextBox)
                {
                    if (child.Name == "TxtArama") { continue; }

                    child.Text = string.Empty;
                }
                else if (child is ListBox lstBox)
                {
                    lstBox.Items.Clear();
                }
                else if (child is DateTimePicker dtp)
                {
                    dtp.Value = dtp.MaxDate;
                }
            }
        }
        public FrmAna()
        {
            InitializeComponent();
        }
        private FrmDoktor _frmDoktor;
        private FrmHasta _frmHasta;
        private FrmHemsire _frmHemsire;
        private FrmPersonel _frmPersonel;
        private void hastaIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmHasta != null && !_frmHasta.IsDisposed) return;

            _frmHasta = new FrmHasta
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            _frmHasta.Show();
        }

        private void doctorIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmDoktor != null && !_frmDoktor.IsDisposed) return;

            _frmDoktor = new FrmDoktor
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            _frmDoktor.Show();
        }

        private void hemsireIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmHemsire != null && !_frmHemsire.IsDisposed) return;

            _frmHemsire = new FrmHemsire
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            _frmHemsire.Show();
        }

        private void personelIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmPersonel != null && !_frmPersonel.IsDisposed) return;

            _frmPersonel = new FrmPersonel
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            _frmPersonel.Show();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {

        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = @"Bir JSON dosyası seçiniz";
            dosyaAc.Filter = @"(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "DoktorList.json";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dosya = File.OpenRead(dosyaAc.FileName);
                    var reader = new StreamReader(dosya);
                    var dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    Kisi.DoktorList = JsonConvert.DeserializeObject<List<Doktor>>(dosyaIcerigi);
                    
                    MessageBox.Show($@"{Kisi.DoktorList.Count} doktor sisteme basariyla eklendi");
                    var doktorListesi = Kisi.DoktorList;
                    if (Kisi.DoktorList != null) doktorListesi.AddRange(doktorListesi.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Bir hata olustu: " + ex.Message);
                }
            }
        }

        private void hemsireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hastaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doktorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = @"Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = @"(JSON Dosyası) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "DoktorListesi.json";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                var file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                var writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(Kisi.DoktorList));
                writer.Close();
                writer.Dispose();
            }
        }

        private void hemsireToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void personelToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hastaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
