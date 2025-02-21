---
title: Ler, atualizar e gravar arquivo DWG
type: docs
weight: 11
url: /pt/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Como ler, atualizar e gravar arquivo DWG**

**Problema:** Como ler, atualizar e gravar arquivo DWG.

**Dicas:** Para fazer isso, você pode obter o arquivo usando o método load, obter as entidades necessárias e fazer alterações nelas, como mudar os pontos de início e fim ou a espessura das linhas.

**Nota:** Este trecho de código mostra um exemplo de leitura de um arquivo dwg, mudando objetos: as posições de linhas, círculos, valores de texto (você pode adicionar mudanças a outros objetos e seus valores para os quais a leitura/gravação é suportada) e então salvando em um novo arquivo. Assim, você pode abrir um novo arquivo no AutoCAD e ver objetos com valores alterados.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
