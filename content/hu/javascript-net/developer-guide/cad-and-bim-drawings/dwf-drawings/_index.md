---
title: DWF Rajzok
type: docs
weight: 20
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF Formátum Exportálása PNG-ra**

Az Aspose.CAD JavaScriptben Angular számára lehetővé teszi a fejlesztők számára, hogy egy [DWF](https://docs.fileformat.com/cad/dwf/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak.
A [DWF](https://docs.fileformat.com/cad/dwf/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be a [DWF](https://docs.fileformat.com/cad/dwf/) rajz fájlt a **Image.load** módszer használatával.
1. Hívja meg a **Image.save**-t, miközben egy **PngOptions** objektumot ad át második paraméterként.

## Mintakód

Az alábbi kód megmutatja, hogyan érhetjük el ugyanazt a célt az Aspose.CAD JavaScript használatával.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWF-to-PNG-Export.js" >}}
