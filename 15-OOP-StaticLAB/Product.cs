
namespace _15_OOP_StaticLAB
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            ProductID = GenerateProductId();
            //TotalProductsInInventory++;
        }

        private int GenerateProductId()
        {
            return TotalProductsInInventory++;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public static int TotalProductsInInventory { get; set; } = 1;

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Id: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine("");
        }
    }
}
