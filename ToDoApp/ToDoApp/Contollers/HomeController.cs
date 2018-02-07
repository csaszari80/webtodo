using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Contollers
{
    //Ez az home vezérlője ha nincs megadva más akkor ez lesz meghívva(ez a standard név)
    public class HomeController : Controller
    {
        //biztosítjuk az adatbázishozzáférést a vezérlőnek
        TodoAppContext db = new TodoAppContext();
        // GET: Index
        //Ez ez pedig a view-t hívja
        //A teljes cím: http://locsalhost:port/Home/index ebbőlaz Home az HomeControllert jelenti a index pedig ezt a függvényt hívja ami megjeleníti a viewt ha nincs máés függvény akkor a standard szerint ez lesz meghívva
        public ActionResult Index()
        {
            var bevasarlolista = db.Feladatok.ToList();
            
           
            

            //Az előállított adatokat (a modelt) átadjuk a nézetnek
            return View(bevasarlolista);
        }
        
        /// <summary>
        /// Ez a függvény fogja kezelni az Add action-t.
        /// Ezt get kérés fogja keresni (A főoldalon lévő link)
        /// Ahhoz hogy ne dobjon fel hibát hozzá kell adni egy Add nevű viewt
        /// </summary>
        /// <returns></returns>
        [HttpGet] //így most már csak get kérésre reagál (annotáltuk)
        public ActionResult Add()
        {
           
            // model létrehozása és kiküldése a felületre
            var model = new Feladat();
            return View(model);
        }
        /// <summary>
        /// Ez a függvényváltozat fogja kezelni az Add actiont akkor ha az űrlapról van meghivatkozva,
        /// a paraméterként megadott változókat automatikusan keresni fogja querystringben(get) és a form data-ban(post) is.
        /// - Ellenőrzi és rögzíti a felhasználó által bevitt adatokat.
        /// - Ezután átirányít az Indexre
        /// </summary>
        /// <param name="Megnevezes"></param>
        /// <returns></returns>
        [HttpPost] // ez csak post kérésekre reagál
        public ActionResult Add(Feladat feladat)
        {
            //todo: perzisztens adattárolás
            //adatok validálása
            if (!ModelState.IsValid)  
            {
                //ha az adatok nincsenek rendben vissza kell küldeni őket módosításra
                return View(feladat);
            }

            //Ha az adatok rendben vannak új elem felvitele
            //bevasarlolista.Add(new Feladat { Megnevezes = "Marhahusika", Elvegezve = false });
            db.Feladatok.Add(feladat);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}