---
title: Inserir desenho DXF/DWG dentro do DWG
type: docs
weight: 38
url: /pt/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Como inserir desenho DXF/DWG dentro do DWG**

**Problema:** Como inserir desenho DXF/DWG dentro do DWG.

**Dicas:** Para fazer isso, primeiro crie um CadInsertObject com os valores necessários, depois obtenha todos os blocos em um CadBlockDictionary, crie um novo bloco CadBlockEntity e adicione-o ao CadBlockDictionary, adicione um CadBlockDictionary às BlockEntities do desenho, adicione um CadInsertObject à entidade de desenho para o array, crie um CadBlockTableObject por referência e, em seguida, adicione um bloco ao desenho.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
