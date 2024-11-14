namespace _16_OOP_Generic
{
    // Generic yapılar belirli bir tipe baplı olmak yerine herhangi bir veri tipiyle çalışabilen sınıfların, interfacelerin,metotların, fielların oluşturulmasına izin verir.

    // Generic yapılar farklı türlerdeki verilerle çalışabilen kod oluşturmamuz gerektiğinde kullanışlıdır.

    /*
   Constraint: generic yapılarda tipleri sınırlamak için üç anahtar kelime kullanılır class, struct ve BaseClass
   Class: sadece referans tiplerin kabul edilmesini güvence altına alır.
   Struct: sadece value tiplerin kabul edilmesini güvence altına alır.
   BaseClass: sadece belirlibir temel sınıftan türetilmesini güvence altına alır.
    */

    internal class PrintData<T> where T : Person
    {
        public T ID { get; set; }
        private T myField;

        public void Print(T data)
        {
            Console.WriteLine("Data: " + data);
        }

        public T ValueGet(T data)
        {
            return data;
        }
    }
}