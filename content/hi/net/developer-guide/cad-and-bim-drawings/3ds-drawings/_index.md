---
title: 3DS रेखाचित्र
type: docs
weight: 70
url: /hi/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **3DS प्रारूप को PDF में निर्यात करना**

Aspose.CAD for .NET डेवलपर्स को [3DS](https://docs.fileformat.com/3d/3ds/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने की अनुमति देता है। [3DS](https://docs.fileformat.com/3d/3ds/) से [PDF](https://docs.fileformat.com/pdf/) में रूपांतरण की प्रक्रिया निम्नलिखित प्रकार से काम करती है:

1. [3DS](https://docs.fileformat.com/3d/3ds/) रेखाचित्र फ़ाइल को [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फ़ैक्टरी विधि का उपयोग करके लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) गुण सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

## उदाहरण कोड

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
