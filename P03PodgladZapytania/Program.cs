using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PodgladZapytania
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();

            var wynik = db.Zawodnik.Where(x => x.kraj == "pol").OrderBy(x => x.wzrost).ToList();

            Console.Read();
        }
    }
}
