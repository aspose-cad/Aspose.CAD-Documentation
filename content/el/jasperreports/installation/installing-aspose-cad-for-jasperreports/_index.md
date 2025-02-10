---
title: Εγκατάσταση Aspose.CAD για JasperReports
type: docs
weight: 20
url: /el/jasperreports/installing-aspose-cad-for-jasperreports/
---

Για να χρησιμοποιήσετε το **Aspose.CAD για JasperReports** από την εφαρμογή σας, αντιγράψτε το **aspose-cad-jasperreports-xx.x.jar** από τον φάκελο \lib του **aspose-cad-jasperreports-xx.x.zip** στο φάκελο lib του JasperReports ή σε έναν φάκελο βιβλιοθήκης της εφαρμογής σας. Αφού το κάνετε αυτό, μπορείτε να αποκτήσετε πρόσβαση στους εξαγωγείς προγραμματιστικά.

Το παρακάτω παράδειγμα δείχνει τον τυπικό κώδικα που απαιτείται για να εξάγετε μια αναφορά σε αρχείο TIFF χρησιμοποιώντας το Aspose.CAD για JasperReports. Περισσότερα παραδείγματα μπορείτε να βρείτε στις διοικητικές αναφορές που περιλαμβάνονται στο αρχείο προϊόντος.

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
