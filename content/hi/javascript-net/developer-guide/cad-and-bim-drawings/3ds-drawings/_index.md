---
title: 3डीएस चित्रण
type: docs
weight: 70
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **PNG में 3DS प्रारूप का निर्यात**

Aspose.CAD for Javascript in Angular डेवलपर्स को [3DS](https://docs.fileformat.com/3d/3ds/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) प्रारूप में निर्यात करने की अनुमति देता है। [3DS](https://docs.fileformat.com/3d/3ds/) से [PNG](https://docs.fileformat.com/image/png/) में रूपांतरण का तरीका निम्नलिखित है:

1. **Image.load** विधि का उपयोग करके [3DS](https://docs.fileformat.com/3d/3ds/) चित्रण फ़ाइल लोड करें।
1. दूसरे पैरामीटर के रूप में **PngOptions** का एक ऑब्जेक्ट पारित करते समय **Image.save** का कॉल करें।

## नमूना कोड

नीचे दिए गए कोड में दिखाया गया है कि Aspose.CAD for JavaScript का उपयोग करके समान लक्ष्य को कैसे प्राप्त किया जाए

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-3DS-to-PNG-Export.js" >}}
