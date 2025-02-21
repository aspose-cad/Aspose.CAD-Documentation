---
title: 블록 객체 내부의 엔티티에 접근하기
type: docs
weight: 11
url: /ko/net/developer-guide/how-to/access-to-entities-inside-block-objects/
---

## **블록 객체 내부의 엔티티에 접근하는 방법**

**문제:** 블록 객체 내부의 엔티티에 접근하는 방법 (CADNET-552).

**팁:** 이를 위해서는 블록 객체 내부의 엔티티에 접근해야 하며, 먼저 도면에서 블록에 접근한 후 CadBlockEntity 클래스를 사용하여 접근해야 합니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "access-to-entities-inside-block-objects.cs" >}}
