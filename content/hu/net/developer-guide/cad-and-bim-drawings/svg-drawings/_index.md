---
title: SVG Rajzok
type: docs
weight: 70
url: /hu/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG Formátum PDF-re Exportálása**

Az Aspose.CAD a .NET számára lehetővé teszi a fejlesztők számára, hogy egy SVG fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. Az SVG [PDB](https://docs.fileformat.com/pdf/) konvertálási megközelítés a következőképpen működik:

1. Töltse be az SVG rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári módszerrel.
2. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
3. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
4. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) példányt második paraméterként adja át.

## Példa Kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
