---
title: SVG चित्रण
type: docs
weight: 170
url: /hi/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG स्वरूप को PDF में निर्यात करना**

Aspose.CAD for Python डेवलपर्स को [SVG](https://docs.fileformat.com/page-description-language/svg/) फ़ाइल को [PDF](https://docs.fileformat.com/pdf/) स्वरूप में निर्यात करने की अनुमति देता है। [SVG](https://docs.fileformat.com/page-description-language/svg/) से [PDF](https://docs.fileformat.com/pdf/) परिवर्तन दृष्टिकोण इस प्रकार काम करता है:

1. **Image.load** फ़ैक्टरी विधि का उपयोग करके SVG चित्रण फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक वस्तु बनाएं और **page_height** और **page_width** गुण सेट करें।
1. **PdfOptions** वर्ग का एक वस्तु बनाएं और **VectorRasterizationOptions** गुण सेट करें।
1. दूसरे पैरामीटर के रूप में **PdfOptions** का एक वस्तु पास करते हुए **Image.save** को कॉल करें।

## उदाहरण कोड

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
