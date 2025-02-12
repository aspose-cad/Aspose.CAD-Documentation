---
title: Erstellen Sie ein Rechteck als Polylinien und füllen Sie es mit Schraffur
type: docs
weight: 24
url: /de/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Wie man ein Rechteck als Polylinien erstellt und es mit Schraffur füllt**

**Problem:** Wie man ein Rechteck als Polylinien erstellt und es mit Schraffur füllt (CADNET-1351).

**Tipps:** Dazu erstellen Sie eine CadLwPolyline und fügen die Punktkoordinaten hinzu, verwenden Sie CadHatch, um mit Farben zu arbeiten, und verwenden Sie CadEdgeBoundaryPath, um zu verbinden. Verwenden Sie CadHatch, um mit Winkeln zu arbeiten, und CadHatchPatternData für das Muster.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
