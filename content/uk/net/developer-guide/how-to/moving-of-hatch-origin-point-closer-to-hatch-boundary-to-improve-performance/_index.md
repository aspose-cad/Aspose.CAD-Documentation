---
title: Переміщення точки початку сітки ближче до межі сітки для покращення продуктивності
type: docs
weight: 41
url: /uk/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Як перемістити точку початку сітки ближче до межі сітки для покращення продуктивності**

**Проблема:** Як перемістити точку початку сітки ближче до межі сітки для покращення продуктивності (CADNET-1340).

**Поради:** Для цього отримайте об'єкти CadHatch з креслення, встановіть необхідні точки з Point2D, обчисліть відстань і в CadHatchPatternData встановіть LineBasePoint для X і Y.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
