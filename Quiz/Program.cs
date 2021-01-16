using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "Laptop";
            product1.piece = 15;
            product1.price = 666;

            Product product2 = new Product();
            product2.name = "Keyboard";
            product2.piece = 150;
            product2.price = 6;

            Product product3 = new Product();
            product3.name = "Mouse";
            product3.piece = 15;
            product3.price = 66;

            //Console.WriteLine(product1.name + " " + product1.piece + " " + product1.price);

            Product[] products = new Product[] {product1,product2,product3};
            foreach (var product in products)   //Foreach
            {
                Console.WriteLine(product.name + " " + product.piece + " " + product.price );
            }

            //-------------------------------------------------------------- /for

            for(int i =0; i<products.Length; i++)
            {
                Console.WriteLine(products[i].name + " " + products[i].piece + " " + products[i].price);
            }
            //------------------------------------------ /while
            int a = 0;
            while(a < products.Length)
            {
                Console.WriteLine(products[a].name + " " + products[a].piece + " " + products[a].price);
                a++;
            }
        }
    }
    class Product
    {
        public string name { get; set; }
        public int piece { get; set; }
        public int price { get; set; }
    }
}
