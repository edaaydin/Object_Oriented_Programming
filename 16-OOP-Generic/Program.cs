using _16_OOP_Generic;

//PrintData<int> printData = new PrintData<int>();
//printData.Print(5);

//PrintData<double> printData1 = new PrintData<double>();
//printData1.Print(5.0);

//PrintData<string> printData2 = new PrintData<string>();
//printData2.Print("hello");

//PrintData<DateTime> printData3 = new PrintData<DateTime>();
//printData3.Print(DateTime.Now);

PrintData<Person> printData4 = new PrintData<Person>();
printData4.Print(new Person());

PrintData<Memur> printData5 = new PrintData<Memur>();
printData5.Print(new Memur());

KeyValuePair<double, string, string> pair = new KeyValuePair<double, string, string>();

pair.Name = "";
pair.BirthDate = DateTime.Now;
pair.Id = 10.0;
pair.Get("");


KeyValuePair<Guid, string, bool> pair2 = new KeyValuePair<Guid, string, bool>();

pair2.Name = "";
pair2.BirthDate = DateTime.Now;
pair2.Id = Guid.NewGuid();
pair2.Get(true);

//EkranaYaz<string>("");
EkranaYaz<int>(5);
EkranaYaz<bool>(true);
//EkranaYaz<Person>(new Person());

//EkranaYaz("");
EkranaYaz(5);
EkranaYaz(true);
//EkranaYaz(new Person());

static void EkranaYaz<T>(T data) where T : struct
{
    Console.WriteLine(data);
}