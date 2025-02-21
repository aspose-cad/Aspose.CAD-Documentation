---
title: DWG 내에 DXF/DWG 도면 삽입하기
type: docs
weight: 38
url: /ko/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **DWG 내에 DXF/DWG 도면 삽입하는 방법**

**문제:** DWG 내에 DXF/DWG 도면을 삽입하는 방법.

**팁:** 이를 위해 먼저 필요한 값으로 CadInsertObject를 생성한 후, CadBlockDictionary에서 모든 블록을 가져오고, 새로운 CadBlockEntity 블록을 생성하여 CadBlockDictionary에 추가하며, 도면의 BlockEntities에 CadBlockDictionary를 추가하고, 배열을 위한 도면 엔티티에 CadInsertObject를 추가하고, 참조로 CadBlockTableObject를 생성한 다음, 도면에 블록을 추가합니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
