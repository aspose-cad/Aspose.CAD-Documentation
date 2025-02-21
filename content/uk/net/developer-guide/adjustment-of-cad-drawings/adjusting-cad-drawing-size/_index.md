---
title: Налаштування розміру креслення CAD
type: docs
weight: 10
url: /uk/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Використовуючи бібліотеку Aspose.CAD для .NET, розробники можуть налаштувати розмір креслення CAD під час конвертації в будь-який підтримуваний формат. Ця тема пояснює підхід до автоматичного або ручного налаштування розміру за допомогою перерахування [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) класу [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Налаштування розміру креслення CAD**

Aspose.CAD для .NET надає перерахування [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) для налаштування розміру креслення під час конвертації формату CAD. Є два способи змінити розмір креслення.

1. Автоматичне налаштування розміру.
1. Налаштування розміру за допомогою перерахування [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) класу [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

Для автоматичного налаштування розміру розробникам не потрібно вказувати властивості Width та Height класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Нижче подано фрагмент коду, який є прикладом автоматичного налаштування розміру.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Перерахування [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) дозволяє налаштувати масштабування, коли властивості Width та Height не задані. Нижче наведено фрагмент коду, який демонструє, як використовувати [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
