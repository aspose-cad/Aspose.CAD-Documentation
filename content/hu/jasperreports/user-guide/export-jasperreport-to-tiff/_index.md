---
title: Exportálás JasperReport TIFF-be
type: docs
weight: 100
url: /hu/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Az Aspose.CAD JasperReports-hez biztosít egy ASTiffExporter osztályt a JasperReport TIFF-be való exportálásához.

{{% /alert %}}

Az alábbi kódrészlet bemutatja, hogyan lehet a JasperReportot TIFF-be exportálni.

**Java**

{{< highlight java >}}

ASTiffExporter tiffExporter = new ASTiffExporter();
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("John Smith");
tiffExportConfiguration.setDateTime("2020.08.12.");
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

tiffExporter.exportReport();

{{< /highlight >}}
