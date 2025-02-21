---
title: Di chuyển điểm gốc của hatch gần hơn với ranh giới hatch để cải thiện hiệu suất
type: docs
weight: 41
url: /vi/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Cách di chuyển điểm gốc của hatch gần hơn với ranh giới hatch để cải thiện hiệu suất**

**Vấn đề:** Cách di chuyển điểm gốc của hatch gần hơn với ranh giới hatch để cải thiện hiệu suất (CADNET-1340).

**Mẹo:** Để thực hiện điều này, lấy các thực thể CadHatch từ bản vẽ, đặt các điểm cần thiết với Point2D, tính toán khoảng cách và trong CadHatchPatternData đặt LineBasePoint cho X và Y.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
