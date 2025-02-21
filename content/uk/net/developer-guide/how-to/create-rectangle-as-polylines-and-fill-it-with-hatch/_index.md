---
title: Створити прямокутник як полігональні лінії та заповнити його штрихуванням
type: docs
weight: 24
url: /uk/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Як створити прямокутник як полігональні лінії та заповнити його штрихуванням**

**Проблема:** Як створити прямокутник як полігональні лінії та заповнити його штрихуванням (CADNET-1351).

**Поради:** Для цього створіть CadLwPolyline і додайте координати точок до нього, використайте CadHatch для роботи з кольором і використайте CadEdgeBoundaryPath для з'єднання, використайте CadHatch для роботи з кутами та CadHatchPatternData для шаблону.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
