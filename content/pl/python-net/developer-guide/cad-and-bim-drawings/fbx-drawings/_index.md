---
title: Rysunki FBX
type: docs
weight: 110
url: /pl/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Eksportowanie formatu FBX do PDF**

Aspose.CAD dla Pythona pozwala deweloperom na eksportowanie pliku [FBX](https://docs.fileformat.com/3d/fbx/) do formatu [PDF](https://docs.fileformat.com/pdf/). Podejście konwersji [FBX](https://docs.fileformat.com/3d/fbx/) do [PDF](https://docs.fileformat.com/pdf/) działa w następujący sposób:

1. Załaduj plik rysunku [FBX](https://docs.fileformat.com/3d/fbx/) przy użyciu metody fabrycznej **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **PageHeight** i **PageWidth**.
1. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **vector_rasterization_options**.
1. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

## Przykładowy kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
