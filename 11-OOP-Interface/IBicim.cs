namespace _11_OOP_Interface
{
    // Interface (arayüz): Bir alt sınıf bir interface'i miras aldığında bu interface uygulanmak zorundadır. Interface bir sözleşmenin madderli gibi düşünülebilir. Kalıtım alan taraf bu sözleşmenin tüm madderlini uygulamak zorundadır.

    // Bir sınıf birden fazla interface'den kalıtım alabilir.

    // struct, class, enum, interface : namespace'in içinde
    // Public, internal, protected, private : Class'ta yada üyelerinde
    // static class, abstract class, sealed class, partial class
    internal interface IBicim
    {
        public int Numaram { get; set; }
        void InterfaceMetot();

        internal void foo()
        {
            Console.WriteLine("Hello");
        }
    }
}
