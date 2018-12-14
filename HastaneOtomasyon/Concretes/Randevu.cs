using System;

namespace HastaneOtomasyon.Concretes
{
    public class Randevu
    {
        private Doktor _doktor;
        private Hasta _hasta;
        private DateTime _tarih;
        private string _saat;
        private bool _durum;

        public Doktor Doktor
        {
            get => _doktor;
            set => _doktor = value;
        }

        public Hasta Hasta
        {
            get => _hasta;
            set => _hasta = value;
        }

        public DateTime Tarih
        {
            get => _tarih;
            set => _tarih = value;
        }
        public string Saat
        {
            get => _saat;
            set => _saat = value;
        }

        public bool Durum
        {
            get => _durum;
            set => _durum = value;
        }
    }
}
