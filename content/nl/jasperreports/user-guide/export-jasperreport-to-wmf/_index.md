---
title: Exporteer JasperReport naar WMF
type: docs
weight: 30
url: /nl/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD voor JasperReports biedt een klasse genaamd ASWmfExporter voor het exporteren van JasperReport naar WMF.

{{% /alert %}}

De volgende codefragment toont aan hoe je de JasperReport naar WMF kunt exporteren.

**Java**

{{< highlight java >}}

// Voorbeeld 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
