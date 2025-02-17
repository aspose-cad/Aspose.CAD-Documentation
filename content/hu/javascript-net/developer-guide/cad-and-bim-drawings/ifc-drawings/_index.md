---
title: IFC Rajzok
type: docs
weight: 70
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/ifc-drawings/
---

## **FBX Formátum Exportálása PNG-ra**

Az Aspose.CAD Javascripthez Angularban lehetővé teszi a fejlesztők számára, hogy egy [IFC](https://docs.fileformat.com/cad/ifc/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak.
Az [IFC](https://docs.fileformat.com/cad/ifc/) és a [PNG](https://docs.fileformat.com/image/png/) konverziós megközelítés a következőképpen működik:

1. Töltse be az [IFC](https://docs.fileformat.com/cad/ifc/) rajz fájlt a **Image.load** módszer segítségével.
2. Hívja meg a **Image.save**-t, miközben a második paraméterként egy **PngOptions** objektumot ad meg.

## Mintakód

Az alábbi kód megmutatja, hogyan lehet elérni ugyanazt a célt az Aspose.CAD Javascript segítségével

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-IFC-to-PNG-Export.js" >}}
