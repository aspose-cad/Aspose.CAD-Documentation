---
title: Adicionar novas entidades TEXT/MTEXT à direita das existentes
type: docs
weight: 17
url: /pt/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Como adicionar novas entidades TEXT/MTEXT à direita das existentes**

**Problema:** Como adicionar novas entidades TEXT/MTEXT à direita das existentes (CADNET-8172).

**Dicas:** Para fazer isso, crie um objeto CadBaseEntity, crie um CadMText ou CadText com texto, no novo objeto adicione cadImage.Layouts["Model"].BlockTableRecordHandle do desenho ao campo SoftOwner e adicione-o ao bloco cadImage.BlockEntities[" *MODEL_SPACE"] e adicione o novo objeto às entidades do desenho.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
