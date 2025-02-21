---
title: DXF 도면
type: docs
weight: 60
url: /ko/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF 도면을 PDF로 내보내기**

Aspose.CAD는 AutoCAD DXF 도면 엔티티를 로드하고 전체 도면을 PDF 형식으로 렌더링하는 기능을 제공합니다. DXF에서 PDF로의 변환 방법은 다음과 같습니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하고 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 두 번째 매개변수로 전달합니다.

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **지원하는 형식**

현재 우리는 AutoCAD DXF 2010 파일 형식을 완전히 지원합니다. 이전 DXF 버전은 100% 유효성을 보장하지 않습니다. 향후 Aspose.CAD 버전에서는 더 많은 형식 및 기능을 포함할 계획입니다.

### **지원하는 엔티티**

현재 우리는 모든 널리 사용되는 2D 엔티티 및 기본 기본 매개변수를 다음과 같이 지원합니다:

1. 정렬 치수
1. 각도 치수
1. 호
1. 속성
1. 블록 참조
1. 원
1. 지름 치수
1. 타원
1. 해치
1. 선
1. 다중선 텍스트
1. 절대 좌표 치수
1. 점
1. 폴리라인
1. 방사형 치수
1. 광선
1. 회전 치수
1. 테이블
1. 텍스트
1. 엑스라인

{{% alert color="primary" %}}

파싱 중 지원하지 않는 엔티티 또는 속성을 만나면 해당 엔티티 또는 속성은 무시됩니다.

{{% /alert %}}

### **메모리 관리**

[**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) 클래스의 [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) 속성을 사용하여 메모리 재배치를 제어할 수 있습니다. 재배치는 미리 할당된 캐시에 대해 발생할 가능성이 높습니다. 시스템이 할당된 공간이 충분하지 않다고 판단할 때 발생할 수 있습니다.

- 기본값인 **False**로 설정된 경우, 공간은 동일한 매체에 재할당됩니다.
- **True**로 설정된 경우, 재배치는 지정된 최대 공간을 초과할 수 없습니다. 이 경우 기존의 메모리 내 캐시(재배치가 필요한 경우)는 해제되고 디스크에 확장된 공간이 할당됩니다.

## **특정 DXF 도면 레이어를 PDF로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DXF 도면 파일을 엽니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)의 인스턴스를 생성하고 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 및 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 속성을 지정합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 객체에 레이어를 추가합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 인스턴스를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 호출하고 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 두 번째 매개변수로 전달합니다.

아래의 코드 샘플은 DXF의 특정 레이어를 PDF로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **DXF 도면의 PDF 파일 렌더링**

이 방법은 다음과 같이 작동합니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 PDF 파일을 로드합니다.
1. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하고 파일을 저장합니다.

아래의 코드 샘플은 DXF 도면의 일부로 PDF 파일을 렌더링하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **DXF 형식의 내장 DGN 언더레이 내보내기**

Aspose.CAD는 AutoCAD DXF 파일을 로드하고 DXF 형식의 내장 DGN 언더레이를 내보내는 기능을 제공합니다.

아래의 코드 샘플은 지정된 요구 사항을 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DXF 파일 저장 지원**

Aspose.CAD는 AutoCAD DXF 파일을 로드하고 수정한 후 다시 DXF 파일로 저장하는 기능을 제공합니다.

아래의 코드 샘플은 지정된 요구 사항을 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **DXF를 WMF로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 PDF 파일을 로드합니다.
1. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하고 파일을 저장합니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **특정 DXF 레이아웃을 PDF로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DXF 도면 파일을 엽니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 인스턴스를 생성하고 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 및 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 속성을 지정합니다.
1. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 속성을 사용하여 원하는 레이아웃 이름을 지정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 인스턴스를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 호출하여 도면을 PDF로 내보내고 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 두 번째 매개변수로 전달합니다.

아래의 코드 샘플은 특정 DXF 레이아웃을 PDF로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

속성 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts)는 문자열 배열형이므로 PDF 형식으로 변환할 수 있는 한 번에 여러 레이아웃을 지정할 수 있습니다. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 속성을 위해 여러 레이아웃을 지정하면 결과 PDF는 여러 페이지를 가지게 되며, 각 페이지는 개별 AutoCAD 레이아웃을 나타냅니다.

{{% /alert %}}

## **블록 클리핑 지원**

Aspose.CAD는 블록 클리핑 기능을 제공합니다. 블록 클리핑 접근 방식은 다음과 같이 작동합니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 PDF 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)의 원하는 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하고 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 두 번째 매개변수로 전달하여 파일을 저장합니다.

아래의 코드 샘플은 블록 클리핑이 작동하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **이미지를 DXF로 내보내기**

Aspose.CAD를 사용하여 이미지를 DXF 형식으로 내보낼 수 있습니다. 이 접근 방식을 사용하면 다음 작업을 수행할 수 있습니다:

1. 새로운 글꼴 설정
1. 엔티티 숨기기
1. 텍스트 업데이트

다음 코드 샘플은 위에 나열된 작업을 수행하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **특정 DXF 도면 레이어를 이미지로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DXF 도면 파일을 엽니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 인스턴스를 생성하고 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 및 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 속성을 지정합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 객체에 레이어를 추가합니다.
1. [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 인스턴스를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 도면을 PDF로 내보냅니다.

아래의 코드 샘플은 특정 DXF 레이어를 이미지로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
