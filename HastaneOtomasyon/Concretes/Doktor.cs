using HastaneOtomasyon.Abstracts;
#pragma warning disable 169

namespace HastaneOtomasyon.Concretes
{
    public class Doktor:Calisan
    {
        private string _brans;

        public string Brans { get; set; }
    }
}
