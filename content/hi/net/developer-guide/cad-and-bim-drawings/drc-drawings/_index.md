---
title: DRC चित्र
type: docs
weight: 15
url: /hi/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC चित्रों का PDF में निर्यात**

Aspose.CAD ऑटोकैड [DRC](https://docs.fileformat.com/3d/drc/) ड्राइंग इकाइयों को लोड करने और उन्हें पूरी ड्राइंग के रूप में [PDF](https://docs.fileformat.com/pdf/) प्रारूप में रेंडर करने की सुविधा प्रदान करता है। [DRC](https://docs.fileformat.com/3d/drc/) से [PDF](https://docs.fileformat.com/pdf/) में रूपांतरण का दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फ़ैक्टरी विधि का उपयोग करके [DRC](https://docs.fileformat.com/3d/drc/) ड्राइंग फ़ाइल को लोड करें।
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) गुण सेट करें।
3. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) गुण सेट करें।
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

### उदाहरण कोड

निम्नलिखित कोड उदाहरण दिखाता है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करके एक फ़ाइल को कैसे परिवर्तित किया जाए।


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
