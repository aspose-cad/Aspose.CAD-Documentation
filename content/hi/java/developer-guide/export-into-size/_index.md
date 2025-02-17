---
title: DWG/DXF ड्राइंग और लेआउट को निर्दिष्ट आकार में निर्यात करना
type: docs
weight: 40
url: /hi/java/developer-guide/export-into-size/
---

## **A4 PDF आकार में मॉडल और सभी लेआउट का निर्यात करें**

Aspose.CAD API आपको DWG/DXF फ़ाइल के सभी शीट्स को निर्दिष्ट भौतिक PDF आकार में निर्यात करने की अनुमति देता है।
निम्नलिखित नमूना कोड [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) ऑब्जेक्ट के आकार को सेट करता है ताकि वांछित PDF आकार प्राप्त किया जा सके।
A4 पेपर शीट का आकार 210x297 मिलीमीटर या 8.27x11.69 इंच है और इन मानों का उपयोग कोड में किया गया है।

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **विभिन्न आकार में PDF में CAD लेआउट का निर्यात करें**

कभी-कभी लेआउट को इसके भौतिक आकार में निर्यात करना आवश्यक होता है। नीचे दिया गया उदाहरण उस ड्राइंग का निर्यात दर्शाता है जो मल्टीपेज PDF में है जहां प्रत्येक पृष्ठ में लेआउट सामग्री
अपना भौतिक PDF आकार है। यह उदाहरण [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) प्रॉपर्टी का उपयोग करता है।

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
