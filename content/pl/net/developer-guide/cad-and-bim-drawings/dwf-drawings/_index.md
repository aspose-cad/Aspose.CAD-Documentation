---
title: Rysunki DWF
type: docs
weight: 20
url: /pl/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Eksportowanie rysunków DWF do PDF**

Aspose.CAD zapewnia funkcję ładowania jednostek rysunkowych AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) i renderowania ich jako całego rysunku do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście konwersji [DWF](https://docs.fileformat.com/cad/dwf/) do [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku [DWF](https://docs.fileformat.com/cad/dwf/) za pomocą metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Stwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) i [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Stwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

### Przykładowy kod

Przykład kodu poniżej pokazuje, jak skonwertować plik przy użyciu domyślnych ustawień.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Ekstrakcja warstw z rysunku DWF**

Aspose.CAD zapewnia funkcję ładowania jednostek rysunkowych AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) i renderowania ich jako całego rysunku do formatu [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Załaduj plik rysunku [DWF](https://docs.fileformat.com/cad/dwf/) za pomocą metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Stwórz obiekt klasy [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Stwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Ekstrahuj nazwę warstw za pomocą obiektu [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt klasy [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) jako drugi parametr.

### Przykładowy kod

Przykład kodu poniżej pokazuje, jak skonwertować plik przy użyciu domyślnych ustawień.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Wsparcie dla warstw w DWF**

Aspose.CAD zapewnia funkcję ładowania jednostek rysunkowych AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) i renderowania ich jako całego rysunku do formatu [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Załaduj plik rysunku [DWF](https://docs.fileformat.com/cad/dwf/) za pomocą metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Stwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Dodaj pożądane warstwy.
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt klasy [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) jako drugi parametr.

### Przykładowy kod

Przykład kodu poniżej pokazuje, jak skonwertować plik przy użyciu domyślnych ustawień.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Eksportowanie rysunków DWF do BMP**

Aspose.CAD zapewnia funkcję ładowania jednostek rysunkowych AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) i renderowania ich jako całego rysunku do formatu [BMP](https://docs.fileformat.com/image/bmp/). Podejście konwersji [DWF](https://docs.fileformat.com/cad/dwf/) do [BMP](https://docs.fileformat.com/image/bmp/) działa w następujący sposób:

1. Załaduj plik rysunku [DWF](https://docs.fileformat.com/cad/dwf/) za pomocą metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Stwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) i [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Stwórz obiekt klasy [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt klasy [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) jako drugi parametr.

### Przykładowy kod

Przykład kodu poniżej pokazuje, jak przekonwertować plik [DWF](https://docs.fileformat.com/cad/dwf/) na [BMP](https://docs.fileformat.com/image/bmp/) przy użyciu domyślnych ustawień.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
