---
title: Bản vẽ DRC
type: docs
weight: 40
url: /vi/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Xuất định dạng DRC sang PDF**

Aspose.CAD cho Python cho phép các nhà phát triển xuất một tệp [DRC](https://docs.fileformat.com/3d/drc/) sang định dạng [PDF](https://docs.fileformat.com/pdf/). Phương pháp chuyển đổi [DRC](https://docs.fileformat.com/3d/drc/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ DRC bằng phương thức factory **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và thiết lập các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **VectorRasterizationOptions**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

## Mẫu mã


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
