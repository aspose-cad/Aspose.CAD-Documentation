---
title: DRC Rajzok
type: docs
weight: 40
url: /hu/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC formátum exportálása PDF-be**

Az Aspose.CAD Python számára lehetővé teszi a fejlesztők számára, hogy egy [DRC](https://docs.fileformat.com/3d/drc/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. A [DRC](https://docs.fileformat.com/3d/drc/) PDF-re [PDF](https://docs.fileformat.com/pdf/) konverziós megközelítése a következőképpen működik:

1. Töltse be a DRC rajzfájlt a **Image.load** gyári metódus segítségével.
1. Hozzon létre egy objektumot a **CadRasterizationOptions** osztályból, és állítsa be a **page_height** és **page_width** tulajdonságokat.
1. Hozzon létre egy objektumot a **PdfOptions** osztályból, és állítsa be a **VectorRasterizationOptions** tulajdonságot.
1. Hívja meg a **Image.save**-t, miközben a **PdfOptions** objektumot második paraméterként adja át.

## Példa Kód


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
