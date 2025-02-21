---
title: Rysunki DRC
type: docs
weight: 40
url: /pl/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Eksportowanie formatu DRC do PDF**

Aspose.CAD dla Pythona pozwala deweloperom na eksportowanie plików [DRC](https://docs.fileformat.com/3d/drc/) do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście do konwersji [DRC](https://docs.fileformat.com/3d/drc/) do [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Wczytaj plik rysunku DRC za pomocą metody fabrycznej **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
1. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **VectorRasterizationOptions**.
1. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

## Przykładowy kod


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
