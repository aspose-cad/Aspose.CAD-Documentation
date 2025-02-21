---
title: ส่งออก JasperReport เป็น SVG
type: docs
weight: 40
url: /th/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD สำหรับ JasperReports มีคลาสชื่อ ASSvgExporter สำหรับการส่งออก JasperReport เป็น SVG

{{% /alert %}}

โค้ดตัวอย่างต่อไปนี้จะแสดงวิธีการส่งออก JasperReport เป็น SVG

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
