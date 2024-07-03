using System.Reflection.Emit;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "c#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Python";
            kurs2.egitmen = "Rıfat Yusuf Altun";
            kurs2.izlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.egitmen = "Enes";
            kurs3.izlenmeOrani = 98;

            //Console.WriteLine(kurs1.egitmen + " " + kurs1.kursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }

        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }
}
