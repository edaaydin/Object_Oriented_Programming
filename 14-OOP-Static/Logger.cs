namespace _14_OOP_Static
{
    internal static class Logger
    {
        // static class
        // Eğer nesneye bağımlı işlemler gerçekleştirmiyorsanız. Amaç ssadece belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplamak ise static sınıf tercih edilebilir. Instance almadan tüm öğeleri kullanabilir.

        // static sınıflar içersinde sadece static üyeler barındırıabilirler.
        // Kalıtım alamaz.

        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
