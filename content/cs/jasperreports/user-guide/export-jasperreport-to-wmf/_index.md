---
title: Export JasperReport do formátu WMF
type: docs
weight: 30
url: /cs/jasperreports/export-jasperreport-to-wmf
---

{{% alert color="primary" %}}

Aspose.CAD pro JasperReports poskytuje třídu nazvanou ASWmfExporter pro export JasperReport do formátu WMF.

{{% /alert %}}

Následující část kódu ukazuje, jak exportovat JasperReport do formátu WMF.

**Java**

{{< highlight java >}}

// Příklad 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
