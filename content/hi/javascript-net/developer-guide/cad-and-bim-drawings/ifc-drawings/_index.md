---
title: IFC चित्रण 
type: docs
weight: 70
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/ifc-drawings/
---

## **PNG में FBX प्रारूप का निर्यात**

Angular में Aspose.CAD डेवलपर्स को [IFC](https://docs.fileformat.com/cad/ifc/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) प्रारूप में निर्यात करने की अनुमति देता है। 
[IFC](https://docs.fileformat.com/cad/ifc/) से [PNG](https://docs.fileformat.com/image/png/) में रूपांतरण का तरीका इस प्रकार कार्य करता है:

1. **Image.load** विधि का उपयोग करके [IFC](https://docs.fileformat.com/cad/ifc/) चित्रण फ़ाइल को लोड करें।
1. द्वितीय पैरामीटर के रूप में **PngOptions** का एक ऑब्जेक्ट पास करते समय **Image.save** का कॉल करें।

## नमूना कोड

नीचे दिया गया कोड दिखाता है कि Aspose.CAD for JavaScript का उपयोग करके समान लक्ष्य कैसे प्राप्त किया जाए।

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-IFC-to-PNG-Export.js" >}}
