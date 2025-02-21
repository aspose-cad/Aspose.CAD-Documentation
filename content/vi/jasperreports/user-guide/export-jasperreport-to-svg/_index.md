---
title: Xuất JasperReport thành SVG
type: docs
weight: 40
url: /vi/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD cho JasperReports cung cấp một lớp có tên là ASSvgExporter để xuất JasperReport thành SVG.

{{% /alert %}}

Đoạn mã sau đây minh họa cách xuất JasperReport thành SVG.

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
