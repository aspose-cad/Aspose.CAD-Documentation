---
title: Exportar JasperReport a WMF
type: docs
weight: 30
url: /es/jasperreports/export-jasperreport-to-wmf
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports proporciona una clase llamada ASWmfExporter para exportar JasperReport a WMF.

{{% /alert %}}

El siguiente fragmento de código demuestra cómo exportar el JasperReport a WMF.

**Java**

{{< highlight java >}}

// Ejemplo 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
