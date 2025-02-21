---
title: Rysunki DRC
type: docs
weight: 15
url: /pl/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Eksportowanie rysunków DRC do PDF**

Aspose.CAD zapewnia funkcję ładowania encji rysunków AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) i renderowania ich jako całości rysunku do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście konwersji [DRC](https://docs.fileformat.com/3d/drc/) do [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku [DRC](https://docs.fileformat.com/3d/drc/) za pomocą metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) i [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

### Przykładowy kod

Poniższy fragment kodu pokazuje, jak skonwertować plik przy użyciu domyślnych ustawień.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
