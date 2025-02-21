---
title: Bản vẽ FBX
type: docs
weight: 70
url: /vi/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Xuất định dạng FBX sang PDF**

Aspose.CAD cho .NET cho phép các nhà phát triển xuất một tệp [FBX](https://docs.fileformat.com/3d/fbx/) sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi từ [FBX](https://docs.fileformat.com/3d/fbx/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [FBX](https://docs.fileformat.com/3d/fbx/) bằng cách sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

## Mã mẫu

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
