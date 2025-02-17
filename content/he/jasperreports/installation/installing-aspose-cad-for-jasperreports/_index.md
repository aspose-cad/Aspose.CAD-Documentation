---
title: התקנת Aspose.CAD עבור JasperReports
type: docs
weight: 20
url: /he/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

כדי להשתמש ב**Aspose.CAD עבור JasperReports** מהיישום שלך, העתק את **aspose-cad-jasperreports-xx.x.jar** מתיקיית ה\lib של **aspose-cad-jasperreports-xx.x.zip** לתיקיית JasperReports\lib או לתיקיית ספריה של היישום שלך. לאחר מכן, תוכל לגשת לייצואנים בצורה תכנותית.

הדוגמה הבאה מראה את הקוד הטיפוסי הנדרש לייצוא דוח לקובץ TIFF באמצעות Aspose.CAD עבור JasperReports. דוגמאות נוספות ניתן למצוא בדוחות הדמו הכלולים בארכיון המוצר.

**Java**

{{< highlight java >}}
    ASTiffExporter tiffExporter = new ASTiffExporter();
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
    tiffExportConfiguration.setArtist("John Smith");
    tiffExportConfiguration.setDateTime("12.08.2020");
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
    tiffExporter.setConfiguration(tiffExportConfiguration);

    exporterInput = new ASExportInputImpl(jasperPrint);
    tiffExporter.setExporterInput(exporterInput);

    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
    tiffExporter.setExporterOutput(exporterOutput);

    tiffExporter.exportReport();
{{< /highlight >}}
