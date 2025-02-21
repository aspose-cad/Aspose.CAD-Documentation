---
title: Xuất bản vẽ DWG/DXF và bố cục sang kích thước chỉ định
type: docs
weight: 40
url: /vi/java/developer-guide/export-into-size/
---

## **Xuất mô hình và tất cả bố cục vào kích thước PDF A4**

Aspose.CAD API cho phép bạn xuất tất cả các trang của tệp DWG/DXF vào kích thước PDF vật lý chỉ định.
Mẫu mã sau thiết lập kích thước của đối tượng [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) để đạt được kích thước PDF mong muốn.
Kích thước của tờ giấy A4 là 210x297 mm hoặc 8.27x11.69 inch và các giá trị này được sử dụng trong mã.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Xuất Bố cục CAD sang PDF với kích thước khác nhau**

Đôi khi cần xuất bố cục thành kích thước vật lý của nó. Ví dụ dưới đây minh họa việc xuất bản vẽ vào PDF nhiều trang mà mỗi trang có nội dung bố cục
có kích thước PDF vật lý riêng. Ví dụ này sử dụng thuộc tính [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) .

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
