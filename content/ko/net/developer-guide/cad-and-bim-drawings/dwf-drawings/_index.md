---
title: DWF 도면
type: docs
weight: 20
url: /ko/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF 도면을 PDF로 내보내기**

Aspose.CAD는 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 도면 엔티티를 로드하고 전체 도면을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 렌더링하는 기능을 제공합니다. [DWF](https://docs.fileformat.com/cad/dwf/)를 [PDF](https://docs.fileformat.com/pdf/)로 변환하는 방법은 다음과 같습니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하면서 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 두 번째 매개변수로 전달합니다.

### 샘플 코드

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF 도면에서 레이어 추출**

Aspose.CAD는 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 도면 엔티티를 로드하고 전체 도면을 [JPEG](https://docs.fileformat.com/image/jpeg/) 형식으로 렌더링하는 기능을 제공합니다.

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 도면 파일을 로드합니다.
1. [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 클래스의 객체를 생성합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성합니다.
1. [JPEG](https://docs.fileformat.com/image/jpeg/) 객체를 사용하여 레이어 이름을 추출합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하면서 [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 객체를 두 번째 매개변수로 전달합니다.

### 샘플 코드

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF의 레이어 지원**

Aspose.CAD는 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 도면 엔티티를 로드하고 전체 도면을 [JPEG](https://docs.fileformat.com/image/jpeg/) 형식으로 렌더링하는 기능을 제공합니다.

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성합니다.
1. 원하는 레이어를 추가합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하면서 [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 객체를 두 번째 매개변수로 전달합니다.

### 샘플 코드

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **DWF 도면을 BMP로 내보내기**

Aspose.CAD는 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 도면 엔티티를 로드하고 전체 도면을 [BMP](https://docs.fileformat.com/image/bmp/) 형식으로 렌더링하는 기능을 제공합니다. [DWF](https://docs.fileformat.com/cad/dwf/)를 [BMP](https://docs.fileformat.com/image/bmp/)로 변환하는 방법은 다음과 같습니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
1. [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하면서 [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) 객체를 두 번째 매개변수로 전달합니다.

### 샘플 코드

아래의 코드 샘플은 기본 설정을 사용하여 [DWF](https://docs.fileformat.com/cad/dwf/) 파일을 [BMP](https://docs.fileformat.com/image/bmp/)로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
