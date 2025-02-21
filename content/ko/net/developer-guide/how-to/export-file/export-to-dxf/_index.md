---
title: DXF로 내보내기
type: docs
weight: 20
url: /ko/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **DXF로 내보내는 방법**

**문제:** DXF로 내보내는 방법.

**팁:** 이를 위해 파일 저장 옵션에서 DxfOption을 바이너리 및 일반 모두 사용할 수 있습니다.

**참고:** 흥미로운 기능 중 하나는 지원되는 모든 파일 형식을 dxf로 저장할 수 있는 기능입니다.
이는 정말 좋은 기능이며 여러 가지 뉘앙스가 있습니다:
DXF/DWG 파일 형식에서 저장 - 소스 형식이 가진 정확한 엔티티로 내보내기를 수행합니다.
다른 형식에서 내보내기 - 선 및 텍스트 엔티티만 사용하여 내보내기를 수행합니다.
또한 ASCII 및 바이너리 DXF 파일 형식을 지원합니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
