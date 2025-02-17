---
title: DXB Rajzok
type: docs
weight: 70
url: /hu/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB Formátum Exportálása PDF-be**

Az Aspose.CAD .NET-hez lehetővé teszi a fejlesztők számára, hogy egy DXB fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. A DXB és [PDF](https://docs.fileformat.com/pdf/) közötti átalakítási eljárás a következőképpen működik:

1. Töltse be a DXB rajz fájlt az [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódus segítségével.
1. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
1. Hozzon létre egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
1. Hívja meg az [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben átad egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) második paraméterként.

## Mintakód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
