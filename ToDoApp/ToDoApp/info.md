# Webes TODO alkalmazás készítése
- Markdown állományok fogalma 
  - [Dokumentáció](https://guides.github.com/features/mastering-markdown/)
  - #;##;### a különböző szintű címek megjelenítése
  - -a felsorolásjelejókhez
  - [szöveg](link) a linkekhez
  - *kiemelések* is **vannak** *-karakterek közé írjuk a szöveget
  - ``` 
    A beírt szövegek feldolgozás nélküli megjelenítéséhez(pl ascii ábrák)
    ```
  - kép bevitele: linkként kell bevinni a cím helyére a relatív útvonalat(az .md-hez képest) kell beírni

- webes tervezéshez(képernyőképek) ajánlott mockflow.com (ingyenes regisztráció)
- webes fejlesztés fogalma
  - ajánlott tanfolyamok: 
    - lenyűgöző weblapok készítése
    - asp.net core
    - étterem projekt
    - snake projekt
    - MVC tervminta
    - HTML és CSS, HTML alapozó
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
## Adatok szállítása a felhasználótól az alkalmazásig
- Az adatokat a kérébe kell befoglalni
- az adatbevitelhez űrlapot fogunk használni
  - Ha a form-ot alapértelmezett actionnel, és get metódussal (querystring-en) keresztül adjuk át az felvet problémákat
    - ugyanarra az actionra megy a kérés mint az előző
      - A form actionjába egy elérési utat kell megadni controller/action/id formátumban
      - Az Actionhoz a contorllerben kell egy függvénynek kell tartoznia
      - 
    - webes konvenció, hogy a get típusú kérése ne változtasson adatot a szerveren.
      - post metódust használunk a formban(az adatok a Form Data -n keresztül kerülnek átadásra)
      - az action függvény paraméterén keresztül vesszük át form paramétert (model binding)
  - Meg kell oldani, hogy a bevitt adatok megőrződjenek a szerveren



