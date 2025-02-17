---
title: Licencelés
type: docs
weight: 50
url: /hu/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Miután elégedett vagy az Aspose.CAD .NET értékelésével, vásárolj licencet az Aspose weboldalán: [Vásárlási Portál](https://purchase.aspose.com/buy). Ismerkedj meg a különböző licencetípusokkal, amelyek elérhetők. Ha bármilyen kérdésed van, [lépj kapcsolatba az Aspose értékesítési csapatával](https://about.aspose.com/contact), és ők szívesen segítenek neked.

Minden Aspose licenc egyéves előfizetést tartalmaz, amely ingyenes frissítéseket biztosít bármely új verzióra vagy javításra, amely ezen időszak alatt megjelenik. Ingyenes és korlátlan technikai támogatást nyújtunk mind a licencelt, mind az értékelési felhasználóknak.

A licencek egy sima szövegű XML fájl, amely olyan részleteket tartalmaz, mint a termék neve, a licencelt fejlesztők száma, az előfizetés lejárati dátuma és így tovább. A fájl digitálisan aláírt, ezért ne módosítsd a fájlt: még egy extra sortörés hozzáadása is érvényteleníti azt.

{{% /alert %}}

## **Mikor alkalmazzunk licencet**

Kövesd ezeket az egyszerű szabályokat:

- A licencet csak egyszer kell beállítani alkalmazás domainenként.
- A licencet az Aspose.CAD osztályok használata előtt kell beállítani.
- A SetLicense többszöri hívása nem káros, de pazarolja a processzort.
- Ha Windows Forms vagy konzolos alkalmazást fejlesztesz, hívd meg a SetLicense-t az induló kódban, az Aspose.CAD osztályok használata előtt.
- ASP.NET alkalmazás fejlesztésekor hívd meg a SetLicense-t a Global.asax.cs (Global.asax.vb) fájlban, az Application_Start védett metóduson belül. Ezt egyszer hívják meg, amikor az alkalmazás elindul.
- Ne hívd meg a SetLicense-t a Page_Load metódusokból, mivel ez azt jelenti, hogy a licencek minden alkalommal betöltődnek, amikor egy weboldal betöltődik.
- Ha osztálykönyvtárat fejlesztesz, a SetLicense-t az Aspose.CAD-t használó osztály statikus konstruktorából kell meghívni. A statikus konstruktor a példány létrehozása előtt hajtódik végre, biztosítva, hogy az Aspose.CAD licenc megfelelően legyen beállítva.

## **Licenc alkalmazása fájl vagy stream objektum használatával**

Használja a **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** metódust a komponens licencelésére. A legegyszerűbb módja a licenc beállításának, ha a licenct fájlt ugyanabba a mappába helyezi, mint az Aspose.CAD.dll, és így adja meg a fájlnevet, útvonal nélkül, ahogy az alábbiakban látható.

### **Licenc betöltése fájlból**

Ez a kódrészlet inicializálja a fájlban vagy beágyazott erőforrásban tárolt licencet.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Licenc betöltése stream objektumból**

Ez a kódrészlet inicializálja a licencet stream alapján.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
