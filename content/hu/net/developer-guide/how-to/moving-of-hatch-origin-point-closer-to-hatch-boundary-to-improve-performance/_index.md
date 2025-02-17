---
title: A hablemez eredeti pontjának közelebb helyezése a hablemez határához a teljesítmény javítása érdekében
type: docs
weight: 41
url: /hu/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Hogyan közelítsük a hablemez eredeti pontját a hablemez határához a teljesítmény javítása érdekében**

**Probléma:** Hogyan közelítsük a hablemez eredeti pontját a hablemez határához a teljesítmény javítása érdekében (CADNET-1340).

**Tippek:** Ehhez szerezd meg a CadHatch entitásokat a rajzból, állítsd be a szükséges pontokat Point2D-vel, számold ki a távolságot, és a CadHatchPatternData-ban állítsd be a LineBasePoint-ot X és Y értékekre.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
