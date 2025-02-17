---
title: SVG Rajzok
type: docs
weight: 170
url: /hu/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG Formátum PDF-be Történő Exportálása**

Az Aspose.CAD Pythonhoz lehetővé teszi a fejlesztők számára, hogy egy [SVG](https://docs.fileformat.com/page-description-language/svg/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. Az [SVG](https://docs.fileformat.com/page-description-language/svg/) PDF-be való konvertálásának megközelítése a következőképpen működik:

1. Töltse be az SVG rajzfájlt a **Image.load** gyári metódus használatával.
1. Hozzon létre egy objektumot a **CadRasterizationOptions** osztályból, és állítsa be a **page_height** és **page_width** tulajdonságokat.
1. Hozzon létre egy objektumot a **PdfOptions** osztályból, és állítsa be a **VectorRasterizationOptions** tulajdonságot.
1. Hívja meg a **Image.save**-ot, miközben a második paraméterként egy **PdfOptions** objektumot ad át.

## Minta Kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
