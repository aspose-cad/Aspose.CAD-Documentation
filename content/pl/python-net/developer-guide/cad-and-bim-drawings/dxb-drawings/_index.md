---
title: Rysunki DXB
type: docs
weight: 90
url: /pl/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Eksportowanie formatu DXB do PDF**

Aspose.CAD dla Pythona pozwala programistom na eksportowanie pliku DXB do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście do konwersji DXB do [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku DXB za pomocą metody fabrycznej **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
1. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **vector_rasterization_options**.
1. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
