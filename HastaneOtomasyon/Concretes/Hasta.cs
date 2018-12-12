using System;

namespace HastaneOtomasyon.Concretes
{
    public class Hasta
    {
        private string _ad, _soyad, _tcNo;
        private DateTime _dogumTarihi;

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

        public string TcNo
        {
            get => _tcNo;
            set => _tcNo = value;
        }

        public DateTime DogumTarihi
        {
            get => _dogumTarihi;
            set => _dogumTarihi = value;
        }


    }
}
