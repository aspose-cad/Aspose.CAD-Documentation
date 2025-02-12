---
title: Exportovat JasperReport do formátu TIFF
type: docs
weight: 100
url: /cs/jasperreports/export-jasperreport-to-tiff
---

{{% alert color="primary" %}}

Aspose.CAD pro JasperReports poskytuje třídu jménem ASTiffExporter pro exportování JasperReportu do formátu TIFF.

{{% /alert %}}

Následující část kódu demonstruje, jak exportovat JasperReport do formátu TIFF.

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
