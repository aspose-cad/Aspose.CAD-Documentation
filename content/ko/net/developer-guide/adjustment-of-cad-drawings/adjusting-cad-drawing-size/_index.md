---
title: CAD 도면 크기 조정
type: docs
weight: 10
url: /ko/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for .NET 라이브러리를 사용하면 개발자는 지원되는 모든 형식으로 변환하는 동안 CAD 도면의 크기를 조정할 수 있습니다. 이 주제에서는 [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) 열거형을 사용하여 크기를 자동 또는 수동으로 조정하는 방법을 설명합니다. 

{{% /alert %}}

## **CAD 도면 크기 조정**

Aspose.CAD for .NET에서는 CAD 형식 변환 중 도면의 크기를 조정하기 위해 [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) 열거형을 제공합니다. 도면 크기를 조정하는 방법은 두 가지가 있습니다.

1. 자동 크기 조정.
2. [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) 클래스의 [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) 열거형을 사용하여 크기 조정

크기를 자동으로 조정하려면 개발자가 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) 클래스의 Width 및 Height 속성을 제공할 필요가 없습니다. 아래 제공된 코드 스니펫은 자동 크기 조정의 예입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) 열거형은 Width 및 Height 속성이 설정되지 않았을 때 배율 조정 기능을 제공합니다. 아래 제공된 코드 스니펫은 [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) 사용 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
