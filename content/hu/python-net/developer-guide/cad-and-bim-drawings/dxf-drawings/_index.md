---
title: DXF Rajzok
type: docs
weight: 10
url: /hu/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF Rajzok exportálása PDF-be**

Az Aspose.CAD lehetőséget biztosít az AutoCAD DXF rajz entitások betöltésére és teljes rajzként való PDF formátumba való renderelésére. A DXF PDF-be való konvertálás folyamata a következőképpen működik:

1. Töltse be a DXF rajzfájlt a **Image.load** gyári metódus használatával.
1. Hozzon létre egy objektumot a **CadRasterizationOptions** osztályból, és állítsa be a **page_height** és **page_width** tulajdonságokat.
1. Hozzon létre egy objektumot a **PdfOptions** osztályból, és állítsa be a **VectorRasterizationOptions** tulajdonságot.
1. Hívja meg az **Image.save**-t, miközben a második paraméterként egy **PdfOptions** objektumot ad át.

Az alábbi kódrészlet azt mutatja be, hogyan lehet egy fájlt konvertálni az alapértelmezett beállítások felhasználásával.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Támogatott formátumok**

Jelenleg teljes mértékben támogatjuk az AutoCAD DXF 2010 fájlformátumokat. Az előző DXF verzióknál nem garantált a 100% -os érvényesség. Tervezzük, hogy több formátumot és funkciót is bevezetünk a jövőbeli Aspose.CAD verziókban.

### **Támogatott entitások**

Jelenleg támogatjuk az összes elterjedt 2D entitást és azok alapvető alapértelmezett paramétereit a következők szerint:

1. Igazított méret
1. Szögmérték
1. Ív
1. Attribútum
1. Blokk hivatkozás
1. Kör
1. Átmérő méret
1. Ellipszis
1. Hálós töltés
1. Vonal
1. Többsoros szöveg
1. Ordináta
1. Pont
1. Poligon
1. Sugárméret
1. Sugár
1. Forgatott méret
1. Táblázat
1. Szöveg
1. Xvonal

{{% alert color="primary" %}}

Ha a feldolgozás során olyan entitással vagy tulajdonsággal találkozunk, amelyet nem támogatunk, az entitás vagy tulajdonság csendben figyelmen kívül lesz hagyva.

{{% /alert %}}

## **Beágyazott DGN alátét exportálása DXF formátumban**

Az Aspose.CAD lehetőséget biztosít az AutoCAD DXF fájlok betöltésére és a beágyazott DGN alátét exportálására DXF formátumban.

Az alábbi kódrészlet bemutatja, hogyan lehet elérni a megadott követelményeket.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **DXF fájlok mentésének támogatása**

Az Aspose.CAD lehetőséget biztosít az AutoCAD DXF fájlok betöltésére, módosításokra és újbóli mentésére DXF fájlként.

Az alábbi kódrészlet bemutatja, hogyan lehet elérni a megadott követelményeket.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **DXF exportálása WMF formátumba**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DXF rajzfájlt a **Image.load** gyári metódus használatával.
1. Hozzon létre egy objektumot a **CadRasterizationOptions** osztályból és töltse be a PDF fájlokat.
1. Állítsa be a **page_height** és **page_width** tulajdonságokat.
1. Hívja meg az **Image.save**-t és mentse a fájlt.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
