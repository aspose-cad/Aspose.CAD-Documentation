---
title: Exportera JasperReport till TIFF
type: docs
weight: 100
url: /sv/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD för JasperReports erbjuder en klass som heter ASTiffExporter för att exportera JasperReport till TIFF.

{{% /alert %}}

Följande kodexempel visar hur man exporterar JasperReport till TIFF.

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
