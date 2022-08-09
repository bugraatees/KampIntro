using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java Kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);



            string[] kurslar = new string[]
            {
                "Yazılım Geliş  tirme Kampı" , "Programlamaya Başlangıç için Temel Kurs", "Java Kursu" ,"Python"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine("Kursunuz : " + kurslar[i]);
            }

            Console.WriteLine("For bitti..");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            

            Console.WriteLine("Sayfa sonu - footer");



        }
    }
}