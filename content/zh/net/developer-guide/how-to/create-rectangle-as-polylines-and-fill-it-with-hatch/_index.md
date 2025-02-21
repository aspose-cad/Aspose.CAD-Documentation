---
title: 创建多段线矩形并填充斜纹
type: docs
weight: 24
url: /zh/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **如何创建多段线矩形并填充斜纹**

**问题：** 如何创建多段线矩形并填充斜纹 (CADNET-1351)。

**提示：** 为此，创建一个 CadLwPolyline 并向其中添加点坐标，使用 CadHatch 处理颜色，使用 CadEdgeBoundaryPath 连接，使用 CadHatch 处理角度，使用 CadHatchPatternData 处理模式。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
