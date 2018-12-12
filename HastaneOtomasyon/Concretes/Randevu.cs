using System;
using HastaneOtomasyon.Abstracts;

namespace HastaneOtomasyon.Concretes
{
    public class Randevu
    {
        private Doktor _doktor;
        private Hasta _hasta;
        private DateTime _tarih;
        private bool _durum;

        public Doktor Doktor
        {
            get => _doktor;
            protected set => _doktor = value;
        }

        public Hasta Hasta
        {
            get => _hasta;
            protected set => _hasta = value;
        }

        public DateTime Tarih
        {
            get => _tarih;
            protected set => _tarih = value;
        }

        public bool Durum
        {
            get => _durum;
            protected set => _durum = value;
        }
    }
}
