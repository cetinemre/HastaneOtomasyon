namespace HastaneOtomasyon.Abstracts
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
        OrtopediDrMaas = 7000,
        DisDrMaas = 8000,
        KbbDrMaas = 5000,
        HastaBakici = 2500,
        Muhasebe = 3000,
        Hizmetli = 1605,
        AnesteziHemsiresi = 3500,
        PsikiyatriHemsiresi = 2500,
        Bashemsire = 4000
    }

}
