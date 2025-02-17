---
title: DWG Rajzok
type: docs
weight: 70
url: /hu/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG Rajzok PDF-be exportálása**

Az Aspose.CAD for Python API képes betölteni az AutoCAD rajzokat [DWG](https://docs.fileformat.com/cad/dwg/) formátumban, és átkonvertálni őket [PDF](https://docs.fileformat.com/pdf/) formátumba. Ez a téma az Aspose.CAD API használatát magyarázza el, amely lehetővé teszi a DWG PDF formátumba történő átkonvertálását az alábbi egyszerű lépések követésével.

{{% alert color="primary" %}}

Az API az alábbi AutoCAD DWG verziókat támogatja:

- DWG 2004  verzió 16.0 kiadás 18
- DWG 2005 verzió  16.1
- DWG 2010 verzió 18.0
- DWG 2013 verzió 19.0

{{% /alert %}}

### **DWG Fájlformátum**

A [DWG](https://docs.fileformat.com/cad/dwg/) egy bináris fájl, amely vektorgrafikus képadatokat és metaadatokat tartalmaz. A vektorgrafikus képadatok útmutatást adnak a CAD alkalmazásnak arról, hogyan kell megjeleníteni a DWG-t; a metaadatok különféle információkat tartalmazhatnak a fájlról, beleértve a helyspecifikus adatokat és az ügyfélinformációkat is. A DWG fájlformátum nyílt specifikációi [ebben a PDF-ben](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) találhatók.

### **DWG Fájlok PDF-be konvertálása**

Az alábbi egyszerű lépések szükségesek a [DWG](https://docs.fileformat.com/cad/dwg/) PDF-be konvertálásához:

1. Töltse be a DWG fájlt egy **Image** példányba.
1. Hozzon létre egy **CadRasterizationOptions** osztály példányt, és állítsa be a **page_height** és **page_width** tulajdonságokat.
1. Hozzon létre egy **PdfOptions** osztály példányt, és állítsa be a **VectorRasterizationOptions** tulajdonságot.
1. Hívja meg az **Image.save**-et, miközben átad egy **PdfOptions** objektumot második paraméterként.

Az alábbi kód példa azt mutatja be, hogyan lehet DWG Rajzokat PDF-be exportálni.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Támogatott AutoCAD Primitívek**

Az alábbi AutoCAD primitívek támogatottak:

- SZÖVEG
- MTEXT
- ATTDEF
- ATTRIB
- ÍV
- Ellipszis
- Töltés
- Vezér
- Pont
- VERTEX 2D
- VERTEX 3D
- POLILINE 2D
- LWPOLYLINE
- ALAK
- KÖR
- DIMENZIÓ ORDINÁT
- DIMENZIÓ LINEÁRIS
- DIMENZIÓ ELLENEGY
- DIMENZIÓ SZÖG 3Pt
- DIMENZIÓ SZÖG 2Ln
- DIMENZIÓ RADIUS
- DIMENZIÓ ÁTMÉRŐ
- FORMÁZAT
- SZILÁRD
- SPLINE
- MLINE
- VONAL
- XLINE
- STÍLUS
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Különleges DWG Elrendezés PDF-be exportálása**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DWG fájlt az **Aspose.CAD.Image.load** gyári metódusával.
1. Hozzon létre egy példányt a **CadRasterizationOptions** osztályból, és állítsa be az eredményoldal magasságát és szélességét.
1. Állítsa be a **Layouts** tulajdonságot a **CadRasterizationOptions** objektumban.
1. Hozzon létre egy példányt a **PdfOptions** osztályból, és állítsa be a **VectorRasterizationOptions** tulajdonságát.
1. Exportálja a képet PDF-be az **Image.save()** metódus használatával.

Az alábbi kód példa azt mutatja be, hogyan lehet egy konkrét DWG elrendezést PDF-be konvertálni.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **DWG PDF/A és PDF/E formátumra exportálása**

Ez a megközelítés a következőképpen működik:

1. Töltse be a DWG fájlt az **Image.load** gyári metódusával.
1. Hozzon létre egy példányt a **CadRasterizationOptions** osztályból.
1. Hozzon létre egy példányt a **PdfOptions** osztályból, és állítsa be a **VectorRasterizationOptions** tulajdonságát.
1. Állítsa be a PDF megfelelőségi tulajdonságot és mentse el azt.
1. Exportálja a képet PDF-be az **Image.save()** metódus használatával.

Az alábbi kód példa azt mutatja be, hogyan lehet egy DWG fájlt PDF/A és PDF/E formátumra konvertálni.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **DWG Rajzok DXF-be konvertálása**

Az Aspose.CAD lehetőséget biztosít az AutoCAD DWG fájl betöltésére és DXF formátumba exportálására. A DWG DXF-be konvertálási megközelítés a következőképpen működik:

1. Töltse be a DWG rajzfájlt az **Image.load** gyári metódusával.
1. Exportálja a DWG rajzot DXF-be az **Image.save()** metódus használatával.

Az alábbi kód példa azt mutatja be, hogyan lehet egy DWG fájlt DXF formátumra konvertálni.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **DWG Rajzok SVG-be konvertálása**

Az Aspose.CAD for Python API képes betölteni az AutoCAD rajzokat DWG formátumban, és átkonvertálni őket SVG-be. Ez a téma az Aspose.CAD API használatát magyarázza el, amely lehetővé teszi a DWG SVG formátumba történő átkonvertálását az alábbi egyszerű lépések követésével.

1. Töltse be a DWG fájlt egy **Image** példányba.
1. Hozzon létre egy **SvgOptions** osztály példányt, és állítsa be a szükséges tulajdonságokat.
1. Exportálja a DWG rajzot SVG-be az **Image.save()** metódus használatával.

Az alábbi kód példa azt mutatja be, hogyan lehet egy DWG fájlt SVG formátumra konvertálni.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
