---
title: Ajustando o Tamanho do Desenho CAD
type: docs
weight: 10
url: /pt/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Usando a biblioteca Aspose.CAD para .NET, os desenvolvedores podem ajustar o tamanho do desenho CAD durante a conversão para qualquer formato suportado. Este tópico explica a abordagem para ajustar o tamanho automaticamente ou manualmente usando o [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enum da classe [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Ajustando o tamanho do desenho CAD**

Aspose.CAD para .NET fornece a enumeração [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) para ajustar o tamanho do desenho durante a conversão do formato CAD. Existem duas maneiras de ajustar o tamanho do desenho.

1. Ajuste de tamanho automático.
2. Ajustar tamanho usando a enumeração [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) da classe [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

Para ajustar automaticamente o tamanho, os desenvolvedores não precisam fornecer as propriedades Width e Height da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). O trecho de código abaixo é um exemplo de dimensionamento automático.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

A enumeração [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) oferece a capacidade de ajustar a escala quando as propriedades Width e Height não estão definidas. O trecho de código abaixo demonstra como usar [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
