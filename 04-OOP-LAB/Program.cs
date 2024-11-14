using _04_OOP_LAB;

Console.WriteLine("Hello, World!");

/*
 ısı ayarı 
marka
fiyat
garantiSüresi
GarantisiVarMi
BuharliMi
UretimTarihi
SuDoldurmaKapasitesi
Güç
KazanliMi
Renk
Model
Stok
SeriNumarasi
DikeyMi
TabanTipi
Sürekli Buhar (gr/dk)
Şok Buhar (gr/dk)
DamlamaÖnlemeVarMi
 Kendini Temizleme / Kireç Önleme
Ayarlanabilir buhar gücü
satışTarihi

 */

Utu tefal = new Utu("Tefal-34A", true);
tefal.GenelBilgiGoster();

//new Utu(); // Default constructor ezildi. Kullanamayız.

//tefal.Garanti = DateTime.Now.AddYears(10);

tefal.SuOrani = 600;
tefal.Derece = 20;

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(2000); // döngüyü 2 saniye bekletir.
    if (!tefal.Isin())
    {
        break;
    }
}

