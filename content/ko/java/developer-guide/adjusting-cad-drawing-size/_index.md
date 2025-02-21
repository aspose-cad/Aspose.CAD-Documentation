---
title: CAD 도면 크기 조정
type: docs
weight: 10
url: /ko/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for Java를 사용하면 개발자가 CAD 형식 변환 중 도면의 크기를 조정할 수 있습니다. 이 주제에서는 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 열거형을 사용하는 도면의 자동 조정 또는 크기 조정 접근 방식을 설명합니다. [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) 클래스의 

{{% /alert %}}

## **CAD 도면 크기 조정**

Aspose.CAD for Java는 CAD 형식 변환 중 도면 크기를 조정하기 위한 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 열거형을 제공합니다. 도면 크기를 조정하는 방법은 두 가지가 있습니다.

1. 자동 크기 조정
1. [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) 클래스의 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 열거형을 사용하여 크기 조정

크기를 자동으로 조정하려면 개발자가 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 Width 및 Height 속성을 제공할 필요가 없습니다. 아래 제공된 코드 스니펫은 자동 크기 조정의 예입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 열거형은 Width 및 Height 속성이 설정되지 않았을 때 크기를 조정할 수 있는 기능을 제공합니다. 아래 제공된 코드 스니펫은 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)을 사용하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
