﻿namespace HastaneOtomasyon.Abstracts
{
    public abstract class Calisan:Kisi
    {
        private string _brans;
        private decimal _maas;
        
        public decimal Maas
        {
            get => _maas;
            set => _maas = value;
        }

       public string Brans
       {
           get => _brans;
           set => _brans = value;
       }
    }

    public enum Maaslar
    {
        Ortopedi = 7000,
        Dis = 8000,
        Kbb = 5000,
        HastaBakici = 2500,
        Muhasebe = 3000,
        Satinalma = 4300,
        AnesteziHemsiresi = 3500,
        PsikiyatriHemsiresi = 2500,
        Bashemsire = 4000
    }
}
