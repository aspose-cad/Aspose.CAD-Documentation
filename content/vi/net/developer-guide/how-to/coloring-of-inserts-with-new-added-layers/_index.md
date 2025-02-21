---
title: Tô màu cho các phần chèn với lớp mới được thêm vào
type: docs
weight: 23
url: /vi/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Cách tô màu cho các phần chèn với lớp mới được thêm vào (CADNET-1146)**

**Vấn đề:** Cách tô màu cho các phần chèn với lớp mới được thêm vào (CADNET-1146).

**Mẹo:** Để làm điều này, hãy sử dụng lớp CadLayerTable để tạo một lớp để có thể thêm một lớp mới vào bản vẽ, bạn cũng có thể sử dụng CadLayersList để thêm nhiều lớp.

**Ví dụ:**

{{% alert color="primary" %}}

Tệp ban đầu chứa 5 phần chèn với tên "1", "2", "3", "4" và "5" và tất cả chúng đều nằm trong lớp 0 mặc định.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
