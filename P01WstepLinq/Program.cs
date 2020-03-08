using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 8, 3, 2, 7 };

            int wynik1 = a.Max();
            int wynik2= a.Max(x => x);

            a= a.OrderByDescending(x=>x).ToArray();

            Console.WriteLine(string.Join(" ", a));

            string[] b = new string[] { "ala", "ma", "kota" };

            string[] wynik3 = b.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ",wynik3));


            string[] wynik4 = b.OrderBy(x => x.Length).ToArray();
            Console.WriteLine(string.Join(" ", wynik4));


            List<Czlowiek> osoby = new List<Czlowiek>()
            {
                new Czlowiek() { Imie = "Jan",Nazwisko = "Kowalski", Wiek = 40},
                new Czlowiek() { Imie = "Adam",Nazwisko = "Nowak", Wiek = 30},
                new Czlowiek() { Imie = "Ala",Nazwisko = "Nowakowska", Wiek = 50},
            };

            List<Czlowiek> wynik5 = osoby.OrderBy(x => x.Imie).ThenBy(x => x.Wiek).ToList();

            foreach (var item in wynik5)
                Console.WriteLine(item.Imie + " " + item.Nazwisko + " " + item.Wiek);

            var wynik6 = osoby.Where(x => x.Imie.Length > 3).ToList();

            var liczba = 6;

            dynamic typDynamiczny = 7;
            typDynamiczny = "x";

            List<string> wynik7 = osoby.Select(x => x.Imie).ToList();

            List<string> wynik8 = osoby.Select(x => x.Imie + " " + x.Wiek).ToList();


            List<CzlowiekMini> wynik9 = osoby.Select(x => new CzlowiekMini() { Imie = x.Imie, Wiek = x.Wiek }).ToList();

            var wynik10=  osoby.Select(x => new { MojeImie = x.Imie, MojWiek = x.Wiek }).ToList();

            int c = wynik10[0].MojWiek;
            for (int i = 0; i < wynik10.Count(); i++)
            {
                Console.WriteLine(wynik10[i].MojeImie);
            }




            Console.ReadKey();
        }
    }
}
