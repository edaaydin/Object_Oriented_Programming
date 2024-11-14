namespace _12_OOP_InterfaceLAB
{
    internal class Futbolcu : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public int SutGucu { get; set; }
        public int PasGucu { get; set; }
        public int KosmaHizi { get; set; }
        public bool SakatMi { get; set; }

        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void PasVer()
        {
            Console.WriteLine("Futbolcu pas veriyor");
        }

        public void SutCek()
        {
            if (SutGucu > 70)
                Console.WriteLine("Gol Olur");
            else
                Console.WriteLine("Taç olur");
        }
    }
}
