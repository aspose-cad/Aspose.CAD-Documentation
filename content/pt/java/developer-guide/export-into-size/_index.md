---
title: Exportando desenho e layouts DWG/DXF para tamanho especificado
type: docs
weight: 40
url: /pt/java/developer-guide/export-into-size/
---

## **Exportar Modelo e todos os layouts para PDF tamanho A4**

A API Aspose.CAD permite exportar todas as folhas do arquivo DWG/DXF para um tamanho físico de PDF especificado.
O código de exemplo a seguir configura o tamanho do objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) para atingir o tamanho de PDF desejado.
O tamanho da folha de papel A4 é 210x297 milímetros ou 8.27x11.69 polegadas e esses valores são utilizados no código.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Exportar Layouts CAD para PDF em tamanho diferente**

Às vezes, é necessário exportar o layout para seu tamanho físico. O exemplo abaixo demonstra a exportação do desenho para um PDF de várias páginas, onde cada página com conteúdo de layout
tem seu próprio tamanho físico de PDF. Este exemplo usa a propriedade [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) .

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
