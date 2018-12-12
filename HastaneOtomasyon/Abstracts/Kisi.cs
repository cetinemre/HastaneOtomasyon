using System;

namespace HastaneOtomasyon.Abstracts
{
   public abstract class Kisi
    {
        private string _tcNo, _ad, _soyad;
        private DateTime _dogumTarihi;

        public string TcNo
        {
            get => _tcNo;
            protected set => _tcNo = value;
        }

        public string Ad
        {
            get => _ad;
            protected set => _ad = value;
        }
        public string Soyad
        {
            get => _soyad;
            protected set => _soyad = value;
        }
       
        public DateTime DogumTarihi
        {
            get => _dogumTarihi;
            protected set => _dogumTarihi = value;
        }
    }
}
