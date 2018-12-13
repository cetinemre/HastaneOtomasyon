using System;
using System.Collections.Generic;
using HastaneOtomasyon.Concretes;

namespace HastaneOtomasyon.Abstracts
{

   public abstract class Kisi
    {
        public static List<Doktor> DoktorList { get; set; } = new List<Doktor>();

        public static List<Hasta> HastaList { get; set; } = new List<Hasta>();

        public static List<Personel> PersonelList { get; set; } = new List<Personel>();


        private string _tcNo, _ad, _soyad;
        private DateTime _dogumTarihi;

        public string TcNo
        {
            get => _tcNo;
            set
            {
                if (value.Length != 11)
                    throw new Exception("TCNO 11 haneli olmalıdır.");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TCNO sadece rakamlardan oluşmalıdır.");
                }
                    _tcNo = value;
            }
        }

        public string Ad
        {
            get => _ad;
            set
            {
                NameValid(value, "Ad");
                value = value.Trim();
                _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        
        public string Soyad
        {
            get => _soyad;
            set
            {
                NameValid(value, "Soyad");
                value = value.Trim();
                _soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
       
        public DateTime DogumTarihi
        {
            get => _dogumTarihi;
            set => _dogumTarihi = value;
        }

        private void NameValid(string value, string propertyName)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception($"{propertyName} girisi sadece harf ve bosluklarla yapilmalidir.");
            }
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

        public enum BranslarDoktor
        {
            Ortopedi,
            Dis,
            Kbb
        }

        public enum BranslarHemsire
        {
            Psikiyatri,
            Bashemsire,
            Anestezi
        }

        public enum BranslarPersonel
        {
            Muhasebe,
            Hizmetli,
            Satinalma
        }


    }
}
