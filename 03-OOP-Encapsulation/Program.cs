using _03_OOP_Encapsulation;

//Product product1 = new Product();
////product1.Id = "1";
////product1.Name = "Kalem"; // set private
//product1.Description = "Kurşun Kalem";
//product1.Price = 101;

//Console.WriteLine(product1.Description);
//Console.WriteLine(product1.GetProduct());

Product product2 = new Product(35, "Kalem Kırmızı", 10);
product2.Description = "Kurşun Kalem Kırmızı";
product2.Price = 110;

//Ürünler Listesi
List<Product> products = new List<Product>();
//products.Add(product1);
products.Add(product2);

int num = 0;
foreach (Product item in products)
{
    Console.WriteLine($"No:{num} Adı: {item.Name} Fiyat: {item.Price}");

    num++;
}

Console.WriteLine("Satın almak istediğiniz ürünün numarasını giriniz.");
int order = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Alacağın Ürün: ");
Console.WriteLine(products[order].GetProduct());

Console.WriteLine("Kaç adet almak istiyorsunuz:");

int quantity = Convert.ToInt32(Console.ReadLine());

products[order].SellProduct(quantity);
Console.WriteLine("Ürünün Son Durumu: ");
Console.WriteLine(products[order].GetProduct());

