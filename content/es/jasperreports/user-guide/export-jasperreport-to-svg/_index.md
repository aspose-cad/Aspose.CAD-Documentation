---
title: Exportar JasperReport a SVG
type: docs
weight: 40
url: /es/jasperreports/export-jasperreport-to-svg
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports proporciona una clase llamada ASSvgExporter para exportar JasperReport a SVG.

{{% /alert %}}

El siguiente fragmento de código demuestra cómo exportar el JasperReport a SVG.

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
