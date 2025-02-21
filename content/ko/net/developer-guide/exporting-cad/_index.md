---
title: CAD 내보내기
type: docs
weight: 40
url: /ko/net/developer-guide/exporting-cad/
---

## **3D AutoCAD 이미지를 PDF로 내보내기**

Aspose.CAD를 사용하면 3D AutoCAD 이미지를 PDF로 내보낼 수 있습니다. 3D 엔티티를 내보내고 싶을 경우 [**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)를 사용해 주십시오.

아래 샘플 코드는 AutoCAD 3D 파일을 로드하고 이를 [PDF](https://docs.fileformat.com/pdf/)로 내보냅니다. 파일이 PDF로 변환되면, 선호하는 PDF 뷰어를 사용하여 열 수 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **CAD 레이아웃을 PDF로 내보내기**

Aspose.CAD for .NET은 CAD 레이아웃을 PDF로 내보내는 기능을 제공합니다. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) 클래스의 [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 메서드를 사용하여 레이아웃을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 내보낼 수 있습니다.

아래 샘플 코드는 CAD 파일을 로드하고 "모델" 레이아웃을 PDF로 내보냅니다. 파일이 PDF로 변환되면, 선호하는 PDF 뷰어를 사용하여 열 수 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **내보내기에서 펜 설정 지원**

Aspose.CAD for .NET을 사용하면 CAD의 내보내기 속성에 펜 옵션을 추가할 수 있습니다. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)를 사용하여 펜 속성 옵션을 설정할 수 있습니다.

아래는 지정한 요구 사항을 달성하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **CAD 삽입 객체 분해**

Aspose.CAD for .NET은 CAD 객체를 분해하고 삽입 내에서 개별 엔티티를 처리할 수 있습니다. 아래는 지정한 요구 사항을 달성하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **ACAD 프록시 엔티티 지원**

Aspose.CAD for .NET은 ACAD_PROXY_ENTITY 엔티티를 읽고 내보낼 수 있습니다. 아래는 지정한 요구 사항을 달성하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **IGES 형식 통합**

Aspose.CAD for .NET은 IGES 형식을 읽고 내보낼 수 있습니다. 아래는 지정한 요구 사항을 달성하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **메시 모델 지원**

Aspose.CAD for .NET은 가장자리, 정점 및 면과 같은 메시 모델을 구현하고 계산할 수 있습니다. 아래는 지정한 요구 사항을 달성하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **사용자 지정 시점 설정**

Aspose.CAD for .NET은 모델 레이아웃을 위한 사용자 지정 시점을 설정할 수 있습니다. [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)를 사용하면 사용자 지정 시점을 설정할 수 있습니다. 아래 샘플 코드는 사용자 지정 시점을 설정하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
