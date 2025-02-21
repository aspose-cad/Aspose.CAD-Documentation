---
title: Rysunki DWF
type: docs
weight: 50
url: /pl/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Eksportowanie rysunków DWF do PDF**

Aspose.CAD oferuje funkcję ładowania encji rysunkowych AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) i renderowania ich jako całego rysunku w formacie [PDF](https://docs.fileformat.com/pdf/). Podejście do konwersji [DWF](https://docs.fileformat.com/cad/dwf/) na [PDF](https://docs.fileformat.com/pdf/) działa następująco:

1. Załaduj plik rysunku [DWF](https://docs.fileformat.com/cad/dwf/) za pomocą fabrycznej metody **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
1. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **vector_rasterization_options**.
1. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

### Przykładowy kod

Poniższy przykładowy kod pokazuje, jak przekonwertować plik, używając ustawień domyślnych.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Eksportowanie rysunków DWF do BMP**

Aspose.CAD oferuje funkcję ładowania encji rysunkowych AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) i renderowania ich jako całego rysunku w formacie [BMP](https://docs.fileformat.com/image/bmp/). Podejście do konwersji [DWF](https://docs.fileformat.com/cad/dwf/) na [BMP](https://docs.fileformat.com/image/bmp/) działa następująco:

1. Załaduj plik rysunku [DWF](https://docs.fileformat.com/cad/dwf/) za pomocą fabrycznej metody **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
1. Utwórz obiekt klasy **BmpOptions** i ustaw właściwość **vector_rasterization_options**.
1. Wywołaj **Image.save**, przekazując obiekt **BmpOptions** jako drugi parametr.

### Przykładowy kod

Poniższy przykładowy kod pokazuje, jak przekonwertować plik [DWF](https://docs.fileformat.com/cad/dwf/) na [BMP](https://docs.fileformat.com/image/bmp/) przy użyciu ustawień domyślnych.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
