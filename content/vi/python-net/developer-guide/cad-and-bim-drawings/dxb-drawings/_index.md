---
title: Bản vẽ DXB
type: docs
weight: 90
url: /vi/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Xuất Định Dạng DXB Ra PDF**

Aspose.CAD cho Python cho phép các nhà phát triển xuất tệp DXB sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi DXB sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ DXB bằng phương thức chế tạo **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và thiết lập các thuộc tính **page_height** và **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **vector_rasterization_options**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

## Mẫu Mã

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
