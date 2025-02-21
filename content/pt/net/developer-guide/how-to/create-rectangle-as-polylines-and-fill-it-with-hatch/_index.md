---
title: Criar retângulo como polilinhas e preenchê-lo com hachura
type: docs
weight: 24
url: /pt/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Como criar retângulo como polilinhas e preenchê-lo com hachura**

**Problema:** Como criar retângulo como polilinhas e preenchê-lo com hachura (CADNET-1351).

**Dicas:** Para fazer isso, crie um CadLwPolyline e adicione coordenadas de ponto a ele, use CadHatch para trabalhar com a cor e use CadEdgeBoundaryPath para conectar, use CadHatch para trabalhar com ângulos e CadHatchPatternData para o padrão.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
