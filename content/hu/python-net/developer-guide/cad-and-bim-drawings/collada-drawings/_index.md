---
title: COLLADA Rajzok
type: docs
weight: 20
url: /hu/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA Formátum Exportálása PDF-be**

Az Aspose.CAD for Python lehetővé teszi a fejlesztők számára, hogy egy [COLLADA](https://docs.fileformat.com/3d/dae/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. A [COLLADA](https://docs.fileformat.com/3d/dae/) PDF-be való konvertálásának folyamata a következőképpen működik:

1. Töltsd be a [COLLADA](https://docs.fileformat.com/3d/dae/) rajzfájlt a **Image.load** gyári módszer segítségével.
1. Hozz létre egy példányt a **CadRasterizationOptions** osztályból, és állítsd be a **page_height** és **page_width** tulajdonságokat.
1. Hozz létre egy példányt a **PdfOptions** osztályból, és állítsd be a **vector_rasterization_options** tulajdonságot.
1. Call **Image.save** úgy, hogy a második paraméterként egy **PdfOptions** objektumot adsz át.

## Példakód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
