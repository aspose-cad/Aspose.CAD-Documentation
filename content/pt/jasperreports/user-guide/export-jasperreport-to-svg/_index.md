---
title: Exportar JasperReport para SVG
type: docs
weight: 40
url: /pt/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports fornece uma classe chamada ASSvgExporter para exportar JasperReport para SVG.

{{% /alert %}}

O seguinte trecho de código demonstra como exportar o JasperReport para SVG.

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
