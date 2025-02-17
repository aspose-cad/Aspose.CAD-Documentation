---
title: COLLADA Rajzok
type: docs
weight: 70
url: /hu/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA Formátum Exportálása PDF-be**

Az Aspose.CAD a .NET számára lehetővé teszi a fejlesztők számára, hogy egy [COLLADA](https://docs.fileformat.com/3d/dae/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. A [COLLADA](https://docs.fileformat.com/3d/dae/) és [PDF](https://docs.fileformat.com/pdf/) közötti konverziós folyamat a következőképpen működik:

1. Töltsön be egy [COLLADA](https://docs.fileformat.com/3d/dae/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
1. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, átadva a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) példányt második paraméterként.

## Példa Kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
