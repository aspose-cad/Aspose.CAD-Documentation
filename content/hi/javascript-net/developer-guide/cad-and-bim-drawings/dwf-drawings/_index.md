---
title: DWF चित्रण
type: docs
weight: 20
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **PNG में DWF प्रारूप का निर्यात**

Aspose.CAD के लिए Javascript में Angular डेवलपर्स को [DWF](https://docs.fileformat.com/cad/dwf/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) प्रारूप में निर्यात करने की अनुमति देता है।
[DWF](https://docs.fileformat.com/cad/dwf/) से [PNG](https://docs.fileformat.com/image/png/) में रूपांतरण का दृष्टिकोण इस प्रकार है:

1. **Image.load** विधि का प्रयोग करते हुए [DWF](https://docs.fileformat.com/cad/dwf/) चित्रण फ़ाइल लोड करें।
1. **PngOptions** के एक ऑब्जेक्ट को दूसरे पैरामीटर के रूप में पास करते हुए **Image.save** को कॉल करें।

## नमूना कोड

नीचे दिया गया कोड दिखाता है कि Aspose.CAD के लिए JavaScript का उपयोग करके समान लक्ष्य कैसे प्राप्त किया जाए।

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWF-to-PNG-Export.js" >}}
