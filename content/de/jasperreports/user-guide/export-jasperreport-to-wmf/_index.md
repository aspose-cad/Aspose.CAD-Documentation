---
title: JasperReport nach WMF exportieren
type: docs
weight: 30
url: /de/jasperreports/export-jasperreport-to-wmf
---

{{% alert color="primary" %}}

Aspose.CAD für JasperReports bietet eine Klasse namens ASWmfExporter zum Exportieren von JasperReport nach WMF.

{{% /alert %}}

Der folgende Code-Ausschnitt zeigt, wie der JasperReport nach WMF exportiert wird.

**Java**

{{< highlight java >}}

// Beispiel 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
