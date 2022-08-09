using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Bugra";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demirog";
            kurs1.izlenmeOrani = 68;

            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Eğitmen = "Murat Kurtboğan";
            kurs4.izlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { 
            kurs1, kurs2, kurs3, kurs4
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
                
            }   


           //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }
}