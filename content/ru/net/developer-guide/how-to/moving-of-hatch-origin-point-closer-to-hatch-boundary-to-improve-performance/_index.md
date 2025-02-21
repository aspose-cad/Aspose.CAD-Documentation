---
title: Перемещение начальной точки штриха ближе к границе штриха для повышения производительности
type: docs
weight: 41
url: /ru/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Как переместить начальную точку штриха ближе к границе штриха для повышения производительности**

**Проблема:** Как переместить начальную точку штриха ближе к границе штриха для повышения производительности (CADNET-1340).

**Советы:** Для этого получите объекты CadHatch из чертежа, установите необходимые точки с помощью Point2D, вычислите расстояние и в CadHatchPatternData установите LineBasePoint для X и Y.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
