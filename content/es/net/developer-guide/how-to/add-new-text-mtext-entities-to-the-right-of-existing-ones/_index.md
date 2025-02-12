---
title: Agregar nuevas entidades TEXT/MTEXT a la derecha de las existentes
type: docs
weight: 17
url: /es/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Cómo agregar nuevas entidades TEXT/MTEXT a la derecha de las existentes**

**Problema:** Cómo agregar nuevas entidades TEXT/MTEXT a la derecha de las existentes (CADNET-8172).

**Consejos:** Para hacer esto, crea un objeto CadBaseEntity, crea un CadMText o CadText con texto, en el nuevo objeto agrega cadImage.Layouts["Model"].BlockTableRecordHandle del dibujo al campo SoftOwner y agrégalo al bloque cadImage.BlockEntities[" *MODEL_SPACE"] y agrega el nuevo objeto a las entidades del dibujo.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
