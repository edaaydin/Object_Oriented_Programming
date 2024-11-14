using System.Reflection.Emit;

namespace _01_OOP_Class
{
    //Basitce tanımlamak gerekirse Class(sınıf), nesneleri olusturmak icin kullanılan sablonlardır.
    // Sınıf - Class
    // Nesne - Object

    internal class Person
    {
        // Temel Olarak Uyeler
        // Constructor (Yapıcı Metot)
        // Fields (Alanlar) - Global olarak tanımlananlar
        // Properties (Ozellikler) - get set metotları olanlar
        // Methods (Metotlar) - hareket etmesi gerekir, bir davranıstır.
        // Event, Delegate ve struct

        // Default Constructor Method (Person sınıfı default olarak geldigi icin tekrardan yazmaya gerek yok.)
        // Person() { }

        //public int Id;
        //public string Name;
        //public string Surname;
        //public int Age;
        //private double Salary; // Sadece Sınıf iIcinden erisim olur.

        // Fields dışardan mudahele olmaması icin private tanımlarız.

        private string _name;
        private int _age;

        // Properties - Baska sınıfın icindeki ozellikleri kullanabilmek icin bunları kullanırız.

        public string Name { get; set; }
        public int Age { get; set; }

        // prob tab tab olursa properties acilir.
        // Metot tanımlarken metodun default olarak erisim belirleyicisi privatedir.

        #region II. Yontem

        #endregion


    }
}