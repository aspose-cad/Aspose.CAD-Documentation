---
title: 다각형으로 사각형 만들기 및 해치로 채우기
type: docs
weight: 24
url: /ko/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **다각형으로 사각형 만들기 및 해치로 채우는 방법**

**문제:** 다각형으로 사각형을 만들고 해치로 채우는 방법 (CADNET-1351).

**팁:** 이를 위해 CadLwPolyline을 생성하고 점 좌표를 추가하고, CadHatch를 사용하여 색상 작업을 수행하고, CadEdgeBoundaryPath를 사용하여 연결하며, CadHatch를 사용하여 각도 작업을 수행하고 CadHatchPatternData를 패턴에 사용하십시오.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
