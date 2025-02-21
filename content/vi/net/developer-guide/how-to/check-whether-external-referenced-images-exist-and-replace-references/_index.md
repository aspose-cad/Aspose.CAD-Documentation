---
title: Kiểm tra xem hình ảnh được tham chiếu bên ngoài có tồn tại không và thay thế tham chiếu
type: docs
weight: 22
url: /vi/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Cách chỉnh sửa liên kết trên các đối tượng**

**Vấn đề:** Làm thế nào để kiểm tra xem hình ảnh được tham chiếu bên ngoài có tồn tại và thay thế tham chiếu (CADNET-8088).

**Mẹo:** Để thực hiện điều này, lấy một thực thể có loại CadObjectTypeName.IMAGEDEF từ các thực thể bản vẽ và sử dụng CadRasterImageDef để kiểm tra.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
