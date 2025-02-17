---
title: जैस्पररिपोर्ट को एसवीजी में निर्यात करें
type: docs
weight: 40
url: /hi/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports एसवीजी में जैस्पररिपोर्ट निर्यात करने के लिए ASSvgExporter नामक एक क्लास प्रदान करता है।

{{% /alert %}}

निम्नलिखित कोड स्निपेट दर्शाता है कि जैस्पररिपोर्ट को एसवीजी में कैसे निर्यात करें।

**जावा**

{{< highlight java >}}

ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true);
svgExportConfiguration.setCompress(true);

svgExporter.setConfiguration(svgExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

svgExporter.exportReport();

{{< /highlight >}}
