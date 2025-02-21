---
title: Ajustando o Tamanho do Desenho CAD
type: docs
weight: 10
url: /pt/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Usando a biblioteca Aspose.CAD para Python, os desenvolvedores podem ajustar o tamanho do desenho CAD durante a conversão para qualquer formato suportado. Este tópico explica a abordagem para ajustar o tamanho automaticamente ou manualmente usando o enum **UnitType** da classe **ImageOptions**.

{{% /alert %}}

## **Ajustando o tamanho do desenho CAD**

Aspose.CAD para Python fornece a enumeração **UnitType** para ajustar o tamanho do desenho durante a conversão do formato CAD. Existem duas maneiras de ajustar o tamanho do desenho.

1. Ajuste automático de tamanho.
1. Ajustar o tamanho usando a enumeração **UnitType** da classe **ImageOptions**

Para ajustar automaticamente o tamanho, os desenvolvedores não precisam fornecer as propriedades Width e Height da classe **CadRasterizationOptions**. O trecho de código abaixo é um exemplo de dimensionamento automático.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

A enumeração **UnitType** dá a capacidade de ajustar a escalabilidade quando as propriedades Width e Height não estão definidas. O trecho de código abaixo demonstra como usar **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
