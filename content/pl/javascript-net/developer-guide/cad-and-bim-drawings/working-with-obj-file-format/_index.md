---
title: Praca z formatem plików OBJ
type: docs
weight: 120
url: /pl/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD teraz wspiera format plików OBJ. Format plików OBJ to geometria 3D, która zawiera mapy tekstur, współrzędne 3D, wielokątne twarze oraz inne informacje o obiektach.

{{% /alert %}}

## **Eksportowanie formatu OBJ do PNG**

Aspose.CAD dla JavaScript w Angular pozwala deweloperom eksportować plik [OBJ](https://docs.fileformat.com/3d/obj/) do formatu [PNG](https://docs.fileformat.com/image/png/).
Podejście do konwersji [OBJ](https://docs.fileformat.com/3d/obj/) na [PNG](https://docs.fileformat.com/image/png/) działa w następujący sposób:

1. Załaduj plik rysunku [OBJ](https://docs.fileformat.com/3d/obj/) używając metody **Image.load**.
1. Wywołaj **Image.save**, przekazując obiekt **PngOptions** jako drugi parametr.

## Przykładowy kod

Poniższy kod pokazuje, jak osiągnąć ten sam cel, używając Aspose.CAD dla JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
