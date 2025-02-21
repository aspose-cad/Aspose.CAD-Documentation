---
title: CTB 파일 지원
type: docs
weight: 40
url: /ko/java/developer-guide/support-ctb/
---

## **CTB 파일 지원**

때때로 색상, 선 두께 및 기타 옵션은 도면 자체뿐만 아니라 별도의 CTB 파일에 있는 플롯 스타일에서도 사용할 수 있습니다. 
이 정보를 사용하는 가장 간단한 방법은 해당 CTB 파일을 DWG/DXF 형식의 도면 파일 근처에 두는 것이며, 이로부터의 정보는 
내보내기 중에 자동으로 적용됩니다.

모든 CTB 파일을 스트림 형태로 로드하는 것도 가능합니다. 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) 속성을 사용하여 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 객체에서 로드할 수 있습니다.

다음은 이를 수행하는 방법의 예입니다:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
