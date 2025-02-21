---
title: Rysunki FBX
type: docs
weight: 70
url: /pl/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Eksportowanie formatu FBX do PDF**

Aspose.CAD dla .NET pozwala deweloperom na eksportowanie plików [FBX](https://docs.fileformat.com/3d/fbx/) do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście do konwersji [FBX](https://docs.fileformat.com/3d/fbx/) na [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku [FBX](https://docs.fileformat.com/3d/fbx/) za pomocą fabrycznej metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) oraz [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
