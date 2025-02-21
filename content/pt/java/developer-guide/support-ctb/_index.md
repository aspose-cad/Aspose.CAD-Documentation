---
title: Suporte a arquivos CTB
type: docs
weight: 40
url: /pt/java/developer-guide/support-ctb/
---

## **Suporte a arquivos CTB**

Às vezes, cores, pesos de linha e outras opções para desenhos podem ser usados não apenas dos próprios desenhos, mas também de estilos de impressão em arquivos CTB separados. A maneira mais simples de usar essa informação é colocar os arquivos CTB correspondentes ao lado do arquivo com o desenho no formato DWG/DXF e as informações deles serão aplicadas automaticamente durante a exportação.

Também é possível carregar todos os arquivos CTB na forma de Stream usando a propriedade 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) do objeto 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

Aqui está um exemplo de como fazer isso:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
