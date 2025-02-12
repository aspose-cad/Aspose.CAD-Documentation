---
title: Verschieben des Ursprungspunkts der Schraffur näher an die Schraffurgrenze zur Leistungsverbesserung
type: docs
weight: 41
url: /de/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **So verschieben Sie den Ursprungspunkt der Schraffur näher an die Schraffurgrenze zur Leistungsverbesserung**

**Problem:** Wie verschiebt man den Ursprungspunkt der Schraffur näher an die Schraffurgrenze zur Leistungsverbesserung (CADNET-1340).

**Tipps:** Um dies zu tun, erhalten Sie die CadHatch-Entitäten aus der Zeichnung, setzen Sie die erforderlichen Punkte mit Point2D, berechnen Sie die Entfernung und setzen Sie in CadHatchPatternData LineBasePoint für X und Y.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
