---
title: 向下移动绘图以添加标题
type: docs
weight: 40
url: /zh/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **如何向下移动绘图以添加标题**

**问题：** 如何向下移动绘图以添加标题 (CADNET-980)。

**提示：** 为此，创建一个带有参数的 CadText 对象，将该块添加到绘图中，然后使用 UpdateSize 更新绘图的新尺寸，添加一个多线段作为绘图的框架，将多线段添加到 BlockEntities["*Model_Space"] 并再次使用 UpdateSize 更新。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
