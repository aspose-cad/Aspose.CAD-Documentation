---
title: Esportazione del formato DGN AutoCAD
type: docs
weight: 50
url: /it/java/developer-guide/exporting-dgn-autocad/
---

## **Esportazione del formato DGN AutoCAD in PDF**

Aspose.CAD per Java API ha introdotto la funzionalità per caricare un file [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD e convertirlo nel formato [PDF](https://docs.fileformat.com/pdf/). La classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) serve a questo scopo.

Devi caricare un file DGN esistente come [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e imposta diverse proprietà. Crea un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) e passa l'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Ora chiama il metodo [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) dell'istanza della classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Codice di esempio

Di seguito è riportata la dimostrazione del codice per convertire/esportare DGN in formato PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Esportazione del formato DGN AutoCAD in formato immagine raster**

Aspose.CAD per Java API ha introdotto la funzionalità per caricare un file [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD e convertirlo in un'immagine raster. La classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) serve a questo scopo.

Devi caricare un file DGN esistente come [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e imposta diverse proprietà. Crea un'istanza della classe [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) e passa l'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Ora chiama il metodo [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) dell'istanza della classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Codice di esempio

Di seguito è riportata la dimostrazione del codice per convertire/esportare [DGN](https://docs.fileformat.com/cad/dgn/) in immagine [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
