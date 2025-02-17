---
title: 3DS Rajzok
type: docs
weight: 70
url: /hu/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **3DS Formátum Exportálása PDF-be**

Az Aspose.CAD a .NET számára lehetővé teszi a fejlesztők számára, hogy egy [3DS](https://docs.fileformat.com/3d/3ds/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. A [3DS](https://docs.fileformat.com/3d/3ds/) PDF-be [PDF](https://docs.fileformat.com/pdf/) való konvertálás folyamata a következőképpen működik:

1. Töltsön be egy [3DS](https://docs.fileformat.com/3d/3ds/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódus használatával.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hozzon létre egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
1. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben a második paraméterként átad egy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot.

## Minta Kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
