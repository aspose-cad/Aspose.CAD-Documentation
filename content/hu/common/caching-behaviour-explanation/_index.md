---
title: Az Aspose.CAD gyorsítótárazási viselkedésének magyarázata
type: docs
weight: 20
url: /hu/common/caching-behaviour-explanation/
---

## **Hogyan tárolja az Aspose.CAD az adatokat** 

Az Aspose.CAD által végzett összes gyorsítótárazás teljesen automatikus, felhasználói input nélkül, és nincs szükség felhasználói beavatkozásra. Alapvetően háromféle gyorsítótárazás van, mindhárom a betűtípusokhoz kapcsolódik.

### **Betűtípus név gyorsítótár** 

A betűtípus név gyorsítótár gyorsabb indítást segíti elő az összes megtalált betűtípus fájl előfeldolgozásával és az ezekben a fájlokban található betűtípusok neveinek listájának összeállításával, mivel egy betűtípus fájl több betűtípust is tartalmazhat. Ideiglenes fájlként tárolják, és a legtöbb rendszeren legfeljebb néhány tíz kilobyte méretű.

### **Betűtípus glyph adatok gyorsítótár** 

Egy memóriában található gyorsítótár, amely tartalmazza az összes glykóz adatot, amit az alkalmazás élettartama alatt használtak, csökkentve az aktuális, lemezen található betűtípus fájlok újbóli olvasásának szükségességét a későbbi exportálások során. Ennek megfelelően folyamatosan növekvő memóriafogyasztáshoz vezetne, ha a későbbi exportok új betűtípusokra hivatkozó fájlokat tartalmaznak és/vagy olyan karaktereket tartalmaznak, amelyeket korábban nem találkoztunk. Azonban a gyakorlatban, még az egész Aspose.CAD tesztcsomagban, amely több ezer fájlt tartalmaz, köztük más nyelveken írt fájlokat is, a memóriafogyasztás körülbelül 200 megabyte, ami nem jelentős egy modern rendszer számára.

### **Karakterenkénti betűtípus visszaesési gyorsítótár** 

Egy memóriában található gyorsítótár, amely tárolja azokat a betűtípusokat, amelyek tartalmaznak egy adott karaktert az összes Unicode karakter esetében, hogy megkönnyítse a helyettesítő betűtípus kiválasztását abban az esetben, ha a rajzban egy szöveges entitás által megadott betűtípus nem tartalmazza a karaktert az entitás szövegtartalmában. Az első exportálási művelet során épül fel az alkalmazás élettartama alatt, és az alkalmazás leállításáig ott marad. Viszonylag szerény tesztgépeinken, ahol hatalmas betűtípus-gyűjteményeket használnak a tesztcsomagokban, a gyorsítótár felépítése körülbelül 30 másodpercet vesz igénybe és 70 megabyte-ot foglal el. Miután felépült, már nem vesz igénybe időt és nem növekszik.
