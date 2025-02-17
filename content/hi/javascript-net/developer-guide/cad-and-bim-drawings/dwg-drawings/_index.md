---
title: DWG डिज़ाइन
type: docs
weight: 40
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG फ़ॉर्मेट को PNG में निर्यात करना**

Aspose.CAD के लिए Javascript Angular में डेवलपर्स को [DWG](https://docs.fileformat.com/cad/dwg/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) फ़ॉर्मेट में निर्यात करने की अनुमति देता है।
[DWG](https://docs.fileformat.com/cad/dwg/) से [PNG](https://docs.fileformat.com/image/png/) में रूपांतरण प्रक्रिया इस प्रकार कार्य करती है:

1. **Image.load** विधि का उपयोग करके [DWG](https://docs.fileformat.com/cad/dwg/) ड्राइंग फ़ाइल लोड करें।
1. दूसरे पैरामीटर के रूप में **PngOptions** की एक वस्तु पास करते हुए **Image.save** कॉल करें।

## नमूना कोड

नीचे दिया गया कोड दिखाता है कि Aspose.CAD के लिए JavaScript का उपयोग करके समान लक्ष्य कैसे प्राप्त किया जा सकता है

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWG-to-PNG-Export.js" >}}
