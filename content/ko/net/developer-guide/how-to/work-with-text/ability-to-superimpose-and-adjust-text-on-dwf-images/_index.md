---
title: DWF 이미지에 텍스트를 겹쳐서 조정하는 기능, 따라서 결과 렌더 출력을 어느 정도 편집 가능
type: docs
weight: 20
url: /ko/net/developer-guide/how-to/work-with-text/ability-to-superimpose-and-adjust-text-on-dwf-images/
---

## **DWF 이미지에 텍스트를 겹쳐서 조정하는 방법**

**문제:** DWF 이미지에 텍스트를 겹쳐서 조정하는 방법.

**팁:** 이를 위해 DwfWhipText를 생성하고 필요한 매개변수를 설정한 후 AddElement 메서드를 사용하여 도면에 추가해야 하며, 제거하려면 RemoveElement 메서드를 사용할 수 있습니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "superimpose-and-adjust-text-on-dwf.cs" >}}
