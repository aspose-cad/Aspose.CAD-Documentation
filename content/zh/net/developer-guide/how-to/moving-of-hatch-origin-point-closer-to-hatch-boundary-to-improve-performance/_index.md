---
title: 将 hatch 原点移动靠近 hatch 边界以提高性能
type: docs
weight: 41
url: /zh/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **如何将 hatch 原点移动靠近 hatch 边界以提高性能**

**问题：** 如何将 hatch 原点移动靠近 hatch 边界以提高性能 (CADNET-1340)。

**提示：** 要做到这一点，从图纸中获取 CadHatch 实体，使用 Point2D 设置所需的点，计算距离，并在 CadHatchPatternData 中为 X 和 Y 设置 LineBasePoint。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
