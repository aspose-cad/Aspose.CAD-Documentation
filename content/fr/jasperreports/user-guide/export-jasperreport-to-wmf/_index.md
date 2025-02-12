---
title: Exporter JasperReport vers WMF
type: docs
weight: 30
url: /fr/jasperreports/export-jasperreport-to-wmf
---

{{% alert color="primary" %}}

Aspose.CAD pour JasperReports fournit une classe nommée ASWmfExporter pour exporter JasperReport vers WMF.

{{% /alert %}}

Le code suivant démontre comment exporter le JasperReport vers WMF.

**Java**

{{< highlight java >}}

// Exemple 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
