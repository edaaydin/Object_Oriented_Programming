namespace _06_OOP_InheritanceLAb
{
    internal class Uye
    {
        private int uyeID;
        private string uyeAdi;
        private DateTime uyelikTarihi;
        protected int aylikUcret;

        public Uye()
        {
            Console.WriteLine("Parametresiz Ana Yapıcı");
        }

        public Uye(int uyeID, string uyeAdi, DateTime uyelikTarihi)
        {
            Console.WriteLine("3 Parametreli Ana Yapıcı");
            this.uyeID = uyeID;
            this.uyeAdi = uyeAdi;
            this.uyelikTarihi = uyelikTarihi;
        }

        public override string ToString()
        {
            return $"\nÜye Adı: {uyeAdi} \nUye Id: {uyeID} \nUye Kayıt Tarih: {uyelikTarihi} \nAylık Ucret: {aylikUcret}";
        }

        public virtual int AidatHesapla()
        {
            return 1000;
        }
    }
}
