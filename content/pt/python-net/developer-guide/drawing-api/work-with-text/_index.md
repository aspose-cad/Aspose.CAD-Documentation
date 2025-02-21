---
title: Trabalhar com texto
type: docs
weight: 40
url: /pt/python-net/developer-guide/drawing-api/work-with-text/
---

## **Trabalhar com texto**

Quase todas as ilustrações contêm objetos de texto e estes exemplos mostram como realizar operações com eles. 
Existem diferentes tipos de entidades para DWG/DXF que podem armazenar texto, são elas **CadText**, **CadMText**, CadAttDef, CadAttrib. Os dois últimos tipos estão tipicamente relacionados 
a **CadInsertObject** e armazenados dentro dele ou no bloco correspondente.

Aqui estão alguns exemplos descrevendo operações com texto.

### **Pesquisar o texto**

Este exemplo mostra como encontrar valores de texto no arquivo DWG/DXF e pode ser usado também para substituir valores de texto.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
