using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product product1 = new Product();

            product1.Name = "Elma";
            product1.Price = 15;
            product1.Comment = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Comment = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Comment);
                Console.WriteLine( product.Price);
                Console.WriteLine("--------------");

            }
            Console.WriteLine("---------Methods---------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Ekle2("Armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice
