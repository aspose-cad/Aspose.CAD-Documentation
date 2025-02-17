---
title: हATCH के साथ पॉलिलाइनों के रूप में आयत कैसे बनाएं और इसे भरें
type: docs
weight: 24
url: /hi/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **हATCH के साथ पॉलिलाइनों के रूप में आयत कैसे बनाएं और इसे भरें**

**समस्या:** हATCH के साथ पॉलिलाइनों के रूप में आयत कैसे बनाएं (CADNET-1351)।

**सुझाव:** ऐसा करने के लिए, एक CadLwPolyline बनाएं और इसमें बिंदु समन्वय जोड़ें, रंग के साथ काम करने के लिए CadHatch का उपयोग करें और कनेक्ट करने के लिए CadEdgeBoundaryPath का उपयोग करें, कोणों के साथ काम करने के लिए CadHatch का उपयोग करें और पैटर्न के लिए CadHatchPatternData का उपयोग करें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
