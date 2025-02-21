---
title: Tìm kiếm thuộc tính bên trong chèn
type: docs
weight: 44
url: /vi/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Cách tìm kiếm một thuộc tính bên trong chèn**

**Vấn đề:** Làm thế nào để tìm kiếm một thuộc tính bên trong chèn (CADNET-8050).

**Mẹo:** Để làm điều này, hãy lấy một thực thể với loại CadEntityTypeName.ATTDEF và trong đó có trường PromptString với giá trị "StringToSearch".

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
