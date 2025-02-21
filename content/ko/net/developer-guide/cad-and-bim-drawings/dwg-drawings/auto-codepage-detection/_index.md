---
title: 자동 코드 페이지 감지
type: docs
weight: 10
url: /ko/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **자동 코드 페이지 감지**

Aspose.CAD는 [DWG](https://docs.fileformat.com/cad/dwg/)와 [DWF](https://docs.fileformat.com/cad/dwf/) 파일에 대한 자동 코드 페이지 감지를 지원합니다. 이 기능을 사용하고 싶지 않으신 경우, 다음 속성을 설정하여 이를 무시할 수 있습니다: [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) 클래스의.

- [**지정된 인코딩**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): 비 유니코드 DXF 및 DWG 형식에서 텍스트 데이터를 읽는 데 사용되는 인코딩을 설정합니다. 기본적으로 자동으로 감지됩니다.
- [**지정된 MIF 인코딩**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): CJK 인코딩의 MIF 인코딩 기호를 읽는 데 사용되는 인코딩을 설정합니다 (M+nXXXX 형식). 기본적으로 자동으로 감지됩니다.
- [**잘못된 CIF/MIF 복구**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): CIF (U+XXXX) 및 MIF 인코딩된 문자가 적절한 AutoCAD 형식이 없을 경우 디코딩될지 여부를 정의합니다 (AutoCAD는 이러한 기호 앞에 백슬래시를 붙입니다). 기본적으로 디코딩됩니다.

## 샘플 코드

아래의 코드 샘플은 Aspose.CAD에서 자동 코드 페이지 감지를 어떻게 무시하는지를 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
