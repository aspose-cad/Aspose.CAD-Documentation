---
title: ऑटो कोडपेज डिटेक्शन
type: docs
weight: 10
url: /hi/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **ऑटो कोडपेज डिटेक्शन**

Aspose.CAD DWG और DWF फ़ाइलों के लिए ऑटो कोडपेज डिटेक्शन का समर्थन करता है। यदि आप इस फ़ीचर का उपयोग नहीं करना चाहते हैं, तो आप **LoadOptions** क्लास की निम्नलिखित प्रॉपर्टीज़ सेट करके इसे ओवरराइड कर सकते हैं।

- **specified_encoding**: गैर-यूनिकोड DXF और DWG प्रारूपों से टेक्स्ट डेटा पढ़ने के लिए उपयोग की जाने वाली इनकोडिंग सेट करता है। यह स्वचालित रूप से पहचान लिया जाता है।
- **specified_mif_encoding**: CJK इनकोडिंग (M+nXXXX प्रारूप) के MIF-encoded प्रतीकों को पढ़ने के लिए उपयोग की जाने वाली इनकोडिंग सेट करता है। यह स्वचालित रूप से पहचान लिया जाता है।
- **recover_malformed_cif_mif**: यह निर्धारित करता है कि यदि CIF (U+XXXX) और MIF-encoded वर्णों का उचित AutoCAD फॉर्मेटिंग नहीं है (AutoCAD इन प्रतीकों के पहले बैकस्लैश लगाता है) तो क्या उन्हें डिकोड किया जाएगा। डिफ़ॉल्ट रूप से, इन्हें डिकोड किया जाता है।

## उदहारण कोड

नीचे दिया गया कोड उदाहरण दिखाता है कि Aspose.CAD में ऑटो कोडपेज डिटेक्शन को कैसे ओवरराइड किया जाता है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
