---
title: CAD ड्राइंग आकार को समायोजित करना
type: docs
weight: 10
url: /hi/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD के लिए Python लाइब्रेरी का उपयोग करके, डेवलपर्स कन्वर्ज़न के दौरान CAD ड्राइंग का आकार समायोजित कर सकते हैं। यह विषय स्वचालित या मैन्युअल रूप से **UnitType** एनम का उपयोग करके आकार को समायोजित करने के तरीके को समझाता है।

{{% /alert %}}

## **CAD ड्राइंग आकार को समायोजित करना**

Aspose.CAD के लिए Python ड्राइंग के आकार को CAD फॉर्मेट के कन्वर्ज़न के दौरान समायोजित करने के लिए **UnitType** एनम प्रदान करता है। ड्राइंग आकार को समायोजित करने के दो तरीके हैं।

1. स्वचालित आकार समायोजन।
2. **ImageOptions** क्लास के **UnitType** एनम का उपयोग करके आकार समायोजित करना।

स्वचालित रूप से आकार समायोजित करने के लिए, डेवलपर्स को **CadRasterizationOptions** क्लास की Width और Height प्रॉपर्टीज़ प्रदान करने की आवश्यकता नहीं है। नीचे दिया गया कोड स्निपेट स्वचालित आकार के उदाहरण के रूप में है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

**UnitType** एनम उस समय स्केलिंग समायोजित करने की क्षमता प्रदान करता है जब Width और Height प्रॉपर्टीज सेट नहीं की गई होती हैं। नीचे दिया गया कोड स्निपेट **UnitType** का उपयोग करने का तरीका प्रदर्शित करता है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
