---
title: DWFx चित्रण
type: docs
weight: 30
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/dwfx-drawing/
---

## **DWFX प्रारूप को PNG में निर्यात करना**

Angular में Aspose.CAD डेवलपर्स को [DWFX](https://docs.fileformat.com/cad/dwfx/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) प्रारूप में निर्यात करने की अनुमति देता है।
[DWFX](https://docs.fileformat.com/cad/dwfx/) से [PNG](https://docs.fileformat.com/image/png/) परिवर्तन विधि इस प्रकार कार्य करती है:

1. **Image.load** विधि का उपयोग करके [DWFX](https://docs.fileformat.com/cad/dwfx/) चित्रण फ़ाइल को लोड करें।
1. **PngOptions** का एक ऑब्जेक्ट पास करते हुए **Image.save** को कॉल करें।

## नमूना कोड

नीचे दिया गया कोड दिखाता है कि Aspose.CAD for JavaScript का उपयोग करके समान लक्ष्य कैसे प्राप्त किया जाए

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWFX-to-PNG-Export.js" >}}
