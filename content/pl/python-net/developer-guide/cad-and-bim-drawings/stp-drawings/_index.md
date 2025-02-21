---
title: Rysunki STP
type: docs
weight: 160
url: /pl/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Eksportowanie formatu STP do PDF**

Aspose.CAD dla Pythona pozwala deweloperom eksportować plik [STP](https://docs.fileformat.com/3d/stp/) do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście do konwersji [STP](https://docs.fileformat.com/3d/stp/) na [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku [STP](https://docs.fileformat.com/3d/stp/) używając metody fabrycznej **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
1. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **vector_rasterization_options**.
1. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
