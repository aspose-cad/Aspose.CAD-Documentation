---
title: Export JasperReport to WMF
type: docs
weight: 30
url: /jasperreports/export-jasperreport-to-wmf
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports provides a class named ASWmfExporter for exporting JasperReport to WMF.

{{% /alert %}}

The following code snippet demonstrates how to export the JasperReport to WMF.

**Java**

{{< highlight java >}}

// Example 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
