
// Abstract Class'lar sadece base class olarak davranmasını (Yani instance çıkartılmamasını) istediğimiz durumlarda kullanışlıdır.

/*
  Abstract Metotlar (Abstract metotlar tanımlanırken aşağıdaki kurallara dikkat edilmelidir.)

- Abstract bir mett private olarak tanımlanamaz. çünkü private metotlar miras alınan sınıflarda implement edilmezler. bu da abstract yapısına ters düşer.
- Abstract metotlar sadece abstract sınıfların içinde tanımlanabilirler.
- Abstract metotlar virtual olarak tanımlanamazlar. Her abstract class virtual'dur.
- Absttract static olarak tanımlanamazlar.
 
 */

using _09_OOP_AbstractClass;

namespace _09_OOP_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YeniClass yeniClass = new YeniClass(); // abstract class yada interface'in nesnesi oluşturulamaz.

            SinifA sinifA = new SinifA();
            sinifA.MesajYazAbstract();
            sinifA.MesajYaz();

            SinifB sinifB = new SinifB();
            sinifB.MesajYaz();
            sinifB.MesajYazAbstract();
        }
    }

    public abstract class YeniClass
    {
        private string mesaj = "Merhaba Dünya";
        public string Mesaj { get; set; }

        public void MesajYaz()
        {
            Console.WriteLine(mesaj);
        }

        // Abstract bir class'ın en önemli özelliği içerisinde absract olan veya olmayan metotlar barındırabilir.
        // Abstract bir metotdun kalıtım alınan sınıf içerisinde implement'e edilmesi zorunludur.

        public abstract void MesajYazAbstract();

        //public abstract void MesajYazAbstract() // Abstract bir metodun body'si olmaz.
        //{
        //    Console.WriteLine(Mesaj);
        //}

    }
    // YeniClass : Base Class
    // SinifA: Derived Class
    public class SinifA : YeniClass
    {
        public override void MesajYazAbstract()
        {
            Console.WriteLine("Merhaba Sınıf A");
        }
    }

    public class SinifB : YeniClass
    {
        public override void MesajYazAbstract()
        {
            Console.WriteLine("Merhaba Sınıf B");
        }
    }
}
