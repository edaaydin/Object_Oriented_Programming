using _12_OOP_InterfaceLAB;

Futbolcu defans = new Futbolcu()
{
    AdiSoyadi = "Sabri Sarıoğlu",
    FormaNumarasi = "55",
    KosmaHizi = 80,
    PasGucu = 60,
    SutGucu = 70,
    SakatMi = true
};

Kaleci kaleci = new Kaleci();


Futbolcu forvet = new Futbolcu();


List<IFutbolcu> takim = new List<IFutbolcu>();
takim.Add(forvet);
takim.Add(defans);
takim.Add(kaleci);


foreach (IFutbolcu oyuncu in takim)
{
    oyuncu.PasVer();
    oyuncu.SutCek();
}
