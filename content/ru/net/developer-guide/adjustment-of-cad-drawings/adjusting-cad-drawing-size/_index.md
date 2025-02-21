---
title: Настройка размера чертежа CAD
type: docs
weight: 10
url: /ru/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Используя библиотеку Aspose.CAD для .NET, разработчики могут настраивать размер чертежа CAD во время конвертации в любой поддерживаемый формат. Эта тема объясняет подход к автоматической или ручной настройке размера с использованием перечисления [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) класса [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Настройка размера чертежа CAD**

Aspose.CAD для .NET предоставляет.enumeration [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) для настройки размера чертежа во время конвертации формата CAD. Существует два способа для настройки размера чертежа.

1. Автоматическая настройка размера.
1. Настройка размера с помощью перечисления [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) класса [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

Для автоматической настройки размера разработчикам не нужно предоставлять свойства Width и Height класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Ниже приведен пример кода для автоматической настройки размера.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Перечисление [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) дает возможность настраивать масштабирование, когда свойства Width и Height не установлены. Ниже приведен пример кода, демонстрирующий, как использовать [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
