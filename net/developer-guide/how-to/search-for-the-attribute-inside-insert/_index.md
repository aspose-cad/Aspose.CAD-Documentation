---
title: Search for the attribute inside insert
type: docs
weight: 44
url: /net/how-to/search-for-the-attribute-inside-insert/
---

## **How to search for an attribute inside insert**

**Issue:** How to search for an attribute inside insert (CADNET-8050).

**Tips:** To do this, get an entity with the type CadEntityTypeName.ATTDEF and in it a PromptString field with the value "StringToSearch".

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}