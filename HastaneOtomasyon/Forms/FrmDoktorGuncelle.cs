using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmDoktorGuncelle : Form
    {
        public FrmDoktorGuncelle()
        {
            InitializeComponent();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmDoktorGuncelle_Load(object sender, EventArgs e)
        {
            cbBrans.DataSource = Enum.GetValues(typeof(Kisi.BranslarDoktor));
        }
    }
}
