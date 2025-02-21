---
title: CAD 도면 크기 조정
type: docs
weight: 10
url: /ko/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for Python 라이브러리를 사용하여 개발자는 지원되는 형식으로 변환하는 동안 CAD 도면의 크기를 조정할 수 있습니다. 이 주제에서는 **ImageOptions** 클래스의 **UnitType** 열거형을 사용하여 크기를 자동으로 또는 수동으로 조정하는 방법을 설명합니다.

{{% /alert %}}

## **CAD 도면 크기 조정**

Aspose.CAD for Python은 CAD 형식 변환 중 도면의 크기를 조정하기 위해 **UnitType** 열거형을 제공합니다. 도면 크기를 조정하는 방법은 두 가지가 있습니다.

1. 자동 크기 조정.
1. **ImageOptions** 클래스의 **UnitType** 열거형을 사용하여 크기 조정

크기를 자동으로 조정하려면 개발자가 **CadRasterizationOptions** 클래스의 Width 및 Height 속성을 제공할 필요가 없습니다. 아래 제공된 코드 스니펫은 자동 크기 조정의 예입니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

**UnitType** 열거형은 Width 및 Height 속성이 설정되지 않은 경우 스케일링을 조정할 수 있는 기능을 제공합니다. 아래 제공된 코드 스니펫은 **UnitType**을 사용하는 방법을 설명합니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
