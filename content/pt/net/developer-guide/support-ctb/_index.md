---
title: Suporte a arquivos CTB
type: docs
weight: 40
url: /pt/net/developer-guide/support-ctb/
---

## **Suporte a arquivos CTB**

Às vezes, cores, pesos de linha e algumas outras opções para desenhos podem ser utilizados não apenas dos próprios desenhos, mas também de estilos de impressão em arquivos CTB separados. 
A maneira mais simples de usar essas informações é colocar os arquivos CTB correspondentes perto do arquivo com o desenho no formato DWG/DXF, e as informações deles serão aplicadas
automaticamente durante a exportação.

Também é possível carregar todos os arquivos CTB na forma de Stream usando 
a propriedade [**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) do 
objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).

Aqui está um exemplo de como fazer isso:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
