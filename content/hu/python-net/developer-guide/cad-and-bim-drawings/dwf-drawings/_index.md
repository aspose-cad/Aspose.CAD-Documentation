---
title: DWF Rajzok
type: docs
weight: 50
url: /hu/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF Rajzok exportálása PDF-be**

Aspose.CAD lehetőséget biztosít AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) rajz entitások betöltésére és azok teljes rajzként való megjelenítésére [PDF](https://docs.fileformat.com/pdf/) formátumban. A [DWF](https://docs.fileformat.com/cad/dwf/) -ből [PDF](https://docs.fileformat.com/pdf/) -be való konverzió folyamata a következőképpen működik:

1. Betöltjük a [DWF](https://docs.fileformat.com/cad/dwf/) rajzfájlt a **Image.load** gyári módszer segítségével.
1. Létrehozunk egy példányt a **CadRasterizationOptions** osztályból és beállítjuk a **page_height** és **page_width** tulajdonságokat.
1. Létrehozunk egy példányt a **PdfOptions** osztályból és beállítjuk a **vector_rasterization_options** tulajdonságot.
1. Meghívjuk a **Image.save** metódust, miközben a második paraméterként átadunk egy **PdfOptions** objektumot.

### Példa Kód

Az alábbi kódrészlet szemlélteti, hogyan lehet egy fájlt konvertálni az alapértelmezett beállításokkal.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **DWF Rajzok exportálása BMP-be**

Aspose.CAD lehetőséget biztosít AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) rajz entitások betöltésére és azok teljes rajzként való megjelenítésére [BMP](https://docs.fileformat.com/image/bmp/) formátumban. A [DWF](https://docs.fileformat.com/cad/dwf/) -ből [BMP](https://docs.fileformat.com/image/bmp/) -be való konverzió folyamata a következőképpen működik:

1. Betöltjük a [DWF](https://docs.fileformat.com/cad/dwf/) rajzfájlt a **Image.load** gyári módszer segítségével.
1. Létrehozunk egy példányt a **CadRasterizationOptions** osztályból és beállítjuk a **page_height** és **page_width** tulajdonságokat.
1. Létrehozunk egy példányt a **BmpOptions** osztályból és beállítjuk a **vector_rasterization_options** tulajdonságot.
1. Meghívjuk a **Image.save** metódust, miközben a második paraméterként átadunk egy **BmpOptions** objektumot.

### Példa Kód

Az alábbi kódrészlet szemlélteti, hogyan lehet egy [DWF](https://docs.fileformat.com/cad/dwf/) fájlt [BMP](https://docs.fileformat.com/image/bmp/) formátumba konvertálni az alapértelmezett beállításokkal.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
