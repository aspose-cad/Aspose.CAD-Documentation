---
title: 将 DXF/DWG 图纸插入到 DXF 中
type: docs
weight: 39
url: /zh/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **如何将 DXF/DWG 图纸插入到 DXF 中**

**问题：** 如何将 DXF/DWG 图纸插入到 DXF 中。

**提示：** 要做到这一点，您必须首先创建一个具有必要值的 CadInsertObject，然后在 CadBlockDictionary 中获取所有块，创建一个新的 CadBlockEntity 块并将其添加到 CadBlockDictionary 中，将 CadBlockDictionary 添加到图纸的 BlockEntities 中，为数组向图纸的实体添加一个 CadInsertObject。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
