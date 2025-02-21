---
title: Xuất bản vẽ DWG/DXF và bố cục vào kích thước đã chỉ định
type: docs
weight: 40
url: /vi/net/developer-guide/export-into-size/
---

## **Xuất mô hình và tất cả bố cục thành kích thước PDF A4**

API Aspose.CAD cho phép bạn xuất tất cả các trang của tệp DWG/DXF thành kích thước PDF vật lý đã chỉ định.

Mẫu mã sau thiết lập kích thước của đối tượng [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) để đạt được kích thước PDF mong muốn.
Kích thước của tờ giấy A4 là 210x297 milimét hoặc 8.27x11.69 inch và các giá trị này được sử dụng trong mã.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Xuất Bố cục CAD thành PDF với kích thước khác nhau**

Đôi khi cần phải xuất bố cục thành kích thước vật lý của nó. Ví dụ dưới đây minh họa việc xuất bản vẽ vào PDF đa trang, nơi mỗi trang với nội dung bố cục có kích thước PDF vật lý riêng.
Ví dụ này sử dụng thuộc tính [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
