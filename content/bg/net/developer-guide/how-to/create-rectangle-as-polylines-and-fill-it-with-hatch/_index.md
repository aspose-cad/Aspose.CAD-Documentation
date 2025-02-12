---
title: Създаване на правоъгълник като полилиния и запълване с хачура
type: docs
weight: 24
url: /bg/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Как да създадете правоъгълник като полилиния и да го запълните с хачура**

**Проблем:** Как да създадете правоъгълник като полилиния и да го запълните с хачура (CADNET-1351).

**Съвети:** За да постигнете това, създайте CadLwPolyline и добавете координатите на точките към нея, използвайте CadHatch за работа с цветове и използвайте CadEdgeBoundaryPath за свързването, използвайте CadHatch за работа с ъгли и CadHatchPatternData за шаблон.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
