---
title: ऑटो कोडपेज पहचान
type: docs
weight: 10
url: /hi/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **ऑटो कोडपेज पहचान**

Aspose.CAD DWG और DWF फ़ाइलों के लिए ऑटो कोडपेज पहचान का समर्थन करता है। यदि आप इस सुविधा का उपयोग नहीं करना चाहते हैं, तो आप [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) क्लास की निम्नलिखित प्रॉपर्टीज़ सेट करके इसे ओवरराइड कर सकते हैं।

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): गैर-यूनिकोड DXF और DWG प्रारूपों से टेक्स्ट डेटा पढ़ने के लिए उपयोग की जाने वाली एन्कोडिंग सेट करता है। इसे डिफ़ॉल्ट रूप से ऑटो-डिटेक्ट किया जाता है।
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): CJK एन्कोडिंग के MIF-एन्कोडेड प्रतीकों को पढ़ने के लिए उपयोग की जाने वाली एन्कोडिंग सेट करता है (M+nXXXX प्रारूप)। इसे डिफ़ॉल्ट रूप से ऑटो-डिटेक्ट किया जाता है।
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): यह परिभाषित करता है कि क्या CIF (U+XXXX) और MIF-एन्कोडेड पात्रों को डिकोड किया जाएगा यदि इनमें उचित AutoCAD प्रारूपण नहीं है (AutoCAD इन प्रतीकों को बैक-स्लैश के साथ प्रारंभ करता है)। डिफ़ॉल्ट रूप से, इन्हें डिकोड किया जाता है।

## नमूना कोड

नीचे दिया गया कोड नमूना दिखाता है कि Aspose.CAD में ऑटो कोडपेज पहचान को कैसे ओवरराइड करना है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
