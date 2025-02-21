---
title: DGN 도면
type: docs
weight: 10
url: /ko/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **DWG의 일환으로 DGN 형식 그리기**

Aspose.CAD for Java는 개발자가 내장된 DGN 언더레이가 포함된 DWG 파일을 내보낼 수 있도록 합니다. 다음은 DWG 파일을 내보내는 동안 DWG 파일 내의 DGN 언더레이에 접근하는 방법을 보여주는 코드입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **DGN v7의 3D 엔터티 지원**

Aspose.CAD for Java API는 DGN AutoCAD 파일을 로드하고 DGN v7에 대한 3D 엔터티를 지원하는 기능을 소개했습니다. [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) 클래스는 이 목적을 수행합니다. 각 DGN 이미지는 9개의 미리 정의된 보기를 지원합니다. 이는 1에서 9까지 열거됩니다. 내보내는 동안 보기가 정의되지 않은 경우, 다중 페이지 출력 형식(예: PDF)의 경우 모든 보기가 내보내지며, 각 보기마다 별도의 페이지에 표시됩니다. DGN 파일 형식에서는 2D뿐만 아니라 3D 엔터티도 지원됩니다. 

VectorRasterizationOptions.TypeOfEntities는 DGN 형식에서는 더 이상 사용되지 않으며(2D와 3D를 동시에 지원함), 이에 대한 샘플 코드는 지원되는 DGN 요소를 확인하는 데 도움이 됩니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
