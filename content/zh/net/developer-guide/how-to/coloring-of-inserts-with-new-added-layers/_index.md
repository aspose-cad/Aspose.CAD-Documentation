---
title: 新添加图层的插入物着色
type: docs
weight: 23
url: /zh/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **如何为新添加的图层着色插入物 (CADNET-1146)**

**问题：** 如何为新添加的图层着色插入物 (CADNET-1146)。

**提示：** 为此，使用 CadLayerTable 类创建一个图层，以便能够将新图层添加到绘图中，您还可以使用 CadLayersList 添加多个图层。

**示例：**

{{% alert color="primary" %}}

初始文件包含5个名称为“1”，“2”，“3”，“4”和“5”的插入物，所有这些都在默认的0图层中。

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
