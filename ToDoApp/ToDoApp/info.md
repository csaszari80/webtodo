# Webes TODO alkalmazás készítése
- Markdown állományok fogalma 
  - [Dokumentáció](https://guides.github.com/features/mastering-markdown/)
  - #;##;### a különböző szintű címek megjelenítése
  - -a felsorolásjelejókhez
  - [szöveg](link) a linkekhez
  - ``` 
    A beírt szövegek feldolgozás nélküli megjelenítéséhez(pl ascii ábrák)
    ```

- webes fejlesztés fogalma
  - ajánlott tanfolyamok: 
    - lenyűgöző weblapok készítése
    - asp.net core
    - étterem projekt
    - snake projekt
  - Minimum weblap testHTML.html
  - http protokoll (wikipédia) 
    - Négy eszköz: kérés, tartalom, fejléc, végállapot
    - A böngészőkben meg lehet nézni az oldal forrását
    - Böngészők fejlesztő eszköztárában meg lehet tekinteni ahálózati forgalmat is:
      - módja alegtöbb böngészőben: F12 (Networkfül, majd Oldalfrissítés)
- MVC(Model-View-Controller) alkalmazás fejlesztés 
  - a fejlesztő környezet három fontos szereplőt különböztet meg:
    - vezérlő (Controller): Minden kérés hozzá érkezik a feladata a kérés kiszolgálása vagy a kiszolgáláshoz szükséges feladatok delegálása, a feladatok elvégzésével a végeredmény továbbítása a kérő felé.
    - adatok (Model): adatok köre, létrehozása, kiszámolása, előállítása, transzformációja a kész adatok szolgáltatása a másik két szereplőnek
    - Megjelenítés (View): feladata a kinézethez szükséges elemek meghatározása, előáállítása módosítása (jelen esetben html a forma)
  - ASP.Net MVC: névkonvenció alapú a könyvtárak és állományok nevei egy előre meghatározott konvenciót követnek, a működésük ebből következik
    - Controler létrehozása (Contorllers Mappa létrehozása | Add Controller | HomeController)
    - Nézet létrehozása (adatokat most még nem használunk) (View mappában lévő home (ez a contorller neve) mappában hozzuk létre index.cshtml néven)
- Egy megjelenítő oldal készítése
- Specifikáció
- A Model bevezetése
  - szükségünk van egy felsorolásra amit a programunk valahol előállít
  - az adatokat át kell adni a nézetnek
  - az adatokat a nézet megfelelő helyén megjelenítjük
 ## Alkalmazás futtatása
### IIS
- ha élesben akarjuk használni akkor kell egy szerver amin fut
- fejlesztéshez a Visual Studio automatikusan telepíti a Visual Studio Express-t

4.video 36 perc