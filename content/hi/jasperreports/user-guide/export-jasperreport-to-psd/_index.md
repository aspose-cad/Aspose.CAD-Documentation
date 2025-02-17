---
title: जैस्पर रिपोर्ट को PSD में निर्यात करें
type: docs
weight: 90
url: /hi/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports एक क्लास प्रदान करता है जिसे ASPsdExporter कहा जाता है जो जैस्पर रिपोर्ट को PSD में निर्यात करने के लिए है।

{{% /alert %}}

निम्नलिखित कोड स्निपेट दिखाता है कि जैस्पर रिपोर्ट को PSD में कैसे निर्यात किया जाए।

**जावा**

{{< highlight java >}}

ASPsdExporter psdExporter = new ASPsdExporter();
ASPsdExportConfigurationImpl psdExportConfiguration = new ASPsdExportConfigurationImpl();
psdExportConfiguration.setColorMode(ColorModesEnum.Rgb);
psdExportConfiguration.setPsdVersion(PsdVersionEnum.Psd);
psdExportConfiguration.setCompressionMethod(CompressionMethodEnum.Raw);
psdExporter.setConfiguration(psdExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
psdExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.psd");
psdExporter.setExporterOutput(exporterOutput);

psdExporter.exportReport();

{{< /highlight >}}
