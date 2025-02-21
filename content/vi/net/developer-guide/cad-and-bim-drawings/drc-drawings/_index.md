---
title: Bản vẽ DRC
type: docs
weight: 15
url: /vi/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Xuất Bản vẽ DRC sang PDF**

Aspose.CAD cung cấp tính năng tải các thực thể bản vẽ AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) và render chúng thành một bản vẽ hoàn chỉnh ở định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi [DRC](https://docs.fileformat.com/3d/drc/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [DRC](https://docs.fileformat.com/3d/drc/) bằng cách sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

### Mẫu Mã

Mẫu mã dưới đây cho thấy cách chuyển đổi tệp bằng cách sử dụng các cài đặt mặc định.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
