using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoApp.Contollers
{
    //Ez az home vezérlője ha nincs megadva más akkor ez lesz meghívva(ez a standard név)
    public class HomeController : Controller
    {
        // GET: Index
        //Ez ez pedig a view-t hívja
        //A teljes cím: http://locsalhost:port/Home/index ebbőlaz Home az HomeControllert jelenti a index pedig ezt a függvényt hívja ami megjeleníti a viewt ha nincs máés függvény akkor a standard szerint ez lesz meghívva
        public ActionResult Index()
        {
            var bevasarlolista = new List<string>();
            bevasarlolista.Add("Hagyma");
            bevasarlolista.Add("Pirospaprika");
            bevasarlolista.Add("Olaj");
            bevasarlolista.Add("Marhahusika");

            
            //Az előállított adatokat (a modelt) átadjuk a nézetnek
            return View(bevasarlolista);
        }
    }
}