---
title: DWG में बैकग्राउंड के रूप में इमेज कैसे जोड़ें
type: docs
weight: 15
url: /hi/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **DWG में बैकग्राउंड के रूप में इमेज कैसे जोड़ें**

**समस्या:** DWG में बैकग्राउंड के रूप में इमेज कैसे जोड़ें।

**टिप्स:** ऐसा करने के लिए, बैकग्राउंड इमेज के लिए एक CadRasterImageDef ऑब्जेक्ट बनाएँ, ड्राइंग के लिए बैकग्राउंड लगाने के लिए एक CadRasterImage ऑब्जेक्ट बनाएँ, ड्रॉइंग ऑब्जेक्ट्स में एक CadRasterImage ऑब्जेक्ट जोड़ें, एक CadBaseObject CadBaseObject बनाएँ और इसे cadImage.Objects में जोड़ें, सभी को CadBlockTableObject के माध्यम से प्रोसेस करें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
