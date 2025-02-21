---
title: JasperReportをWMFにエクスポート
type: docs
weight: 30
url: /ja/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReportsは、JasperReportをWMFにエクスポートするためのASWmfExporterというクラスを提供します。

{{% /alert %}}

次のコードスニペットは、JasperReportをWMFにエクスポートする方法を示します。

**Java**

{{< highlight java >}}

// 例 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
