---
title: FBX Rajzok
type: docs
weight: 110
url: /hu/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX Formátum PDF-be Exportálása**

Az Aspose.CAD for Python lehetővé teszi a fejlesztők számára, hogy egy [FBX](https://docs.fileformat.com/3d/fbx/) fájlt [PDF](https://docs.fileformat.com/pdf/) formátumba exportáljanak. Az [FBX](https://docs.fileformat.com/3d/fbx/) és [PDF](https://docs.fileformat.com/pdf/) közötti konverzió a következőképpen működik:

1. Töltse be az [FBX](https://docs.fileformat.com/3d/fbx/) rajzfájlt a **Image.load** gyári módszer segítségével.
2. Hozzon létre egy **CadRasterizationOptions** osztály objektumot, és állítsa be a **PageHeight** & **PageWidth** tulajdonságokat.
3. Hozzon létre egy **PdfOptions** osztály objektumot, és állítsa be a **vector_rasterization_options** tulajdonságot.
4. Hívja meg a **Image.save**-t, miközben átad egy **PdfOptions** objektumot második paraméterként.

## Példa Kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
