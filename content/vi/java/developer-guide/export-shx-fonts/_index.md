---
title: Xuất khẩu phông chữ SHX
type: docs
weight: 40
url: /vi/java/developer-guide/export-shx-fonts/
---

## **Xuất khẩu phông chữ SHX cho bản vẽ DXF/DWG**

Một số bản vẽ có thể chứa phông chữ ở định dạng SHX đặc biệt, định dạng này lưu trữ các ký hiệu của phông chữ dưới dạng hình dạng.
Định dạng này yêu cầu quy trình tải bổ sung cho mỗi phông chữ được sử dụng trong bản vẽ.
Apose.CAD có thể xuất khẩu các bản vẽ với văn bản được viết bằng SHX và có các tùy chọn khác nhau để thực hiện điều này.
Cách đơn giản nhất để làm điều đó là chỉ cần sử dụng thuộc tính [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) của đối tượng [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Mỗi phông chữ SHX đi kèm với mã trang tương ứng. Những mối liên hệ này được biết đến và một phần được nhúng vào Aspose.CAD cho các phông chữ SHX đã biết.
Trong trường hợp một phông chữ SHX tùy chỉnh được sử dụng, có thể áp dụng thuộc tính **setShxCodePages** và thiết lập đường dẫn đến tệp SHX và mã trang tương ứng. 
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
