---
title: कैड ड्राइंग आकार को समायोजित करना
type: docs
weight: 10
url: /hi/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for Java का उपयोग करते हुए, डेवलपर्स कैड प्रारूप के रूपांतरण के दौरान ड्राइंग के आकार को समायोजित कर सकते हैं। यह विषय स्वचालित समायोजन या [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) एनम के उपयोग से आकार समायोजित करने के तरीके को स्पष्ट करता है। 

{{% /alert %}}

## **कैड ड्राइंग आकार को समायोजित करना**

Aspose.CAD for Java कैड प्रारूप के रूपांतरण के दौरान ड्राइंग के आकार को समायोजित करने के लिए [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) एनम प्रदान करता है। ड्राइंग के आकार को समायोजित करने के दो तरीके हैं।

1. स्वचालित आकार समायोजित करना
1. [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) क्लास के [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) एनम का उपयोग करके आकार समायोजित करना

स्वचालित रूप से आकार समायोजित करने के लिए, डेवलपर्स को [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास के चौड़ाई और ऊँचाई गुण प्रदान करने की आवश्यकता नहीं है। नीचे दिया गया कोड स्निपेट स्वचालित आकार प्रदान करने का एक उदाहरण है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) एनम को चौड़ाई और ऊँचाई गुण सेट न होने पर स्केलिंग समायोजित करने की क्षमता देता है। नीचे दिया गया कोड स्निपेट दिखाता है कि [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) का उपयोग कैसे किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
