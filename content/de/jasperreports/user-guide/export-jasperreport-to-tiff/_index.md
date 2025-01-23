---
title: JasperReport in TIFF exportieren
type: docs
weight: 100
url: /de/jasperreports/export-jasperreport-to-tiff
---

{{% alert color="primary" %}}

Aspose.CAD für JasperReports bietet eine Klasse namens ASTiffExporter zum Exportieren von JasperReport nach TIFF.

{{% /alert %}}

Das folgende Code-Snippet zeigt, wie der JasperReport nach TIFF exportiert wird.

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
