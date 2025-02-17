---
title: DGN चित्रण
type: docs
weight: 10
url: /hi/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **DWG का हिस्सा के रूप में DGN प्रारूप का चित्रण**

Aspose.CAD for Java डेवलपर्स को एक DWG फ़ाइल को अंतर्निहित DGN अंडरलै के साथ निर्यात करने की अनुमति देता है। निम्नलिखित कोड DWG फ़ाइल निर्यात करते समय DWG फ़ाइल के अंदर DGN अंडरलै तक पहुँचने का प्रदर्शन करता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **DGN v7 के लिए 3D तत्वों का समर्थन**

Aspose.CAD for Java API ने DGN AutoCAD फ़ाइल को लोड करने की कार्यक्षमता और DGN v7 के लिए 3D तत्वों का समर्थन पेश किया है। [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) वर्ग इसका उद्देश्य पूरा करता है। प्रत्येक DGN छवि 9 पूर्वनिर्धारित दृश्य का समर्थन करती है। यह 1 से 9 के बीच नमांकित होता है। यदि निर्यात पर दृश्य परिभाषित नहीं किया गया है, तो बहु-पृष्ठ आउटपुट प्रारूपों (जैसे PDF) के लिए सभी दृश्य निर्यात किए जाएंगे, प्रत्येक एक अलग पृष्ठ पर। DGN फ़ाइल प्रारूप पर 3D तत्वों का समर्थन किया गया है, साथ ही 2D का भी।
VectorRasterizationOptions.TypeOfEntities अब DGN प्रारूप के लिए उपयोग नहीं किया जाता है (दोनों 2D और 3D को एक साथ समर्थन किया गया है)।

समर्थित DGN तत्वों को देखने के लिए नमूना कोड।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
