---
title: تصدير JasperReport إلى WMF
type: docs
weight: 30
url: /ar/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

تقدم Aspose.CAD لـ JasperReports فئة تُسمى ASWmfExporter لتصدير JasperReport إلى WMF.

{{% /alert %}}

توضح مقطع الشيفرة التالية كيف يتم تصدير JasperReport إلى WMF.

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
