---
title: Flytta hatchingens ursprungspunkt närmare hatchinggränsen för att förbättra prestanda
type: docs
weight: 41
url: /sv/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Hur man flyttar hatchingens ursprungspunkt närmare hatchinggränsen för att förbättra prestanda**

**Problem:** Hur man flyttar hatchingens ursprungspunkt närmare hatchinggränsen för att förbättra prestanda (CADNET-1340).

**Tips:** För att göra detta, hämta CadHatch-enheterna från ritningen, ställ in de nödvändiga punkterna med Point2D, beräkna avståndet och i CadHatchPatternData ställ in LineBasePoint för X och Y.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
