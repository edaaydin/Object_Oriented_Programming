using _10_AbstractClassLAB;

//MuzikAleti muzikAleti = new MuzikAleti();

Gitar gitar = new Gitar();
gitar.Name = "";
gitar.Description = "";

Flut flut = new Flut();
Batari batari = new Batari();

gitar.Music();
flut.Music();
batari.Music();

ElektroGitar elektroGitar = new ElektroGitar();

elektroGitar.Music();

Keman keman = new Keman() { Name = "Yamaha-X10", Description = "" };

Muzisyen muzisyen1 = new Muzisyen();
muzisyen1.Adi = "Zafer";
muzisyen1.Soyadi = "Dörter";
muzisyen1.MuzikAleti = new Flut();
muzisyen1.MuzikAletleri = new List<MuzikAleti>() { new Flut(), new Gitar(), new ElektroGitar() };

Muzisyen muzisyen2 = new Muzisyen()
{
    Adi = "Zehra",
    Soyadi = "Dörter",
    MuzikAleti = new Keman(),
    MuzikAletleri = new List<MuzikAleti>()
    {
       keman,
        new Batari()
    }
};

foreach (MuzikAleti item in muzisyen1.MuzikAletleri)
{
    Console.WriteLine(item.Music());
}