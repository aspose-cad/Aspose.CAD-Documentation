---
title: DXF 도면
type: docs
weight: 60
url: /ko/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **DXF 도면을 PDF로 내보내기**

Aspose.CAD는 AutoCAD DXF 도면 엔티티를 로드하고 이를 전체 도면으로 PDF 형식으로 렌더링하는 기능을 제공합니다. DXF에서 PDF로 변환하는 방법은 다음과 같습니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 객체를 만들고 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 및 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 클래스의 객체를 만들고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. 두 번째 매개변수로 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/PdfOptions) 객체를 전달하면서 Image.Save를 호출합니다.

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **지원되는 형식**

현재 우리는 AutoCAD DXF 2010 파일 형식을 완전히 지원합니다. 이전 DXF 버전은 100% 유효성을 보장하지 않습니다. 향후 Aspose.CAD 버전에서 더 많은 형식과 기능을 포함할 계획입니다.

### **지원되는 엔티티**

현재 우리는 모든 널리 퍼진 2D 엔티티와 그 기본 기본 매개변수를 다음과 같이 지원합니다:

1. 정렬 치수
1. 각도 치수
1. 호
1. 속성
1. 블록 참조
1. 원
1. 지름 치수
1. 타원
1. 해칭
1. 선
1. 다중선 텍스트
1. 좌표 치수
1. 점
1. 다각선
1. 반지름 치수
1. 광선
1. 회전 치수
1. 테이블
1. 텍스트
1. X선

{{% alert color="primary" %}}

파싱 중 지원하지 않는 엔티티나 속성을 만나면 해당 엔티티나 속성은 조용히 무시됩니다.

{{% /alert %}}

### **메모리 관리**

속성 [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--)는 메모리 재할당을 제어하는 데 사용할 수 있습니다. 재할당은 미리 할당된 캐시에 대해 가장 많이 발생합니다. 시스템이 할당된 공간이 충분하지 않을 것이라고 판단할 때 발생할 수 있습니다.

- [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--)가 기본값인 **False**로 설정된 경우, 공간은 동일한 매체로 재할당됩니다.
- **True**로 설정된 경우, 재할당은 지정된 최대 공간을 초과할 수 없습니다. 이 경우, 기존의 메모리 캐시(재할당이 필요한)는 해제되고 디스크에 확장된 공간이 할당됩니다.

## **특정 DXF 도면의 레이어를 PDF로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 엽니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 의 인스턴스를 만들고 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 및 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageHeight-float-) 속성을 지정합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 객체에 레이어를 추가합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 의 인스턴스를 만들고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메소드를 사용하여 도면을 PDF로 내보냅니다.

아래의 코드 샘플은 DXF의 특정 레이어를 PDF로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **특정 DXF 도면의 레이어를 이미지로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 엽니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 의 인스턴스를 만들고 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) 및 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageHeight-float-) 속성을 지정합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 객체에 레이어를 추가합니다.
1. [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/JpegOptions) 의 인스턴스를 만들고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메소드를 사용하여 도면을 PDF로 내보냅니다.

아래의 코드 샘플은 DXF의 특정 레이어를 이미지로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **DXF 도면의 일부로 PDF 파일 렌더링하기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/CadRasterizationOptions) 클래스의 객체를 만들고 PDF 파일을 로드합니다.
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageHeight-float-) 및 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)를 호출하여 파일을 저장합니다.

아래의 코드 샘플은 DXF 도면의 일부로 PDF 파일을 렌더링하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **DXF를 WMF로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/CadRasterizationOptions) 클래스의 객체를 만들고 PDF 파일을 로드합니다.
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageHeight-float-) 및 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/Image#save--)를 호출하여 파일을 저장합니다.

아래의 코드 샘플은 DXF를 WMF로 내보내는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **DXF 파일 저장 지원**

Aspose.CAD는 AutoCAD DXF 파일을 로드하고 이를 수정한 후 다시 DXF 파일로 저장하는 기능을 제공합니다. 아래의 코드 샘플은 지정된 요구 사항을 충족하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **DXF 형식의 임베디드 DGN 언더레이 내보내기**

Aspose.CAD는 AutoCAD DXF 파일을 로드하고 DXF 형식의 임베디드 DGN 언더레이를 내보내는 기능을 제공합니다.

아래의 코드 샘플은 지정된 요구 사항을 충족하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **특정 DXF 레이아웃을 PDF로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 엽니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 의 인스턴스를 만들고 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 및 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageHeight-float-) 속성을 지정합니다.
1. 원하는 레이아웃 이름을 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 속성을 사용하여 지정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/PdfOptions)의 인스턴스를 만들고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/Image#save--) 메소드를 사용하여 도면을 PDF로 내보냅니다.

아래의 코드 샘플은 DXF의 특정 레이아웃을 PDF로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

속성 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-)는 문자열 배열 유형이므로 한 번에 여러 개의 레이아웃을 PDF 형식으로 변환하기 위해 지정할 수 있습니다. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 속성에 대해 여러 레이아웃을 지정하면 결과 PDF에는 여러 페이지가 포함되며, 각 페이지는 개별 AutoCAD 레이아웃을 나타냅니다.

{{% /alert %}}

## **ATTRIB 및 MTEXT 개체 접근하기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 엽니다.
1. CAD 파일 내의 엔티티에 접근합니다.
1. [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) 및 [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) 엔티티를 확인합니다.
1. 추가 처리를 위해 임시 목록으로 추가합니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **CAD 삽입 개체 분해하기**

이 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 **DXF** 도면 파일을 엽니다.
1. CAD 파일 내의 엔티티에 접근합니다.
1. [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) 엔티티를 확인합니다.
1. [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) 유형 목록을 확인합니다.
1. 엔티티를 처리합니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **블록 클리핑 지원**

Aspose.CAD는 블록 클리핑 기능을 제공합니다. 블록 클리핑 방법은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메소드를 사용하여 DXF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/CadRasterizationOptions) 클래스의 객체를 만들고 PDF 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/CadRasterizationOptions) 의 원하는 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/Image#save--)를 호출하면서 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/PdfOptions) 객체를 두 번째 매개변수로 전달하여 파일을 저장합니다.

아래의 코드 샘플은 블록 클리핑의 작동 방식을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **이미지를 DXF로 내보내기**

Aspose.CAD를 사용하여 이미지 를 DXF 형식으로 내보낼 수 있습니다. 이 방법을 사용하여 다음 작업을 수행할 수 있습니다:

1. 새 글꼴 설정
1. 엔티티 숨기기
1. 텍스트 업데이트

다음 코드 스니펫은 나열된 작업을 수행하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
