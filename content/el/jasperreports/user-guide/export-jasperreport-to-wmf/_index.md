---
title: Εξαγωγή JasperReport σε WMF
type: docs
weight: 30
url: /el/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Το Aspose.CAD για JasperReports παρέχει μια κλάση που ονομάζεται ASWmfExporter για την εξαγωγή του JasperReport σε WMF.

{{% /alert %}}

Το ακόλουθο κομμάτι κώδικα δείχνει πώς να εξαγάγετε τον JasperReport σε WMF.

**Java**

{{< highlight java >}}

// Παράδειγμα 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
