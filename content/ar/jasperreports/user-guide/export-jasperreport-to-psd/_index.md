---
title: تصدير JasperReport إلى PSD
type: docs
weight: 90
url: /ar/jasperreports/export-jasperreport-to-psd
---

{{% alert color="primary" %}}

تقدم Aspose.CAD لـ JasperReports فئة تُدعى ASPsdExporter لتصدير JasperReport إلى PSD.

{{% /alert %}}

توضح مقتطفات الكود التالية كيفية تصدير JasperReport إلى PSD.

**Java**

{{< highlight java >}}

ASPsdExporter psdExporter = new ASPsdExporter();
ASPsdExportConfigurationImpl psdExportConfiguration = new ASPsdExportConfigurationImpl();
psdExportConfiguration.setColorMode(ColorModesEnum.Rgb);
psdExportConfiguration.setPsdVersion(PsdVersionEnum.Psd);
psdExportConfiguration.setCompressionMethod(CompressionMethodEnum.Raw);
psdExporter.setConfiguration(psdExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
psdExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.psd");
psdExporter.setExporterOutput(exporterOutput);

psdExporter.exportReport();

{{< /highlight >}}