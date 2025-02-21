---
title: Berekening van de oppervlakte en omtrek van de cirkels
type: docs
weight: 18
url: /nl/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **Hoe de oppervlakte en omtrek van de cirkels te berekenen**

**Probleem:** Hoe de oppervlakte en omtrek van de cirkels te berekenen (CADNET-1153).

**Tips:** Om dit te doen, haal de straal op van CadEntityTypeName.CIRCLE van de entiteiten en gebruik de formule **"2 * Math.PI * radius"**.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
