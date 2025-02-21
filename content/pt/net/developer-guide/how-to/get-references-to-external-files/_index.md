---
title: Obter referências a arquivos externos
type: docs
weight: 36
url: /pt/net/developer-guide/how-to/get-references-to-external-files/
---

## **Como obter referências a arquivos externos**

**Problema:** Como obter referências a arquivos externos (CADNET-110).

**Dicas:** Para obter referências a arquivos externos para desenhos no bloco de entidade, há um campo XRef PathName para imagens raster. CadRasterImage é usado para sobreposições externas, CadDgnUnderlay é usado e seu campo UnderlayPath.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
