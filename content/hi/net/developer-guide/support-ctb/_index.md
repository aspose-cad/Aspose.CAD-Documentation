---
title: CTB फ़ाइलों का समर्थन
type: docs
weight: 40
url: /hi/net/developer-guide/support-ctb/
---

## **CTB फ़ाइलों का समर्थन**

कभी-कभी रंग, लाइनवेट और ड्रॉइंग के लिए कुछ अन्य विकल्प केवल ड्रॉइंग से ही नहीं बल्कि अलग CTB फ़ाइलों में प्लॉट शैली से भी उपयोग किए जा सकते हैं। 
इस जानकारी का उपयोग करने का सबसे सरल तरीका है कि CTB फ़ाइलों को DWG/DXF प्रारूप में ड्रॉइंग वाली फ़ाइल के पास रखा जाए और उन फ़ाइलों से जानकारी को निर्यात के दौरान 
स्वचालित रूप से लागू किया जाएगा।

यह सभी CTB फ़ाइलों को स्ट्रीम के रूप में लोड करना भी संभव है 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) संपत्ति का उपयोग करके 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) वस्तु की।

यहां यह कैसे किया जाए इसका एक उदाहरण है:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
