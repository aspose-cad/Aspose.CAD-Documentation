---
title: निर्दिष्ट आकार में DWG/DXF चित्र और लेआउट का निर्यात
type: docs
weight: 40
url: /hi/net/developer-guide/export-into-size/
---

## **A4 PDF आकार में मॉडल और सभी लेआउट का निर्यात**

Aspose.CAD API आपको DWG/DXF फ़ाइल के सभी शीट्स को निर्दिष्ट भौतिक PDF आकार में निर्यात करने की अनुमति देती है। 

निम्नलिखित सैंपल कोड [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) ऑब्जेक्ट के आकार की सेटिंग करता है ताकि इच्छित PDF आकार प्राप्त किया जा सके।
A4 पेपर शीट का आकार 210x297 मिमी या 8.27x11.69 इंच है और इन मानों का उपयोग कोड में किया गया है।

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **विभिन्न आकार में CAD लेआउट को PDF में निर्यात करें**

कभी-कभी लेआउट को इसके भौतिक आकार में निर्यात करना आवश्यक होता है। नीचे दिया गया उदाहरण ऐसे चित्र का निर्यात दर्शाता है जिसे बहुपृष्ठ PDF में निर्यात किया गया है जहां प्रत्येक पृष्ठ पर लेआउट सामग्री का अपना भौतिक PDF आकार है। यह उदाहरण [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/) प्रॉपर्टी का उपयोग करता है।

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
