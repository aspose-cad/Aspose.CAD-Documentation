---
title: Verplaatsen van het oorsprongspunt van het hatch dichter bij de hatch-grens om prestaties te verbeteren
type: docs
weight: 41
url: /nl/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Hoe het oorsprongspunt van het hatch dichter bij de hatch-grens te verplaatsen om prestaties te verbeteren**

**Probleem:** Hoe het oorsprongspunt van het hatch dichter bij de hatch-grens te verplaatsen om prestaties te verbeteren (CADNET-1340).

**Tips:** Om dit te doen, haal de CadHatch-entiteiten uit de tekening, stel de vereiste punten in met Point2D, bereken de afstand en stel in CadHatchPatternData de LineBasePoint in voor X en Y.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
