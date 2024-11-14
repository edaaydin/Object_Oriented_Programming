namespace _12_OOP_InterfaceLAB
{
    internal interface IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public int SutGucu { get; set; }
        public int PasGucu { get; set; }
        public int KosmaHizi { get; set; }
        public bool SakatMi { get; set; }
        void Kos();
        void SutCek();
        void PasVer();
    }
}
