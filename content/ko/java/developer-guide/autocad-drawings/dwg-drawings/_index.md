---
title: DWG 도면
type: docs
weight: 40
url: /ko/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **DWG 도면을 PDF로 내보내기**

Aspose.CAD for Java API는 DWG 형식의 AutoCAD 도면을 로드하고 PDF로 변환할 수 있습니다. 이 주제에서는 DWG를 PDF 형식으로 변환하는 간단한 단계를 정의하여 Aspose.CAD API의 사용법을 설명합니다.

{{% alert color="primary" %}}

API는 다음 AutoCAD DWG 개정판을 지원합니다:

- DWG 2004 버전 16.0 릴리스 18
- DWG 2005 버전 16.1
- DWG 2010 버전 18.0
- DWG 2013 버전 19.0

{{% /alert %}}

### **DWG 파일 형식**

DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 바이너리 파일입니다. 벡터 이미지 데이터는 CAD 응용 프로그램에 DWG를 표시하는 방법에 대한 지침을 제공하며, 메타데이터에는 위치별 데이터 및 클라이언트 데이터와 같은 다양한 정보가 포함될 수 있습니다. DWG 파일 형식에 대한 개방 사양은 [이 PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)에서 확인할 수 있습니다.

### **DWG 파일을 PDF로 변환하기**

DWG를 PDF로 변환하기 위해 다음과 같은 간단한 단계가 필요합니다.

1. [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image)의 인스턴스에 DWG 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 및 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 호출하고 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 객체를 두 번째 매개변수로 전달합니다.

아래의 코드 샘플은 DWG 도면을 PDF로 내보내는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **다양한 레이아웃 크기로 단일 PDF 생성하기**

Aspose.CAD for Java를 사용하면 DWG 파일을 다양한 레이아웃 크기로 단일 PDF로 변환할 수 있습니다. 이 접근 방식은 다음과 같이 작동합니다:

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 인스턴스를 생성하고 결과 페이지 높이와 너비를 설정합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 객체를 위한 필수 [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-)를 추가합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 클래스의 인스턴스를 생성하고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래의 코드 샘플은 서로 다른 레이아웃을 가진 단일 PDF를 생성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **DWG를 PDF/A 및 PDF/E로 내보내기**

DWG를 PDF로 변환하기 위해 필요한 간단한 단계는 다음과 같습니다.

1. [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image)의 인스턴스에 DWG 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 및 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 호출하고 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 객체를 두 번째 매개변수로 전달합니다.

아래의 코드 샘플은 DWG 도면을 PDF로 내보내는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **지원되는 AutoCAD 원시 객체**

다음 AutoCAD 원시 객체가 지원됩니다.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **특정 DWG 레이아웃을 PDF로 내보내기**

이 접근 방식은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 인스턴스를 생성하고 결과 페이지 높이와 너비를 설정합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 객체에 대한 [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 클래스의 인스턴스를 생성하고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래의 코드 샘플은 DWG의 특정 레이아웃을 PDF로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **고정 크기로 DWG를 래스터 또는 PDF로 내보내기**

Aspose.CAD for Java API는 DWG 형식의 AutoCAD 도면을 로드하고 고정 크기를 사용하여 PDF 또는 래스터로 변환할 수 있습니다.

아래의 코드 샘플은 이 기능을 구현하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **DWG/DXF를 BMP 및 PDF로 내보낼 때 둥근 숨겨진 선 지원**

이 접근 방식은 다음과 같이 작동합니다:

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 인스턴스를 생성합니다.
1. 결과 페이지 높이와 너비를 설정하기 위해 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 또 다른 인스턴스를 생성합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 클래스의 인스턴스를 생성하고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래의 코드 샘플은 이 기능을 구현하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **내보낸 PDF에서 DWG 이미지의 인쇄 영역 설정 지원**

Aspose.CAD for Java API는 DWG 형식의 AutoCAD 도면을 로드하고 PDF로 변환할 수 있습니다. 이 주제에서는 내보낸 PDF에서 DWG 이미지의 인쇄 영역 설정 지원을 달성하기 위한 Aspose.CAD API의 사용법을 설명합니다.

아래의 코드 샘플은 이 기능을 구현하는 방법을 보여줍니다.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG 파일에 대한 XREF 메타데이터 읽기 지원**

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
2. 모든 이미지 엔티티를 탐색합니다.
3. 엔티티가 [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay)인 경우 XREF 엔티티와 메타데이터를 연결합니다.

아래의 코드 샘플은 이 기능을 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **좌표를 지정하여 DWG 문서 가져오기**

Aspose.CAD for Java API는 이제 문서의 너비와 높이의 좌표를 제공하여 DWG 문서를 렌더링하는 기능을 제공합니다.

아래의 코드 샘플은 DWG 문서를 렌더링하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

속성 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--)는 문자열 배열 형식이므로 PDF 형식으로 변환할 수 있는 여러 레이아웃을 한 번에 지정할 수 있습니다. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 속성을 위해 여러 레이아웃을 지정하면 결과 PDF는 여러 페이지를 포함하게 되며, 각 페이지는 개별 AutoCAD 레이아웃을 나타냅니다.

