---
title: DRC Rajzok
type: docs
weight: 15
url: /hu/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC Rajzok exportálása PDF formátumba**

Az Aspose.CAD lehetőséget biztosít AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) rajzi entitások betöltésére és azokat egy teljes rajzként való [PDF](https://docs.fileformat.com/pdf/) formátumra történő renderelésére. A [DRC](https://docs.fileformat.com/3d/drc/) és [PDF](https://docs.fileformat.com/pdf/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be a [DRC](https://docs.fileformat.com/3d/drc/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári módszer használatával.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hozzon létre egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
1. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot ad át második paraméterként.

### Példa Kód

Az alábbi kód példa megmutatja, hogyan lehet egy fájlt konvertálni alapértelmezett beállításokkal.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
