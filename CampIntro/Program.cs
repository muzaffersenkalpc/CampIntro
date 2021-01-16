using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.55;
            double dolarBugün = 7.55;
            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }
            bool SistemeGirisYapmisMi = true;

            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Basarılı bir sekilde giriş yapıldı.");
            }
            else
            {
                Console.WriteLine("Giriş yapılmadı!");
            }

            Console.WriteLine(kategoriEtiketi);

           
        }
    }
}
