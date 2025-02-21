---
title: Регулювання розміру CAD креслення
type: docs
weight: 10
url: /uk/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Використовуючи бібліотеку Aspose.CAD для Python, розробники можуть регулювати розмір CAD креслення під час конвертації в будь-який підтримуваний формат. Ця тема пояснює підхід для автоматичного або ручного регулювання розміру за допомогою перерахування **UnitType** класу **ImageOptions**.

{{% /alert %}}

## **Регулювання розміру CAD креслення**

Aspose.CAD для Python надає перерахування **UnitType** для регулювання розміру креслення під час конвертації формату CAD. Існує два способи регулювання розміру креслення.

1. Автоматичне регулювання розміру.
1. Регулювання розміру за допомогою перерахування **UnitType** класу **ImageOptions**.

Для автоматичного регулювання розміру розробникам не потрібно вказувати властивості Width і Height класу **CadRasterizationOptions**. Нижче наведено приклад коду автоматичного регулювання розміру.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

Перерахування **UnitType** дає можливість регулювати масштабування, коли властивості Width і Height не задані. Нижче наведено приклад коду, що демонструє, як використовувати **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
