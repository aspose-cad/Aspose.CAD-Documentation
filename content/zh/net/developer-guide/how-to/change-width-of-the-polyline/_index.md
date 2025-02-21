---
title: 更改折线宽度
type: docs
weight: 20
url: /zh/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **如何更改折线的宽度**

**问题：** 如何更改折线的宽度 (CADNET-459-460)。

**提示：** 要在 CadBaseEntity 中更改宽度（如果类型为 CadEntityTypeName.LWPOLYLINE），使用 (entity as CadLwPolyline).ConstantWidth = 2 或者对于常规实体 LineWeight。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
