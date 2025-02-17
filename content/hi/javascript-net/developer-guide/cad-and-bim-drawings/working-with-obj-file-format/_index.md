---
title: OBJ फ़ाइल प्रारूप के साथ काम करना
type: docs
weight: 120
url: /hi/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD अब OBJ फ़ाइल प्रारूप का समर्थन करता है। OBJ फ़ाइल प्रारूप 3D ज्यामिति है जिसमें टेक्स्चर मैप, 3D निर्देशांक, बहुभुज चेहरे और अन्य वस्तु जानकारी शामिल होती है।

{{% /alert %}}

## **OBJ प्रारूप को PNG में निर्यात करना**

Angular में Aspose.CAD डेवलपर्स को [OBJ](https://docs.fileformat.com/3d/obj/) फ़ाइल को [PNG](https://docs.fileformat.com/image/png/) प्रारूप में निर्यात करने की अनुमति देता है।
[OBJ](https://docs.fileformat.com/3d/obj/) से [PNG](https://docs.fileformat.com/image/png/) में रूपांतरण दृष्टिकोण इस प्रकार कार्य करता है:

1. **Image.load** विधि का उपयोग करके [OBJ](https://docs.fileformat.com/3d/obj/) ड्राइंग फ़ाइल लोड करें।
1. **PngOptions** के एक ऑब्जेक्ट को दूसरे पैरामीटर के रूप में पास करते हुए **Image.save** कॉल करें।

## नमूना कोड

नीचे दिया गया कोड Aspose.CAD for JavaScript का उपयोग करके समान लक्ष्य प्राप्त करने का तरीका दर्शाता है।

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
