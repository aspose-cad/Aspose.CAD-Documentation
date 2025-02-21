---
title: 仅导出部分图层并调整尺寸
type: docs
weight: 31
url: /zh/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **仅导出部分图层并调整尺寸 (CADNET-559)**

**问题:** 如何仅导出部分图层并调整尺寸 (CADNET-559)。

**提示:** 要做到这一点，请选择所需的图层，将它们添加到 CadBaseEntity 数组中，然后将它们分配给绘图实体并执行 UpdateSize。

**示例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
