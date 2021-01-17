using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = " Yazılım icin gelistirici";
            string kurs2 = "Programlamaya baslangıc";
            string kurs3 = "Java";


            string[] kurslar = new string[] { "Yazılım icin gelistirici", "Programlamaya baslangıc",
                "Java","python","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for biiti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu");
        }
    }
}
