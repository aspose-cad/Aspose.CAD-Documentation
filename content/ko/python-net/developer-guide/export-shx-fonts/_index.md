---
title: SHX 폰트 내보내기
type: docs
weight: 40
url: /ko/python-net/developer-guide/export-shx-fonts/
---

## **DXF/DWG 도면용 SHX 폰트 내보내기**

일부 도면에는 문자 모양을 형태로 저장하는 특별한 SHX 형식의 폰트가 포함될 수 있습니다. 이 형식은 도면에서 사용되는 각 폰트에 대해 추가 로딩 절차가 필요합니다. Apose.CAD는 SHX로 작성된 텍스트가 포함된 도면을 내보낼 수 있으며, 이를 수행하는 다양한 옵션이 있습니다. 가장 간단한 방법은 
**CadRasterizationOptions** 객체의 
**ShxFonts** 속성을 사용하는 것입니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
