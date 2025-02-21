---
title: 在 DWG 中插入 DXF/DWG 图纸
type: docs
weight: 38
url: /zh/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **如何在 DWG 中插入 DXF/DWG 图纸**

**问题:** 如何在 DWG 中插入 DXF/DWG 图纸。

**提示:** 要做到这一点，首先创建一个具有所需值的 CadInsertObject，然后获取 CadBlockDictionary 中的所有块，创建一个新的 CadBlockEntity 块并将其添加到 CadBlockDictionary，向图纸的 BlockEntities 添加一个 CadBlockDictionary，为数组添加一个 CadInsertObject 到图形实体，按引用创建一个 CadBlockTableObject，然后将一个块添加到图纸中。

**示例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
