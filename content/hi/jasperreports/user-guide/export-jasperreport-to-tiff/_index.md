---
title: जैस्पर रिपोर्ट को TIFF में निर्यात करें
type: docs
weight: 100
url: /hi/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports TIFF में जैस्पर रिपोर्ट को निर्यात करने के लिए ASTiffExporter नामक एक वर्ग प्रदान करता है।

{{% /alert %}}

निम्नलिखित कोड स्निप्पेट दिखाता है कि जैस्पर रिपोर्ट को TIFF में कैसे निर्यात किया जाए।

**Java**

{{< highlight java >}}

ASTiffExporter tiffExporter = new ASTiffExporter();
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("John Smith");
tiffExportConfiguration.setDateTime("12.08.2020");
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

tiffExporter.exportReport();

{{< /highlight >}}
