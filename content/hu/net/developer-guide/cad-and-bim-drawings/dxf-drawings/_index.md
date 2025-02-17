---
title: DXF Rajzok
type: docs
weight: 60
url: /hu/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF Rajzok PDF-be Exportálása**

Aspose.CAD lehetővé teszi az AutoCAD DXF rajzok betöltését és azok teljes rajzként való renderelését PDF formátumban. A DXF PDF-be konvertálás megközelítése a következőképpen működik:

1. Töltse be a DXF rajz fájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári módszer használatával.
1. Hozzon létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hozzon létre egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztály objektumot, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságot.
1. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben átad egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot második paraméterként.

Az alábbi kód minta bemutatja, hogyan lehet fájlt konvertálni az alapértelmezett beállításokkal.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Támogatott Formátumok**

Jelenleg teljes mértékben támogatjuk az AutoCAD DXF 2010 fájlformátumokat. A korábbi DXF verziók 100%-os érvényessége nem garantált. Tervezzük, hogy a jövőbeli Aspose.CAD verziókban több formátumot és funkciót is bevezetünk.

### **Támogatott Entitások**

Jelenleg minden elterjedt 2D entitást és azok alapértelmezett paramétereit támogatjuk az alábbiak szerint:

1. Igazított Mérték
1. Szögmérték
1. Ív
1. Attribútum
1. Blokk Referencia
1. Kör
1. Átmérő Mérték
1. Ellipszis
1. Mintázás
1. Vonal
1. Többsoros Szöveg
1. Ordinate Mérték
1. Pont
1. Poliline
1. Sugár Mérték
1. Sugár
1. Forgatott Mérték
1. Táblázat
1. Szöveg
1. X-vonal

{{% alert color="primary" %}}

Ha a feldolgozás során olyan entitással vagy tulajdonsággal találkozunk, amelyet nem támogatunk, az entitás vagy tulajdonság csendben figyelmen kívül lesz hagyva.

{{% /alert %}}

### **Memória kezelés**

A [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) tulajdonság a [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) osztályban használható a memória újraallokálásának vezérlésére. Az újraallokálás legjobban a korábban allokált gyorsítótárak esetén valósul meg. Előfordulhat, amikor a rendszer rájön, hogy a foglalt hely nem lesz elegendő.

- Ha az [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) az alapértelmezett értékre, **False**-ra van állítva, a hely ugyanarra a közegre van újraallokálva.
- Ha **True**-ra van állítva, az újraallokálás nem lépheti túl a maximális megadott helyet. Ebben az esetben a meglévő, memóriában allokált gyorsítótár (amely újraallokálást igényel) felszabadul, és a kibővített hely a lemezen kerül allokálásra.

## **DXF Rajzok Meghatározott Rétegének Exportálása PDF-be**

Ez a megközelítés a következőképpen működik:

1. Nyissa meg a DXF rajz fájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári módszer használatával.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és adja meg a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) és [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) tulajdonságokat.
1. Adjon rétegeket a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) objektumhoz.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságot.
1. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) módszert, és adja át a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot második paraméterként.

Az alábbi kód minta bemutatja, hogyan lehet egy meghatározott réteget DXF-ből PDF-be konvertálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **PDF fájlok renderelése DXF rajzok részeként**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DXF rajz fájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári módszer használatával.
1. Hozzon létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot, és töltse be a PDF fájlokat.
1. Állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hívja meg az [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, és mentse a fájlt.

Az alábbi kód minta bemutatja, hogyan lehet PDF fájlokat DXF rajzok részeként renderelni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Beágyazott DGN alátámasztás exportálása DXF formátumba**

Aspose.CAD lehetővé teszi az AutoCAD DXF fájlok betöltését és a beágyazott DGN alátámasztás exportálását DXF formátumban.

Az alábbi kód minta bemutatja, hogyan lehet elérni a megadott követelményeket.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DXF fájlok mentésének támogatása**

Aspose.CAD lehetővé teszi az AutoCAD DXF fájlok betöltését, módosítását és újra mentését DXF fájlként.

Az alábbi kód minta bemutatja, hogyan lehet elérni a megadott követelményeket.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **DXF exportálása WMF formátumba**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DXF rajz fájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári módszer használatával.
1. Hozzon létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot, és töltse be a PDF fájlokat.
1. Állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hívja meg az [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, és mentse a fájlt.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Meghatározott DXF elrendezés exportálása PDF-be**

Ez a megközelítés a következőképpen működik:

1. Nyissa meg a DXF rajz fájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári módszer használatával.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és adja meg a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) és a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) tulajdonságokat.
1. Adja meg a kívánt elrendezés nevét a [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) tulajdonság használatával.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságot.
1. Exportálja a rajzot PDF-be, hívja meg az [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, és adja át a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot második paraméterként.

Az alábbi kód minta bemutatja, hogyan lehet egy meghatározott DXF elrendezést PDF-be konvertálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

A [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) tulajdonság típusa string tömb, így meghatározhat több elrendezést egyszerre a PDF formátumba történő konvertálás céljából. Ha több elrendezést ad meg a [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) tulajdonságnak, a kapott PDF több oldalt fog tartalmazni, ahol minden oldal egy-egy AutoCAD elrendezést képvisel.

{{% /alert %}}

## **Blokk Klippelés Támogatása**

Aspose.CAD lehetővé teszi a Blokk Klippelés megvalósítását. A Blokk Klippelés megközelítése a következőképpen működik:

1. Töltse be a DXF rajz fájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári módszer használatával.
1. Hozzon létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot, és töltse be a PDF fájlokat.
1. Állítsa be a kívánt [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) tulajdonságait.
1. Hívja meg az [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben átad egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot második paraméterként, és mentse a fájlt.

Az alábbi kód minta bemutatja, hogyan működik a Blokk Klippelés.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Képek Exportálása DXF-be**

Az Aspose.CAD segítségével képeket exportálhat DXF formátumba. E megközelítés alkalmazásával az alábbi műveleteket végezheti el:

1. Állítson be új betűtípust
1. Rejtsen el entitásokat
1. Frissítse a szöveget

Az alábbi kód minta megmutatja, hogyan végezheti el a fent említett műveleteket.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **DXF Rajzok Meghatározott Rétegének Exportálása Képbe**

Ez a megközelítés a következőképpen működik:

1. Nyissa meg a DXF rajz fájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári módszer használatával.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és adja meg a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) és [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) tulajdonságokat.
1. Adjon rétegeket a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) objektumhoz.
1. Hozzon létre egy példányt a [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságot.
1. Exportálja a rajzot PDF-be az [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódus használatával.

Az alábbi kód minta bemutatja, hogyan lehet egy meghatározott DXF réteget képpé konvertálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
