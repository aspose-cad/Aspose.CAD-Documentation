---
title: Thêm hình ảnh làm nền vào DWG
type: docs
weight: 15
url: /vi/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Cách thêm hình ảnh làm nền trong DWG**

**Vấn đề:** Cách thêm hình ảnh làm nền trong DWG.

**Mẹo:** Để làm điều này, hãy tạo một đối tượng CadRasterImageDef cho hình ảnh nền, tạo một đối tượng CadRasterImage để chèn nền cho bản vẽ, thêm một đối tượng CadRasterImage vào các đối tượng bản vẽ, tạo một đối tượng CadBaseObject và thêm nó vào cadImage.Objects, xử lý mọi thứ thông qua CadBlockTableObject.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
