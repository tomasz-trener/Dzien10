using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05LaczenieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();

            //db.Zawodnik
            //    .Select(x =>
            //        new
            //        {
            //            NazwiskoZawodnika = x.nazwisko,
            //            NazwiskoTrenera = db.Trener.FirstOrDefault(y => y.id_trenera == x.id_trenera).nazwisko_t
            //        }).ToList()
            //        .ForEach(x => { Console.WriteLine(x.NazwiskoZawodnika  + " " + x.NazwiskoTrenera); });

            //  db.Zawodnik.Select(x => new { NazwiskoZawodnika = x.nazwisko, NazwiskoTrenera = x.Trener.nazwisko_t }).ToList()
            //      .ForEach(x => { Console.WriteLine(x.NazwiskoZawodnika + " " + x.NazwiskoTrenera); });

            // lazy loading 
            //  Zawodnik z = db.Zawodnik.FirstOrDefault(x => x.nazwisko == "małysz");
            //  Console.WriteLine(z.Trener.nazwisko_t);

            var wszyscy = // na razie tylko ci najwyzszy
                db.Zawodnik.Where(x => x.wzrost == db.Zawodnik.Where(y => y.kraj == x.kraj).Max(y => y.wzrost))
                .Select(x => new { Imie = x.imie, Nazwisko = x.nazwisko, StylWyswietlania = "bold" })
                .ToList();
            
            var reszta = db.Zawodnik.Where(x => x.wzrost != db.Zawodnik.Where(y => y.kraj == x.kraj).Max(y => y.wzrost))
                .Select(x => new { Imie = x.imie, Nazwisko = x.nazwisko, StylWyswietlania = "normal" })
                .ToList();

            wszyscy.AddRange(reszta); // ci najwyzszy + reszta 


            Console.ReadKey();
        }
    }
}
