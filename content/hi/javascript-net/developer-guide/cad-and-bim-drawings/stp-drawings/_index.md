---
title: STP चित्रण 
type: docs
weight: 70
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP प्रारूप को PNG में निर्यात करना**

Angular में Aspose.CAD जावास्क्रिप्ट के लिए डेवलपर्स को [STP](https://docs.fileformat.com/3d/stp/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) प्रारूप में निर्यात करने की अनुमति देता है। [STP](https://docs.fileformat.com/3d/stp/) से [PNG](https://docs.fileformat.com/image/png/) रूपांतरण का दृष्टिकोण इस प्रकार काम करता है:

1. **Image.load** विधि का उपयोग करके [STP](https://docs.fileformat.com/3d/stp/) चित्रण फ़ाइल लोड करें।
1. **PngOptions** का एक ऑब्जेक्ट पास करते समय **Image.save** को कॉल करें।

## नमूना कोड

नीचे दिया गया कोड Aspose.CAD का उपयोग करके उसी लक्ष्य को प्राप्त करने का तरीका दिखाता है जावास्क्रिप्ट के लिए

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-STP-to-PNG-Export.js" >}}
