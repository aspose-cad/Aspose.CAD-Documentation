---
title: SVG 도면
type: docs
weight: 70
url: /ko/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG 형식을 PDF로 내보내기**

Aspose.CAD for .NET는 개발자가 SVG 파일을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 내보낼 수 있도록 합니다. SVG에서 [PDF](https://docs.fileformat.com/pdf/)로 변환하는 방법은 다음과 같습니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 SVG 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하면서 두 번째 매개변수로 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)의 객체를 전달합니다.

## 샘플 코드

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
