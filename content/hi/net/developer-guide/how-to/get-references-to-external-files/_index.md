---
title: बाहरी फ़ाइलों के लिए संदर्भ प्राप्त करना
type: docs
weight: 36
url: /hi/net/developer-guide/how-to/get-references-to-external-files/
---

## **बाहरी फ़ाइलों के लिए संदर्भ कैसे प्राप्त करें**

**समस्या:** बाहरी फ़ाइलों के लिए संदर्भ कैसे प्राप्त करें (CADNET-110)।

**टिप्स:** एंटिटी ब्लॉक में चित्रों के लिए बाहरी फ़ाइलों के संदर्भ प्राप्त करने के लिए, रास्टर चित्रों के लिए XRef PathName फ़ील्ड का उपयोग किया जाता है। CadRasterImage Def बाहरी अंडरलै का उपयोग करता है और CadDgnUnderlay का उपयोग किया जाता है और इसका UnderlayPath फ़ील्ड।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
