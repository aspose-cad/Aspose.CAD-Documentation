---
title: DWG/DXF 도면 및 레이아웃을 지정된 크기로 내보내기
type: docs
weight: 40
url: /ko/net/developer-guide/export-into-size/
---

## **모델과 모든 레이아웃을 A4 PDF 크기로 내보내기**

Aspose.CAD API를 사용하면 DWG/DXF 파일의 모든 시트를 지정된 물리적 PDF 크기로 내보낼 수 있습니다.

다음 샘플 코드는 원하는 PDF 크기를 얻기 위해 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 객체의 크기를 설정합니다.
A4 용지의 크기는 210x297 밀리미터 또는 8.27x11.69 인치이며, 이 값들이 코드에서 사용됩니다.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **다양한 크기로 CAD 레이아웃을 PDF로 내보내기**

때때로 레이아웃을 물리적 크기로 내보내야 할 필요가 있습니다. 아래 예제는 각 페이지가 레이아웃 콘텐츠를 가지고 있는 다중 페이지 PDF로 도면을 내보내는 방법을 보여줍니다.
이 예제에서는 [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/) 속성을 사용합니다.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
