---
title: 자동 코드페이지 감지
type: docs
weight: 10
url: /ko/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **자동 코드페이지 감지**

Aspose.CAD는 [DWG](https://docs.fileformat.com/cad/dwg/) 및 [DWF](https://docs.fileformat.com/cad/dwf/) 파일에 대한 자동 코드페이지 감지를 지원합니다. 이 기능을 사용하고 싶지 않다면 **LoadOptions** 클래스의 다음 속성을 설정하여 이를 무시할 수 있습니다.

- **specified_encoding**: 비유니코드 DXF 및 DWG 형식의 텍스트 데이터를 읽는 데 사용되는 인코딩을 설정합니다. 기본적으로 자동 감지됩니다.
- **specified_mif_encoding**: CJK 인코딩의 MIF 인코딩 기호를 읽는 데 사용되는 인코딩을 설정합니다 (M+nXXXX 형식). 기본적으로 자동 감지됩니다.
- **recover_malformed_cif_mif**: 적절한 AutoCAD 형식이 없는 경우 CIF (U+XXXX) 및 MIF 인코딩된 문자가 디코드될지를 정의합니다 (AutoCAD는 이러한 기호 앞에 백슬래시를 추가합니다). 기본적으로 디코드됩니다.

## 샘플 코드

아래 코드 샘플은 Aspose.CAD에서 자동 코드페이지 감지를 오버라이드하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
