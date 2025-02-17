---
title: DGN AutoCAD Exportálása
type: docs
weight: 50
url: /hu/java/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD Formátum PDF-be Exportálása**

Az Aspose.CAD Java API bevezette a funkcionalitást egy [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD fájl betöltésére és PDF-be [PDF](https://docs.fileformat.com/pdf/) formátumba való konvertálására. A [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) osztály szolgál erre a célra.

Meg kell tölteni egy meglévő DGN fájlt [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) néven. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és állítson be különböző tulajdonságokat. Hozzon létre egy példányt a [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) osztályból, és adja át a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) példányt. Most hívja meg a [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust a [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) osztály példányán.

### Minta Kód

Következik a kódbemutató a DGN PDF formátumba konvertálására/exportálására.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **DGN AutoCAD Formátum Raster Képformátumra Exportálása**

Az Aspose.CAD Java API bevezette a funkcionalitást egy [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD fájl betöltésére és raster kép formátumba való konvertálására. A [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) osztály szolgál erre a célra.

Meg kell tölteni egy meglévő DGN fájlt [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) néven. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és állítson be különböző tulajdonságokat. Hozzon létre egy példányt a [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) osztályból, és adja át a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) példányt. Most hívja meg a [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust a [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) osztály példányán.

### Minta Kód

Következik a kódbemutató a [DGN](https://docs.fileformat.com/cad/dgn/) [JPEG](https://docs.fileformat.com/image/jpeg/) képbe konvertálására/exportálására.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
