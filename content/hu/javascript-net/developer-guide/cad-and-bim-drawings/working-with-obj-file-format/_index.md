---
title: Az OBJ fájlformátummal való munka
type: docs
weight: 120
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Az Aspose.CAD most már támogatja az OBJ fájlformátumot. Az OBJ fájlformátum egy 3D geometria, amely textúratérképeket, 3D koordinátákat, poligonális felületeket és egyéb objektuminformációkat tartalmaz.

{{% /alert %}}

## **OBJ formátum exportálása PNG-ba**

Az Aspose.CAD Javascripthez Angularban lehetővé teszi a fejlesztők számára, hogy egy [OBJ](https://docs.fileformat.com/3d/obj/) fájlt [PNG](https://docs.fileformat.com/image/png/) formátumba exportáljanak.
Az [OBJ](https://docs.fileformat.com/3d/obj/) PNG-ba [konvertálás](https://docs.fileformat.com/image/png/) megközelítése a következőképpen működik:

1. Töltsd be az [OBJ](https://docs.fileformat.com/3d/obj/) rajzfájlt a **Image.load** metódus segítségével.
1. Hívd meg az **Image.save**-t, miközben egy **PngOptions** objektumot adsz át második paraméterként.

## Minta Kód

Az alábbi kód megmutatja, hogyan érhetjük el ugyanazt a célt az Aspose.CAD JavaScript használatával

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
