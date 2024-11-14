using _00_Odev_SinifEkleme_;

Class1 class1 = new Class1();

class1.Ad = "Eda";
class1.Soyad = "Aydın";
class1.Meslek = "Software Developer";
class1.Yas = 22;

Console.WriteLine($"Adi : {class1.Ad} Soyadi : {class1.Soyad} Meslegi : {class1.Meslek} Yasi : {class1.Yas}");

Class1 class2 = new Class1();

class2.OkulNo = 12345;
class2.OkulAdi = "İstinye Üniversitesi";
class2.MezunYili = 2024;
class2.Bolum = "Yazılım";


Console.WriteLine("----------------------------------------------------------------------------------------");
Console.WriteLine($"OkulNo : {class2.OkulNo} Okul Adi : {class2.OkulAdi} Mezuniyet Yili : {class2.MezunYili} Bolumu : {class2.Bolum}");

Class1 class3 = new Class1();

class3.MeyveAdi = "Karpuz";
class3.SebzeAdi = "Kabak";
class3.Baklagiller = "Nohut";
class3.YesillikAdi = "Maydanoz";

Console.WriteLine("----------------------------------------------------------------------------------------");
Console.WriteLine($"Meyve Adi : {class3.MeyveAdi} Sebze Adi : {class3.SebzeAdi} Baklagil Adi : {class3.Baklagiller} Yesillik Adi : {class3.YesillikAdi}");

Class1 class4 = new Class1();

class4.AMarka = "Apple";
class4.BMarka = "Lenovo";
class4.CMarka = "Casper";

Console.WriteLine("----------------------------------------------------------------------------------------");
Console.WriteLine($"A Markasi : {class4.AMarka} B markasi : {class4.BMarka} C Markasi : {class4.CMarka}");

Class1 class5 = new Class1();

class5.UstGiyim = "Kazak";
class5.AltGiyim = "Pantolon";
class5.DisGiyim = "Trenckot";
class5.AyakkabiNo = 37;

Console.WriteLine("----------------------------------------------------------------------------------------");
Console.WriteLine($"Ust Giyim : {class5.UstGiyim} Alt Giyim : {class5.AltGiyim} Dis Giyim : {class5.DisGiyim} Ayakkabi No : {class5.AyakkabiNo}");