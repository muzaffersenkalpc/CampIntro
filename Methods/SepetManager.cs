using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Congratulation. Product Added! : " + product.Name);
        }

        public void Ekle2(string productName, string comment, double price, int piece)
        {
            Console.WriteLine("Congrat. Product Added : "+ productName);

        }
    }
}
