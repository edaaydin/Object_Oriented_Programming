namespace _15_OOP_StaticLAB
{
    public static class InventoryManager
    {
        //public static InventoryManager(){} static bir sınıfın constructor'ı olmaz, çünkü instance'ı alınamaz.

        static InventoryManager()
        {
            Console.WriteLine("Deneme");
        }

        public static List<Product> products = new List<Product>();

        public static void AppProduct(Product product)
        {
            products.Add(product);
        }

        public static void DisplayInventory()
        {
            Console.WriteLine("Inventory: ");
            foreach (Product product in products)
            {
                product.DisplayProductInfo();
            }
        }
    }
}
