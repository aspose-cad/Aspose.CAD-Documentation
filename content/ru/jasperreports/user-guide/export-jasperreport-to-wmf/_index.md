---
title: Экспорт JasperReport в WMF
type: docs
weight: 30
url: /ru/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD для JasperReports предоставляет класс под названием ASWmfExporter для экспорта JasperReport в WMF.

{{% /alert %}}

Следующий фрагмент кода демонстрирует, как экспортировать JasperReport в WMF.

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
