---
title: Tính toán diện tích và chu vi của hình tròn
type: docs
weight: 18
url: /vi/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **Cách tính toán diện tích và chu vi của hình tròn**

**Vấn đề:** Cách tính toán diện tích và chu vi của hình tròn (CADNET-1153).

**Mẹo:** Để làm điều này, lấy bán kính từ CadEntityTypeName.CIRCLE từ các thực thể và sử dụng công thức **"2 * Math.PI * bán kính"**.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
