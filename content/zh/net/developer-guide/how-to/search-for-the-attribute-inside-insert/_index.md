---
title: 在插入内部搜索属性
type: docs
weight: 44
url: /zh/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **如何在插入内部搜索属性**

**问题：** 如何在插入内部搜索属性 (CADNET-8050)。

**提示：** 要做到这一点，请获取一个类型为 CadEntityTypeName.ATTDEF 的实体，并在其中获取一个值为 "StringToSearch" 的 PromptString 字段。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
