using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Ornek
{
    public class Araba
    {
        // Özellikler (Property)
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }

        // Yapıcı Metot (Constructor)
        public Araba(string marka, string model, int yil)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
        }

        public void BilgiGoster()
        {
            Console.WriteLine($"Araba: {Marka} {Model}, Yıl: {Yil}");
        }
    }

    // 2. Sınıf: Ogrenci
    public class Ogrenci
    {
        // Özellikler (Property)
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }

        // Yapıcı Metot (Constructor)
        public Ogrenci(string ad, string soyad, int numara)
        {
            Ad = ad;
            Soyad = soyad;
            Numara = numara;
        }

        public void OgrenciBilgi()
        {
            Console.WriteLine($"Öğrenci: {Ad} {Soyad}, Numara: {Numara}");
        }
    }

    // 3. Sınıf: Bilgisayar
    public class Bilgisayar
    {
        // Özellikler (Property)
        public string Islemci { get; set; }
        public int Ram { get; set; }
        public int Depolama { get; set; }

        // Yapıcı Metot (Constructor)
        public Bilgisayar(string islemci, int ram, int depolama)
        {
            Islemci = islemci;
            Ram = ram;
            Depolama = depolama;
        }

        public void BilgiGoster()
        {
            Console.WriteLine($"Bilgisayar: {Islemci}, RAM: {Ram}GB, Depolama: {Depolama}GB");
        }
    }

    // 4. Sınıf: Kitap
    public class Kitap
    {
        // Özellikler (Property)
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }

        // Yapıcı Metot (Constructor)
        public Kitap(string baslik, string yazar, int sayfaSayisi)
        {
            Baslik = baslik;
            Yazar = yazar;
            SayfaSayisi = sayfaSayisi;
        }

        public void KitapBilgi()
        {
            Console.WriteLine($"Kitap: {Baslik}, Yazar: {Yazar}, Sayfa Sayısı: {SayfaSayisi}");
        }
    }

    // 5. Sınıf: Telefon
    public class Telefon
    {
        // Özellikler (Property)
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Hafiza { get; set; }

        // Yapıcı Metot (Constructor)
        public Telefon(string marka, string model, int hafiza)
        {
            Marka = marka;
            Model = model;
            Hafiza = hafiza;
        }

        public void TelefonBilgi()
        {
            Console.WriteLine($"Telefon: {Marka} {Model}, Hafıza: {Hafiza}GB");
        }
    }

}
// 1. Sınıf: Araba
