namespace HastaneOtomasyon.Abstracts
{
    public abstract class Hemsire:Calisan
   {
       private string _servis, _doktor;

       public string Servis
       {
           get => _servis;
           set => _servis = value;
       }
        public string Doktor
        {
            get => _doktor;
            set => _doktor = value;
        }
    }
}
