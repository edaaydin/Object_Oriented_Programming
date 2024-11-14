namespace _07_OOP_Sealed
{
    // Türeyen Sınıf : Derived Class

    // Kitap sınıfı mühürlendi. Artık kimse ondan miras alamaz. Türetilemez.
    internal sealed class Kitap : BaseKitap
    {
        public string KitapAdi { get; set; }

        public string KitapTuru { get; set; }

        public string ISBNNo { get; set; }

        public string YazarAdi { get; set; }

        public override void GetLog()
        {
            Console.WriteLine("Kitap Class'ından kayıt getiriliyor...");
        }

        public override void GetUser()
        {
            Console.WriteLine("Kitap Class'ından kullanıcı getiriliyor...");
        }


    }
}
