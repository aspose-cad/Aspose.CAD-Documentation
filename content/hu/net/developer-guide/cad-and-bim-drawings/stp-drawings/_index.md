---
title: STP Rajzok
type: docs
weight: 70
url: /hu/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP Formátum exportálása PDF-be**

Az Aspose.CAD a .NET számára lehetővé teszi a fejlesztők számára, hogy egy [STP](https://docs.fileformat.com/3d/stp/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumban exportáljanak. Az [STP](https://docs.fileformat.com/3d/stp/) és [PDF](https://docs.fileformat.com/pdf/) közötti konvertálási folyamat a következőképpen működik:

1. Töltse be az [STP](https://docs.fileformat.com/3d/stp/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hozzon létre egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
1. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot ad meg második paraméterként.

## Példa Kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
