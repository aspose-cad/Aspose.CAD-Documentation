---
title: Hỗ trợ tệp CTB
type: docs
weight: 40
url: /vi/java/developer-guide/support-ctb/
---

## **Hỗ trợ tệp CTB**

Đôi khi màu sắc, trọng lượng đường và một số tùy chọn khác cho bản vẽ có thể được sử dụng không chỉ từ bản vẽ mà còn từ các kiểu in trong các tệp CTB riêng biệt. 
Cách đơn giản nhất để sử dụng thông tin này là đặt các tệp CTB tương ứng gần tệp có bản vẽ ở định dạng DWG/DXF và thông tin từ chúng sẽ được áp dụng 
tự động trong quá trình xuất.

Cũng có thể tải tất cả các tệp CTB dưới dạng Stream bằng cách sử dụng 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) thuộc tính của 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) đối tượng.

Dưới đây là ví dụ về cách thực hiện điều này:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
