---
title: DXF Rajzok
type: docs
weight: 60
url: /hu/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **DXF Rajzok Exportálása PDF-be**

Aspose.CAD lehetőséget biztosít AutoCAD DXF rajz entitások betöltésére és ezek egész rajzként történő renderelésére PDF formátumban. A DXF-ből PDF-be való konverziós folyamat a következőképpen működik:

1. Betölti a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) és [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) tulajdonságokat.
1. Hozzon létre egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságot.
1. Hívja meg az Image.Save-t, miközben egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) objektumot ad át második paraméterként.

Az alábbi kódrészlet bemutatja, hogyan lehet egy fájlt alapértelmezett beállításokkal konvertálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Támogatott Formátumok**

Jelenleg teljes mértékben támogatjuk az AutoCAD DXF 2010 fájlformátumokat. A korábbi DXF verziók 100%-os érvényessége nem garantált. A jövőbeli Aspose.CAD verziókban több formátum és funkció hozzáadását tervezzük.

### **Támogatott Entitások**

Jelenleg támogatjuk az összes széles körben használt 2D entitást és alapértelmezett paramétereiket, a következők szerint:

1. Igazított Méret
1. Szögméret
1. Ív
1. Attribútum
1. Blokk Hivatkozás
1. Kör
1. Átmérő Méret
1. Ellipszis
1. Mintázat
1. Vonal
1. Többsoros Szöveg
1. Ordinate Méret
1. Pont
1. Polyline
1. Sugár Méret
1. Sugár
1. Forgatott Méret
1. Táblázat
1. Szöveg
1. Xvonal

{{% alert color="primary" %}}

Ha a böngészés során olyan entitással vagy tulajdonsággal találkozunk, amelyet nem támogatunk, az entitás vagy tulajdonság csendben figyelmen kívül lesz hagyva.

{{% /alert %}}

### **Memória Kezelés**

A [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) tulajdonság segítségével vezérelheti a memória újraallokációját. Az újraallokáció legvalószínűbb, hogy előre allokált gyorsítótárak esetén fordul elő. Ez akkor történhet meg, amikor a rendszer rájön, hogy az allokált tér nem lesz elegendő.

- Ha az [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) az alapértelmezett értékre, **False**, van beállítva, a tér ugyanazon a közegen kerül újraallokálásra.
- Ha **True**-ra van állítva, az újraallokáció nem haladhatja meg a megadott maximális teret. Ebben az esetben a meglévő allokált memóriában lévő gyorsítótár (amely újraallokálást igényel) felszabadul, és bővített területet allokálnak a lemezen.

## **DXF Rajzok Meghatározott Rétegének Exportálása PDF-be**

Ez a folyamat a következőképpen működik:

1. Nyissa meg a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és adja meg a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) és [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) tulajdonságokat.
1. Rétegeket adjon hozzá a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objektumhoz.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságot.
1. Exportálja a rajzot PDF-be a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódus segítségével.

Az alábbi kódrészlet bemutatja, hogyan lehet egy DXF meghatározott rétegét PDF-be konvertálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **DXF Rajzok Meghatározott Rétegének Exportálása Képbe**

Ez a folyamat a következőképpen működik:

1. Nyissa meg a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és adja meg a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) és [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) tulajdonságokat.
1. Rétegeket adjon hozzá a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objektumhoz.
1. Hozzon létre egy példányt a [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságot.
1. Exportálja a rajzot Képbe a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódus segítségével.

Az alábbi kódrészlet bemutatja, hogyan lehet egy DXF meghatározott rétegét Képbe konvertálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **PDF fájlok renderelése a DXF rajzok részeként**

Ez a folyamat a következőképpen működik:

1. Betölti a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és töltse be a PDF fájlokat.
1. Állítsa be a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) és [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) tulajdonságokat.
1. Hívja meg a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust, és mentse el a fájlt.

Az alábbi kódrészlet bemutatja, hogyan lehet PDF fájlokat renderálni a DXF rajzok részeként.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **DXF Exportálása WMF-be**

Ez a folyamat a következőképpen működik:

1. Betölti a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és töltse be a PDF fájlokat.
1. Állítsa be a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) és [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) tulajdonságokat.
1. Hívja meg a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust, és mentse el a fájlt.

Az alábbi kódrészlet bemutatja, hogyan lehet DXF-et WMF-be exportálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **DXF Fájlok Mentésének Támogatása**

Aspose.CAD lehetőséget biztosít AutoCAD DXF fájlok betöltésére, azok módosítására és újra DXF fájlba történő mentésére. Az alábbi kódrészlet bemutatja, hogyan érheti el a megadott követelményeket.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Beágyazott DGN Alapréteg Exportálása DXF Formátumba**

Aspose.CAD lehetőséget biztosít AutoCAD DXF fájlok betöltésére és a beágyazott DGN alapréteg exportálására DXF formátumba.

Az alábbi kódrészlet bemutatja, hogyan érheti el a megadott követelményeket.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **DXF Meghatározott Elrendezésének Exportálása PDF-be**

Ez a folyamat a következőképpen működik:

1. Nyissa meg a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és adja meg a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) és [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) tulajdonságokat.
1. Adja meg a kívánt elrendezési nevet(eket) a [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) tulajdonság használatával.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságot.
1. Exportálja a rajzot PDF-be a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódus segítségével.

Az alábbi kódrészlet bemutatja, hogyan lehet a DXF meghatározott elrendezését PDF-be konvertálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

A [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) tulajdonság típusa karakterlánc tömb, így egyszerre több elrendezés is megadható a PDF formátumra való esetleges konverzióhoz. Több elrendezés megadásakor a [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) tulajdonság számára az eredeti PDF több oldalt tartalmaz, ahol minden oldal egyedi AutoCAD elrendezést képvisel.

{{% /alert %}}

## **ATTRIB és MTEXT objektumok elérése**

Ez a folyamat a következőképpen működik:

1. Nyissa meg a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Access the entities inside CAD file.
1. Ellenőrizze a [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) és [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) entitásokat.
1. Adja hozzá a ideiglenes listához a további feldolgozás érdekében.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **CAD Beszúró Objektumok Degradálása**

Ez a folyamat a következőképpen működik:

1. Nyissa meg a **DXF** rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer segítségével.
1. Access the entities inside CAD file.
1. Ellenőrizze a [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) entitásokat.
1. Ellenőrizze a [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) típuslistát.
1. Feldolgozza az entitásokat.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Blokk Levágás Támogatása**

Aspose.CAD lehetőséget biztosít a Blokk Levágásra. A Blokk Levágás folyamata a következőképpen működik:

1. Betölti a DXF rajzfájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári módszer használatával.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és töltse be a PDF fájlokat.
1. Állítsa be a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) kívánt tulajdonságait.
1. Hívja meg a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust, miközben egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) objektumot ad át második paraméterként, és mentse el a fájlt.

Az alábbi kódrészlet bemutatja, hogyan működik a Blokk Levágás.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Képek Exportálása DXF-be**

Az Aspose.CAD segítségével képeket exportálhat DXF formátumba. E megoldás segítségével a következő tevékenységeket végezheti el:

1. Állítson be új betűtípust.
1. Rejtsen el entitásokat.
1. Frissítse a szöveget.

Az alábbi kódrészlet megmutatja, hogyan hajthatja végre a fent említett tevékenységeket.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
