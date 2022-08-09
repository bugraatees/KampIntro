using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugün = 7.45;

            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }
            
            else if (dolarDun<dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
          
            



        }

    }
}
