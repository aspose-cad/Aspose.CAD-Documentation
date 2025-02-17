---
title: STP Rajzok
type: docs
weight: 70
url: /hu/javascript-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP Formátum Exportálása PNG-ba**

Az Aspose.CAD Javascript-ben Angular alkalmazásban lehetőséget ad a fejlesztőknek, hogy [STP](https://docs.fileformat.com/3d/stp/) fájlt exportáljanak [PNG](https://docs.fileformat.com/image/png/) formátumba.
Az [STP](https://docs.fileformat.com/3d/stp/) és [PNG](https://docs.fileformat.com/image/png/) közötti átalakítás folyamata a következőképpen működik:

1. Töltse be az [STP](https://docs.fileformat.com/3d/stp/) rajzfájlt a **Image.load** metódus segítségével.
1. Hívja meg a **Image.save** metódust, miközben a második paraméterként átad egy **PngOptions** objektumot.

## Példa Kód

Az alábbi kód bemutatja, hogyan érhetjük el ugyanezt az Aspose.CAD for JavaScript segítségével.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-STP-to-PNG-Export.js" >}}
