---
title: ส่งออก JasperReport เป็น WMF
type: docs
weight: 30
url: /th/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD สำหรับ JasperReports มีคลาสชื่อ ASWmfExporter สำหรับการส่งออก JasperReport ไปยัง WMF

{{% /alert %}}

โค้ดตัวอย่างต่อไปนี้แสดงวิธีการส่งออก JasperReport ไปยัง WMF

**Java**

{{< highlight java >}}

// ตัวอย่างที่ 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
