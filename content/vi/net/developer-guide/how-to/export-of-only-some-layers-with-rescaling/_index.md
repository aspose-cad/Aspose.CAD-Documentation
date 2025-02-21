---
title: Xuất chỉ một số lớp với việc thay đổi kích thước
type: docs
weight: 31
url: /vi/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **Xuất chỉ một số lớp với việc thay đổi kích thước (CADNET-559)**

**Vấn đề:** Làm thế nào để xuất chỉ một số lớp với việc thay đổi kích thước (CADNET-559).

**Mẹo:** Để làm điều này, hãy chọn các lớp cần thiết, thêm chúng vào mảng CadBaseEntity, sau đó gán chúng cho các thực thể bản vẽ và thực hiện UpdateSize.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
