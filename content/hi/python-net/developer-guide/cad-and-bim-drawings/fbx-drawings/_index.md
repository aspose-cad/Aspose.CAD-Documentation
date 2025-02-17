---
title: FBX चित्रण
type: docs
weight: 110
url: /hi/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX प्रारूप को PDF में निर्यात करना**

Aspose.CAD for Python डेवलपर्स को [FBX](https://docs.fileformat.com/3d/fbx/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने की अनुमति देता है। [FBX](https://docs.fileformat.com/3d/fbx/) से [PDF](https://docs.fileformat.com/pdf/) रूपांतरण दृष्टिकोण इस प्रकार काम करता है:

1. **Image.load** फ़ैक्टरी विधि का उपयोग करके [FBX](https://docs.fileformat.com/3d/fbx/) चित्रण फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक ऑब्जेक्ट बनाएँ और **PageHeight** और **PageWidth** गुण सेट करें।
1. **PdfOptions** वर्ग का एक ऑब्जेक्ट बनाएँ और **vector_rasterization_options** गुण सेट करें।
1. दूसरे पैरामीटर के रूप में **PdfOptions** का एक ऑब्जेक्ट पास करते हुए **Image.save** कॉल करें।

## नमूना कोड

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
