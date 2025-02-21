---
title: Bản vẽ FBX
type: docs
weight: 110
url: /vi/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Xuất định dạng FBX sang PDF**

Aspose.CAD cho Python cho phép các nhà phát triển xuất tệp [FBX](https://docs.fileformat.com/3d/fbx/) sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi [FBX](https://docs.fileformat.com/3d/fbx/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [FBX](https://docs.fileformat.com/3d/fbx/) bằng cách sử dụng phương pháp factory **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và thiết lập các thuộc tính **PageHeight** & **PageWidth**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **vector_rasterization_options**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

## Mẫu Mã

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
