---
title: DXB 도면
type: docs
weight: 70
url: /ko/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB 형식에서 PDF로 내보내기**

Aspose.CAD for .NET은 개발자가 DXB 파일을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 내보낼 수 있도록 합니다. DXB에서 [PDF](https://docs.fileformat.com/pdf/)로 변환하는 접근 방식은 다음과 같이 작동합니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 DXB 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하면서 두 번째 매개변수로 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 전달합니다.

## 샘플 코드

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
