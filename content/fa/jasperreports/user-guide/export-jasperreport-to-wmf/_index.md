---
title: صادرات JasperReport به WMF
type: docs
weight: 30
url: /fa/jasperreports/export-jasperreport-to-wmf
---

{{% alert color="primary" %}}

Aspose.CAD برای JasperReports یک کلاس به نام ASWmfExporter برای صادرات JasperReport به WMF ارائه می‌دهد.

{{% /alert %}}

کد زیر نشان می‌دهد که چگونه JasperReport را به WMF صادر کنیم.

**Java**

{{< highlight java >}}

// مثال 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
