---
title: DXB Rajzok
type: docs
weight: 90
url: /hu/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB Formátum Exportálása PDF-be**

Az Aspose.CAD Pythonhoz lehetővé teszi a fejlesztők számára, hogy DXB fájlt exportáljanak [PDF](https://docs.fileformat.com/pdf/) formátumba. A DXB és [PDF](https://docs.fileformat.com/pdf/) közötti átalakítási megközelítés a következőképpen működik:

1. Töltse be a DXB rajzfájlt a **Image.load** gyári metódus használatával.
1. Hozzon létre egy objektumot a **CadRasterizationOptions** osztályból, és állítsa be a **page_height** és **page_width** tulajdonságokat.
1. Hozzon létre egy objektumot a **PdfOptions** osztályból, és állítsa be a **vector_rasterization_options** tulajdonságot.
1. Hívja meg a **Image.save** metódust, miközben a második paraméterként átad egy **PdfOptions** objektumot.

## Minta Kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
