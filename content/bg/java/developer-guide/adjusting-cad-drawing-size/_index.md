---
title: Коригиране на размера на CAD чертежа
type: docs
weight: 10
url: /bg/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

С помощта на Aspose.CAD за Java, разработчиците могат да коригират размера на чертежа по време на конверсията на CAD формата. Тази тема обяснява подхода за автоматично коригиране или коригиране на размера, използвайки избора на [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) от избора на [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) клас.

{{% /alert %}}

## **Коригиране на размера на CAD чертежа**

Aspose.CAD за Java предоставя избора на [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) за коригиране на размера на чертежа по време на конверсията на CAD формата. Има два начина за коригиране на размера на чертежа.

1. Автоматично коригиране на размера
1. Коригиране на размера с помощта на избора на [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) от избора на [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) клас

За автоматично коригиране на размера, разработчиците не трябва да предоставят свойствата Width и Height на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). По-долу предоставеният кодов фрагмент е пример за автоматично коригиране на размера.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Изборът на [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) предоставя възможност за коригиране на мащабирането, когато свойствата Width и Height не са зададени. По-долу предоставеният кодов фрагмент демонстрира как да използвате [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
