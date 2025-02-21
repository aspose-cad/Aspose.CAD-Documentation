---
title: 在 DWG 中添加图像作为背景
type: docs
weight: 15
url: /zh/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **如何在 DWG 中添加图像作为背景**

**问题：** 如何在 DWG 中添加图像作为背景。

**提示：** 要做到这一点，首先创建一个用于背景图像的 CadRasterImageDef 对象，创建一个 CadRasterImage 对象以插入绘图的背景，将 CadRasterImage 对象添加到绘图对象中，创建一个 CadBaseObject 并将其添加到 cadImage.Objects，通过 CadBlockTableObject 处理所有内容。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
