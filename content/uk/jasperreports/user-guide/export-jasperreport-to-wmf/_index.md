---
title: Експорт JasperReport до WMF
type: docs
weight: 30
url: /uk/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD для JasperReports надає клас під назвою ASWmfExporter для експорту JasperReport до WMF.

{{% /alert %}}

Наступний фрагмент коду демонструє, як експортувати JasperReport до WMF.

**Java**

{{< highlight java >}}

// Приклад 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
