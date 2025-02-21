---
title: FBX 도면
type: docs
weight: 110
url: /ko/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX 형식을 PDF로 내보내기**

Aspose.CAD for Python은 개발자가 [FBX](https://docs.fileformat.com/3d/fbx/) 파일을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 내보낼 수 있도록 합니다. [FBX](https://docs.fileformat.com/3d/fbx/) 에서 [PDF](https://docs.fileformat.com/pdf/)로의 변환 접근 방식은 다음과 같이 작동합니다:

1. **Image.load** 팩토리 메서드를 사용하여 [FBX](https://docs.fileformat.com/3d/fbx/) 도면 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 객체를 만들고 **PageHeight** 및 **PageWidth** 속성을 설정합니다.
1. **PdfOptions** 클래스의 객체를 만들고 **vector_rasterization_options** 속성을 설정합니다.
1. **PdfOptions** 객체를 두 번째 매개변수로 전달하면서 **Image.save**를 호출합니다.

## 샘플 코드

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
