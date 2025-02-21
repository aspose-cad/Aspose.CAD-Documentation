---
title: 숨겨진 레이어와 레이어를 이름으로 내보내지 않기
type: docs
weight: 26
url: /ko/net/developer-guide/how-to/do-not-export-hidden-layer-and-layers-by-name/
---

## **숨겨진 레이어와 레이어를 이름으로 내보내지 않는 방법**

**문제:** 숨겨진 레이어와 레이어를 이름으로 내보내지 않는 방법.

**팁:** 이를 위해 "LayerToHide"로 이름이 지정되지 않은 레이어 배열을 생성하고 이를 rasterizationOptions.Layers에 추가해야 합니다.

**예시:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "do-not-export-hidden-layer-and-layers-by-name.cs" >}}
