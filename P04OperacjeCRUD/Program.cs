using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04OperacjeCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            // insert 

            //Zawodnik z = new Zawodnik();
            //z.imie = "jan";
            //z.nazwisko = "kowalski";
            //z.wzrost = 170;
            //ModelBazyDataContext db = new ModelBazyDataContext();
            //db.Zawodnik.InsertOnSubmit(z);
            // db.SubmitChanges();


            // update : najpierw trzeba pobrać z bazy tego kogo chcemy updateowac a potem go zmienić i zapisać zmiany 

            //ModelBazyDataContext db = new ModelBazyDataContext();
            //var z = db.Zawodnik.FirstOrDefault(x => x.nazwisko == "kowalski");
            //z.imie = "Adam";
            //z.wzrost = z.wzrost + 10;
            //db.SubmitChanges();


            // delete: najpierw trzeba pobrać z bazy tego którego checmy  usunać a potem go usunąć 

            ModelBazyDataContext db = new ModelBazyDataContext();
            var z = db.Zawodnik.FirstOrDefault(x => x.nazwisko == "kowalski");
            db.Zawodnik.DeleteOnSubmit(z);
            db.SubmitChanges();


        }
    }
}
