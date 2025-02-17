---
title: Exportálás JasperReport WMF formátumba
type: docs
weight: 30
url: /hu/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Az Aspose.CAD for JasperReports egy ASWmfExporter nevű osztályt biztosít a JasperReport WMF formátumba történő exportálásához.

{{% /alert %}}

Az alábbi kódpélda bemutatja, hogyan lehet a JasperReportot WMF formátumba exportálni.

**Java**

{{< highlight java >}}

// Példa 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
