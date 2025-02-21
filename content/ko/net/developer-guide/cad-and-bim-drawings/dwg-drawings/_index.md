---
title: DWG 도면
type: docs
weight: 40
url: /ko/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG 도면을 PDF로 내보내기**

Aspose.CAD for .NET API는 AutoCAD 도면을 [DWG](https://docs.fileformat.com/cad/dwg/) 형식으로 로드하고 이를 [PDF](https://docs.fileformat.com/pdf/)로 변환할 수 있습니다. 이 주제에서는 간단한 단계를 통해 DWG를 PDF 형식으로 변환하는 Aspose.CAD API의 사용법을 설명합니다.

{{% alert color="primary" %}}

이 API는 다음의 AutoCAD DWG 버전을 지원합니다:

- DWG 2004 버전 16.0 릴리스 18
- DWG 2005 버전 16.1
- DWG 2010 버전 18.0
- DWG 2013 버전 19.0

{{% /alert %}}

### **DWG 파일 형식**

[DWG](https://docs.fileformat.com/cad/dwg/)는 벡터 이미지 데이터와 메타데이터를 포함하는 이진 파일입니다. 벡터 이미지 데이터는 CAD 애플리케이션에 DWG를 어떻게 표시할 것인지에 대한 지침을 제공합니다. 메타데이터는 파일에 대한 다양한 정보를 포함할 수 있으며, 여기에는 위치 관련 데이터와 클라이언트 데이터도 포함됩니다. DWG 파일 형식에 대한 공개 사양은 [이 PDF 문서](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)에서 찾을 수 있습니다.

### **DWG 파일을 PDF로 변환하기**

다음의 간단한 단계가 필요합니다 [DWG](https://docs.fileformat.com/cad/dwg/)를 [PDF](https://docs.fileformat.com/pdf/)로 변환하기 위해:

1. [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 인스턴스에 DWG 파일을 로드합니다.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.
3. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save)를 호출하며, [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 두 번째 매개변수로 전달합니다.

아래 코드 샘플은 DWG 도면을 PDF로 내보내는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **다양한 레이아웃 크기로 하나의 PDF 생성하기**

Aspose.CAD for .NET은 DWG 파일을 다양한 레이아웃 크기로 하나의 PDF로 변환할 수 있습니다. 이 방법은 다음과 같이 작동합니다:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 인스턴스를 생성하고 결과 페이지 높이 및 너비를 설정합니다.
3. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 객체에 필요한 [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes)를 추가합니다.
4. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 인스턴스를 생성하고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
5. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래 코드 샘플은 다양한 레이아웃으로 하나의 [PDF](https://docs.fileformat.com/pdf/)를 만드는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **지원되는 AutoCAD 프리미티브**

다음의 AutoCAD 프리미티브가 지원됩니다.

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

이 방법은 다음과 같이 작동합니다:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 인스턴스를 생성하고 결과 페이지 높이 및 너비를 설정합니다.
3. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 객체에 대한 [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 속성을 설정합니다.
4. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 인스턴스를 생성하고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
5. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래 코드 샘플은 특정 DWG 레이아웃을 PDF로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **좌표를 지정하여 DWG 문서 렌더링**

Aspose.CAD for .NET API는 이제 문서의 너비와 높이의 좌표를 제공하여 DWG 문서를 렌더링하는 기능을 제공합니다.

아래 코드 샘플은 DWG 문서를 렌더링하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **고정 크기를 사용하여 DWG를 래스터 또는 PDF로 내보내기**

Aspose.CAD for .NET API는 DWG 형식의 AutoCAD 도면을 로드하고 고정 크기를 사용하여 PDF 또는 래스터로 변환할 수 있습니다.

아래 코드 샘플은 이 기능을 구현하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **DWG를 PDF/A 및 PDF/E로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 인스턴스를 생성합니다.
3. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 인스턴스를 생성하고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
4. PDF 준수 속성을 설정하고 저장합니다.
5. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래 코드 샘플은 DWG 파일을 PDF/A 및 PDF/E로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **DWG/DXF를 BMP 및 PDF로 내보낼 때 라운드 숨은 선 지원**

이 방법은 다음과 같이 작동합니다:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 인스턴스를 생성하고 결과 페이지 높이 및 너비를 설정합니다.
3. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 인스턴스를 생성하고 그 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 속성을 설정합니다.
4. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 이미지를 PDF로 내보냅니다.

아래 코드 샘플은 이 기능을 구현하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **내보낸 PDF에서 DWG 이미지의 인쇄 영역 설정 지원**

Aspose.CAD for .NET API는 DWG 형식의 AutoCAD 도면을 로드하고 PDF로 변환할 수 있습니다. 이 주제에서는 내보낸 PDF에서 DWG 이미지에 대한 인쇄 영역 설정 지원을 달성하는 Aspose.CAD API의 사용법을 설명합니다.

아래 코드 샘플은 이 기능을 구현하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG 파일의 XREF 메타데이터 읽기 지원**

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 DWG 파일을 로드합니다.
2. 모든 이미지 개체를 순회합니다.
3. 개체가 CadUnderlay인 경우 메타데이터가 있는 XREF 개체입니다.

아래 코드 샘플은 이 기능을 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 속성은 문자열 배열 형식이므로 PDF 형식으로 가능한 변환을 위해 한 번에 여러 개의 레이아웃을 지정할 수 있습니다. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 속성에 대해 여러 레이아웃을 지정할 때 결과 PDF에는 여러 페이지가 포함되며, 각 페이지는 개별 AutoCAD 레이아웃을 나타냅니다.

### **모든 레이아웃 목록**

다음 코드 스니펫을 사용하여 AutoCAD 도면에 존재하는 모든 레이아웃을 나열할 수 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **DWG 형식에 대한 언더레이 플래그 접근 지원**

Aspose.CAD for .NET은 DWG 형식에 대한 언더레이 플래그를 구현하였으며, 개발자가 이를 액세스할 수 있도록 허용합니다. 다음은 간단한 코드 데모입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **DWG 개체 지원**

Aspose.CAD for .NET API는 DWG 형식의 AutoCAD 도면을 로드하고 다양한 개체를 지원하여 작업할 수 있습니다.

### **MLeader 개체에 대한 지원**

DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 이진 파일입니다. DWG 파일에는 다양한 개체가 있습니다. 다음 섹션에서는 DWG 파일 내에서 MLeader 개체와 작업하는 예를 설명합니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **DWG 개체를 이미지로 내보내는 지원**

DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 이진 파일입니다. DWG 파일에는 다양한 개체가 있습니다. 다음 섹션에서는 특정 DWG 개체를 이미지로 내보내는 예를 설명합니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **DWG에 텍스트 추가 지원**

Aspose.CAD for .NET API는 DWG 형식의 AutoCAD 도면을 로드하고 다양한 개체를 지원하여 작업할 수 있습니다. DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 이진 파일입니다. DWG 파일에는 다양한 개체가 있습니다. 다음 섹션에서는 DWG 파일 내에 텍스트를 추가하는 방법을 설명합니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **DWG 파일에 이미지 가져오기 지원**

Aspose.CAD for .NET API는 DWG 형식의 AutoCAD 도면을 로드하고 다양한 개체를 지원하여 작업할 수 있습니다. DWG는 벡터 이미지 데이터와 메타데이터를 포함하는 이진 파일입니다. DWG 파일에는 다양한 개체가 있습니다. 다음 섹션에서는 DWG 파일 내에 이미지를 가져오는 방법을 설명합니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **DWG에서 메시 지원**

Aspose.CAD for .NET API는 이제 [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) 및 [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) 유형을 포함한 메시를 지원하는 엔티티에 접근할 수 있습니다. 다음 예제는 메시 유형에 접근하는 방법을 설명합니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **DWG 도면을 DXF로 변환하기**

Aspose.CAD는 AutoCAD DWG 파일을 로드하고 DXF 형식으로 내보내는 기능을 제공합니다. DWG에서 DXF로 변환하는 방법은 다음과 같습니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 팩토리 메서드를 사용하여 DWG 도면 파일을 로드합니다.
2. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 DWG 도면을 DXF로 내보냅니다.

아래 코드 샘플은 DWG 파일을 DXF 형식으로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **DWG 도면을 SVG로 변환하기**

Aspose.CAD for .NET API는 DWG 형식의 AutoCAD 도면을 로드하고 이를 SVG로 변환할 수 있습니다. 이 주제에서는 간단한 단계를 통해 DWG를 SVG 형식으로 변환하는 Aspose.CAD API의 사용법을 설명합니다.

1. [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 인스턴스에 DWG 파일을 로드합니다.
2. [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) 클래스의 객체를 생성하고 필요한 속성을 설정합니다.
3. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 DWG 도면을 SVG로 내보냅니다.

아래 코드 샘플은 DWG 파일을 SVG 형식으로 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **대형 DWG 파일 로드하기**

Aspose.CAD for .NET은 [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 클래스를 사용하여 매우 큰 DWG 파일을 열 수 있는 기능을 제공합니다. 이제 아래의 샘플 코드를 통해 대형 파일을 쉽게 열 수 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
