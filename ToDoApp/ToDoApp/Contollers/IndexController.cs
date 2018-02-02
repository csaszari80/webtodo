using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoApp.Contollers
{
    public class IndexController : Controller
    {
        // GET: Index
        //Ez az Index vezérlője
        public ActionResult Index()
        {
            var bevasarlolista = new List<string>();
            bevasarlolista.Add("Hagyma");
            bevasarlolista.Add("Pirospaprika");
            bevasarlolista.Add("Olaj");
            bevasarlolista.Add("Marhahusika");

            // a nézeten lévő adatok speciális elnevezésű asszociatív tömmbben melynek egyenlőre csak egy bevásárlólista nevű eleme lesz ami a bevásárlólistát tartalmazza
            ViewData["bevasarlolista"] = bevasarlolista;
            return View();
        }
    }
}