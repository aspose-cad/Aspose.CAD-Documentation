---
title: DGN Rajz
type: docs
weight: 10
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/dgn-drawing/
---

## **DGN Formátum Exportálása PNG-ra**

Az Aspose.CAD Angularhoz lehetővé teszi a fejlesztők számára, hogy egy [DGN](https://docs.fileformat.com/cad/dgn/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak. 
A [DGN](https://docs.fileformat.com/cad/dgn/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megközelítés a következőképpen működik:

1. Töltsön be egy [DGN](https://docs.fileformat.com/cad/dgn/) rajzfájlt a **Image.load** metódus használatával.
1. Hívja meg a **Image.save**-t, miközben a második paraméterként egy **PngOptions** objektumot ad át.

## Példa Kód

Az alábbi kód bemutatja, hogyan érheti el ugyanazt a célt az Aspose.CAD JavaScript használatával.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DGN-to-PNG-Export.js" >}}
