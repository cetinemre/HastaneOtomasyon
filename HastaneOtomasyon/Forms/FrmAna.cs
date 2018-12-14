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
            if (_frmHasta == null || _frmHasta.IsDisposed)
            {
                _frmHasta = new FrmHasta();
                _frmHasta.WindowState = FormWindowState.Maximized;
                _frmHasta.MdiParent = this;
                _frmHasta.Show();
            }
        }

        private void doctorIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmDoktor == null || _frmDoktor.IsDisposed)
            {
                _frmDoktor = new FrmDoktor();
                _frmDoktor.WindowState = FormWindowState.Maximized;
                _frmDoktor.MdiParent = this;
                _frmDoktor.Show();
            }
        }

        private void hemsireIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmHemsire == null || _frmHemsire.IsDisposed)
            {
                _frmHemsire = new FrmHemsire();
                _frmHemsire.WindowState = FormWindowState.Maximized;
                _frmHemsire.MdiParent = this;
                _frmHemsire.Show();
                
            }
        }

        private void personelIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmPersonel == null || _frmPersonel.IsDisposed)
            {
                _frmPersonel = new FrmPersonel();
                _frmPersonel.WindowState = FormWindowState.Maximized;
                _frmPersonel.MdiParent = this;
                _frmPersonel.Show();
                
            }
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
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    Kisi.DoktorList = JsonConvert.DeserializeObject<List<Doktor>>(dosyaIcerigi);

                    //kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List<Kisi>;
                    //kisiler = (List<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($@"{Kisi.DoktorList.Count} kisi sisteme basariyla eklendi");
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
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
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
