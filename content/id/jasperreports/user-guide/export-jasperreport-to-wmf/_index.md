---
title: Ekspor JasperReport ke WMF
type: docs
weight: 30
url: /id/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD untuk JasperReports menyediakan kelas bernama ASWmfExporter untuk mengekspor JasperReport ke WMF.

{{% /alert %}}

Potongan kode berikut menunjukkan cara mengekspor JasperReport ke WMF.

**Java**

{{< highlight java >}}

// Contoh 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
