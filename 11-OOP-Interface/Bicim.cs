
namespace _11_OOP_Interface
{
    internal class Bicim : IBicim
    {
        private int numaram;

        public int Numaram
        {
            get { return numaram; }
            set { numaram = value; }
        }

        public void InterfaceMetot()
        {

            Console.WriteLine("Numara: {0}", numaram);
        }
    }
}
