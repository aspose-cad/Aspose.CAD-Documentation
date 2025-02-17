---
title: CAD ड्राइंग आकार समायोजन
type: docs
weight: 10
url: /hi/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for .NET पुस्तकालय का उपयोग करके, डेवलपर्स CAD ड्राइंग के आकार को किसी भी समर्थित प्रारूप में रूपांतरण के दौरान समायोजित कर सकते हैं। यह विषय स्वचालित या मैन्युअल रूप से आकार समायोजित करने के तरीके की व्याख्या करता है जिसका उपयोग [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) एनम के माध्यम से किया जा सकता है जो [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) वर्ग का है।

{{% /alert %}}

## **CAD ड्राइंग का आकार समायोजन**

Aspose.CAD for .NET CAD प्रारूप के रूपांतरण के दौरान ड्राइंग के आकार को समायोजित करने के लिए [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) एनम प्रदान करता है। ड्राइंग के आकार को समायोजित करने के लिए दो तरीके हैं।

1. स्वचालित आकार समायोजन।
1. [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) वर्ग के [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) एनम का उपयोग करके आकार समायोजित करें।

स्वचालित रूप से आकार समायोजित करने के लिए, डेवलपर्स को [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) वर्ग के चौड़ाई और ऊँचाई प्रॉपर्टीज प्रदान करने की आवश्यकता नहीं है। नीचे दिया गया कोड स्निपेट स्वचालित आकार का एक उदाहरण है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) एनम इस क्षमता को प्रदान करता है कि चौड़ाई और ऊँचाई प्रॉपर्टीज सेट न होने पर स्केलिंग को समायोजित किया जा सके। नीचे दिया गया कोड स्निपेट दर्शाता है कि [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) का उपयोग कैसे करें।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
