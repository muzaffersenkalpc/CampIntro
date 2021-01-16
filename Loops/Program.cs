using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "XX başlangıç düzel geliştirme";
            string kurs3 = "Herhangi bir kurs.";
            //array - dizi

            string[] kurslar = new string[]
            {
                "Yazılım geliştirici yetiştirme kampı","XX başlangıç düzel geliştirme","Herhangi bir kurs."
            };

            for(int i=0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            };
            Console.WriteLine("For Bitti\n");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("sayfa sonu - footer");

            

            /*for(int i =1; i<10; i++)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
