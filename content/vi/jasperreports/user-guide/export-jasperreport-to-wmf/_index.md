---
title: Xuất JasperReport ra WMF
type: docs
weight: 30
url: /vi/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD cho JasperReports cung cấp một lớp có tên là ASWmfExporter để xuất JasperReport ra WMF.

{{% /alert %}}

Mã mẫu sau đây minh họa cách xuất JasperReport ra WMF.

**Java**

{{< highlight java >}}

// Ví dụ 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
