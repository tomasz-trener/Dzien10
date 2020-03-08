using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WstepORM
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) linq to sql 
            //(2) entity framework
            //(3) nhibernate to rozszerzenie hibernate 

            ModelBazyDataContext db = new ModelBazyDataContext();

            List<Zawodnik> wynik1 = db.Zawodnik.ToList();

           // foreach (var item in wynik1)
             //   Console.WriteLine(item.imie + " " + item.nazwisko + " " + item.kraj);

            //    List<Zawodnik> wynik2 =new ModelBazyDataContext().Zawodnik.Where(x => x.waga > 80).ToList();

            // 1. do wynik3 podaj z bazy danych tylko polaków, posortuj ich wg. wzrostu

            var wynik3 = db.Zawodnik.Where(x => x.kraj == "pol").OrderBy(x => x.wzrost).ToList();

            // 2. podaj najwyzszego niemca

            // var  wynik4 = db.Zawodnik.Where(x => x.kraj == "ger").Max(x => x.wzrost);
            // var wynik4 = db.Zawodnik.Where(x => x.kraj == "ger").OrderByDescending(x => x.wzrost).ToList()[0];
            // var wynik4 = db.Zawodnik.Where(x => x.kraj == "ger").OrderByDescending(x => x.wzrost).FirstOrDefault();
            //  var wynik4 = db.Zawodnik.OrderByDescending(x => x.wzrost).Where(x => x.kraj == "ger").FirstOrDefault();
            var wynik4 = db.Zawodnik.OrderByDescending(x => x.wzrost).FirstOrDefault(x => x.kraj == "ger");

            Console.WriteLine(wynik4.imie + " " + wynik4.nazwisko);


            // 3. podaj unikalne kraje i posortuj alfabetycznie

            var wynik5 = db.Zawodnik.Select(x => x.kraj).Distinct().OrderBy(x => x).ToList();

            // 4. podaj tylko nazwiska zawodników i posortuj wg wzrostu  

            // var wynik6 = db.Zawodnik.Select(x=>x.nazwisko).OrderBy(x=>x.wz)
            var wynik6 = db.Zawodnik.OrderBy(x => x.wzrost).Select(x => x.nazwisko).ToList();

            // 5. wypisz zawodnikow, ktorzy są wyzsi od najwyzszego polaka 

            //   var wynik7a = db.Zawodnik.Where(x => x.kraj == "pol").Max(x => x.wzrost)
            //  var wynik7b = db.Zawodnik.Where(x => x.wzrost > wynik7a).ToList();

            var wynik7 = db.Zawodnik.Where(x => x.wzrost > db.Zawodnik.Where(y => y.kraj == "pol").Max(y => y.wzrost)).ToList();


            var wynik8= db.Zawodnik.GroupBy(x => x.kraj).Select(x => new { MojKraj = x.Key, MojSrWzrost = x.Average(y => y.wzrost) }).ToList();

            foreach (var item in wynik8)
                Console.WriteLine(item.MojKraj + " " + item.MojSrWzrost);

            wynik8.ForEach(x => 
            {
                // ciało tej anonimowej funkcji wykonuję dla kazdego rekordu z wynik 8 
                Console.WriteLine(x.MojKraj + " " + x.MojSrWzrost);
            });

            // 6. podaj ile jest osób z każdego kraju

            db.Zawodnik.GroupBy(x => x.kraj).Select(x => new { Kraj = x.Key, Ile = x.Count() }).ToList();

            //   db.Zawodnik.GroupBy(x=> new { x.kraj, x.nazwisko}).Select(x=>x.Key.)

            var wynik9 = from x in db.Zawodnik
                         where x.kraj == "pol"
                         select new
                         {
                             MojeImie = x.imie,
                             MojeNazwisko = x.nazwisko
                         };

            var wynik10 = (from x in db.Zawodnik
                          where x.kraj == "pol"
                          select x).ToList();

            var wynik11 = db.Zawodnik.Where(x => x.kraj == "pol").Select(x => x).ToList();



        }
    }
}
