---
title: SHX फ़ॉन्ट का निर्यात
type: docs
weight: 40
url: /hi/java/developer-guide/export-shx-fonts/
---

## **DXF/DWG चित्रों के लिए SHX फ़ॉन्ट का निर्यात**

कुछ चित्रों में विशेष SHX प्रारूप में फ़ॉन्ट होते हैं, जो फ़ॉन्ट के प्रतीकों को आकारों के रूप में संग्रहीत करता है। 
इस प्रारूप के लिए चित्र में उपयोग किए गए प्रत्येक फ़ॉन्ट के लिए अतिरिक्त लोडिंग प्रक्रिया की आवश्यकता होती है। 
Apose.CAD SHX में लिखे गए पाठ के साथ चित्रों को निर्यात कर सकता है और यह करने के लिए विभिन्न विकल्प हैं। 
इसे करने का सबसे आसान तरीका [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) प्रॉपर्टी का उपयोग करना है [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ऑब्जेक्ट।	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

प्रत्येक SHX फ़ॉन्ट के साथ उचित कोडपेज होता है जो उससे संबंधित होता है। ये संघ पर्यटन ज्ञात हैं और ज्ञात SHX फ़ॉन्ट्स के लिए Aspose.CAD में आंशिक रूप से समायोजित हैं। 
यदि कोई कस्टम SHX फ़ॉन्ट का उपयोग किया जाता है तो **setShxCodePages** प्रॉपर्टी को लागू करना संभव है और SHX फ़ाइल के लिए पथ और संबंधित कोड पेज सेट करना संभव है।

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
