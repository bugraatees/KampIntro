using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiyafet kiyafet1 = new Kiyafet();
            kiyafet1.kiyafetAdi = "T-shirt";
            kiyafet1.cins = "Yakalı";
            kiyafet1.renk = "Yeşil";

            Kiyafet kiyafet2 = new Kiyafet();
            kiyafet2.kiyafetAdi = "Kazak";
            kiyafet2.cins = "Boğazlı";
            kiyafet2.renk = "Siyah";

            Kiyafet[] kiyafetler = new Kiyafet[]
            {
            kiyafet1 , kiyafet2
            };
            foreach (var kiyafets in kiyafetler)
            {
                Console.WriteLine(kiyafets.kiyafetAdi + " - " + kiyafets.cins + " - " + kiyafets.renk);
            }
        }
    }
    class Kiyafet
    {
        public string kiyafetAdi { get; set; }
        public string cins { get; set; }
        public string renk { get; set; }
    }
}

