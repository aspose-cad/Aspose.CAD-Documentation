---
title: 새로 추가된 레이어로 삽입물 색칠하기
type: docs
weight: 23
url: /ko/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **새로 추가된 레이어로 삽입물 색칠하기 (CADNET-1146)**

**문제:** 새로 추가된 레이어로 삽입물 색칠하기 (CADNET-1146).

**팁:** 이렇게 하려면 CadLayerTable 클래스를 사용하여 새 레이어를 추가할 수 있는 레이어를 생성하고, CadLayersList를 사용하여 여러 레이어를 추가할 수도 있습니다.

**예제:**

{{% alert color="primary" %}}

초기 파일에는 "1", "2", "3", "4" 및 "5"라는 이름의 5개의 삽입물이 있으며, 이들 모두 기본 0 레이어에 있습니다.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
