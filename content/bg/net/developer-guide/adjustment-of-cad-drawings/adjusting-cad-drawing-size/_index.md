---
title: Промяна на размера на CAD чертежа
type: docs
weight: 10
url: /bg/net/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

С използването на библиотеката Aspose.CAD за .NET, разработчиците могат да променят размера на CAD чертежа по време на конвертирането към всякакъв поддържан формат. Тази тема обяснява метода за автоматично или ръчно променяне на размера, използвайки изброяването [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) на класа [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Промяна на размера на CAD чертежа**

Aspose.CAD за .NET предоставя изброяването [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) за промяна на размера на чертежа по време на конвертирането на CAD формата. Има два начина за промяна на размера на чертежа.

1. Автоматично променяне на размера.
1. Промяна на размера, като използвате [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) изброяването на класа [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

За автоматично променяне на размера, разработчиците не се нуждаят от предоставяне на свойствата Width и Height на клас [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Предоставеният по-долу откъс от код е пример за автоматично мащабиране.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Изброяването [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) предоставя възможност за промяна на мащабирането, когато свойствата Width и Height не са зададени. Предоставеният по-долу откъс от код показва как да се използва [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
