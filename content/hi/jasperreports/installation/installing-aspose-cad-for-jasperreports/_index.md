---
title: JasperReports के लिए Aspose.CAD स्थापित करना
type: docs
weight: 20
url: /hi/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

अपने एप्लिकेशन से **Aspose.CAD for JasperReports** का उपयोग करने के लिए, **aspose-cad-jasperreports-xx.x.jar** फ़ाइल को **aspose-cad-jasperreports-xx.x.zip** के \lib फ़ोल्डर से JasperReports\lib निर्देशिका या आपके एप्लिकेशन के किसी लाइब्रेरी फ़ोल्डर में कॉपी करें। इसके बाद, आप प्रोग्रामेटिक रूप से निर्यातकों का उपयोग कर सकते हैं।

निम्नलिखित उदाहरण दर्शाता है कि Aspose.CAD for JasperReports का उपयोग करके एक रिपोर्ट को TIFF फ़ाइल में निर्यात करने के लिए आवश्यक सामान्य कोड क्या है। उत्पाद संग्रह में शामिल डेमो रिपोर्ट में अधिक उदाहरण मिल सकते हैं।

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
