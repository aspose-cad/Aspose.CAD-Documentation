---
title: تصدير JasperReport إلى SVG
type: docs
weight: 40
url: /ar/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

يوفر Aspose.CAD لـ JasperReports فئة تسمى ASSvgExporter لتصدير JasperReport إلى SVG.

{{% /alert %}}

يوضح المقتطف التالي من الشيفرة كيفية تصدير JasperReport إلى SVG.

**Java**

{{< highlight java >}}

ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true); // يمكنك دمج الخطوط
svgExportConfiguration.setCompress(true); // يمكنك الضغط

svgExporter.setConfiguration(svgExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

svgExporter.exportReport();

{{< /highlight >}}