### **모든 레이아웃 나열하기**

다음 코드 스니펫을 사용하여 AutoCAD 도면에 있는 모든 레이아웃을 나열할 수 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **외부 참조의 블록 속성 값 가져오기**

Aspose.CAD for Java API를 사용하여 블록 속성의 외부 참조를 가져올 수 있습니다. Aspose.CAD API는 [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) 속성을 노출하여 [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) 컬렉션에서 블록 속성의 외부 참조를 가져옵니다.

다음 코드는 블록 속성의 외부 참조를 가져오는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **DWG AutoCAD 파일에서 텍스트 검색하기**

Aspose.CAD for Java API는 DWG AutoCAD 파일에서 텍스트를 검색하는 기능을 제공합니다. Aspose.CAD API는 DWG AutoCAD 파일에서 텍스트 엔티티를 나타내는 [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) 클래스를 노출합니다. 클래스 [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText)도 Aspose.CAD API에 포함되어 있으며, 일부 다른 엔티티도 텍스트를 포함할 수 있습니다.

다음 코드는 DWG AutoCAD 파일에서 텍스트를 검색하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **특정 레이아웃에서 텍스트 검색하기**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **DWG 형식의 언더레일 플래그에 접근하기**

Aspose.CAD for Java는 DWG 형식의 언더레일 플래그를 구현하였으며, 개발자들이 이를 접근할 수 있게 합니다. 다음은 간단한 코드 데모입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **DWG 엔티티 지원**

Aspose.CAD for Java API는 DWG 형식의 AutoCAD 도면을 로드할 수 있으며, 다양한 엔티티와 함께 작업할 수 있도록 지원합니다.

### **MLeader 엔티티 지원**

DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 바이너리 파일입니다. DWG 파일에는 다양한 엔티티가 있습니다. 다음 섹션에서는 DWG 파일 내에서 MLeader 엔티티를 사용하는 예제를 설명합니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **DWG 엔티티를 이미지로 내보내기 지원**

DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 바이너리 파일입니다. DWG 파일에는 다양한 엔티티가 존재합니다. 다음 섹션에서는 특정 DWG 엔티티를 이미지로 내보내는 예제를 설명합니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **DWG 파일에 이미지 가져오기 지원**

Aspose.CAD for Java API는 DWG 형식의 AutoCAD 도면을 로드하고 다양한 엔티티와 함께 작업할 수 있도록 지원합니다. DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 바이너리 파일입니다. DWG 파일에는 다양한 엔티티가 있습니다. 다음 섹션에서는 DWG 파일 내에 이미지를 가져오는 방법을 설명합니다.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **DWG에 텍스트 추가 지원**

Aspose.CAD for Java API는 DWG 형식의 AutoCAD 도면을 로드하고 다양한 엔티티와 함께 작업할 수 있도록 지원합니다. DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 바이너리 파일입니다. DWG 파일에는 다양한 엔티티가 있습니다. 다음 섹션에서는 DWG 파일 내에 텍스트를 추가하는 방법을 설명합니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **DWG에서 메쉬 지원**

Aspose.CAD for Java API는 이제 [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) 및 [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) 유형을 포함하여 메쉬를 지원하는 엔티티에 접근할 수 있습니다. 다음 예제에서는 메쉬 유형에 접근하는 방법을 설명합니다.

## **DWG 도면을 DXF로 변환하기**

Aspose.CAD는 AutoCAD DWG 파일을 로드하고 DXF 형식으로 내보내는 기능을 제공합니다. DWG에서 DXF로의 변환 접근 방식은 다음과 같이 작동합니다:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메서드를 사용하여 DWG 도면 파일을 로드합니다.
2. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 사용하여 DWG 도면을 DXF로 내보냅니다.

아래의 코드 샘플은 DWG 파일을 DXF 형식으로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **DWG 도면을 SVG로 변환하기**

Aspose.CAD API는 DWG 형식의 AutoCAD 도면을 로드하고 SVG로 변환할 수 있습니다. 이 주제에서는 DWG를 SVG 형식으로 변환하는 방법을 설명합니다.

1. [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image)의 인스턴스에 DWG 파일을 로드합니다.
2. [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) 클래스의 객체를 생성하고 필요한 속성을 설정합니다.
3. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 사용하여 DWG 도면을 SVG로 내보냅니다.

아래의 코드 샘플은 DWG 파일을 SVG 형식으로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
