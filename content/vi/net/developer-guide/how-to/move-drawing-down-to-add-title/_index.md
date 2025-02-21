---
title: Di chuyển bản vẽ xuống để thêm tiêu đề
type: docs
weight: 40
url: /vi/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Cách di chuyển bản vẽ xuống để thêm tiêu đề**

**Vấn đề:** Cách di chuyển bản vẽ xuống để thêm tiêu đề (CADNET-980).

**Mẹo:** Để thực hiện điều này, hãy tạo một đối tượng CadText với các tham số, thêm khối này vào bản vẽ, sau đó cập nhật bản vẽ với các kích thước mới bằng UpdateSize, thêm một đường polyline làm khung xung quanh bản vẽ, thêm đường polyline vào BlockEntities["*Model_Space"] và cập nhật lại bằng UpdateSize.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
