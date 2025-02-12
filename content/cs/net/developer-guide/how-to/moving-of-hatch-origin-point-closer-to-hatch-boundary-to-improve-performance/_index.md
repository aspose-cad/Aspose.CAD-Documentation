---
title: Přesunutí počátečního bodu vývoje bližšího ke hranici vývoje pro zlepšení výkonu
type: docs
weight: 41
url: /cs/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Jak přesunout počáteční bod vývoje bližší ke hranici vývoje pro zlepšení výkonu**

**Problém:** Jak přesunout počáteční bod vývoje bližší ke hranici vývoje pro zlepšení výkonu (CADNET-1340).

**Tipy:** Pro provedení tohoto kroku získejte entity CadHatch z výkresu, nastavte požadované body s Point2D, spočítejte vzdálenost a v CadHatchPatternData nastavte LineBasePoint pro osu X a Y.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
