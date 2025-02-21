---
title: Xuất JasperReport sang TIFF
type: docs
weight: 100
url: /vi/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD cho JasperReports cung cấp một lớp có tên là ASTiffExporter để xuất JasperReport sang TIFF.

{{% /alert %}}

Đoạn mã sau đây mô tả cách xuất JasperReport sang TIFF.

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
