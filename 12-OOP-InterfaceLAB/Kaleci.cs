
namespace _12_OOP_InterfaceLAB
{
    internal class Kaleci : IFutbolcu, IKaleci
    {
        public string AdiSoyadi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FormaNumarasi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SutGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PasGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KosmaHizi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SakatMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Degaj { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void PasVer()
        {
            Console.WriteLine("Kaleci pas veriyor");
        }

        public void SutCek()
        {
            Console.WriteLine("Kaleci şut çekiyor");
        }

        public void TopKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
