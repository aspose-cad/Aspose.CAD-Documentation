---
title: صادرات JasperReport به SVG
type: docs
weight: 40
url: /fa/jasperreports/export-jasperreport-to-svg
---

{{% alert color="primary" %}}

Aspose.CAD برای JasperReports کلاسی به نام ASSvgExporter برای صادرات JasperReport به SVG ارائه می‌دهد.

{{% /alert %}}

کد زیر نشان می‌دهد که چگونه JasperReport را به SVG صادر کنیم.

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
