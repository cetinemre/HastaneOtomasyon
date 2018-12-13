using System;
using System.Windows.Forms;
using HastaneOtomasyon.Abstracts;

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
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }

        private void FrmDoktorEkle_Load(object sender, EventArgs e)
        {
            cbBrans.DataSource = Enum.GetValues(typeof(Kisi.BranslarDoktor));
        }
    }
}
