---
title: STL Rajzok
type: docs
weight: 100
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/stl-drawings/
---

## **STL Formátum Exportálása PNG-be**

Az Aspose.CAD Javascriptben Angular számára lehetővé teszi a fejlesztők számára, hogy egy [STL](https://docs.fileformat.com/cad/stl/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak. Az [STL](https://docs.fileformat.com/cad/stl/) fájl [PNG](https://docs.fileformat.com/image/png/) formátumba történő átkonvertálásának megközelítése a következőképpen működik:

1. Töltse be az [STL](https://docs.fileformat.com/cad/stl/) rajz fájlt az **Image.load** metódussal.
1. Hívja meg az **Image.save**-t, miközben a második paraméterként egy **PngOptions** objektumot ad át.

## Minta Kód

Az alábbi kód megmutatja, hogyan érhető el ugyanaz a cél az Aspose.CAD Javascript használatával

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-STL-to-PNG-Export.js" >}}
