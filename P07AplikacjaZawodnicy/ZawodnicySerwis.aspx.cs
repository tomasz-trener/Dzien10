using P07AplikacjaZawodnicy.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P07AplikacjaZawodnicy
{
    public partial class ZawodnicySerwis : System.Web.UI.Page
    {
        public Zawodnik[] zawodnicy;

        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepo zr = new ZawodnicyRepo();

            string kraj = Request["kraj"];
            if (kraj == null)
            {
                zawodnicy = zr.PodajZawodnikow();
            }
            else
            {
                zawodnicy = zr.PodajZawodnikow(kraj);
            }


           
           


        }
    }
}