---
title: STP चित्र
type: docs
weight: 70
url: /hi/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **PDF के लिए STP प्रारूप का निर्यात करना**

Aspose.CAD for .NET डेवलपर्स को [STP](https://docs.fileformat.com/3d/stp/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने की अनुमति देता है। [STP](https://docs.fileformat.com/3d/stp/) से [PDF](https://docs.fileformat.com/pdf/) में रूपांतरण का तरीका इस प्रकार है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फैक्टरी विधि का उपयोग करके [STP](https://docs.fileformat.com/3d/stp/) चित्र फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) कक्षा का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) गुण सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) कक्षा का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) गुण सेट करें।
1. दूसरे पैरामीटर के रूप में [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट पास करते हुए [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें।

## नमूना कोड

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
