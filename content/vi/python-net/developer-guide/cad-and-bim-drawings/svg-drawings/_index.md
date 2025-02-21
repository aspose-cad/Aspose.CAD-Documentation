---
title: Hình ảnh SVG
type: docs
weight: 170
url: /vi/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Xuất định dạng SVG sang PDF**

Aspose.CAD cho Python cho phép các nhà phát triển xuất tệp [SVG](https://docs.fileformat.com/page-description-language/svg/) sang định dạng [PDF](https://docs.fileformat.com/pdf/). Phương pháp chuyển đổi từ [SVG](https://docs.fileformat.com/page-description-language/svg/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ SVG bằng phương thức **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và thiết lập các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **VectorRasterizationOptions**.
1. Gọi **Image.save** trong đó truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

## Mẫu mã

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
