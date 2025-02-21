---
title: 자동 코드 페이지 감지
type: docs
weight: 10
url: /ko/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **자동 코드 페이지 감지**

Aspose.CAD는 [DWG](https://docs.fileformat.com/cad/dwg/) 및 [DWF](https://docs.fileformat.com/cad/dwf/) 파일에 대한 자동 코드 페이지 감지를 지원합니다. 이 기능을 사용하고 싶지 않은 경우, [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) 클래스의 다음 속성을 설정하여 이를 재정의할 수 있습니다.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): 비유니코드 DXF 및 DWG 형식에서 텍스트 데이터를 읽는 데 사용되는 인코딩을 설정합니다. 기본적으로 자동으로 감지됩니다.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): CJK 인코딩의 MIF 인코딩된 기호를 읽는 데 사용되는 인코딩을 설정합니다(M+nXXXX 형식). 기본적으로 자동으로 감지됩니다.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): CIF (U+XXXX) 및 MIF 인코딩된 문자가 적절한 AutoCAD 형식이 없는 경우 해독될지 여부를 정의합니다 (AutoCAD는 이러한 기호 앞에 백슬래시를 붙입니다). 기본적으로 해독됩니다.

## 샘플 코드

아래 코드 샘플은 Aspose.CAD에서 자동 코드 페이지 감지를 어떻게 재정의하는지 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
