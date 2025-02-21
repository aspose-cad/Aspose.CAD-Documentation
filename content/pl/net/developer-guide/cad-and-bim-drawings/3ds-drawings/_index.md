---
title: Rysunki 3DS
type: docs
weight: 70
url: /pl/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Eksportowanie formatu 3DS do PDF**

Aspose.CAD dla .NET umożliwia deweloperom eksport pliku [3DS](https://docs.fileformat.com/3d/3ds/) do formatu [PDF](https://docs.fileformat.com/pdf/). Proces konwersji z [3DS](https://docs.fileformat.com/3d/3ds/) na [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku [3DS](https://docs.fileformat.com/3d/3ds/) za pomocą metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) i [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
