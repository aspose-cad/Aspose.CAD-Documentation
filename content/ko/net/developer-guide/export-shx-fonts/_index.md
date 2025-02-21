---
title: SHX 글꼴 내보내기
type: docs
weight: 40
url: /ko/net/developer-guide/export-shx-fonts/
---

## **DXF/DWG 도면을 위한 SHX 글꼴 내보내기**

일부 도면에는 글꼴의 기호를 형태로 저장하는 특별한 SHX 형식의 글꼴이 포함될 수 있습니다. 이 형식은 도면에 사용되는 각 글꼴에 대해 추가 로딩 절차가 필요합니다. Apose.CAD는 SHX로 작성된 텍스트가 포함된 도면을 내보낼 수 있으며, 이를 수행하기 위한 다양한 옵션이 있습니다. 가장 간단한 방법은 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) 속성을 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 객체로 사용하는 것입니다.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


다음 예제를 사용하여 여러 SHX 글꼴의 모든 경로를 설정하지 않고도 가능하다:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
각 SHX 글꼴에는 관련된 적절한 코드 페이지가 함께 제공됩니다. 이러한 연결은 알려진 SHX 글꼴에 대해 알려져 있으며 Aspose.CAD에 부분적으로 삽입되어 있습니다.
사용자 정의 SHX 글꼴이 사용되는 경우 ShxCodePages 속성을 적용하고 SHX 파일과 해당 코드 페이지에 대한 경로를 설정할 수 있습니다. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
