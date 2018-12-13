using System;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;
using HastaneOtomasyon.Concretes;

namespace HastaneOtomasyon.Forms
{
    public partial class FrmDoktorEkle : Form
    {

        public FrmDoktorEkle()
        {
            InitializeComponent();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBrans.SelectedIndex==0)
                {
                    Doktor yeniDoktor = new OrtopediDoktoru();
                    yeniDoktor.Ad = txtAd.Text;
                   
                }
                else if (cbBrans.SelectedIndex==1)
                {
                    Doktor yeniDoktor = new DisDoktoru();
                }
                else if (cbBrans.SelectedIndex == 2)
                {
                    Doktor yeniDoktor = new KbbDoktoru();
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }

        private void FrmDoktorEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
