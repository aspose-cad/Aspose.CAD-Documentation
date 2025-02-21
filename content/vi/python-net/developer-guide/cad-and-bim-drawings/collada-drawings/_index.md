---
title: Bản vẽ COLLADA
type: docs
weight: 20
url: /vi/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Xuất định dạng COLLADA sang PDF**

Aspose.CAD cho Python cho phép các nhà phát triển xuất tệp [COLLADA](https://docs.fileformat.com/3d/dae/) sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách chuyển đổi từ [COLLADA](https://docs.fileformat.com/3d/dae/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [COLLADA](https://docs.fileformat.com/3d/dae/) bằng phương thức khởi tạo **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và thiết lập các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **vector_rasterization_options**.
1. Gọi **Image.save** và truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

## Mẫu mã

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
