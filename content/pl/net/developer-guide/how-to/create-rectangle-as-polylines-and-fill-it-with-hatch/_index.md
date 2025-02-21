---
title: Tworzenie prostokąta jako polilinii i wypełnianie go wzorem
type: docs
weight: 24
url: /pl/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Jak stworzyć prostokąt jako polilinie i wypełnić go wzorem**

**Problem:** Jak stworzyć prostokąt jako polilinie i wypełnić go wzorem (CADNET-1351).

**Wskazówki:** Aby to zrobić, utwórz CadLwPolyline i dodaj współrzędne punktów, użyj CadHatch do pracy z kolorem, a także CadEdgeBoundaryPath do połączenia. Użyj CadHatch do pracy z kątami oraz CadHatchPatternData dla wzoru.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
