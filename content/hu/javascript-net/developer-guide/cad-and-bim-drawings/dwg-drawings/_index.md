---
title: DWG Rajzok
type: docs
weight: 40
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG formátum exportálása PNG-be**

Az Aspose.CAD for Javascript Angular-ban lehetővé teszi a fejlesztők számára, hogy [DWG](https://docs.fileformat.com/cad/dwg/) fájlt exportáljanak [PNG](https://docs.fileformat.com/image/png/) formátumba.  
A [DWG](https://docs.fileformat.com/cad/dwg/) és [PNG](https://docs.fileformat.com/image/png/) közötti átalakítási megközelítés a következőképpen működik:

1. Töltse be a [DWG](https://docs.fileformat.com/cad/dwg/) rajz fájlt a **Image.load** metódus használatával.
1. Hívja meg az **Image.save**-t, miközben az **PngOptions** objektumot a második paraméterként adja át.

## Mintakód

Az alábbi kód megmutatja, hogyan érhető el ugyanaz a cél az Aspose.CAD for JavaScript használatával

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWG-to-PNG-Export.js" >}}
