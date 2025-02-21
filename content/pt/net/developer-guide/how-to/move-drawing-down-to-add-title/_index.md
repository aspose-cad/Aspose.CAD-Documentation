---
title: Mover o desenho para baixo para adicionar título
type: docs
weight: 40
url: /pt/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Como mover o desenho para baixo para adicionar título**

**Problema:** Como mover o desenho para baixo para adicionar título (CADNET-980).

**Dicas:** Para fazer isso, crie um objeto CadText com parâmetros, adicione este bloco ao desenho, em seguida, atualize o desenho com as novas dimensões usando UpdateSize, adicione uma polilinha que seja uma estrutura em torno do desenho, adicione a polilinha a BlockEntities["*Model_Space"] e atualize novamente usando UpdateSize.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
