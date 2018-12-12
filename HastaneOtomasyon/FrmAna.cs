using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
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
    }
}
