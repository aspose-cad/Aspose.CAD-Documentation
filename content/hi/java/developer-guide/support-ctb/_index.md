---
title: CTB फ़ाइलों का समर्थन
type: docs
weight: 40
url: /hi/java/developer-guide/support-ctb/
---

## **CTB फ़ाइलों का समर्थन**

कभी-कभी रंग, लाइनवेट और कुछ अन्य विकल्पों का उपयोग चित्रों के लिए केवल चित्रों से ही नहीं, बल्कि अलग CTB फ़ाइलों में प्लॉट शैलियों से भी किया जा सकता है। 
इस जानकारी का उपयोग करने का सबसे सरल तरीका यह है कि संबंधित CTB फ़ाइलों को DWG/DXF प्रारूप में चित्र के साथ फ़ाइल के पास रखा जाए और इनसे जानकारी स्वचालित रूप से निर्यात के दौरान लागू की जाएगी।

यह भी संभव है कि सभी CTB फ़ाइलों को स्ट्रीम के रूप में लोड किया जाए, 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) प्रॉपर्टी का उपयोग करते हुए 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ऑब्जेक्ट के।

यहाँ यह करने का उदाहरण है:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
