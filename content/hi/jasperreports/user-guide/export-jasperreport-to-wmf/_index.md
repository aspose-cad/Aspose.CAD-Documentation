---
title: जैस्पर रिपोर्ट को WMF में निर्यात करें
type: docs
weight: 30
url: /hi/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports एक क्लास प्रदान करता है जिसका नाम ASWmfExporter है, जो जैस्पर रिपोर्ट को WMF में निर्यात करने के लिए है।

{{% /alert %}}

निम्नलिखित कोड स्निपेट यह दर्शाता है कि जैस्पर रिपोर्ट को WMF में कैसे निर्यात किया जाए।

**जावा**

{{< highlight java >}}

// उदाहरण 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
