---
title: Skapa rektangel som polylines och fyll den med hatching
type: docs
weight: 24
url: /sv/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Hur man skapar rektangel som polylines och fyll den med hatching**

**Issue:** Hur man skapar rektangel som polylines och fyll den med hatching (CADNET-1351).

**Tips:** För att göra detta, skapa en CadLwPolyline och lägg till punktkoordinater till den, använd CadHatch för att arbeta med färg och använd CadEdgeBoundaryPath för att koppla samman, använd CadHatch för att arbeta med vinklar och CadHatchPatternData för mönster.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
