---
title: 해치 원점 위치를 해치 경계에 가깝게 이동하여 성능 향상
type: docs
weight: 41
url: /ko/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **해치 원점을 해치 경계에 가깝게 이동하여 성능을 향상시키는 방법**

**문제:** 해치 원점을 해치 경계에 가깝게 이동하여 성능을 향상시키는 방법 (CADNET-1340).

**팁:** 이를 수행하기 위해, 도면에서 CadHatch 엔티티를 가져오고, Point2D로 필요한 점을 설정한 다음, 거리를 계산하고, CadHatchPatternData에서 X 및 Y에 대해 LineBasePoint를 설정합니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
