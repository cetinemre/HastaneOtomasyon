using HastaneOtomasyon.Abstracts;

namespace HastaneOtomasyon.Concretes
{
    public class Doktor:Calisan
    {
        private string _brans;

        public string Brans
        {
            get => _brans;
            set => _brans = value;
        }
    }
}
