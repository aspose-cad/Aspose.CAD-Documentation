---
title: SHX फोंट निर्यात करना
type: docs
weight: 40
url: /hi/net/developer-guide/export-shx-fonts/
---

## **DXF/DWG ड्रॉइंग के लिए SHX फोंट निर्यात करना**

कुछ ड्रॉइंग में विशेष SHX प्रारूप में फोंट हो सकते हैं, जो फोंट के प्रतीकों को आकारों के रूप में संग्रहीत करते हैं। इस प्रारूप के लिए प्रत्येक फोंट के लिए अतिरिक्त लोडिंग प्रक्रिया की आवश्यकता होती है। Apose.CAD उन ड्रॉइंग का निर्यात कर सकता है जिनमें SHX में लिखित टेक्स्ट होता है और इसे करने के लिए विभिन्न विकल्प हैं। इसे करने का सबसे सरल तरीका है 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) प्रॉपर्टी का उपयोग करना 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) ऑब्जेक्ट का।


{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


अनेक SHX फोंट के लिए सभी पथ सेट करने से बचने के लिए निम्नलिखित उदाहरण का उपयोग किया जा सकता है:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
प्रत्येक SHX फोंट के साथ उचित कोडपेज जुड़ा होता है। ये संघटन ज्ञात हैं और ज्ञात SHX फोंट के लिए Aspose.CAD में आंशिक रूप से एम्बेड किए गए हैं। 
यदि कोई कस्टम SHX फोंट का उपयोग किया जाता है तो ShxCodePages प्रॉपर्टी को लागू करना संभव है और SHX फ़ाइल और संबंधित कोड पृष्ठ के लिए पथ स्थापित करना संभव है। 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
