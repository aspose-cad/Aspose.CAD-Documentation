---
title: DGN AutoCAD exportálása
type: docs
weight: 50
url: /hu/python-net/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD formátum PDF-re exportálása**

Az Aspose.CAD for Python API bevezette azt a funkciót, amely lehetővé teszi egy DGN AutoCAD fájl betöltését és PDF formátumra történő konvertálását. A **CadImage** osztály szolgál erre a célra.

Egy meglévő DGN fájlt kell betölteni **CadImage**-ként. Hozzon létre egy példányt a **CadRasterizationOptions** osztályból és állítson be különböző tulajdonságokat. Hozzon létre egy példányt a **PdfOptions** osztályból és adja át a **CadRasterizationOptions** példányt. Most hívja meg a **save** metódust a **CadImage** osztály példányán.

### Mintakód

Az alábbiakban a DGN [DGN](https://docs.fileformat.com/cad/dgn/) formátum PDF-re konvertálásának/exportálásának kódmegvalósítása látható.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **DGN AutoCAD formátum raszteres kép formátumra exportálása**

Az Aspose.CAD for Python API bevezette azt a funkciót, amely lehetővé teszi egy DGN AutoCAD fájl betöltését és raszteres képre történő konvertálását. A **CadImage** osztály szolgál erre a célra.

Egy meglévő DGN fájlt kell betölteni **CadImage**-ként. Hozzon létre egy példányt a **CadRasterizationOptions** osztályból és állítson be különböző tulajdonságokat. Hozzon létre egy példányt a **JpegOptions** osztályból és adja át a **CadRasterizationOptions** példányt. Most hívja meg a **save** metódust a **CadImage** osztály példányán.

### Mintakód

Az alábbiakban a DGN [DGN](https://docs.fileformat.com/cad/dgn/) JPEG képformátumra konvertálásának/exportálásának kódmegvalósítása látható.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **3D objektumok támogatása DGN v7 esetén**

Az Aspose.CAD for Python API bevezette azt a funkciót, amely lehetővé teszi egy [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD fájl betöltését és a 3D objektumok támogatását DGN v7 esetén. A **CadImage** osztály szolgál erre a célra. Minden [DGN](https://docs.fileformat.com/cad/dgn/) kép 9 előre definiált nézetet támogat. Ezek 1-től 9-ig enumerálva vannak. Ha a nézet nincs meghatározva az exportálás során, a többoldalas kimeneti formátumok esetén (mint a PDF) minden nézet exportálva lesz, mindegyik külön oldalon. 3D objektumok támogatottak a DGN fájlformátumban, valamint a 2D-ben is. Ehhez a **VectorRasterizationOptions** van használva, a TypeOfEntities már nem használatos a DGN formátum esetén (a 2D és 3D egyidejűleg támogatva).

### Mintakód

Az alábbiakban a támogatott DGN elemek megtekintésére szolgáló mintakód található.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
