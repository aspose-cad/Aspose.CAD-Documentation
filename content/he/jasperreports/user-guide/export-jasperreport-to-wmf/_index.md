---
title: ייצוא JasperReport ל-WMF
type: docs
weight: 30
url: /he/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports מספקת מחלקה בשם ASWmfExporter לצורך ייצוא JasperReport ל-WMF.

{{% /alert %}}

הקטע קוד הבא מדגים כיצד לייצא את JasperReport ל-WMF.

**Java**

{{< highlight java >}}

// דוגמה 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
