---
title: Rysunki DXB
type: docs
weight: 70
url: /pl/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Eksportowanie formatu DXB do PDF**

Aspose.CAD dla .NET pozwala deweloperom na eksportowanie pliku DXB do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście do konwersji DXB na [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku DXB używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) oraz [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
