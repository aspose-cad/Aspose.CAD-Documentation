---
title: DWG के अंदर DXF/DWG चित्र को सम्मिलित करें
type: docs
weight: 38
url: /hi/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **DWG के अंदर DXF/DWG चित्र को कैसे सम्मिलित करें**

**समस्या:** DWG के अंदर DXF/DWG चित्र को कैसे सम्मिलित करें।

**टिप्स:** इसके लिए, पहले आवश्यक मानों के साथ एक CadInsertObject बनाएँ, फिर CadBlockDictionary में सभी ब्लॉकों को प्राप्त करें, एक नया CadBlockEntity ब्लॉक बनाएँ और उसे CadBlockDictionary में जोड़ें, चित्र के BlockEntities में एक CadBlockDictionary जोड़ें, सन्निहित सूची के लिए चित्र वस्तु में CadInsertObject जोड़ें, संदर्भ द्वारा एक CadBlockTableObject बनाएँ, फिर चित्र में एक ब्लॉक जोड़ें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
