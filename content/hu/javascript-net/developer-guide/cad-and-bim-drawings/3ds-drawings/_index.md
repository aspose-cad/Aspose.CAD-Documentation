---
title: 3DS Rajzok
type: docs
weight: 70
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **3DS Formátum Exportálása PNG-be**

Az Aspose.CAD for Javascript Angular-ban lehetővé teszi a fejlesztők számára, hogy egy [3DS](https://docs.fileformat.com/3d/3ds/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak. A [3DS](https://docs.fileformat.com/3d/3ds/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megoldás a következőképpen működik:

1. Töltse be a [3DS](https://docs.fileformat.com/3d/3ds/) rajzfájlt a **Image.load** metódus használatával.
1. Hívja meg a **Image.save**-t, miközben a második paraméterként átad egy **PngOptions** objektumot.

## Példa Kód

Az alábbi kód megmutatja, hogyan érheti el ugyanazt a célot az Aspose.CAD for JavaScript segítségével

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-3DS-to-PNG-Export.js" >}}
