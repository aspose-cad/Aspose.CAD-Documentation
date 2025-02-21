---
title: Hỗ trợ tệp CTB
type: docs
weight: 40
url: /vi/net/developer-guide/support-ctb/
---

## **Hỗ trợ tệp CTB**

Đôi khi màu sắc, độ dày đường và một số tùy chọn khác cho bản vẽ có thể được sử dụng không chỉ từ bản vẽ mà còn từ các kiểu vẽ trong các tệp CTB riêng biệt. 
Cách đơn giản nhất để sử dụng thông tin này là đặt các tệp CTB tương ứng gần tệp có bản vẽ ở định dạng DWG/DXF và thông tin từ chúng sẽ được áp dụng
tự động trong quá trình xuất.

Cũng có thể tải tất cả các tệp CTB dưới dạng Stream bằng cách sử dụng 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) thuộc tính của 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) đối tượng.

Dưới đây là ví dụ về cách thực hiện điều này:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
