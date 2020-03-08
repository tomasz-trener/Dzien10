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

            foreach (var item in wynik1)
                Console.WriteLine(item.imie + " " + item.nazwisko + " " + item.kraj);

        //    List<Zawodnik> wynik2 =new ModelBazyDataContext().Zawodnik.Where(x => x.waga > 80).ToList();

            // 1. do wynik3 podaj z bazy danych tylko polaków, posortuj ich wg. wzrostu

            // 2. podaj najwyzszego niemca

            // 3. podaj unikalne kraje i posortuj alfabetycznie

            // 4. podaj tylko nazwiska zawodników i posortuj wg wzrostu 
             




            Console.ReadKey();

        }
    }
}
