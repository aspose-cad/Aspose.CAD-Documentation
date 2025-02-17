---
title: ऑटो कोडपेज पहचान
type: docs
weight: 10
url: /hi/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **ऑटो कोडपेज पहचान**

Aspose.CAD [DWG](https://docs.fileformat.com/cad/dwg/) और [DWF](https://docs.fileformat.com/cad/dwf/) फाइलों के लिए ऑटो कोडपेज पहचान का समर्थन करता है। यदि आप इस सुविधा का उपयोग नहीं करना चाहते हैं, तो आप [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) क्लास की निम्नलिखित प्रॉपर्टी को सेट करके इसे अधिलेखित कर सकते हैं।

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): गैर-यूनिकोड DXF और DWG प्रारूपों से टेक्स्ट डेटा पढ़ने के लिए उपयोग की जाने वाली एन्कोडिंग सेट करता है। यह डिफ़ॉल्ट रूप से ऑटो-डिटेक्ट किया जाता है।
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): CJK एन्कोडिंग (M+nXXXX प्रारूप) के MIF-कोडित प्रतीकों को पढ़ने के लिए उपयोग की जाने वाली एन्कोडिंग सेट करता है। यह डिफ़ॉल्ट रूप से ऑटो-डिटेक्ट किया जाता है।
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): परिभाषित करता है कि क्या CIF (U+XXXX) और MIF-कोडित कैरेक्टर को डिकोड किया जाएगा यदि उनके पास उचित AutoCAD प्रारूपण नहीं है (AutoCAD इन प्रतीकों को एक बैकस्लैश के साथ पूर्वाधिकारित करता है)। डिफ़ॉल्ट रूप से, इन्हें डिकोड किया जाता है।

## नमूना कोड

नीचे दिया गया कोड नमूना दिखाता है कि Aspose.CAD में ऑटो कोडपेज पहचान को कैसे अधिलेखित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
