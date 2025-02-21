---
title: 삽입 내에서 속성 검색
type: docs
weight: 44
url: /ko/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **삽입 내에서 속성을 검색하는 방법**

**문제:** 삽입 내에서 속성을 검색하는 방법 (CADNET-8050).

**팁:** 이를 위해 CadEntityTypeName.ATTDEF 유형의 엔터티를 가져오고 그 안에 "StringToSearch" 값을 가진 PromptString 필드를 사용하십시오.

**예시:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
