---
title: Настройка размера CAD чертежа
type: docs
weight: 10
url: /ru/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Используя Aspose.CAD для Java, разработчики могут настраивать размер чертежа во время конвертации формата CAD. Эта тема объясняет подход к автоматической настройке или настройке размера с использованием перечисления [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) из класса [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Настройка размера CAD чертежа**

Aspose.CAD для Java предоставляет перечисление [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) для настройки размера чертежа во время конвертации формата CAD. Существует два способа настройки размера чертежа.

1. Автоматическая настройка размера
1. Настройка размера с помощью перечисления [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) из класса [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Для автоматической настройки размера разработчикам не нужно указывать свойства Width и Height класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Ниже приведённый фрагмент кода является примером автоматической настройки размера.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Перечисление [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) предоставляет возможность настраивать масштабирование, когда свойства Width и Height не заданы. Ниже приведённый фрагмент кода демонстрирует, как использовать [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
