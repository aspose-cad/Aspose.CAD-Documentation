---
title: Exportando desenho DWG/DXF e layouts em tamanho especificado
type: docs
weight: 40
url: /pt/net/developer-guide/export-into-size/
---

## **Exportar modelo e todos os layouts em PDF tamanho A4**

A API Aspose.CAD permite que você exporte todas as folhas do arquivo DWG/DXF em um tamanho físico de PDF especificado.

O seguinte código de exemplo configura o tamanho do objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) para alcançar o tamanho de PDF desejado. O tamanho da folha de papel A4 é 210x297 milímetros ou 8,27x11,69 polegadas e esses valores são usados no código.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calcular tamanhos para A4.cs">}}

## **Exportar layouts CAD para PDF em tamanhos diferentes**

Às vezes, é necessário exportar o layout em seu tamanho físico. O exemplo abaixo demonstra a exportação do desenho para um PDF multipáginas onde cada página com conteúdo de layout tem seu próprio tamanho físico de PDF. Este exemplo usa a propriedade [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Exportar para multipáginas com tamanhos de páginas diferentes.cs">}}
