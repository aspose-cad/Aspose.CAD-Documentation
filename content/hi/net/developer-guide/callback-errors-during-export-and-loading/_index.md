---
title: निर्यात और लोड के दौरान कॉलबैक त्रुटियाँ
type: docs
weight: 40
url: /hi/net/developer-guide/callback-errors-during-export-and-loading/
---

## **निर्यात और लोड के दौरान कॉलबैक त्रुटियों की समीक्षा**

यह संभव है कि निर्यात या चित्र के लोड के दौरान हमें फ़ाइल की संरचना से संबंधित त्रुटियाँ सामने आ सकती हैं 
(जैसे, फ़ाइल में अनुभाग अब आवश्यक हैं लेकिन पहले नहीं थे)। 
इनमें से कुछ महत्वपूर्ण हैं और ऐसे मामलों में अपवाद उठाया जाता है, लेकिन हम इनमें से कुछ को आंतरिक रूप से नजरअंदाज भी कर सकते हैं और कॉलबैक संदेशों का उपयोग करके इसके बारे में सूचित कर सकते हैं।
वैसे भी, ये सभी संदेश ध्यान देने की आवश्यकता हैं क्योंकि वे निर्यात परिणामों में अनुपस्थित संस्थाओं या अन्य प्रभावों को स्पष्ट कर सकते हैं।

### **निर्यात के दौरान त्रुटियाँ**

[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) में एक RenderResult फ़ील्ड है,
जिसमें IsRenderComplete होता है ताकि यह पता लगाया जा सके कि निर्यात के दौरान त्रुटियाँ थीं या नहीं और उनके बारे में जानकारी प्रिंट की जा सके:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **लोड के दौरान त्रुटियाँ**

चित्रों के साथ कुछ समस्याएँ निर्यात प्रक्रिया शुरू होने से पहले देखी जा सकती हैं। 
[**त्रुटियाँ**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) प्रॉपर्टी
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) ऑब्जेक्ट में उनके बारे में संदेशों को संग्रहीत करने के लिए उपयोग की जाती है।
[**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) प्रॉपर्टी यह तय करने के लिए उपयोगी है कि
क्या लोड त्रुटियों पर अपवाद उठाना आवश्यक है या नहीं। 

यहाँ Errors प्रॉपर्टी के उपयोग का एक उदाहरण है:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
