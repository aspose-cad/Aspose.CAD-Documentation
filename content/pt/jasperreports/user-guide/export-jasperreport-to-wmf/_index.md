---
title: Exportar JasperReport para WMF
type: docs
weight: 30
url: /pt/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports fornece uma classe chamada ASWmfExporter para exportar JasperReport para WMF.

{{% /alert %}}

O seguinte trecho de código demonstra como exportar o JasperReport para WMF.

**Java**

{{< highlight java >}}

// Exemplo 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
