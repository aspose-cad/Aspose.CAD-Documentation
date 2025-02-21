---
title: 제목을 추가하기 위해 그림을 아래로 이동시키기
type: docs
weight: 40
url: /ko/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **제목을 추가하기 위해 그림을 아래로 이동하는 방법**

**문제:** 제목을 추가하기 위해 그림을 아래로 이동하는 방법 (CADNET-980).

**팁:** 이를 위해 매개변수가 있는 CadText 객체를 생성하고, 이 블록을 그림에 추가한 다음, UpdateSize로 새로운 치수로 그림을 업데이트하고, 그림 주위에 프레임이 되는 폴리라인을 추가하고, BlockEntities["*Model_Space"]에 폴리라인을 추가한 후 다시 UpdateSize로 업데이트합니다.

**예시:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
