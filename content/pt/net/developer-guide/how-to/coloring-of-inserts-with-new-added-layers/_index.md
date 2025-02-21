---
title: Coloração de inserções com novas camadas adicionadas
type: docs
weight: 23
url: /pt/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Como colorir inserções com novas camadas adicionadas (CADNET-1146)**

**Problema:** Como colorir inserções com novas camadas adicionadas (CADNET-1146).

**Dicas:** Para fazer isso, use a classe CadLayerTable para criar uma camada e poder adicionar uma nova camada ao desenho; você também pode usar CadLayersList para adicionar várias camadas.

**Exemplo:**

{{% alert color="primary" %}}

O arquivo inicial contém 5 inserções com os nomes "1", "2", "3", "4" e "5", e todas elas estão na camada padrão 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
