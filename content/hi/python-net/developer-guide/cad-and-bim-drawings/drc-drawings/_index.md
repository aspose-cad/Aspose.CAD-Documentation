---
title: DRC चित्र
type: docs
weight: 40
url: /hi/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC फ़ॉर्मेट को PDF में निर्यात करना**

Aspose.CAD for Python डेवलपर्स को [DRC](https://docs.fileformat.com/3d/drc/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) फ़ॉर्मेट में निर्यात करने की अनुमति देता है। [DRC](https://docs.fileformat.com/3d/drc/) से [PDF](https://docs.fileformat.com/pdf/) में रूपांतरण का तरीका इस प्रकार है:

1. **Image.load** फ़ैक्ट्री विधि का उपयोग करके DRC चित्र फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **page_height** & **page_width** गुण सेट करें।
1. **PdfOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **VectorRasterizationOptions** गुण सेट करें।
1. **PdfOptions** का एक ऑब्जेक्ट को दूसरे पैरामीटर के रूप में पास करते हुए **Image.save** कॉल करें।

## नमूना कोड


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
