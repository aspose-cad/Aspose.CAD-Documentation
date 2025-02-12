---
title: Преместване на началната точка на отвора по-близо до границата на отвора за подобряване на производителността
type: документация
weight: 41
url: /bg/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Как да преместите началната точка на отвора по-близо до границата на отвора, за да подобрите производителността**

**Проблем:** Как да преместите началната точка на отвора по-близо до границата на отвора, за да подобрите производителността (CADNET-1340).

**Съвети:** За да постигнете това, вземете съществата CadHatch от чертежа, задайте необходимите точки с Point2D, изчислете разстоянието и в CadHatchPatternData задайте LineBasePoint за X и Y.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
