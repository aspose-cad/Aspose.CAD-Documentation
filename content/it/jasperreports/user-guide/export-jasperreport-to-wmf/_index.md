---
title: Esportare JasperReport in WMF
type: docs
weight: 30
url: /it/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD per JasperReports fornisce una classe chiamata ASWmfExporter per esportare JasperReport in WMF.

{{% /alert %}}

Il seguente frammento di codice dimostra come esportare il JasperReport in WMF.

**Java**

{{< highlight java >}}

// Esempio 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
