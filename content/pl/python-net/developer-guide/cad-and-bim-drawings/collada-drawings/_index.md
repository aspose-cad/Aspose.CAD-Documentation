---
title: Rysunki COLLADA
type: docs
weight: 20
url: /pl/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Eksportowanie formatu COLLADA do PDF**

Aspose.CAD dla Pythona umożliwia deweloperom eksportowanie pliku [COLLADA](https://docs.fileformat.com/3d/dae/) do formatu [PDF](https://docs.fileformat.com/pdf/). Proces konwersji [COLLADA](https://docs.fileformat.com/3d/dae/) na [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku [COLLADA](https://docs.fileformat.com/3d/dae/) za pomocą metody fabrycznej **Image.load**.
2. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
3. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **vector_rasterization_options**.
4. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
