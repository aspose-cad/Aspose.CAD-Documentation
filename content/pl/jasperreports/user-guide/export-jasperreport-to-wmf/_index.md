---
title: Eksportuj JasperReport do WMF
type: docs
weight: 30
url: /pl/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD dla JasperReports zapewnia klasę o nazwie ASWmfExporter do eksportowania JasperReport do WMF.

{{% /alert %}}

Poniższy fragment kodu pokazuje, jak eksportować JasperReport do WMF.

**Java**

{{< highlight java >}}

// Przykład 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
