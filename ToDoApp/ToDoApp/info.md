﻿# Webes TODO alkalmazás készítése
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
    - C# alapok
    - C# nagyoknak
    - Bootstrap tanfolyam
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

## Alkalmazás váza:
- A lista oldalon a következő lehetőségek vannak
- Új elem felvitele
- Meglévő elem törlése
- Meglévő elem elvégzésének jelzése
- Az egyes lehetőségek linkek segítségével elérhetők, ha egy linkre kattintunk akkor az adott feladattal kapcsolatos oldalra kerülünk.
Az általános adatbeviteli megoldás ASP.NET MVC alkalmazásoknál: Két Action és hozáájuk 1 db view
- Az adatbevitelhez szükséges képernyőt egy Action szolgáltatja ami a get kérésekre reagál
- Az adat feldolgozást egy ugyanolyan nevű de csak post kérésekre reagáló action kezeli
## Adatok validálása
Követeljük meg, hogy a feladat megnevezése ne lehessen üres
Ehhez az ASP.NET beépített szolgáltatásait használjuk
- Az adatmodelben annotációval tudjuk a feltételeket megadni microsoft oldalán van hozzá [doksi](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-6)
- Az adatmodellben property-t kell használni
- így a model köré tudjuk építeni a nézetünket **(pl: @Html.TextBoxFor(m => m.Megnevezes), @Html.LabelFor(m => m.Megnevezes))**
- a modellt ár rudjuk venni a POSt-ra váró Action paraméterlistájában
- a modell állapotát ellenőrizni tudjuk az Action-ben **(ModelState.IsValid)**
- ha nem jók az adatok akkor vissza tudjuk küldeni a felhasználónak egy return view(model) sorral
- A validációs üzeneteket ki tudjuk íratni **(pl:  @Html.ValidationSummary() , @Html.ValidationMessageFor(m=>m.Megnevezes))**

## Adatok perzisztens tárolása
MS SQL Server Express-t telepítünk hozzá
A Solution hoz telepíteni kell a EntityFrameWork Nuget package-t
### Adatbáziskezelés EntityFramework Code First segítségével
  #### Megközelítések
- Data First
- Model First
- Code First

Ha nem adunk meg neki semilyen egyéb paramétert akkor a helyi gépen fogja létrehozni a context osztály teljes(névtérrel kiegészített nevével)
- vagy a "default instance-on"
- vagy a sqlexpress nevű szerveren
- vagy localdb-ként

## Nézetek generálása layout-al
- előszőr lefut a _ViewStart.cshtml ami beállítja az alapértelmezett layoutot (_Layout.cshtml)
- akárhány layout-ot használhatunk a nézet elején beállíthatjuk, vagy letilthatjuk Layout=Null
- a nézetben generált html kód a layoutban lévő @RenderBody() helyen fog megjelenni

### [Bootstrap](http://getbootstrap.com)


## Hibaelhárítás
Amennyiben gép újratelepítés után nem indul el a webalkalmazás (pontosabban az iis express nem indul el) akkor a projekt .sln fájlját tartalmazó mappában lévő rejtett vs mappában lévő config mappában (solutionmappa\.vs\config) **applicationhost.config** fájlt kell törölni majd újraindítani a visual studiót




