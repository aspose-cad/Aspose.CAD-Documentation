---
title: Đọc, cập nhật và ghi file DWG
type: docs
weight: 11
url: /vi/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Cách đọc, cập nhật và ghi file DWG**

**Vấn đề:** Cách đọc, cập nhật và ghi file DWG.

**Mẹo:** Để làm điều này, bạn có thể lấy file bằng phương thức load, lấy những thực thể cần thiết và thực hiện các thay đổi với chúng, chẳng hạn như thay đổi các điểm bắt đầu và kết thúc hoặc độ dày của các đường.

**Lưu ý:** Đoạn mã này cho thấy một ví dụ về việc đọc một file dwg, thay đổi các đối tượng: vị trí của các đường, hình tròn, giá trị văn bản (bạn có thể thêm thay đổi cho các đối tượng và giá trị khác mà việc đọc/ghi được hỗ trợ) và sau đó lưu vào một file mới. Vì vậy, bạn có thể mở một file mới trong AutoCAD và xem các đối tượng với giá trị đã thay đổi.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
