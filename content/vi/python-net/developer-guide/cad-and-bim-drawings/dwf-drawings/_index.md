---
title: Bản vẽ DWF
type: docs
weight: 50
url: /vi/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Xuất Bản Vẽ DWF Sang PDF**

Aspose.CAD cung cấp tính năng để tải các thực thể bản vẽ AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) và kết xuất chúng như một bản vẽ hoàn chỉnh sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi từ [DWF](https://docs.fileformat.com/cad/dwf/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [DWF](https://docs.fileformat.com/cad/dwf/) bằng phương thức tạo mẫu **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và đặt các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **vector_rasterization_options**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

### Mẫu Mã

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp bằng cách sử dụng cài đặt mặc định.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Xuất Bản Vẽ DWF Sang BMP**

Aspose.CAD cung cấp tính năng để tải các thực thể bản vẽ AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) và kết xuất chúng như một bản vẽ hoàn chỉnh sang định dạng [BMP](https://docs.fileformat.com/image/bmp/). Cách tiếp cận chuyển đổi từ [DWF](https://docs.fileformat.com/cad/dwf/) sang [BMP](https://docs.fileformat.com/image/bmp/) hoạt động như sau:

1. Tải tệp bản vẽ [DWF](https://docs.fileformat.com/cad/dwf/) bằng phương thức tạo mẫu **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và đặt các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **BmpOptions** và thiết lập thuộc tính **vector_rasterization_options**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **BmpOptions** làm tham số thứ hai.

### Mẫu Mã

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp [DWF](https://docs.fileformat.com/cad/dwf/) sang [BMP](https://docs.fileformat.com/image/bmp/) sử dụng cài đặt mặc định.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
