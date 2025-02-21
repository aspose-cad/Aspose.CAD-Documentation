---
title: Rysunki SVG
type: docs
weight: 70
url: /pl/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Eksportowanie formatu SVG do PNG**

Aspose.CAD dla Javascript w Angular pozwala deweloperom eksportować plik [SVG](https://docs.fileformat.com/page-description-language/svg/) do formatu [PNG](https://docs.fileformat.com/image/png/).
Podejście do konwersji [SVG](https://docs.fileformat.com/page-description-language/svg/) na [PNG](https://docs.fileformat.com/image/png/) działa w następujący sposób:

1. Załaduj plik rysunku [SVG](https://docs.fileformat.com/page-description-language/svg/) używając metody **Image.load**.
1. Wywołaj **Image.save**, przekazując obiekt **PngOptions** jako drugi parametr.

## Przykładowy kod

Kod poniżej pokazuje, jak osiągnąć ten sam cel, używając Aspose.CAD dla JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
