using System;
using System.Windows.Forms;

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
        private FrmDoktorEkle frmDoktorEkle;
        private FrmDoktorSil frmDoktorSil;
        private FrmDoktorGuncelle frmDoktorGuncelle;
        private FrmHemsireEkle frmHemsireEkle;
        private FrmHemsireSil frmHemsireSil;
        private FrmHemsireGuncelle frmHemsireGuncelle;
        private FrmPersonelEkle frmPersoneEkle;
        private FrmPersonelSil frmPersoneSil;
        private FrmPersonelGuncelle frmPersoneGuncelle;
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
            frmDoktorEkle = new FrmDoktorEkle();
            frmDoktorEkle.ShowDialog();
        }

        private void doktorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoktorSil = new FrmDoktorSil();
            frmDoktorSil.ShowDialog();
        }

        private void doktorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDoktorGuncelle = new FrmDoktorGuncelle();
            frmDoktorGuncelle.ShowDialog();
        }

        private void hemşireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHemsireEkle = new FrmHemsireEkle();
            frmHemsireEkle.ShowDialog();
        }

        private void hemşireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHemsireSil = new FrmHemsireSil();
            frmHemsireSil.ShowDialog();
        }

        private void hemşireToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHemsireGuncelle = new FrmHemsireGuncelle();
            frmHemsireGuncelle.ShowDialog();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersoneEkle = new FrmPersonelEkle();
            frmPersoneEkle.ShowDialog();
        }

        private void personelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersoneSil = new FrmPersonelSil();
            frmPersoneSil.ShowDialog();
        }

        private void personelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPersoneGuncelle = new FrmPersonelGuncelle();
            frmPersoneGuncelle.ShowDialog();
        }
    }
}
