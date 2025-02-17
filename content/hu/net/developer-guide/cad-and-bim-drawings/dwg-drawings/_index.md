---
title: DWG Rajzok
type: docs
weight: 40
url: /hu/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG Rajzok PDF-be exportálása**

Az Aspose.CAD for .NET API képes betölteni az AutoCAD rajzokat [DWG](https://docs.fileformat.com/cad/dwg/) formátumban, és átalakítani őket [PDF](https://docs.fileformat.com/pdf/) formátumba. Ez a téma az Aspose.CAD API használatát magyarázza el, hogy a DWG-t PDF formátumra konvertálhassuk a továbbiakban meghatározott egyszerű lépésekkel.

{{% alert color="primary" %}}

Az API az alábbi AutoCAD DWG verziókat támogatja:

- DWG 2004 16.0 verzió 18
- DWG 2005 16.1 verzió
- DWG 2010 18.0 verzió
- DWG 2013 19.0 verzió

{{% /alert %}}

### **DWG Fájlformátum**

A [DWG](https://docs.fileformat.com/cad/dwg/) egy bináris fájl, amely vektorgrafikus képadatokat és metaadatokat tartalmaz. A vektorgrafikus képadatok utasításokat adnak a CAD alkalmazásnak arról, hogyan kell megjeleníteni a DWG-t; a metaadatok különféle információkat tartalmazhatnak a fájlra vonatkozóan, beleértve a helyspecifikus adatokat és az ügyféladatokat is. A DWG fájlformátumra vonatkozó nyílt specifikációk találhatók [ebben a PDF-ben](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf).

### **DWG Fájlok PDF-re konvertálása**

Az alábbi egyszerű lépések szükségesek a [DWG](https://docs.fileformat.com/cad/dwg/) PDF-re történő konvertálásához:

1. Töltse be a DWG fájlt egy [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) példányba.
1. Hozzon létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály példányt, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hozzon létre egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztály példányt, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságot.
1. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) metódust, miközben a második paraméterként egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot ad meg.

Az alábbi kódmintában bemutatjuk, hogyan lehet a DWG rajzokat PDF-be exportálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Egyetlen PDF létrehozása különféle elrendezési méretekkel**

Az Aspose.CAD for .NET lehetővé teszi a DWG fájl egyszeri PDF-be történő konvertálását különböző elrendezési méretekkel. Ez a megközelítés a következőképpen működik:

1. Töltse be a DWG fájlt az [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be az eredményül kapott oldal magasságát és szélességét.
1. Adjon meg a szükséges [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) mezőket a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) objektum számára.
1. Hozzon létre egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztály példányt, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságát.
1. Exportálja a képet PDF-re az [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódussal.

Az alábbi kódmintában bemutatjuk, hogyan lehet létrehozni egyetlen [PDF](https://docs.fileformat.com/pdf/) különféle elrendezésekkel.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Támogatott AutoCAD Primitívek**

Az alábbi AutoCAD primitívek támogatottak.

- SZÖVEG
- MTEXT
- ATTDEF
- ATTRIB
- ÍV
- ELIPSZIS
- TÖLTÉS
- VEZÉR
- PONT
- VERTEX 2D
- VERTEX 3D
- POLYGON 2D
- LWPOLYLINE
- RAJZ
- KÖR
- DIMENZIONÁLÁS ORDINÁCIÓJA
- DIMENZIONÁLÁS LINEÁRIS
- DIMENZIONÁLÁS KIOSZTOTT
- DIMENZIONÁLÁS SZÖG 3Pt
- DIMENZIONÁLÁS SZÖG 2Ln
- DIMENZIONÁLÁS RÁDIUSZ
- DIMENZIONÁLÁS ÁTMÉRŐ
- FORMÁJÚ
- SOLID
- SPLINE
- MLINE
- VONAL
- XLINE
- STÍLUS
- DIMSTIL
- LTIPUS
- MLINESTÍLUS
- RÉTEG
- KÉPKERET
- ELRENDEZÉS

## **Specifikus DWG Elrendezés PDF-be exportálása**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DWG fájlt az [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be az eredményül kapott oldal magasságát és szélességét.
1. Állítsa be a [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) tulajdonságot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) objektum számára.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságát.
1. Exportálja a képet PDF-re az [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódussal.

Az alábbi kódmintában bemutatjuk, hogyan lehet egy konkrét DWG elrendezést PDF-be konvertálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG dokumentum renderelése koordináták megadásával**

Az Aspose.CAD for .NET API mostantól lehetőséget biztosít a DWG dokumentumok renderelésére a dokumentum szélességi és magassági koordinátáinak megadásával.

Az alábbi kódmintában bemutatjuk, hogyan kell renderelni egy DWG dokumentumot.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **DWG exportálása raszterbe vagy PDF-be rögzített méret használatával**

Az Aspose.CAD for .NET API képes betölteni az AutoCAD rajzokat DWG formátumban, és rögzített méret használatával PDF-re vagy raszterre konvertálni.

Az alábbi kódmintában bemutatjuk, hogyan lehet megvalósítani ezt a funkciót.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **DWG PDF/A és PDF/E formátumra való exportálása**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DWG fájlt az [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságát.
1. Állítsa be a PDF megfelelőségi tulajdonságot, és mentse el.
1. Exportálja a képet PDF-re az [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódussal.

Az alábbi kódmintában bemutatjuk, hogyan lehet egy DWG fájlt PDF/A és PDF/E formátumba konvertálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Kerek rejtett vonalak támogatása DWG/DXF BMP és PDF-be való exportálásakor**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DWG fájlt az [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be az eredményül kapott oldal magasságát és szélességét.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) tulajdonságát.
1. Exportálja a képet PDF-re az [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódussal.

Az alábbi kódmintában bemutatjuk, hogyan lehet megvalósítani ezt a funkciót.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Nyomtatási terület beállítása DWG képen exportált PDF-ben**

Az Aspose.CAD for .NET API képes betölteni az AutoCAD rajzokat DWG formátumban, és PDF-re konvertálni. Ez a téma elmagyarázza az Aspose.CAD API használatát a nyomtatási terület beállításának támogatásához a DWG képen az exportált PDF-ben.

Az alábbi kódmintában bemutatjuk, hogyan lehet megvalósítani ezt a funkciót.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **XREF metaadatok olvasása DWG fájlhoz**

1. Töltse be a DWG fájlt az [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
1. Járja be minden képkénti entitást.
1. Ha egy entitás CadUnderlay, akkor XREF entitás metaadatokkal.

Az alábbi kódmintában bemutatjuk, hogyan lehet elérni ezt a funkciót.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

A [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) tulajdonság típusa karakterlánc tömb, így egyszerre több elrendezést is megadhat a PDF formátumba történő lehetséges konverzióhoz. Ha több elrendezést ad meg a [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) tulajdonság számára, az eredményül kapott PDF több oldalt fog tartalmazni, ahol minden oldal egy-egy egyedi AutoCAD elrendezést képvisel.

### **Összes Elrendezés Listázása**

Megjelenítheti az AutoCAD rajzban lévő összes elrendezést az alábbi kódminta segítségével.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Alaplapok elérési flagjeinek elérése DWG formátumban**

Az Aspose.CAD for .NET megvalósította a DWG formátumú alaplapok flagjeit, és lehetővé teszi a fejlesztők számára, hogy hozzáférjenek hozzájuk. Az alábbi egyszerű kód bemutatja.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **DWG Entitások Támogatása**

Az Aspose.CAD for .NET API képes betölteni az AutoCAD rajzokat DWG formátumban és támogat különböző entitásokat a munkához.

### **MLeader Entitás Támogatása**

A DWG egy bináris fájl, amely vektorgrafikus képadatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz bemutat egy példát az MLeader entitással való munkavégzésre a DWG fájlban.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **DWG Entitás Képbe Exportálásának Támogatása**

A DWG egy bináris fájl, amely vektorgrafikus képadatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz bemutat egy példát egy adott DWG entitás képbe való exportálásáról.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Szöveg hozzáadása DWG-ben**

Az Aspose.CAD for .NET API képes betölteni az AutoCAD rajzokat DWG formátumban és támogat különböző entitásokat a munkához. A DWG egy bináris fájl, amely vektorgrafikus képadatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz bemutatja, hogyan tudunk szöveget hozzáadni a DWG fájlhoz.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Kép importálása DWG Fájlba**

Az Aspose.CAD for .NET API képes betölteni az AutoCAD rajzokat DWG formátumban és támogat különböző entitásokat a munkához. A DWG egy bináris fájl, amely vektorgrafikus képadatokat és metaadatokat tartalmaz. Különböző entitások találhatóak egy DWG fájlban. Az alábbi szakasz bemutatja, hogyan importálhatunk képeket a DWG fájlba.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Háló Támogatása DWG-ben**

Az Aspose.CAD for .NET API most már hozzáférhet a hálót támogató entitásokhoz, ideértve a [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) és a [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) típusokat. Az alábbi példa bemutatja, hogyan érhetjük el a hálótípusokat.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **DWG Rajzok DXF-be konvertálása**

Az Aspose.CAD lehetőséget nyújt az AutoCAD DWG fájl betöltésére és DXF formátumba exportálására. A DWG DXF-be konvertálás megközelítése a következőképpen működik:

1. Töltse be a DWG rajzfájlt az [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) gyári metódussal.
1. Exportálja a DWG rajzot DXF-be az [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódussal.

Az alábbi kódmintában bemutatjuk, hogyan lehet egy DWG fájlt DXF formátumba konvertálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **DWG Rajzok SVG-be konvertálása**

Az Aspose.CAD for .NET API képes betölteni az AutoCAD rajzokat DWG formátumban, és SVG-be konvertálni. Ez a téma az Aspose.CAD API használatát magyarázza el, hogy a DWG-t SVG formátumra konvertálhassuk az alábbi egyszerű lépések segítségével.

1. Töltse be a DWG fájlt egy [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) példányba.
1. Hozzon létre egy [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) osztály objektumot, és állítsa be a szükséges tulajdonságokat.
1. Exportálja a DWG rajzot SVG-be az [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódussal.

Az alábbi kódmintában bemutatjuk, hogyan lehet egy DWG fájlt SVG formátumba konvertálni.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Nagy DWG Fájl Betöltése**

Az Aspose.CAD for .NET lehetővé teszi nagyon nagy DWG fájlok megnyitását az [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) osztály segítségével. Mostantól könnyedén megnyithatja a nagy fájlokat az alábbi példa kód segítségével.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
