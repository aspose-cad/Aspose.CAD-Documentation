---
title: SVG चित्रण
type: docs
weight: 70
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG फॉर्मेट को PNG में निर्यात करना**

Aspose.CAD for Javascript in Angular डेवलपर्स को [SVG](https://docs.fileformat.com/page-description-language/svg/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) फ़ॉर्मेट में निर्यात करने की अनुमति देता है।
[SVG](https://docs.fileformat.com/page-description-language/svg/) से [PNG](https://docs.fileformat.com/image/png/) में रूपांतरण का तरीका इस तरह से काम करता है:

1. **Image.load** विधि का उपयोग करके [SVG](https://docs.fileformat.com/page-description-language/svg/) चित्रण फ़ाइल लोड करें।
1. दूसरे पैरामीटर के रूप में **PngOptions** की एक वस्तु पारित करते समय **Image.save** को कॉल करें।

## उदाहरण कोड

नीचे दिया गया कोड Aspose.CAD for JavaScript का उपयोग करके उसी लक्ष्य को प्राप्त करने का तरीका दर्शाता है।

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
