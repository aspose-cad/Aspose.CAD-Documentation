---
title: CTB 파일 지원
type: docs
weight: 40
url: /ko/net/developer-guide/support-ctb/
---

## **CTB 파일 지원**

가끔 색상, 선굵기 및 기타 도면 옵션은 도면 자체뿐만 아니라 별도의 CTB 파일의 플롯 스타일에서도 사용할 수 있습니다. 
이 정보를 사용하는 가장 간단한 방법은 해당 CTB 파일을 DWG/DXF 형식의 도면 파일 가까이에 두는 것이며, 이들로부터의 정보는
내보내기 과정에서 자동으로 적용됩니다.

모든 CTB 파일을 Stream 형태로 로드하는 것도 가능합니다. 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) 속성을 사용하여 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 객체에서 사용할 수 있습니다.

다음은 이를 수행하는 방법의 예입니다:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
