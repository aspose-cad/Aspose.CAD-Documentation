---
title: Mover el punto de origen del sombreado más cerca del límite del sombreado para mejorar el rendimiento
type: docs
weight: 41
url: /es/net/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Cómo mover el punto de origen del sombreado más cerca del límite del sombreado para mejorar el rendimiento**

**Problema:** Cómo mover el punto de origen del sombreado más cerca del límite del sombreado para mejorar el rendimiento (CADNET-1340).

**Consejos:** Para hacer esto, obtén las entidades CadHatch del dibujo, establece los puntos requeridos con Point2D, calcula la distancia y en CadHatchPatternData establece LineBasePoint para X e Y.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
