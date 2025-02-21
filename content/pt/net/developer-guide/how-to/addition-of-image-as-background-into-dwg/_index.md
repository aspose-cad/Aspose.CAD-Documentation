---
title: Adição de imagem como fundo em DWG
type: docs
weight: 15
url: /pt/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Como adicionar uma imagem como fundo em DWG**

**Problema:** Como adicionar uma imagem como fundo em DWG.

**Dicas:** Para fazer isso, crie um objeto CadRasterImageDef para a imagem de fundo, crie um objeto CadRasterImage para inserir o fundo no desenho, adicione um objeto CadRasterImage aos objetos do desenho, crie um CadBaseObject CadBaseObject e adicione-o a cadImage.Objects, processe tudo através do CadBlockTableObject.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
