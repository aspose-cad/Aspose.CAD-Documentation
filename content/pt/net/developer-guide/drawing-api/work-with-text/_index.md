---
title: Trabalhar com texto
type: docs
weight: 40
url: /pt/net/developer-guide/drawing-api/work-with-text/
---

## **Trabalhar com texto**

Quase todos os desenhos contêm objetos de texto e estes exemplos mostram como realizar operações com eles. 
Existem diferentes tipos de entidades para DWG/DXF que podem armazenar texto, são [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Os dois últimos tipos estão tipicamente relacionados 
ao [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
e armazenados dentro dele ou no bloco correspondente.

Aqui estão alguns exemplos que descrevem operações com texto.

### **Buscar o texto**

Este exemplo mostra como encontrar valores de texto no arquivo DWG/DXF e pode ser usado também para substituir valores de texto.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Adicionando novos itens de Texto e MText**

Aqui está o exemplo de como adicionar novos objetos de Texto/Mtext ao desenho. A adição de novas entidades pode alterar o tamanho do desenho, portanto, é recomendável
chamar UpdateSize() após essas operações.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
