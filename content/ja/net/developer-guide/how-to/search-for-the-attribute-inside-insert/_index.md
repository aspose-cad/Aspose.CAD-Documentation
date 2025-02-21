---
title: インサート内の属性を検索する
type: docs
weight: 44
url: /ja/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **インサート内の属性を検索する方法**

**問題:** インサート内の属性を検索する方法 (CADNET-8050)。

**ヒント:** これを行うには、CadEntityTypeName.ATTDEF タイプのエンティティを取得し、その中に "StringToSearch" の値を持つ PromptString フィールドを含めます。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
