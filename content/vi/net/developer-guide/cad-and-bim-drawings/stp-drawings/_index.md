---
title: Các bản vẽ STP
type: docs
weight: 70
url: /vi/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Xuất định dạng STP sang PDF**

Aspose.CAD cho .NET cho phép các nhà phát triển xuất tệp [STP](https://docs.fileformat.com/3d/stp/) sang định dạng [PDF](https://docs.fileformat.com/pdf/). Phương pháp chuyển đổi [STP](https://docs.fileformat.com/3d/stp/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [STP](https://docs.fileformat.com/3d/stp/) bằng cách sử dụng phương thức factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

## Mẫu mã

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
