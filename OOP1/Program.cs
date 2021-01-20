using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, Ue = 35, ProductName = "Kalem" nitsInStock = 5, UnitPric };


            //PascalCase     //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product2);

            //int,double,bool.... değer tip
            //diziler,class abstract class, interface.... referans tip.
        }
    }
}
