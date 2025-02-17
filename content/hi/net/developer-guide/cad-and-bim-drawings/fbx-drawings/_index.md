---
title: FBX चित्र
type: docs
weight: 70
url: /hi/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **PDF में FBX प्रारूप का निर्यात करना**

Aspose.CAD for .NET डेवलपर्स को [FBX](https://docs.fileformat.com/3d/fbx/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने की अनुमति देता है। [FBX](https://docs.fileformat.com/3d/fbx/) से [PDF](https://docs.fileformat.com/pdf/) परिवर्तन दृष्टिकोण इस प्रकार कार्य करता है:

1. [FBX](https://docs.fileformat.com/3d/fbx/) चित्र फ़ाइल को [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फ़ैक्ट्री विधि का उपयोग करके लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएँ और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) गुण सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) वर्ग का एक ऑब्जेक्ट बनाएँ और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें जबकि [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

## नमूना कोड

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
