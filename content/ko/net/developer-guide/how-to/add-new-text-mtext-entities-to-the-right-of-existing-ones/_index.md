---
title: 기존 TEXT/MTEXT 엔티티의 오른쪽에 새로운 TEXT/MTEXT 엔티티 추가
type: docs
weight: 17
url: /ko/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **기존 TEXT/MTEXT 엔티티의 오른쪽에 새로운 TEXT/MTEXT 엔티티를 추가하는 방법**

**문제:** 기존 TEXT/MTEXT 엔티티의 오른쪽에 새로운 TEXT/MTEXT 엔티티를 추가하는 방법 (CADNET-8172).

**팁:** 이렇게 하려면 CadBaseEntity 객체를 생성하고, 텍스트가 포함된 CadMText 또는 CadText를 생성한 다음, 새로운 객체의 SoftOwner 필드에 도면에서 cadImage.Layouts["Model"].BlockTableRecordHandle를 추가하고 cadImage.BlockEntities[" *MODEL_SPACE"] 블록에 추가한 다음 새로운 객체를 도면 엔티티에 추가합니다.

**예시:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
