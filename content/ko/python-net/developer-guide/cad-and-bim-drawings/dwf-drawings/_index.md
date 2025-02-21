---
title: DWF 도면
type: docs
weight: 50
url: /ko/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF 도면을 PDF로 내보내기**

Aspose.CAD는 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 도면 엔티티를 로드하고 전체 도면을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 렌더링하는 기능을 제공합니다. [DWF](https://docs.fileformat.com/cad/dwf/)에서 [PDF](https://docs.fileformat.com/pdf/)로의 변환 접근 방식은 다음과 같이 작동합니다:

1. **Image.load** 팩토리 메서드를 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 도면 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 객체를 만들고 **page_height** 및 **page_width** 속성을 설정합니다.
1. **PdfOptions** 클래스의 객체를 만들고 **vector_rasterization_options** 속성을 설정합니다.
1. **Image.save**를 호출하면서 **PdfOptions** 객체를 두 번째 매개변수로 전달합니다.

### 샘플 코드

아래 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **DWF 도면을 BMP로 내보내기**

Aspose.CAD는 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 도면 엔티티를 로드하고 전체 도면을 [BMP](https://docs.fileformat.com/image/bmp/) 형식으로 렌더링하는 기능을 제공합니다. [DWF](https://docs.fileformat.com/cad/dwf/)에서 [BMP](https://docs.fileformat.com/image/bmp/)로의 변환 접근 방식은 다음과 같이 작동합니다:

1. **Image.load** 팩토리 메서드를 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 도면 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 객체를 만들고 **page_height** 및 **page_width** 속성을 설정합니다.
1. **BmpOptions** 클래스의 객체를 만들고 **vector_rasterization_options** 속성을 설정합니다.
1. **Image.save**를 호출하면서 **BmpOptions** 객체를 두 번째 매개변수로 전달합니다.

### 샘플 코드

아래 코드 샘플은 기본 설정을 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 파일을 [BMP](https://docs.fileformat.com/image/bmp/)로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
