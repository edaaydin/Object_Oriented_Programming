
using _06_OOP_InheritanceLAb;

NormalUye normalUye1 = new NormalUye(1, "Fatih", new DateTime(2024, 5, 1), 5000);
NormalUye normalUye2 = new NormalUye(2, "Zafer", new DateTime(2024, 9, 10), 6000);

VIPUye vIPUye1 = new VIPUye(3, "Zehra", new DateTime(2024, 2, 10), 5000);
VIPUye vIPUye2 = new VIPUye(4, "Zehra", new DateTime(2024, 2, 10), 5000);
VIPUye vIPUye3 = new VIPUye(5, "Zehra", new DateTime(2024, 2, 10), 5000);

List<Uye> list = new List<Uye>();

list.Add(normalUye1);
list.Add(normalUye2);
list.Add(vIPUye1);
list.Add(vIPUye2);
list.Add(vIPUye3);

foreach (Uye uye in list)
{
    Console.WriteLine(uye.ToString());
    Console.WriteLine(uye.AidatHesapla());
}

