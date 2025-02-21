---
title: Настройка размера CAD чертежа
type: docs
weight: 10
url: /ru/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Используя библиотеку Aspose.CAD для Python, разработчики могут настраивать размер CAD чертежа во время преобразования в любой поддерживаемый формат. Эта тема объясняет подход к автоматической или ручной настройке размера с помощью перечисления **UnitType** класса **ImageOptions**.

{{% /alert %}}

## **Настройка размера CAD чертежа**

Aspose.CAD для Python предоставляет перечисление **UnitType** для настройки размера чертежа во время преобразования в CAD формат. Существует два способа настройки размера чертежа.

1. Автоматическая настройка размера.
1. Настройка размера с использованием перечисления **UnitType** класса **ImageOptions**.

Для автоматической настройки размера разработчикам не нужно указывать свойства Width и Height класса **CadRasterizationOptions**. Ниже приведен фрагмент кода в качестве примера автоматической настройки размера.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

Перечисление **UnitType** позволяет настраивать масштабирование, когда свойства Width и Height не установлены. Ниже приведен фрагмент кода, демонстрирующий, как использовать **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
