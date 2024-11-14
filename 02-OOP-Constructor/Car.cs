namespace _02_OOP_Constructor
{
    internal class Car
    {
        // constructor (yapıcı metot), bir sınıfın instance'nın  alındığı anda çalışacak metot.
        // Main metoda benzetilir. Genellikle bir sınıfın özellikleri/alanlarını nesne oluşturma esnasında çalıştırmak için kullanılır. 

        // Default constructor eğer bir değişiklik yapılmayacaksa kullnılır. kodun içinde görmesekte orada vardır.

        public Car()
        {
            Brand = "Mercedes";
        }

        public Car(string brand)
        {
            Brand = brand;
        }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model, int engine)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
        }


        public string Brand
        {

            get
            {
                if (Brand == "BMW")
                    return Brand.ToLower();
                else
                    return Brand.ToUpper();

            }

            set { Brand = value.ToUpper(); }
        }

        public string Model { get; set; }

        public int Engine { get; set; }

    }
}
