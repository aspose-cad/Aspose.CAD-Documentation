---
title: Maak rechthoek als polylijnen en vul deze met hatching
type: docs
weight: 24
url: /nl/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Hoe maak je een rechthoek als polylijnen en vul je deze met hatching**

**Probleem:** Hoe maak je een rechthoek als polylijnen en vul je deze met hatching (CADNET-1351).

**Tips:** Om dit te doen, maak een CadLwPolyline aan en voeg coördinaten van punten toe, gebruik CadHatch om met kleuren te werken en gebruik CadEdgeBoundaryPath om verbinding te maken, gebruik CadHatch om met hoeken te werken en CadHatchPatternData voor het patroon.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
