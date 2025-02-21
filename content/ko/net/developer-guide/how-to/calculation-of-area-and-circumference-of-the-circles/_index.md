---
title: 원의 면적과 둘레 계산
type: docs
weight: 18
url: /ko/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **원의 면적과 둘레 계산 방법**

**문제:** 원의 면적과 둘레 계산 방법 (CADNET-1153).

**팁:** 이를 위해 CadEntityTypeName.CIRCLE에서 반지름을 가져오고 수식 **"2 * Math.PI * radius"**를 사용하세요.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
