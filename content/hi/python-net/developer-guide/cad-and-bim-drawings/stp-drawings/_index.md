---
title: STP चित्र
type: docs
weight: 160
url: /hi/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP प्रारूप को PDF में निर्यात करना**

Aspose.CAD फॉर पायथन डेवलपर्स को [STP](https://docs.fileformat.com/3d/stp/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने की अनुमति देता है। [STP](https://docs.fileformat.com/3d/stp/) से [PDF](https://docs.fileformat.com/pdf/) में परिवर्तन का तरीका निम्नलिखित है:

1. **Image.load** फैक्टरी विधि का उपयोग कर [STP](https://docs.fileformat.com/3d/stp/) चित्र फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **page_height** & **page_width** प्रॉपर्टीज़ सेट करें।
1. **PdfOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **vector_rasterization_options** प्रॉपर्टी सेट करें।
1. **PdfOptions** का एक ऑब्जेक्ट पास करते हुए **Image.save** कॉल करें।

## नमूना कोड

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
