---
title: Tạo hình chữ nhật dưới dạng đường polyline và tô nó bằng dấu chéo
type: docs
weight: 24
url: /vi/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Cách tạo hình chữ nhật dưới dạng đường polyline và tô nó bằng dấu chéo**

**Vấn đề:** Cách tạo hình chữ nhật dưới dạng đường polyline và tô nó bằng dấu chéo (CADNET-1351).

**Mẹo:** Để thực hiện điều này, hãy tạo một CadLwPolyline và thêm các tọa độ điểm vào đó, sử dụng CadHatch để làm việc với màu sắc và sử dụng CadEdgeBoundaryPath để kết nối, sử dụng CadHatch để làm việc với các góc và CadHatchPatternData cho mẫu.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
