---
title: DWG 도면
type: docs
weight: 70
url: /ko/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG 도면을 PDF로 내보내기**

Aspose.CAD for Python API는 [DWG](https://docs.fileformat.com/cad/dwg/) 형식의 AutoCAD 도면을 로드하고 [PDF](https://docs.fileformat.com/pdf/)로 변환할 수 있습니다. 이 주제에서는 DWG를 PDF 형식으로 변환하기 위한 Aspose.CAD API의 사용법을 간단한 단계에 따라 설명합니다.

{{% alert color="primary" %}}

API는 다음의 AutoCAD DWG 개정판을 지원합니다:

- DWG 2004 버전 16.0 릴리스 18
- DWG 2005 버전 16.1
- DWG 2010 버전 18.0
- DWG 2013 버전 19.0

{{% /alert %}}

### **DWG 파일 형식**

[DWG](https://docs.fileformat.com/cad/dwg/)는 벡터 이미지 데이터와 메타데이터를 포함하는 이진 파일입니다. 벡터 이미지 데이터는 DWG를 표시하는 방법에 대한 지침을 CAD 애플리케이션에 제공합니다; 메타데이터는 파일에 대한 위치별 데이터와 클라이언트 데이터를 포함할 수 있는 다양한 정보를 포함할 수 있습니다. DWG 파일 형식에 대한 개방 사양은 [이 PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)에서 찾을 수 있습니다.

### **DWG 파일을 PDF로 변환하기**

[DWG](https://docs.fileformat.com/cad/dwg/)를 [PDF](https://docs.fileformat.com/pdf/)로 변환하기 위해 필요한 간단한 단계는 다음과 같습니다.

1. DWG 파일을 **Image** 인스턴스로 로드합니다.
1. **CadRasterizationOptions** 클래스의 객체를 만들고 **page_height** 및 **page_width** 속성을 설정합니다.
1. **PdfOptions** 클래스의 객체를 만들고 **VectorRasterizationOptions** 속성을 설정합니다.
1. 두 번째 매개변수로 **PdfOptions** 객체를 전달하면서 **Image.save**를 호출합니다.

아래의 코드 샘플은 DWG 도면을 PDF로 내보내는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **지원되는 AutoCAD 프리미티브**

다음 AutoCAD 프리미티브가 지원됩니다.

- 텍스트
- 다중 텍스트
- 속성 정의
- 속성
- 호
- 타원
- 해칭
- 리더
- 점
- 버텍스 2D
- 버텍스 3D
- 다각선 2D
- LWPOLYLINE
- 광선
- 원
- 치수 오르디네이트
- 치수 선형
- 치수 정렬
- 치수 각도 3점
- 치수 각도 2선
- 치수 반지름
- 치수 지름
- 모양
- 고체
- 스플라인
- 다중 선
- 선
- 광선
- 스타일
- 치수 스타일
- 선 종류
- 다중 선 스타일
- 레이어
- 뷰포트
- 레이아웃

## **특정 DWG 레이아웃을 PDF로 내보내기**

이 접근 방식은 다음과 같이 작동합니다:

1. **Aspose.CAD.Image.load** 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 인스턴스를 만들고 결과 페이지 높이와 너비를 설정합니다.
1. **CadRasterizationOptions** 객체에 **Layouts** 속성을 설정합니다.
1. **PdfOptions** 클래스의 인스턴스를 만들고 그 **VectorRasterizationOptions** 속성을 설정합니다.
1. **Image.save()** 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래의 코드 샘플은 DWG의 특정 레이아웃을 PDF로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **DWG를 PDF/A 및 PDF/E로 내보내기**

이 접근 방식은 다음과 같이 작동합니다:

1. **Image.load** 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 인스턴스를 만듭니다.
1. **PdfOptions** 클래스의 인스턴스를 만들고 그 **VectorRasterizationOptions** 속성을 설정합니다.
1. PDF 준수 속성을 설정하고 저장합니다.
1. **Image.save()** 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래의 코드 샘플은 DWG 파일을 PDF/A 및 PDF/E로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **DWG 도면을 DXF로 변환하기**

Aspose.CAD는 AutoCAD DWG 파일을 로드하고 DXF 형식으로 내보내는 기능을 제공합니다. DWG에서 DXF로 변환하는 접근 방식은 다음과 같이 작동합니다:

1. **Image.load** 팩토리 메서드를 사용하여 DWG 도면 파일을 로드합니다.
1. **Image.save()** 메서드를 사용하여 DWG 도면을 DXF로 내보냅니다.

아래의 코드 샘플은 DWG 파일을 DXF 형식으로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **DWG 도면을 SVG로 변환하기**

Aspose.CAD for Python API는 DWG 형식의 AutoCAD 도면을 로드하고 SVG로 변환할 수 있습니다. 이 주제에서는 DWG를 SVG 형식으로 변환하기 위한 Aspose.CAD API의 사용법을 아래의 간단한 단계에 따라 설명합니다.

1. DWG 파일을 **Image** 인스턴스로 로드합니다.
1. **SvgOptions** 클래스의 객체를 만들고 필요한 속성을 설정합니다.
1. **Image.save()** 메서드를 사용하여 DWG 도면을 SVG로 내보냅니다.

아래의 코드 샘플은 DWG 파일을 SVG 형식으로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
