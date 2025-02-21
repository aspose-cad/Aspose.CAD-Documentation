---
title: Verifique se as imagens referenciadas externamente existem e substitua referências
type: docs
weight: 22
url: /pt/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Como editar hyperlinks em objetos**

**Problema:** Como verificar se as imagens referenciadas externamente existem e substituir referências (CADNET-8088).

**Dicas:** Para fazer isso, obtenha uma entidade do tipo CadObjectTypeName.IMAGEDEF das entidades de desenho e use CadRasterImageDef para verificar.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
