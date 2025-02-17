---
title: SVG Rajzok
type: docs
weight: 70
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG Formátum PNG-ra Exportálása**

Az Aspose.CAD for Javascript Angularban lehetővé teszi a fejlesztők számára, hogy egy [SVG](https://docs.fileformat.com/page-description-language/svg/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak. Az [SVG](https://docs.fileformat.com/page-description-language/svg/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be az [SVG](https://docs.fileformat.com/page-description-language/svg/) rajz fájlt a **Image.load** metódus használatával.
1. Hívja meg a **Image.save**-t, miközben a második paraméterként egy **PngOptions** objektumot ad át.

## Minta Kód

Az alábbi kód megmutatja, hogyan érheti el ugyanazt a célt az Aspose.CAD for JavaScript használatával.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
