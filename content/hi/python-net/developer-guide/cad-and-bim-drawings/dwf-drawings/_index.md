---
title: DWF चित्र
type: docs
weight: 50
url: /hi/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF चित्रों को PDF में निर्यात करना**

Aspose.CAD ऑटोकेड [DWF](https://docs.fileformat.com/cad/dwf/) चित्र संस्थाओं को लोड करने और उन्हें संपूर्ण चित्र के रूप में [PDF](https://docs.fileformat.com/pdf/) प्रारूप में रेंडर करने की सुविधा प्रदान करता है। [DWF](https://docs.fileformat.com/cad/dwf/) से [PDF](https://docs.fileformat.com/pdf/) में रूपांतरण का तरीका इस प्रकार है:

1. **Image.load** फैक्टरी विधि का उपयोग करके [DWF](https://docs.fileformat.com/cad/dwf/) चित्र फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **page_height** और **page_width** गुण सेट करें।
1. **PdfOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **vector_rasterization_options** गुण सेट करें।
1. दूसरे पैरामीटर के रूप में **PdfOptions** का एक ऑब्जेक्ट पास करते हुए **Image.save** को कॉल करें।

### नमूना कोड

नीचे दिया गया कोड नमूना यह दिखाता है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करते हुए एक फ़ाइल को कैसे रूपांतरित किया जाए।


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **DWF चित्रों को BMP में निर्यात करना**

Aspose.CAD ऑटोकेड [DWF](https://docs.fileformat.com/cad/dwf/) चित्र संस्थाओं को लोड करने और उन्हें संपूर्ण चित्र के रूप में [BMP](https://docs.fileformat.com/image/bmp/) प्रारूप में रेंडर करने की सुविधा प्रदान करता है। [DWF](https://docs.fileformat.com/cad/dwf/) से [BMP](https://docs.fileformat.com/image/bmp/) में रूपांतरण का तरीका इस प्रकार है:

1. **Image.load** फैक्टरी विधि का उपयोग करके [DWF](https://docs.fileformat.com/cad/dwf/) चित्र फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **page_height** और **page_width** गुण सेट करें।
1. **BmpOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **vector_rasterization_options** गुण सेट करें।
1. दूसरे पैरामीटर के रूप में **BmpOptions** का एक ऑब्जेक्ट पास करते हुए **Image.save** को कॉल करें।

### नमूना कोड

नीचे दिया गया कोड नमूना यह दर्शाता है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करते हुए एक [DWF](https://docs.fileformat.com/cad/dwf/) फ़ाइल को [BMP](https://docs.fileformat.com/image/bmp/) में कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
