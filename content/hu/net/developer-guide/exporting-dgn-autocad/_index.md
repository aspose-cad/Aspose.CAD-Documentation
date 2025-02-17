---
title: DGN AutoCAD exportálása
type: docs
weight: 50
url: /hu/net/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD formátum PDF-re való exportálása**

Az Aspose.CAD for .NET API bevezette azt a funkciót, amely lehetővé teszi egy DGN AutoCAD fájl betöltését és PDF formátumba való konvertálását. A [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) osztály szolgál erre a célra.

Egy meglévő DGN fájlt kell betölteni [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) formátumban. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítson be különböző tulajdonságokat. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) osztályból, és adja át a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) példányt. Most hívja meg a [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust a [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) osztály példányán.

### Mintakód

Az alábbiakban a kód bemutatása következik, amely a [DGN](https://docs.fileformat.com/cad/dgn/) formátumot PDF-re [PDF](https://docs.fileformat.com/pdf/) konvertál.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DGN AutoCAD formátum raster képformátumra való exportálása**

Az Aspose.CAD for .NET API bevezette azt a funkciót, amely lehetővé teszi egy DGN AutoCAD fájl betöltését és raster képformátumba való konvertálását. A [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) osztály szolgál erre a célra.

Egy meglévő DGN fájlt kell betölteni [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) formátumban. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból, és állítson be különböző tulajdonságokat. Hozzon létre egy példányt a [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) osztályból, és adja át a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) példányt. Most hívja meg a [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metódust a [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) osztály példányán.

### Mintakód

Az alábbiakban a kód bemutatása következik, amely a [DGN](https://docs.fileformat.com/cad/dgn/) formátumot [JPEG](https://docs.fileformat.com/image/jpeg/) képre konvertálja/exportálja.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **3D entitások támogatása DGN v7 számára**

Az Aspose.CAD for .NET API bevezette azt a funkciót, amely lehetővé teszi egy [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD fájl betöltését és a 3D entitások támogatását DGN v7 számára. A [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) osztály szolgál erre a célra. Minden [DGN](https://docs.fileformat.com/cad/dgn/) kép 9 előre definiált nézetet támogat. Ezeket 1-től 9-ig számozzák. Ha a nézet nincs definiálva az exportáláskor, a többoldalas kimeneti formátumoknál (mint pl. PDF) minden nézet exportálva lesz, mindegyik külön oldalon. A DGN fájlformátumban a 3D entitások támogatottak, valamint a 2D entitások is. Ehhez a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) osztályt használják, a TypeOfEntities már nem használatos a DGN formátum esetében (mind a 2D, mind a 3D támogatott egyidejűleg).

### Mintakód

Az alábbiakban a mintakód, amely bemutatja a támogatott DGN elemeket.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
