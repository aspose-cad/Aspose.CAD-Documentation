---
title: Создание прямоугольника в виде полилиний и его заливка штриховкой
type: docs
weight: 24
url: /ru/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Как создать прямоугольник в виде полилиний и залить его штриховкой**

**Проблема:** Как создать прямоугольник в виде полилиний и залить его штриховкой (CADNET-1351).

**Советы:** Для этого создайте CadLwPolyline и добавьте в него координаты точек, используйте CadHatch для работы с цветом и CadEdgeBoundaryPath для соединения, используйте CadHatch для работы с углами и CadHatchPatternData для шаблона.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
