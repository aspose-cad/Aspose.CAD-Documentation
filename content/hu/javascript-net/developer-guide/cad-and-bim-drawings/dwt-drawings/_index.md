---
title: DWT Rajzok
type: docs
weight: 50
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/dwt-drawings/
---

## **DWT Formátum Exportálása PNG-ba**

Az Aspose.CAD Javascript számára Angularban lehetővé teszi a fejlesztők számára, hogy egy [DWT](https://docs.fileformat.com/cad/dwt/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak.
A [DWT](https://docs.fileformat.com/cad/dwt/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be a [DWT](https://docs.fileformat.com/cad/dwt/) rajzfájlt a **Image.load** metódussal.
1. Hívja meg a **Image.save**-ot, miközben a második paraméterként átad egy **PngOptions** objektumot.

## Példa Kód

Az alábbi kód megmutatja, hogyan érjük el ugyanazt a célt az Aspose.CAD használatával Javascriptben

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWT-to-PNG-Export.js" >}}
