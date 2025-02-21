---
title: DRC 도면
type: docs
weight: 40
url: /ko/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC 형식을 PDF로 내보내기**

Aspose.CAD for Python은 개발자가 [DRC](https://docs.fileformat.com/3d/drc/) 파일을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 내보낼 수 있게 합니다. [DRC](https://docs.fileformat.com/3d/drc/)를 [PDF](https://docs.fileformat.com/pdf/)로 변환하는 접근 방식은 다음과 같이 작동합니다:

1. **Image.load** 팩토리 메소드를 사용하여 DRC 도면 파일을 로드 합니다.
1. **CadRasterizationOptions** 클래스의 객체를 생성하고 **page_height** 및 **page_width** 속성을 설정합니다.
1. **PdfOptions** 클래스의 객체를 생성하고 **VectorRasterizationOptions** 속성을 설정합니다.
1. **Image.save**를 호출하여 **PdfOptions** 객체를 두 번째 매개변수로 전달합니다.

## 샘플 코드


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
