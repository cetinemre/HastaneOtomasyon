using HastaneOtomasyon.Abstracts;

namespace HastaneOtomasyon.Concretes
{
    public class Hemsire:Calisan
   {
       private string _brans, _doktor;

       public string Brans  
       {
           get => _brans;
           set => _brans = value;
       }
        public string Doktor
        {
            get => _doktor;
            set => _doktor = value;
        }

    }
}
