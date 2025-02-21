---
title: Ekspor JasperReport ke SVG
type: docs
weight: 40
url: /id/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD untuk JasperReports menyediakan kelas bernama ASSvgExporter untuk mengekspor JasperReport ke SVG.

{{% /alert %}}

Potongan kode berikut menunjukkan cara mengekspor JasperReport ke SVG.

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
