---
title: जैस्पर रिपोर्ट को JPEG2000 में निर्यात करें
type: docs
weight: 80
url: /hi/jasperreports/user-guide/export-jasperreport-to-jpeg2000/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports एक वर्ग प्रदान करता है जिसका नाम ASJpeg2000Exporter है, जिसका उपयोग जैस्पर रिपोर्ट को JPEG2000 में निर्यात करने के लिए किया जाता है।

{{% /alert %}}

निम्नलिखित कोड स्निप्पेट दिखाता है कि जैस्पर रिपोर्ट को JPEG2000 में कैसे निर्यात करें।

**Java**

{{< highlight java >}}

ASJpeg2000Exporter jpeg2000Exporter = new ASJpeg2000Exporter();
ASJpeg2000ExportConfigurationImpl jpeg2000ExportConfiguration = new ASJpeg2000ExportConfigurationImpl();
jpeg2000ExportConfiguration.setIrreversible(true);
jpeg2000ExportConfiguration.setCodec(Jpeg2000CodecEnum.J2K);
jpeg2000Exporter.setConfiguration(jpeg2000ExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
jpeg2000Exporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.jp2");
jpeg2000Exporter.setExporterOutput(exporterOutput);

jpeg2000Exporter.exportReport();

{{< /highlight >}}
