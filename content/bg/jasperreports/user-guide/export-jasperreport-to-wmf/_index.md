---
title: Експорт на JasperReport в WMF
type: docs
weight: 30
url: /bg/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD за JasperReports предоставя клас с име ASWmfExporter за експортиране на JasperReport в WMF.

{{% /alert %}}

Следният кодов фрагмент демонстрира как да се експортира JasperReport в WMF.

**Java**

{{< highlight java >}}

// Пример 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
