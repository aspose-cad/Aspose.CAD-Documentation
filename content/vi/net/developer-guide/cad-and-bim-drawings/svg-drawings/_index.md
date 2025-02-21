---
title: Hình Vẽ SVG
type: docs
weight: 70
url: /vi/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Xuất Định Dạng SVG Sang PDF**

Aspose.CAD cho .NET cho phép các nhà phát triển xuất tệp SVG sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi SVG sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp hình vẽ SVG bằng cách sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và đặt các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và đặt thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

## Mã Mẫu

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
