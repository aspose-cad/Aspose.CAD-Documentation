---
title: Експорт JasperReport до SVG
type: docs
weight: 40
url: /uk/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD для JasperReports надає клас ASSvgExporter для експорту JasperReport до SVG.

{{% /alert %}}

Наступний код демонструє, як експортувати JasperReport до SVG.

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
