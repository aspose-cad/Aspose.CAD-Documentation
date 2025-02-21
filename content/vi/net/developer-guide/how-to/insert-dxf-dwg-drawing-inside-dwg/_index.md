---
title: Chèn bản vẽ DXF/DWG vào trong DWG
type: docs
weight: 38
url: /vi/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Cách chèn bản vẽ DXF/DWG vào trong DWG**

**Vấn đề:** Cách chèn bản vẽ DXF/DWG vào trong DWG.

**Mẹo:** Để thực hiện điều này, trước tiên tạo một CadInsertObject với các giá trị cần thiết, sau đó lấy tất cả các khối trong một CadBlockDictionary, tạo một khối CadBlockEntity mới và thêm nó vào CadBlockDictionary, thêm một CadBlockDictionary vào BlockEntities của bản vẽ, thêm một CadInsertObject vào thực thể bản vẽ cho mảng, tạo một CadBlockTableObject bằng tham chiếu, sau đó thêm một khối vào bản vẽ.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
