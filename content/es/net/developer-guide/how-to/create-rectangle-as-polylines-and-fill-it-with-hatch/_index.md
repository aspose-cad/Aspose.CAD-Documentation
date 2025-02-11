---
title: Crear un rectángulo como polilíneas y llenarlo con un patrón
type: docs
weight: 24
url: /es/net/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Cómo crear un rectángulo como polilíneas y llenarlo con un patrón**

**Problema:** Cómo crear un rectángulo como polilíneas y llenarlo con un patrón (CADNET-1351).

**Consejos:** Para hacer esto, crea un CadLwPolyline y añade las coordenadas de los puntos a él, utiliza CadHatch para trabajar con el color y utiliza CadEdgeBoundaryPath para conectar, utiliza CadHatch para trabajar con los ángulos y CadHatchPatternData para el patrón.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
