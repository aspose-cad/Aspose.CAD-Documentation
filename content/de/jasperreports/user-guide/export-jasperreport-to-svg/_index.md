---
title: JasperReport nach SVG exportieren
type: docs
weight: 40
url: /de/jasperreports/export-jasperreport-to-svg
---

{{% alert color="primary" %}}

Aspose.CAD für JasperReports bietet eine Klasse namens ASSvgExporter zum Exportieren von JasperReport nach SVG.

{{% /alert %}}

Der folgende Codeabschnitt zeigt, wie der JasperReport nach SVG exportiert wird.

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
