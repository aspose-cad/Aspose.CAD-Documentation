---
title: Εξαγωγή JasperReport σε TIFF
type: docs
weight: 100
url: /el/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Το Aspose.CAD για JasperReports παρέχει μια κλάση που ονομάζεται ASTiffExporter για την εξαγωγή του JasperReport σε TIFF.

{{% /alert %}}

Το παρακάτω απόσπασμα κώδικα δείχνει πώς να εξάγετε το JasperReport σε TIFF.

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
