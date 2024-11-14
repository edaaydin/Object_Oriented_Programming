namespace _06_OOP_InheritanceLAb
{
    internal class VIPUye : Uye
    {
        public double boy;

        public VIPUye()
        {
            Console.WriteLine("Parametresiz VIP Uye Ana Yapıcı");
        }

        public VIPUye(int uyeID, string uyeAdi, DateTime uyelikTarihi, int aylik) : base(uyeID, uyeAdi, uyelikTarihi)
        {
            Console.WriteLine("4 Parametreli VIP Uye Ana Yapıcı");
            aylikUcret = aylik;
        }

        public override int AidatHesapla()
        {
            return base.AidatHesapla() + (aylikUcret * 12) + 500;
        }

    }
}
