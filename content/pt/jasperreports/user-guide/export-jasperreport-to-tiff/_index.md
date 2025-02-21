---
title: Exportar JasperReport para TIFF
type: docs
weight: 100
url: /pt/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports fornece uma classe chamada ASTiffExporter para exportar JasperReport para TIFF.

{{% /alert %}}

O seguinte trecho de código demonstra como exportar o JasperReport para TIFF.

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
