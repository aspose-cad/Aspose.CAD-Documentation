---
title: IGES डिज़ाइन
type: docs
weight: 80
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/iges-drawings/
---

## **IGES फॉर्मेट को PNG में निर्यात करना**

Aspose.CAD for Javascript in Angular डेवलपर्स को [IGES](https://docs.fileformat.com/cad/iges/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) फ़ॉर्मेट में निर्यात करने की अनुमति देता है। 
[IGES](https://docs.fileformat.com/cad/iges/) से [PNG](https://docs.fileformat.com/image/png/) रूपांतरण का दृष्टिकोण इस प्रकार कार्य करता है:

1. **Image.load** विधि का उपयोग करते हुए [IGES](https://docs.fileformat.com/cad/iges/) चित्र फ़ाइल लोड करें।
1. **PngOptions** का एक ऑब्जेक्ट को दूसरे पैरामीटर के रूप में पास करते हुए **Image.save** का कॉल करें।

## नमूना कोड

नीचे दिया गया कोड Aspose.CAD for JavaScript का उपयोग करके उसी लक्ष्य को प्राप्त करने का तरीका दिखाता है।

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-IGES-to-PNG-Export.js" >}}
