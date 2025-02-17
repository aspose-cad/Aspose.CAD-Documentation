---
title: STP Rajzok
type: docs
weight: 160
url: /hu/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP Formátum Exportálása PDF-be**

Az Aspose.CAD Pythonhoz lehetővé teszi a fejlesztők számára, hogy egy [STP](https://docs.fileformat.com/3d/stp/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. Az [STP](https://docs.fileformat.com/3d/stp/) PDF-be való átkonvertálás folyamata a következőképpen működik:

1. Töltsön be egy [STP](https://docs.fileformat.com/3d/stp/) rajzfájlt a **Image.load** gyári módszer használatával.
1. Hozzon létre egy **CadRasterizationOptions** osztály objektumot, és állítsa be a **page_height** és **page_width** tulajdonságokat.
1. Hozzon létre egy **PdfOptions** osztály objektumot, és állítsa be a **vector_rasterization_options** tulajdonságot.
1. Hívja meg a **Image.save**-t, miközben egy **PdfOptions** objektumot ad meg második paraméterként.

## Minta Kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
