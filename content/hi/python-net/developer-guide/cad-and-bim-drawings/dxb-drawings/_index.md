---
title: DXB चित्रण
type: docs
weight: 90
url: /hi/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB प्रारूप को PDF में निर्यात करना**

Aspose.CAD for Python डेवलपर्स को DXB फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने की अनुमति देता है। DXB से [PDF](https://docs.fileformat.com/pdf/) में रूपांतरण का दृष्टिकोण इस प्रकार है:

1. **Image.load** फैक्ट्री विधि का उपयोग करके DXB चित्रण फ़ाइल लोड करें।
1. **CadRasterizationOptions** क्लास का एक ऑब्जेक्ट बनाएं और **page_height** और **page_width** प्रॉपर्टीज सेट करें।
1. **PdfOptions** क्लास का एक ऑब्जेक्ट बनाएं और **vector_rasterization_options** प्रॉपर्टी सेट करें।
1. दूसरे पैरामीटर के रूप में **PdfOptions** का एक ऑब्जेक्ट पास करते हुए **Image.save** कॉल करें।

## नमूना कोड

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
