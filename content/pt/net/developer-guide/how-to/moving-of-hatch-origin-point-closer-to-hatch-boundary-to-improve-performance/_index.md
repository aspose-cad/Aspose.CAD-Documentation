---
title: Mover o ponto de origem do hachurado mais perto da borda do hachurado para melhorar o desempenho
type: docs
weight: 41
url: /pt/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Como mover o ponto de origem do hachurado mais perto da borda do hachurado para melhorar o desempenho**

**Problema:** Como mover o ponto de origem do hachurado mais perto da borda do hachurado para melhorar o desempenho (CADNET-1340).

**Dicas:** Para fazer isso, obtenha as entidades CadHatch do desenho, defina os pontos necessários com Point2D, calcule a distância e, em CadHatchPatternData, defina LineBasePoint para X e Y.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
