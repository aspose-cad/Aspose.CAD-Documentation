---
title: Расчет площади и длины окружности кругов
type: docs
weight: 18
url: /ru/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **Как рассчитать площадь и длину окружности кругов**

**Проблема:** Как рассчитать площадь и длину окружности кругов (CADNET-1153).

**Советы:** Для этого получите радиус из CadEntityTypeName.CIRCLE из сущностей и используйте формулу **"2 * Math.PI * radius"**.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
