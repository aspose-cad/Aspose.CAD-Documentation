---
title: Ajustando o Tamanho do Desenho CAD
type: docs
weight: 10
url: /pt/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Usando o Aspose.CAD para Java, os desenvolvedores podem ajustar o tamanho do desenho durante a conversão do formato CAD. Este tópico explica a abordagem para ajustar automaticamente ou ajustar o tamanho usando a enumeração [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) da classe [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Ajustando o tamanho do desenho CAD**

Aspose.CAD para Java fornece a enumeração [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) para ajustar o tamanho do desenho durante a conversão do formato CAD. Existem duas maneiras de ajustar o tamanho do desenho.

1. Ajuste automático de tamanho
1. Ajuste do tamanho usando a enumeração [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) da classe [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Para o ajuste automático do tamanho, os desenvolvedores não precisam fornecer as propriedades Width e Height da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). O código fornecido abaixo é um exemplo de dimensionamento automático.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

A enumeração [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) permite ajustar a escala quando as propriedades Width e Height não estão definidas. O código fornecido abaixo demonstra como usar a [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
