---
title: تصدير JasperReport إلى TIFF
type: docs
weight: 100
url: /ar/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

توفر Aspose.CAD لـ JasperReports فئة باسم ASTiffExporter لتصدير JasperReport إلى TIFF.

{{% /alert %}}

تظهر مقتطفات الكود التالية كيفية تصدير JasperReport إلى TIFF.

**Java**

{{< highlight java >}}

ASTiffExporter tiffExporter = new ASTiffExporter();
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("جون سميث");
tiffExportConfiguration.setDateTime("12.08.2020");
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

tiffExporter.exportReport();

{{< /highlight >}}
