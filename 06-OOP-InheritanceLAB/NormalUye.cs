namespace _06_OOP_InheritanceLAb
{
    internal class NormalUye : Uye
    {
        public string kilo;
        public NormalUye()
        {
            Console.WriteLine("Parametresiz Normal Üye Ana Yapıcı");
        }

        public NormalUye(int id, string adi, DateTime tarih, int aylik) : base(id, adi, tarih)
        {
            Console.WriteLine("4 Parametreli Normal Üye Ana Yapıcı");
            aylikUcret = aylik;
        }

        public override int AidatHesapla()
        {
            return base.AidatHesapla() + aylikUcret * 12;
        }
    }
}
