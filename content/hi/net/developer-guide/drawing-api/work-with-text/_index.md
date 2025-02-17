---
title: पाठ के साथ कार्य करें
type: docs
weight: 40
url: /hi/net/developer-guide/drawing-api/work-with-text/
---

## **पाठ के साथ कार्य करें**

लगभग सभी चित्रों में पाठ वस्तुएं होती हैं और इन उदाहरणों में दिखाया गया है कि उनके साथ ऑपरेशन कैसे किए जाते हैं। 
DWG/DXF के लिए विभिन्न प्रकार की संस्थाएं हैं जो पाठ को संग्रहीत कर सकती हैं, वे हैं [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib। अंतिम दो प्रकार आमतौर पर 
[**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/) से संबंधित होते हैं
और इसके अंदर या संबंधित ब्लॉक में संग्रहीत होते हैं।

यहां पाठ के साथ संचालन का वर्णन करने वाले कुछ उदाहरण हैं।

### **पाठ खोजें**

यह उदाहरण दिखाता है कि DWG/DXF फ़ाइल में पाठ मानों को कैसे ढूंढा जाता है और इसका उपयोग पाठ मानों को बदलने के लिए भी किया जा सकता है।

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **नए पाठ और MText आइटम जोड़ना**

यहां नया पाठ/Mtext वस्तुएं चित्र में जोड़ने का उदाहरण है। नई संस्थाओं का जोड़ने से चित्र का आकार बदल सकता है, इसलिए इन ऑपरेशनों के बाद UpdateSize() कॉल करने की सलाह दी जाती है।

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
