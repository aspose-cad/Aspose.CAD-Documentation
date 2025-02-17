---
title: COLLADA चित्रण
type: docs
weight: 20
url: /hi/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA प्रारूप को PDF में निर्यात करना**

Aspose.CAD for Python डेवलपर्स को [COLLADA](https://docs.fileformat.com/3d/dae/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) फ़ॉर्मेट में निर्यात करने की अनुमति देता है। [COLLADA](https://docs.fileformat.com/3d/dae/) से [PDF](https://docs.fileformat.com/pdf/) रूपांतरण दृष्टिकोण इस प्रकार कार्य करता है:

1. **Image.load** फैक्टरी विधि का उपयोग करके [COLLADA](https://docs.fileformat.com/3d/dae/) चित्रण फ़ाइल लोड करें।
2. **CadRasterizationOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **page_height** और **page_width** गुण सेट करें।
3. **PdfOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **vector_rasterization_options** गुण सेट करें।
4. **Image.save** को कॉल करें और दूसरे पैरामीटर के रूप में **PdfOptions** का एक ऑब्जेक्ट पास करें।

## नमूना कोड

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
