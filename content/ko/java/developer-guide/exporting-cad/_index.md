---
title: CAD 내보내기
type: docs
weight: 40
url: /ko/java/developer-guide/exporting-cad/
---

## **3D AutoCAD 이미지를 PDF로 내보내기**
Aspose.CAD를 사용하면 3D AutoCAD 이미지를 PDF로 내보낼 수 있습니다. 3D 엔터티를 내보내고 싶다면 **ImageOptions.CadRasterizationOptions**에서 **TypeOfEntities.Entities3D**를 사용하세요. 
다음 샘플 코드는 AutoCAD 3D 파일을 로드하고 PDF로 내보냅니다. 파일이 PDF로 변환되고 나면, 좋아하는 PDF 뷰어를 사용하여 열 수 있습니다.

아래의 코드 샘플은 3D AutoCAD 이미지를 PDF로 내보내는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-Export3DAutoCADImagesToPDF-.java" >}}

## **CAD 레이아웃을 PDF로 내보내기**
Aspose.CAD for Java를 사용하면 CAD 레이아웃을 PDF로 내보낼 수 있습니다. **CadImage** 클래스의 **save** 메서드를 사용하여 레이아웃을 PDF 형식으로 내보낼 수 있습니다. 
다음 샘플 코드는 CAD 파일을 로드하고 그 "모델" 레이아웃을 PDF로 내보냅니다. 파일이 PDF로 변환되고 나면, 좋아하는 PDF 뷰어를 사용하여 열 수 있습니다.

여기 샘플 코드가 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportCADLayoutsToPDF-.java" >}}

## **내보내기에서 펜 설정 지원**
Aspose.CAD for Java를 사용하면 CAD의 내보내기 속성에 펜 옵션을 추가할 수 있습니다. rasterizationOptions를 사용하여 펜 속성 옵션을 설정할 수 있습니다.

아래는 지정된 요구 사항을 충족하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}

## **Cad Insert Object 분해**
Aspose.CAD for Java를 사용하면 cad 객체를 분해하고 삽입 안의 개별 엔터티를 처리할 수 있습니다. 아래는 지정된 요구 사항을 충족하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **ACAD 프록시 엔터티 지원**
Aspose.CAD for Java를 사용하면 ACAD_PROXY_ENTITY 엔터티를 읽고 내보낼 수 있습니다. 아래는 지정된 요구 사항을 충족하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}

## **IGES 형식 통합**
Aspose.CAD for Java를 사용하면 IGES 형식을 읽고 내보낼 수 있습니다. 아래는 지정된 요구 사항을 충족하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-IGESDrawings-ExportIGEStoPDF-ExportIGEStoPDF.java" >}}

## **메쉬 모델 지원**
Aspose.CAD for Java를 사용하면 모서리, 정점 및 다각형 표현을 사용하는 면과 같은 메쉬 모델을 구현하고 집계할 수 있습니다. 아래는 지정된 요구 사항을 충족하기 위한 샘플 코드입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-MeshSupportForDWG-MeshSupportForDWG.java" >}}

## **사용자 정의 관점 설정**
Aspose.CAD for Java를 사용하면 모델 레이아웃에 대한 사용자 정의 관점을 설정할 수 있습니다. **vectorRasterizationOptions**를 사용하여 사용자 정의 관점을 설정할 수 있습니다. 아래의 코드 샘플은 사용자 정의 관점을 설정하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-FreePointOfView-FreePointOfView.java" >}}
