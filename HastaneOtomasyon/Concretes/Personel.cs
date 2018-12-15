using HastaneOtomasyon.Abstracts;

namespace HastaneOtomasyon.Concretes
{
    public class Personel:Calisan
    {
        private string _brans;
        public string Brans
        {
            get => _brans;
            set => _brans = value;
        }
    }
}
