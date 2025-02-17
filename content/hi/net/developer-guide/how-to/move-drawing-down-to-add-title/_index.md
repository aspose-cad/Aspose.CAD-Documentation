---
title: शीर्षक जोड़ने के लिए चित्रण को नीचे ले जाना
type: docs
weight: 40
url: /hi/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **शीर्षक जोड़ने के लिए चित्रण को नीचे कैसे ले जाना है**

**समस्या:** शीर्षक जोड़ने के लिए चित्रण को नीचे कैसे ले जाना है (CADNET-980)।

**युक्तियाँ:** ऐसा करने के लिए, पैरामीटर के साथ एक CadText ऑब्जेक्ट बनाएं, इस ब्लॉक को चित्रण में जोड़ें, फिर UpdateSize के साथ नए आयामों के साथ चित्रण को अपडेट करें, चित्रण के चारों ओर एक फ्रेम के रूप में एक पॉलीलाइन जोड़ें, पॉलीलाइन को BlockEntities["*Model_Space"] में जोड़ें और एक बार फिर UpdateSize के साथ अपडेट करें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
