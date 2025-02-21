---
title: 외부 참조 이미지가 존재하는지 확인하고 참조를 교체하는 방법
type: docs
weight: 22
url: /ko/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **객체에서 하이퍼링크 편집하는 방법**

**문제:** 외부 참조 이미지가 존재하는지 확인하고 참조를 교체하는 방법 (CADNET-8088).

**팁:** 이렇게 하려면, 드로잉 엔티티에서 CadObjectTypeName.IMAGEDEF 유형의 엔티티를 가져오고 CadRasterImageDef를 사용하여 확인합니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
