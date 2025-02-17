---
title: DXF के अंदर DXF/DWG चित्र कैसे डालें
type: docs
weight: 39
url: /hi/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **DXF के अंदर DXF/DWG चित्र कैसे डालें**

**समस्या:** DXF के अंदर DXF/DWG चित्र कैसे डालें।

**सुझाव:** ऐसा करने के लिए, पहले आपको आवश्यक मानों के साथ एक CadInsertObject बनाना होगा, फिर CadBlockDictionary में सभी ब्लॉकों को प्राप्त करें, एक नया CadBlockEntity ब्लॉक बनाएँ और इसे CadBlockDictionary में जोड़ें, CadBlockDictionary को चित्र के BlockEntities में जोड़ें, चित्र के रूपों में एक CadInsertObject जोड़ें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
