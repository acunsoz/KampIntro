using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Alihan";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.egitmeni = "Kerem";
            kurs1.IzlenmeOrani = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.egitmeni = "Berkay";
            kurs2.IzlenmeOrani = 63;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.egitmeni = "Engin";
            kurs3.IzlenmeOrani = 65;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.egitmeni = "Murat";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.egitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.egitmeni);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }

    }
}
