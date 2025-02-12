---
title: Exporter JasperReport vers SVG
type: docs
weight: 40
url: /fr/jasperreports/export-jasperreport-to-svg
---

{{% alert color="primary" %}}

Aspose.CAD pour JasperReports fournit une classe nommée ASSvgExporter pour exporter JasperReport vers SVG.

{{% /alert %}}

Le code suivant montre comment exporter JasperReport vers SVG.

**Java**

{{< highlight java >}}

ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true); // Intégrer les polices
svgExportConfiguration.setCompress(true); // Compresser

svgExporter.setConfiguration(svgExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

svgExporter.exportReport();

{{< /highlight >}}
