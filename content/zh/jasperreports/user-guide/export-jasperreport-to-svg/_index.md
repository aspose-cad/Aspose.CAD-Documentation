---
title: 将 JasperReport 导出为 SVG
type: docs
weight: 40
url: /zh/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports 提供了一个名为 ASSvgExporter 的类，用于将 JasperReport 导出为 SVG。

{{% /alert %}}

以下代码片段演示如何将 JasperReport 导出为 SVG。

**Java**

{{< highlight java >}}

ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true);
svgExportConfiguration.setCompress(true);

svgExporter.setConfiguration(svgExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

svgExporter.exportReport();

{{< /highlight >}}
