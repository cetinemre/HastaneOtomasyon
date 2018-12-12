using System;

namespace HastaneOtomasyon.Abstracts
{
    public abstract class Calisan
   {
       private string _tcNo, _ad, _soyad, _brans;
       private DateTime _dogumTarihi;
       private decimal _maas;

       public string TcNo
       {
           get => _tcNo;
           set => _tcNo = value;
       }

       public string Ad
       {
           get => _ad;
           set => _ad = value;
       }
        public string Soyad
        {
            get => _soyad;
            set => _soyad = value;
        }
        public string Brans
        {
            get => _brans;
            set => _brans = value;
        }
        public DateTime DogumTarihi
        {
            get => _dogumTarihi;
            set => _dogumTarihi = value;
        }
        public decimal Maas
        {
            get => _maas;
            set => _maas = value;
        }


    }
}
