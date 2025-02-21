---
title: Exportera JasperReport till WMF
type: docs
weight: 30
url: /sv/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD för JasperReports tillhandahåller en klass som heter ASWmfExporter för att exportera JasperReport till WMF.

{{% /alert %}}

Följande kodexempel visar hur man exporterar JasperReport till WMF.

**Java**

{{< highlight java >}}

// Exempel 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
