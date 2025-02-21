---
title: 지정된 크기로 DWG/DXF 도면 및 레이아웃 내보내기
type: docs
weight: 40
url: /ko/java/developer-guide/export-into-size/
---

## **모델 및 모든 레이아웃을 A4 PDF 크기로 내보내기**

Aspose.CAD API를 사용하면 DWG/DXF 파일의 모든 시트를 지정된 물리적 PDF 크기로 내보낼 수 있습니다. 
다음 샘플 코드는 원하는 PDF 크기를 달성하기 위해 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) 객체의 크기를 설정합니다.
A4 용지 크기는 210x297mm 또는 8.27x11.69인치이며 이 값들이 코드에서 사용됩니다.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **다양한 크기로 CAD 레이아웃을 PDF로 내보내기**

때때로 레이아웃을 물리적 크기로 내보내야 할 필요가 있습니다. 아래 예제는 각 페이지가 레이아웃 내용을 가진 다중 페이지 PDF로 도면을 내보내는 것을 보여줍니다.
이 예제는 [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) 속성을 사용합니다.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
