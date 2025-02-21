---
title: DGN AutoCAD 내보내기
type: docs
weight: 50
url: /ko/net/developer-guide/exporting-dgn-autocad/
---

## **PDF로 DGN AutoCAD 형식 내보내기**

Aspose.CAD for .NET API는 DGN AutoCAD 파일을 로드하고 PDF 형식으로 변환하는 기능을 도입했습니다. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) 클래스가 그 목적을 수행합니다.

기존 DGN 파일을 [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)로 로드해야 합니다. 다양한 속성을 설정하고 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 인스턴스를 생성합니다. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 인스턴스를 생성하고 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 인스턴스를 전달합니다. 이제 [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) 클래스 인스턴스의 [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 호출합니다.

### 샘플 코드

다음은 [DGN](https://docs.fileformat.com/cad/dgn/)을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 변환/내보내기 위한 코드 시연입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DGN AutoCAD 형식에서 래스터 이미지 형식으로 내보내기**

Aspose.CAD for .NET API는 DGN AutoCAD 파일을 로드하고 래스터 이미지로 변환하는 기능을 도입했습니다. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) 클래스가 그 목적을 수행합니다.

기존 DGN 파일을 [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)로 로드해야 합니다. 다양한 속성을 설정하고 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 인스턴스를 생성합니다. [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 클래스의 인스턴스를 생성하고 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 인스턴스를 전달합니다. 이제 [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) 클래스 인스턴스의 [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 호출합니다.

### 샘플 코드

다음은 [DGN](https://docs.fileformat.com/cad/dgn/)을 [JPEG](https://docs.fileformat.com/image/jpeg/) 이미지로 변환/내보내기 위한 코드 시연입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **DGN v7에 대한 3D 엔티티 지원**

Aspose.CAD for .NET API는 [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD 파일을 로드하고 DGN v7에 대한 3D 엔티티를 지원하는 기능을 도입했습니다. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) 클래스가 그 목적을 수행합니다. 각 [DGN](https://docs.fileformat.com/cad/dgn/) 이미지에는 9개의 미리 정의된 뷰가 지원됩니다. 이는 1부터 9까지 열거됩니다. 내보내기 할 때 뷰가 정의되지 않으면 다중 페이지 출력 형식(예: PDF)의 경우 모든 뷰가 내보내지며 각 뷰는 별도의 페이지에 있습니다. DGN 파일 형식에서도 3D 엔티티가 지원되며 2D도 지원됩니다. 이를 위해, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)를 사용하며, DGN 형식에서는 TypeOfEntities가 더 이상 사용되지 않습니다(2D와 3D가 동시에 지원됨).

### 샘플 코드

다음은 지원되는 DGN 요소를 확인하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
