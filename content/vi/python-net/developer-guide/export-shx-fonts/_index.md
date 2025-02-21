---
title: Xuất phông chữ SHX
type: docs
weight: 40
url: /vi/python-net/developer-guide/export-shx-fonts/
---

## **Xuất phông chữ SHX cho bản vẽ DXF/DWG**

Một số bản vẽ có thể chứa phông chữ ở định dạng SHX đặc biệt, lưu trữ các ký hiệu của phông chữ dưới dạng hình dạng. Định dạng này yêu cầu quy trình tải thêm cho mỗi phông chữ được sử dụng trong bản vẽ. Apose.CAD có thể xuất bản vẽ với văn bản được viết bằng SHX và có nhiều tùy chọn khác nhau để thực hiện điều này. Cách đơn giản nhất để làm điều này là chỉ cần sử dụng 
**ShxFonts** thuộc tính của
**CadRasterizationOptions** đối tượng.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
