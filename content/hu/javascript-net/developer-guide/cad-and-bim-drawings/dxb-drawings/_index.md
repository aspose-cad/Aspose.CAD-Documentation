---
title: DXB Rajzok
type: docs
weight: 70
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB Formátum Exportálása PNG-be**

Az Aspose.CAD for Javascript Angularban lehetővé teszi a fejlesztők számára, hogy DXB fájlt exportáljanak [PNG](https://docs.fileformat.com/image/png/) formátumba.
A DXB-ből [PNG](https://docs.fileformat.com/image/png/) terjedelmű konverziós megközelítés a következőképpen működik:

1. Töltse be a DXB rajzfájlt a **Image.load** metódussal.
1. Hívja meg a **Image.save**-t, miközben a második paraméterként átad egy **PngOptions** objektumot.

## Mintakód

Az alábbi kód megmutatja, hogyan érheti el ugyanazt a célt az Aspose.CAD for JavaScript segítségével.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DXB-to-PNG-Export.js" >}}
