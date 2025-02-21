---
title: Esportare JasperReport in TIFF
type: docs
weight: 100
url: /it/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD per JasperReports fornisce una classe chiamata ASTiffExporter per esportare JasperReport in TIFF.

{{% /alert %}}

Il seguente frammento di codice dimostra come esportare JasperReport in TIFF.

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
