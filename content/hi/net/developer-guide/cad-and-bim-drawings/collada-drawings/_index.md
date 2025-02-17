---
title: COLLADA ड्रॉइंग
type: docs
weight: 70
url: /hi/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA प्रारूप को PDF में निर्यात करना**

Aspose.CAD for .NET डेवलपर्स को [COLLADA](https://docs.fileformat.com/3d/dae/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने की अनुमति देता है। [COLLADA](https://docs.fileformat.com/3d/dae/) से [PDF](https://docs.fileformat.com/pdf/) में रूपांतरण दृष्टिकोण इस प्रकार कार्य करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फैक्ट्री विधि का उपयोग करके [COLLADA](https://docs.fileformat.com/3d/dae/) ड्राइंग फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) क्लास का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) प्रॉपर्टीज़ सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) क्लास का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) प्रॉपर्टी सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट द्वितीय पैरामीटर के रूप में पास करें।

## नमूना कोड

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
