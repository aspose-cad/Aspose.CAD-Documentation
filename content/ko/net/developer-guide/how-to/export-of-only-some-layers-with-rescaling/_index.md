---
title: 일부 레이어만 비율 조정하여 내보내기
type: docs
weight: 31
url: /ko/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **비율 조정으로 일부 레이어만 내보내기 (CADNET-559)**

**문제:** 비율 조정으로 일부 레이어만 내보내는 방법 (CADNET-559).

**팁:** 이를 위해 필요한 레이어를 선택하고, CadBaseEntity 배열에 추가한 후, 이들을 도면 엔터티에 할당하고 UpdateSize를 실행합니다.

**예시:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
