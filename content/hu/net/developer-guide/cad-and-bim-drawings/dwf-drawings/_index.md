---
title: DWF Rajzok
type: docs
weight: 20
url: /hu/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF Rajzok PDF-be történő exportálása**

Az Aspose.CAD lehetőséget biztosít az AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) rajzobjektumok betöltésére és azok teljes rajzként való létrehozására [PDF](https://docs.fileformat.com/pdf/) formátumban. A [DWF](https://docs.fileformat.com/cad/dwf/) PDF-be történő konvertálási folyamata a következőképpen működik:

1. Betöltjük a [DWF](https://docs.fileformat.com/cad/dwf/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódus segítségével.
1. Létrehozunk egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot, és beállítjuk a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Létrehozunk egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztály objektumot, és beállítjuk a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
1. Meghívjuk a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben átadunk egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot második paraméterként.

### Példa kód

Az alábbi kódrészlet megmutatja, hogyan lehet egy fájlt konvertálni alapértelmezett beállításokkal.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Rétegek kinyerése DWF Rajzból**

Az Aspose.CAD lehetőséget biztosít az AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) rajzobjektumok betöltésére és azok teljes rajzként való létrehozására [JPEG](https://docs.fileformat.com/image/jpeg/) formátumban.

1. Betöltjük a [DWF](https://docs.fileformat.com/cad/dwf/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódus segítségével.
1. Létrehozunk egy [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) osztály objektumot.
1. Létrehozunk egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot.
1. Kinyerjük a rétegek nevét a [JPEG](https://docs.fileformat.com/image/jpeg/) objektum segítségével.
1. Meghívjuk a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben átadunk egy [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) objektumot második paraméterként.

### Példa kód

Az alábbi kódrészlet megmutatja, hogyan lehet egy fájlt konvertálni alapértelmezett beállításokkal.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Rétegek támogatása DWF-ben**

Az Aspose.CAD lehetőséget biztosít az AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) rajzobjektumok betöltésére és azok teljes rajzként való létrehozására [JPEG](https://docs.fileformat.com/image/jpeg/) formátumban.

1. Betöltjük a [DWF](https://docs.fileformat.com/cad/dwf/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódus segítségével.
1. Létrehozunk egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot.
1. Hozzáadjuk a kívánt rétegeket.
1. Meghívjuk a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben átadunk egy [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) objektumot második paraméterként.

### Példa kód

Az alábbi kódrészlet megmutatja, hogyan lehet egy fájlt konvertálni alapértelmezett beállításokkal.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **DWF Rajzok BMP-be történő exportálása**

Az Aspose.CAD lehetőséget biztosít az AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) rajzobjektumok betöltésére és azok teljes rajzként való létrehozására [BMP](https://docs.fileformat.com/image/bmp/) formátumban. A [DWF](https://docs.fileformat.com/cad/dwf/) BMP-be történő konvertálási folyamata a következőképpen működik:

1. Betöltjük a [DWF](https://docs.fileformat.com/cad/dwf/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódus segítségével.
1. Létrehozunk egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztály objektumot, és beállítjuk a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Létrehozunk egy [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) osztály objektumot, és beállítjuk a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
1. Meghívjuk a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben átadunk egy [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) objektumot második paraméterként.

### Példa kód

Az alábbi kódrészlet megmutatja, hogyan lehet egy [DWF](https://docs.fileformat.com/cad/dwf/) fájlt [BMP](https://docs.fileformat.com/image/bmp/) formátumba konvertálni alapértelmezett beállításokkal.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
