---
title: SHX 글꼴 내보내기
type: docs
weight: 40
url: /ko/java/developer-guide/export-shx-fonts/
---

## **DXF/DWG 도면용 SHX 글꼴 내보내기**

일부 도면에는 기호를 형태로 저장하는 특별한 SHX 형식의 글꼴이 포함될 수 있습니다.
이 형식은 도면에서 사용되는 각 글꼴에 대한 추가 로딩 절차가 필요합니다.
Apose.CAD는 SHX로 작성된 텍스트가 포함된 도면을 내보낼 수 있으며 이를 위한 다양한 옵션이 있습니다.
가장 간단한 방법은 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 객체의 [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) 속성을 사용하는 것입니다.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

각 SHX 글꼴은 해당 글꼴과 관련된 적절한 코드 페이지와 함께 제공됩니다. 이러한 연관은 알려진 SHX 글꼴에 대해 부분적으로 Aspose.CAD에 내장되어 있습니다.
사용자가 정의한 SHX 글꼴을 사용하는 경우 **setShxCodePages** 속성을 적용하고 SHX 파일 및 해당 코드 페이지에 대한 경로를 설정할 수 있습니다.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
