namespace _03_OOP_Encapsulation
{
    internal class Product
    {
        // fields
        private int id;
        private string name;
        private int stock;
        private double price;
        private bool status;

        // ctor
        public Product()
        {

        }

        public Product(int id, string name, int stock)
        {
            this.id = id;
            this.name = name;
            this.stock = stock;

            StockControl(stock);
        }

        // Properties
        // Read Only
        public string Id
        {
            get
            {
                return "BLG-" + id;
            }
        }

        public string Name
        {
            get { return name.ToUpper(); }
            private set { name = value; }
        }

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                    //status = stock > 0;
                }
                else
                    throw new Exception("Stok 0 dan küçük olamaz");
            }
        }

        public double Price
        {
            get { return price * 1.2; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new Exception("Fiyat 0 dan küçük olamaz...");
            }
        }

        public bool Status
        {
            get { return status; }
            private set { status = value; }
        }

        // Only write
        public string Description { private get; set; }

        public string GetProduct()
        {
            return $"Ürün No: {Id} Adı: {Name} Fiyat: {price} (Kdv Dahil) Stock: {Stock} Satılabilir mi {Status}";
        }

        public void SellProduct(int quantity)
        {
            Stock = Stock - quantity;

            StockControl(stock);

            Console.WriteLine($"İstenilen Miktar: {quantity} \nBirim Fiyatı: {Price} \nToplam Fiyat: {quantity * Price} \n---------------------\nKalan Stok: {Stock}");
        }

        private void StockControl(int stock)
        {
            status = stock > 0;
        }
    }
}
