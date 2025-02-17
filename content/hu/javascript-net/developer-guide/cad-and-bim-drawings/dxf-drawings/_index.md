---
title: DXF Rajzok
type: docs
weight: 60
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF Formátum Exportálása PNG-ra**

Az Aspose.CAD for Javascript Angularban lehetővé teszi a fejlesztők számára, hogy egy [DXF](https://docs.fileformat.com/cad/dxf/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak. A [DXF](https://docs.fileformat.com/cad/dxf/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be a [DXF](https://docs.fileformat.com/cad/dxf/) rajzfájlt a **Image.load** metódus használatával.
1. Hívja meg a **Image.save**-t, miközben átad egy **PngOptions** objektumot második paraméterként.

## Példa Kód

Az alábbi kód megmutatja, hogyan érhető el ugyanaz a cél az Aspose.CAD for JavaScript használatával.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DXF-to-PNG-Export.js" >}}
