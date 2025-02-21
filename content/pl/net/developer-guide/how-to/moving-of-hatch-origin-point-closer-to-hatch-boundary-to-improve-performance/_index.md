---
title: Przesunięcie punktu początkowego wypełnienia bliżej granicy wypełnienia w celu poprawy wydajności
type: docs
weight: 41
url: /pl/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Jak przesunąć punkt początkowy wypełnienia bliżej granicy wypełnienia w celu poprawy wydajności**

**Problem:** Jak przesunąć punkt początkowy wypełnienia bliżej granicy wypełnienia w celu poprawy wydajności (CADNET-1340).

**Porady:** Aby to zrobić, uzyskaj encje CadHatch z rysunku, ustaw wymagane punkty za pomocą Point2D, oblicz odległość, a w CadHatchPatternData ustaw LineBasePoint dla osi X i Y.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
