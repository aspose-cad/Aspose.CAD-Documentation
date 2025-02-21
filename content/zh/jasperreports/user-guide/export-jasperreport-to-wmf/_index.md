---
title: 导出 JasperReport 到 WMF
type: docs
weight: 30
url: /zh/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports 提供了一个名为 ASWmfExporter 的类，用于将 JasperReport 导出到 WMF。

{{% /alert %}}

以下代码片段演示了如何将 JasperReport 导出到 WMF。

**Java**

{{< highlight java >}}

// 示例 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
