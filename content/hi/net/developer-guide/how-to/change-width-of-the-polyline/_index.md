---
title: पॉलीलाइन की चौड़ाई कैसे बदलें
type: docs
weight: 20
url: /hi/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **पॉलीलाइन की चौड़ाई कैसे बदलें**

**समस्या:** पॉलीलाइन की चौड़ाई कैसे बदलें (CADNET-459-460)।

**टिप्स:** CadBaseEntity में चौड़ाई बदलने के लिए (यदि प्रकार CadEntityTypeName.LWPOLYLINE है) का उपयोग करें (entity as CadLwPolyline).ConstantWidth = 2 या नियमित संस्थाओं के लिए LineWeight।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
