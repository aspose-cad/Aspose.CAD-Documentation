---
title: IGES Rajzok
type: docs
weight: 80
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/iges-drawings/
---

## **IGES Formátum Exportálása PNG-be**

Az Aspose.CAD for Javascript Angular-ban lehetővé teszi a fejlesztők számára, hogy egy [IGES](https://docs.fileformat.com/cad/iges/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak.
Az [IGES](https://docs.fileformat.com/cad/iges/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be az [IGES](https://docs.fileformat.com/cad/iges/) rajzfájlt a **Image.load** módszer segítségével.
1. Hívja meg a **Image.save**-t, miközben a második paraméterként egy **PngOptions** objektumot ad át.

## Példa Kód

Az alábbi kód megmutatja, hogyan érheti el ugyanazt a célt az Aspose.CAD for JavaScript segítségével.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-IGES-to-PNG-Export.js" >}}
