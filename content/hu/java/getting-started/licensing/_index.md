---
title: Licencelés
type: docs
weight: 50
url: /hu/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Letöltheted az **Aspose.CAD** Java verziójának értékelő változatát [a letöltési oldalukról](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). Az értékelő verzió pontosan ugyanazokat a funkciókat biztosít, mint a termék licencelt verziója. Továbbá, az értékelő verzió egyszerűen licencelté válik, amikor megvásárolsz egy licencet és hozzáadsz pár sort a kódhoz a licenc alkalmazásához.

Ha elégedett vagy az **Aspose.CAD** értékelésével, akkor [licencet vásárolhatsz](https://purchase.aspose.com/buy) az Aspose weboldalán. Ismerkedj meg a különböző előfizetési típusokkal, amelyeket kínálnak. Ha bármilyen kérdésed van, ne habozz kapcsolatba lépni az Aspose értékesítési csapatával.

Minden Aspose licenc egyéves előfizetést tartalmaz az új verziókra vagy javításokra vonatkozó ingyenes frissítésekhez, amelyek a megadott idő alatt jelennek meg. A technikai támogatás ingyenes és korlátlan, mind a licencelt, mind az értékelő felhasználók számára biztosítva van.

{{% /alert %}}

Ha tesztelni szeretnéd az **Aspose.CAD**-ot értékelő verzió korlátozások nélkül, kérj egy 30 napos ideiglenes licencet. További információkért lásd [Hogyan szerezhetek ideiglenes licencet?](https://purchase.aspose.com/temporary-license).

## **Licenc beállítása**

A licenc egy sima szöveg XML fájl, amely tartalmazza az olyan részleteket, mint a termék neve, a licencelt fejlesztők száma, az előfizetés lejárati dátuma stb. A fájl digitálisan alá van írva, ezért ne módosítsd a fájlt; még egy véletlenül hozzáadott extra sortörés a fájlban is érvénytelenné teszi.

Alicencet be kell állítani, mielőtt bármilyen műveletet végeznél az AutoCAD fájlokkal. Csak egyszer szükséges a licenc beállítása egy alkalmazás vagy folyamat során.

A licencet streamből vagy fájlból lehet betölteni az alábbi helyeken:

1. Kifejezett útvonal.
1. Az a mappa, amely tartalmazza az Aspose.CAD.jar-t.

Használj License.setLicense() metódust a komponens licencelésére. Gyakran a legegyszerűbb módja a licenc beállításának, ha a licenc fájlt ugyanabba a mappába helyezed, ahol az Aspose.CAD.jar található, és csak a fájl nevét adod meg útvonal nélkül, ahogyan az az alábbi példában látható:

### **Példa 1**

Ebben a példában az **Aspose.CAD** megpróbálja megtalálni a licenc fájlt az alkalmazásod JAR-jait tartalmazó mappában.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Példa 2**

Licenc inicializálása streamből.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Alicenc érvényesítése**

Lehetséges ellenőrizni, hogy a licenc megfelelően be van-e állítva vagy sem. A License osztály rendelkezik egy isLicensed mezővel, amely igazat ad vissza, ha a licenc megfelelően lett beállítva.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Alicenc be van állítva!");

}

{{< /highlight >}}
