---
title: Exportování DGN AutoCAD
type: docs
weight: 50
url: /cs/exportovani-dgn-autocad/
---

## **Exportování formátu DGN AutoCAD do PDF**

Aspose.CAD pro Java API představil funkčnost načtení souboru [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD a jeho konverzi do formátu [PDF](https://docs.fileformat.com/pdf/). Třída [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) slouží k tomuto účelu.

Je třeba načíst existující soubor DGN jako [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte různé vlastnosti. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) a předejte instanci [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Nyní zavolejte metodu [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) instance třídy [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Ukázkový kód

Následuje ukázkové zobrazení kódu pro konverzi/export DGN do formátu PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Exportování formátu DGN AutoCAD do formátu rastrového obrázku**

Aspose.CAD pro Java API představil funkčnost načtení souboru DGN AutoCAD a jeho konverzi do rastrového obrázku. Třída [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) slouží k tomuto účelu.

Je třeba načíst existující soubor DGN jako [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte různé vlastnosti. Vytvořte instanci třídy [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) a předejte instanci [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Nyní zavolejte metodu [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) instance třídy [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Ukázkový kód

Následuje ukázkové zobrazení kódu pro konverzi/export DGN do obrázku [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
