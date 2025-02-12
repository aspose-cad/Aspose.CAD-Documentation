---
title: Jak vytvořit obdélník jako lomenou čáru a vyplnit ho vzorkem
type: docs
weight: 24
url: /cs/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Jak vytvořit obdélník jako lomenou čáru a vyplnit ho vzorkem**

**Problém:** Jak vytvořit obdélník jako lomenou čáru a vyplnit ho vzorkem (CADNET-1351).

**Tipy:** Pro provedení tohoto úkolu vytvořte CadLwPolyline a přidejte do ní souřadnice bodů, použijte CadHatch k práci s barvou a použijte CadEdgeBoundaryPath k propojení, využijte CadHatch k práci s úhly a CadHatchPatternData pro vzor.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
