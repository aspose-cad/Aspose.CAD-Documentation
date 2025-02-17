---
title: DGN ड्राइंग
type: docs
weight: 10
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/dgn-drawing/
---

## **DGN फॉर्मेट को PNG में निर्यात करना**

Aspose.CAD for Javascript in Angular विकासकर्ताओं को एक [DGN](https://docs.fileformat.com/cad/dgn/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) फ़ॉर्मेट में निर्यात करने की अनुमति देता है। 
[DGN](https://docs.fileformat.com/cad/dgn/) से [PNG](https://docs.fileformat.com/image/png/) में रूपांतरण दृष्टिकोण इस प्रकार कार्य करता है:

1. **Image.load** विधि का उपयोग करके [DGN](https://docs.fileformat.com/cad/dgn/) ड्राइंग फ़ाइल लोड करें।
2. **PngOptions** का एक ऑब्जेक्ट पास करते समय **Image.save** को कॉल करें।

## उदाहरण कोड

नीचे दिया गया कोड दिखाता है कि Aspose.CAD for JavaScript का उपयोग करके समान लक्ष्य कैसे प्राप्त किया जाए।

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DGN-to-PNG-Export.js" >}}
