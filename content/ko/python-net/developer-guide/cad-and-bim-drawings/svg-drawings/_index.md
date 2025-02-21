---
title: SVG 도면
type: docs
weight: 170
url: /ko/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG 형식을 PDF로 내보내기**

Aspose.CAD for Python은 개발자가 [SVG](https://docs.fileformat.com/page-description-language/svg/) 파일을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 내보낼 수 있게 합니다. [SVG](https://docs.fileformat.com/page-description-language/svg/) 를 [PDF](https://docs.fileformat.com/pdf/)로 변환하는 방법은 다음과 같습니다:

1. **Image.load** 팩토리 메서드를 사용하여 SVG 도면 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 객체를 생성하고 **page_height** 및 **page_width** 속성을 설정합니다.
1. **PdfOptions** 클래스의 객체를 생성하고 **VectorRasterizationOptions** 속성을 설정합니다.
1. **Image.save**를 호출하면서 두 번째 매개변수로 **PdfOptions** 객체를 전달합니다.

## 샘플 코드

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
