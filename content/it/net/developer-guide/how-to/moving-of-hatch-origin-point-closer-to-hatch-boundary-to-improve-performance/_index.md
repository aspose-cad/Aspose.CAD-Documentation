---
title: Spostare il punto di origine dell'area di riempimento più vicino al confine dell'area di riempimento per migliorare le prestazioni
type: docs
weight: 41
url: /it/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Come spostare il punto di origine dell'area di riempimento più vicino al confine dell'area di riempimento per migliorare le prestazioni**

**Problema:** Come spostare il punto di origine dell'area di riempimento più vicino al confine dell'area di riempimento per migliorare le prestazioni (CADNET-1340).

**Suggerimenti:** Per fare questo, ottenere le entità CadHatch dal disegno, impostare i punti richiesti con Point2D, calcolare la distanza e in CadHatchPatternData impostare LineBasePoint per X e Y.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
