---
title: FBX Rajzok
type: docs
weight: 70
url: /hu/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX Formátum Exportálása PDF-be**

Az Aspose.CAD a .NET számára lehetővé teszi a fejlesztők számára, hogy egy [FBX](https://docs.fileformat.com/3d/fbx/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. Az [FBX](https://docs.fileformat.com/3d/fbx/) és [PDF](https://docs.fileformat.com/pdf/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be az [FBX](https://docs.fileformat.com/3d/fbx/) rajzfájlt a [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) gyári metódussal.
2. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) és [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) tulajdonságokat.
3. Hozzon létre egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot.
4. Hívja meg a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust, miközben a második paraméterként az [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) objektumot adja meg.

## Minta Kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
