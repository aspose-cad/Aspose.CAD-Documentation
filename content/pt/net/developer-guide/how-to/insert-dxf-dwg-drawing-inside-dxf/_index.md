---
title: Inserir desenho DXF/DWG dentro do DXF
type: docs
weight: 39
url: /pt/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Como inserir desenho DXF/DWG dentro do DXF**

**Problema:** Como inserir desenho DXF/DWG dentro do DXF.

**Dicas:** Para fazer isso, você deve primeiro criar um CadInsertObject com os valores necessários, depois obter todos os blocos no CadBlockDictionary, criar um novo bloco CadBlockEntity e adicioná-lo ao CadBlockDictionary, adicionar o CadBlockDictionary às BlockEntities do desenho, adicionar um CadInsertObject às entidades do desenho para o array.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
