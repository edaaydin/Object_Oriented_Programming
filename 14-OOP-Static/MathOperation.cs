namespace _14_OOP_Static
{
    // static anahtar kelimesi, bir elemanın (alan, özellik veya metot) bağlı olduğu bir örneği (nesne) olmadan kullanılabilir. ve üretilen tüm nesneler bu elemanın değerine bağlı olur.
    internal class MathOperation
    {
        public double Area(int r)
        {
            return Pi * r * r;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Pi;
    }
}