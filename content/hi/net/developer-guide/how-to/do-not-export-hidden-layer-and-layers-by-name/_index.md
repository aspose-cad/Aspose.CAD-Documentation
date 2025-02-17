---
title: छिपी हुई परत और परतों को नाम से निर्यात न करें
type: docs
weight: 26
url: /hi/net/developer-guide/how-to/do-not-export-hidden-layer-and-layers-by-name/
---

## **कैसे छिपी हुई परत और परतों को नाम से निर्यात न करें**

**समस्या:** छिपी हुई परत और परतों को नाम से निर्यात न करने का तरीका।

**सलाह:** इसके लिए, आपको उन परतों का एक एरे बनाना होगा जिनका नाम "LayerToHide" नहीं है और उन्हें rasterizationOptions.Layers में जोड़ना होगा।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "do-not-export-hidden-layer-and-layers-by-name.cs" >}}
