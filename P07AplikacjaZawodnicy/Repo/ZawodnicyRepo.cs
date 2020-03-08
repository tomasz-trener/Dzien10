using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P07AplikacjaZawodnicy.Repo
{
    public class ZawodnicyRepo
    {
        public Zawodnik[] PodajZawodnikow()
        {
            return new modelBazyDataContext().Zawodnik.ToArray();
        }

        public Zawodnik[] PodajZawodnikow(string kraj)
        {
            return new modelBazyDataContext().
                Zawodnik.Where(x=>x.kraj.Contains(kraj)).
                ToArray();
        }
    }
}