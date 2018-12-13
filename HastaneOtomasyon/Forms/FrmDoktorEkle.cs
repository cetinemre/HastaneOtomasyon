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

        private void FrmDoktorEkle_Load(object sender, EventArgs e)
        {
            
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

       
    }
}
