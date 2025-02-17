---
title: FBX Rajzok
type: docs
weight: 70
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX Formátum Exportálása PNG-be**

Az Aspose.CAD Javascript-hez Angularban lehetővé teszi a fejlesztők számára, hogy egy [FBX](https://docs.fileformat.com/3d/fbx/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak.
[FBX](https://docs.fileformat.com/3d/fbx/) és [PNG](https://docs.fileformat.com/image/png/) közötti konverziós megközelítés a következőképpen működik:

1. Töltse be az [FBX](https://docs.fileformat.com/3d/fbx/) rajzfájlt a **Image.load** metódus használatával.
1. Hívja meg a **Image.save**-t, miközben az **PngOptions** egy objektumát adja meg második paraméterként.

## Példa Kód

Az alábbi kód azt mutatja be, hogyan érheti el ugyanazt a célt az Aspose.CAD Javascript számára

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-FBX-to-PNG-Export.js" >}}
