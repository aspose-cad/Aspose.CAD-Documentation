---
title: JasperReport'u WMF'ye Dışa Aktarma
type: docs
weight: 30
url: /tr/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports, JasperReport'u WMF'ye dışa aktarmak için ASWmfExporter adlı bir sınıf sağlar.

{{% /alert %}}

Aşağıdaki kod parçası, JasperReport'u WMF'ye dışa aktarmanın nasıl yapılacağını gösterir.

**Java**

{{< highlight java >}}

// Örnek 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
