
using _01_OOP_Class;
using System.Diagnostics.CodeAnalysis;


//Person zafer = new Person(); // Instance : Nesne Oluşturma

//zafer.Name = "Zafer";
//zafer.Surname = "Dörter";
//zafer.Age = 43;
//zafer.Id = 1;

//Person zehra = new Person();
//zehra.Name = "Zehra";
//zehra.Surname = "Dörter";
//zehra.Age = 29;
//zehra.Id = 2;

//Console.WriteLine($"{zafer.Name} {zafer.Surname}");
//Console.WriteLine($"{zehra.Name} {zehra.Surname}");

//Person person1 = new Person();

//person1.Name = "Zafer";
//person1.Age = 15;

////person1.SetAge(17);
////Console.WriteLine(person1.GetAge());

//Console.WriteLine(person1.Age);

//Person burhan = new Person() { Name = "Burhan", Surname = "Balatacı", Age = 30 };

//Person irem = new Person() { Name = "İrem", Surname = "Akay", Age = 25 };

//Person sude = new Person() { Name = "Sude", Surname = "Kılıç", Age = 24 };

//List<Person> people = new List<Person>();

//people.Add(burhan);
//people.Add(irem);
//people.Add(sude);

//List<Person> people = new List<Person>() { burhan, irem, sude};

//foreach (Person person in people)
//{
//    Console.WriteLine($"{person.Name} {person.Surname} {person.Age}");
//}


#region Örnek
// kullanıcı personeller tanımlayacak ve bu bilgiler list içerisinde tutulacak.

// 1- Liste oluştur.
// 2- Kullanıcı X 'e basana kadar döngü ile veri girişi yapmaya devam etsin.
// 3- X 'e basınca liste içindeki tüm verileri ekrana bastıracak.
/* Döngü içinde yeni bir personel nesnesi oluştur.
   Person nesnesinin ilgili property'sine kullanıcıdan gelen veriyi yaz.
    Person nesnesini listeye ekle.
*/

List<Person> people = new List<Person>();

do
{
    Person person = new Person();

    Console.WriteLine("Lütfen İsim Giriniz");
    person.Name = Console.ReadLine();

    Console.WriteLine("Lütfen Soyismi Giriniz");
    person.Surname = Console.ReadLine();

    Console.WriteLine("Lütfen Yaşı Giriniz");
    person.Age = Convert.ToInt32(Console.ReadLine());

    people.Add(person);

    Console.WriteLine("Çıkmak için X e basınız.");

} while (Console.ReadLine() != "X");

foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} {person.Surname} {person.Age}");
}


#endregion