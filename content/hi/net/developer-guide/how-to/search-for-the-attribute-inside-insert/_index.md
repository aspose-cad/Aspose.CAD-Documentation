---
title: Insert के अंदर विशेषता की खोज कैसे करें
type: docs
weight: 44
url: /hi/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Insert के अंदर विशेषता की खोज कैसे करें**

**समस्या:** Insert के अंदर विशेषता की खोज कैसे करें (CADNET-8050)।

**टिप्स:** इसके लिए, CadEntityTypeName.ATTDEF प्रकार के साथ एक इकाई प्राप्त करें और इसमें "StringToSearch" मान के साथ एक PromptString फ़ील्ड हो।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
