---
title: Rysunki SVG
type: docs
weight: 170
url: /pl/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Eksportowanie formatu SVG do PDF**

Aspose.CAD dla Pythona umożliwia programistom eksportowanie pliku [SVG](https://docs.fileformat.com/page-description-language/svg/) do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście do konwersji [SVG](https://docs.fileformat.com/page-description-language/svg/) na [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku SVG używając metody fabrycznej **Image.load**.
2. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
3. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **VectorRasterizationOptions**.
4. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
