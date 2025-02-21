---
title: Bản vẽ STP
type: docs
weight: 160
url: /vi/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Xuất định dạng STP sang PDF**

Aspose.CAD cho Python cho phép các nhà phát triển xuất tệp [STP](https://docs.fileformat.com/3d/stp/) sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi từ [STP](https://docs.fileformat.com/3d/stp/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [STP](https://docs.fileformat.com/3d/stp/) bằng cách sử dụng phương thức nhà máy **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và thiết lập các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **vector_rasterization_options**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

## Mã mẫu

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
