---
title: Регулювання розміру креслення CAD
type: docs
weight: 10
url: /uk/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Використовуючи Aspose.CAD для Java, розробники можуть регулювати розмір креслення під час конвертації формату CAD. Ця тема пояснює підхід до автоматичного регулювання або регулювання розміру за допомогою перерахування [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) класу [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Регулювання розміру креслення CAD**

Aspose.CAD для Java надає перерахування [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) для регулювання розміру креслення під час конвертації формату CAD. Є два способи регулювання розміру креслення.

1. Автоматичне регулювання розміру
1. Регулювання розміру за допомогою перерахування [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) класу [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Для автоматичного регулювання розміру розробникам не потрібно надавати властивості Width і Height класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Низький наданий фрагмент коду є прикладом автоматичного регулювання розміру.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Перерахування [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) дозволяє регулювати масштабування, коли властивості Width і Height не встановлені. Низький наданий фрагмент коду демонструє, як використовувати [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
