---
title: Téglalap létrehozása poligonként és kitöltése mintázattal
type: docs
weight: 24
url: /hu/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Hogyan hozzunk létre téglalapot poligonként és töltsük ki mintázattal**

**Probléma:** Hogyan hozzunk létre téglalapot poligonként és töltsük ki mintázattal (CADNET-1351).

**Tippek:** Ehhez hozzon létre egy CadLwPolyline-t, és adja hozzá a pontkoordinátákat, használjon CadHatch-et a szín kezelésére, és használjon CadEdgeBoundaryPath-ot a kapcsolódáshoz, használjon CadHatch-et a szögek kezelésére, és CadHatchPatternData-t a mintázathoz.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
