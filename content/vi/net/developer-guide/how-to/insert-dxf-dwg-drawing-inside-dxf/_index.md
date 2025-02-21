---
title: Chèn bản vẽ DXF/DWG vào bên trong DXF
type: docs
weight: 39
url: /vi/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Cách chèn bản vẽ DXF/DWG vào bên trong DXF**

**Vấn đề:** Cách chèn bản vẽ DXF/DWG vào bên trong DXF.

**Mẹo:** Để làm điều này, trước tiên bạn phải tạo một CadInsertObject với các giá trị cần thiết, sau đó lấy tất cả các khối trong CadBlockDictionary, tạo một khối CadBlockEntity mới và thêm nó vào CadBlockDictionary, thêm CadBlockDictionary vào BlockEntities của bản vẽ, thêm một CadInsertObject vào các thực thể của bản vẽ cho mảng.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
