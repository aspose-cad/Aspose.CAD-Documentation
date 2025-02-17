---
title: DWG Rajzok
type: docs
weight: 40
url: /hu/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **DWG Rajzok PDF-be történő exportálása**

Az Aspose.CAD for Java API képes betölteni az AutoCAD rajzokat DWG formátumban, és azokat PDF-re konvertálni. Ez a téma magyarázza el az Aspose.CAD API használatát a DWG PDF formátumba történő konvertálásához az alább meghatározott egyszerű lépések segítségével.

{{% alert color="primary" %}}

Az API a következő AutoCAD DWG verziókat támogatja:

- DWG 2004 verzió 16.0 kiadás 18
- DWG 2005 verzió  16.1
- DWG 2010 verzió 18.0
- DWG 2013 verzió 19.0

{{% /alert %}}

### **DWG Fájlformátum**

A DWG egy bináris fájl, amely vektorgrafikus adatokat és metaadatokat tartalmaz. A vektorgrafikus adatok utasításokat adnak a CAD alkalmazás számára arról, hogyan jelenítse meg a DWG-t; a metaadatok sokféle információt tartalmazhatnak a fájlról, beleértve a helyhez kötött adatokat és a kliensadatokat is. Az Open Specifications for DWG fájlformátum megtalálható [ebben a PDF-ben](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **DWG Fájlok PDF-be való konvertálása**

A DWG PDF-be konvertálásához az alábbi egyszerű lépések szükségesek.

1. Töltsd be a DWG fájlt egy [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) példányba.
1. Hozz létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályobjektumot, és állítsd be a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) tulajdonságokat.
1. Hozz létre egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztályobjektumot, és állítsd be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságot.
1. Hívd meg az [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust, és add meg a [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) objektumot második paraméterként.

Az alábbi kód példa megmutatja, hogyan kell DWG rajzokat PDF-be exportálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Egységes PDF létrehozása különböző elrendezés méretekkel**

Az Aspose.CAD for Java lehetővé teszi, hogy a DWG fájlt egy egységes PDF-be konvertáljuk, különböző elrendezésméretekkel. Ez a megközelítés a következőképpen működik:

1. Tölts be egy DWG fájlt az [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári metódus segítségével.
1. Hozz létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztály példányt, és állítsd be az eredményül kapott oldal magasságát és szélességét.
1. Add hozzá a szükséges [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objektumhoz.
1. Hozz létre egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztály példányt, és állítsd be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságát.
1. Exportáld a képet PDF-be az [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódus használatával.

Az alábbi kód példa megmutatja, hogyan kell létrehozni egy egységes PDF-et különböző elrendezésekkel.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **DWG PDF/A és PDF/E-be történő exportálása**

A DWG PDF-be konvertálásához az alábbi egyszerű lépések szükségesek.

1. Töltsd be a DWG fájlt egy [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) példányba.
1. Hozz létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és állítsd be a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) tulajdonságokat.
1. Hozz létre egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztályobjektumot, és állítsd be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságot.
1. Hívd meg az [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust, és add meg a [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) objektumot második paraméterként.

Az alábbi kód példa megmutatja, hogyan kell DWG rajzokat PDF-be exportálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Támogatott AutoCAD Primitívek**

A következő AutoCAD primitívek támogatottak.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **DWG Specifikus Elrendezés PDF-be történő exportálása**

Ez a megközelítés a következőképpen működik:

1. Tölts be egy DWG fájlt az [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári metódus segítségével.
1. Hozz létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztály példányt, és állítsd be az eredményül kapott oldal magasságát és szélességét.
1. Állítsd be a [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) tulajdonságot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objektumra.
1. Hozz létre egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztály példányt, és állítsd be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságát.
1. Exportáld a képet PDF-be az [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódus használatával.

Az alábbi kód példa megmutatja, hogyan kell a DWG egy specifikus elrendezését PDF-be konvertálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **DWG PDF vagy Rasterszerkesztés rögzített mérettel**

Az Aspose.CAD for Java API képes betölteni az AutoCAD rajzokat DWG formátumban, és konvertálni azokat PDF-be vagy Rasterszerkesztésbe rögzített mérettel.

Az alábbi kód példa megmutatja, hogyan lehet ezt a funkciót megvalósítani.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Kerekített rejtett vonalak támogatása DWG/DXF BMP-be és PDF-be exportáláskor**

Ez a megközelítés a következőképpen működik:

1. Tölts be egy DWG fájlt az [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári metódus segítségével.
1. Hozz létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztály példányt.
1. Hozz létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztály példányt, és állítsd be az eredményül kapott oldal magasságát és szélességét.
1. Hozz létre egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztály példányt, és állítsd be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságát.
1. Exportáld a képet PDF-be az [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódus használatával.

Az alábbi kód példa megmutatja, hogyan lehet ezt a funkciót megvalósítani.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Nyomtatási terület beállításának támogatása a DWG képen az exportált PDF-ben**

Az Aspose.CAD for Java API képes betölteni az AutoCAD rajzokat DWG formátumban, és PDF-re konvertálni. Ez a téma magyarázza el az Aspose.CAD API használatát, hogy támogassa a nyomtatási terület beállítását a DWG képen az exportált PDF-ben.

Az alábbi kód példa megmutatja, hogyan lehet ezt a funkciót megvalósítani.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **XREF metaadatok olvasásának támogatása DWG fájl esetén**

1. Tölts be egy DWG fájlt az [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári metódus segítségével.
1. Haladj végig minden képegyesítőn.
1. Ha az egység [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), akkor XREF egység metaadattal.

Az alábbi kód példa megmutatja, hogyan érhetjük el ezt a funkciót.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **DWG dokumentum megadott koordináták alapján**

Az Aspose.CAD for Java API most már lehetőséget biztosít a DWG dokumentumok renderelésére a dokumentum szélességi és magassági koordinátáival.

Az alábbi kód példa megmutatja, hogyan lehet renderelni egy DWG dokumentumot.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

A [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) tulajdonság típusú string tömb, így egyszerre több elrendezést is megadhatsz az esetleges PDF formátumba való konvertáláshoz. Amikor több elrendezést adunk meg a [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) tulajdonság számára, az eredményül kapott PDF több oldalból fog állni, ahol minden oldal egy-egy AutoCAD elrendezést képvisel.

### **Összes Elrendezés Listázása**

Az összes elrendezés listázásához, amely egy AutoCAD rajzban található, használhatod az alábbi kódpéldát.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Blokkattribútum értékének lekérdezése külső hivatkozás esetén**

Az Aspose.CAD for Java API lehetővé teszi, hogy lekérd egy blokkattribútum külső hivatkozását. Az Aspose.CAD API kifejleszti a [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) tulajdonságot, hogy megkaphasd a blokkattribútum külső hivatkozását a [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) gyűjteményben.

Az alábbi kód bemutatja, hogyan lehet megkapni egy blokkattribútum külső hivatkozását.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Szöveg keresése DWG AutoCAD fájlban**

Az Aspose.CAD for Java API lehetőséget biztosít szöveg keresésére egy DWG AutoCAD fájlban. Az Aspose.CAD API bemutatja a [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) osztályt, amely a DWG AutoCAD fájl szöveges egységeit képviseli. A [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) osztály is része az Aspose.CAD API-nak, mivel néhány más egység is tartalmazhat szöveget.

Az alábbi kód bemutatja, hogyan lehet szöveget keresni a DWG AutoCAD fájlban.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Szöveg keresése Specifikus Elrendezésben**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Alapellátási Zászlók elérhetősége DWG formátumban**

Az Aspose.CAD for Java implementálta az alapellátási zászlókat a DWG formátumban, és lehetővé teszi a fejlesztőknek ezek elérését. Az alábbiakban egy egyszerű kód bemutató található.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **DWG Entitások Támogatása**

Az Aspose.CAD for Java API képes betölteni az AutoCAD rajzokat DWG formátumban, és különböző entitásokat támogat a munkához.

### **MLeader Entitás Támogatása**

A DWG egy bináris fájl, amely vektorgrafikus adatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz egy példát mutat be a MLeader entitás használatára a DWG fájlban.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **DWG Entitás Képbe való Exportálás Támogatása**

A DWG egy bináris fájl, amely vektorgrafikus adatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz példát mutat be egy adott DWG entitás képbe való exportálására.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Kép Importálás Támogatása DWG Fájlba**

Az Aspose.CAD for Java API képes betölteni az AutoCAD rajzokat DWG formátumban, és támogat különböző entitásokat a munkához. A DWG egy bináris fájl, amely vektorgrafikus adatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz leírja, hogyan importálhatunk képeket a DWG fájlba.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Szöveg hozzáadásának támogatása DWG-ben**

Az Aspose.CAD for Java API képes betölteni az AutoCAD rajzokat DWG formátumban, és támogat különböző entitásokat a munkához. A DWG egy bináris fájl, amely vektorgrafikus adatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz leírja, hogyan adhatunk hozzá szöveget a DWG fájlhoz.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Mesh támogatás DWG-ben**

Az Aspose.CAD for Java API most már hozzáférhet a mesh-típusú entitásokhoz, beleértve a [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) és [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) típusokat. Az alábbi példa leírja, hogyan érhetjük el a mesh típusokat.

## **DWG Rajzok DXF-be történő konvertálása**

Az Aspose.CAD lehetőséget biztosít az AutoCAD DWG fájl betöltésére és DXF formátumba való exportálására. A DWG-t DXF-re való konvertálás folyamata így működik:

1. Töltsd be a DWG rajzfájlt az [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári metódussal.
1. Exportáld a DWG rajzot DXF-be az [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódus használatával.

Az alábbi kód példa megmutatja, hogyan kell konvertálni egy DWG fájlt DXF formátumba.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **DWG Rajzok SVG-be történő konvertálása**

Az Aspose.CAD API képes betölteni az AutoCAD rajzokat DWG formátumban, és azokat SVG-re konvertálni. Ez a téma magyarázza el az Aspose.CAD API használatát a DWG SVG formátumba történő konvertálásához az alább meghatározott egyszerű lépések segítségével.

1. Töltsd be a DWG fájlt egy [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) példányba.
1. Hozz létre egy [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) osztályobjektumot, és állítsd be a szükséges tulajdonságokat.
1. Exportáld a DWG rajzot SVG-be az [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódussal.

Az alábbi kód példa megmutatja, hogyan kell konvertálni egy DWG fájlt SVG formátumba.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
