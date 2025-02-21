---
title: Bản vẽ DWG
type: docs
weight: 70
url: /vi/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Xuất Bản vẽ DWG sang PDF**

Aspose.CAD cho API Python có thể tải các bản vẽ AutoCAD ở định dạng [DWG](https://docs.fileformat.com/cad/dwg/) và chuyển đổi nó sang [PDF](https://docs.fileformat.com/pdf/). Chủ đề này giải thích cách sử dụng API Aspose.CAD để thực hiện chuyển đổi DWG sang định dạng PDF thông qua các bước đơn giản như được định nghĩa phía dưới.

{{% alert color="primary" %}}

API hỗ trợ các phiên bản DWG AutoCAD sau:

- Phiên bản 16.0 phát hành 18 DWG 2004
- Phiên bản 16.1 DWG 2005
- Phiên bản 18.0 DWG 2010
- Phiên bản 19.0 DWG 2013

{{% /alert %}}

### **Định dạng File DWG**

Một [DWG](https://docs.fileformat.com/cad/dwg/) là một file nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Dữ liệu hình ảnh vector cung cấp hướng dẫn cho ứng dụng CAD về cách hiển thị DWG; siêu dữ liệu có thể chứa nhiều thông tin khác nhau về file bao gồm dữ liệu theo vị trí và cũng dữ liệu khách hàng. Các thông số mở cho định dạng file DWG có thể được tìm thấy [trong PDF này](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Chuyển đổi File DWG sang PDF**

Các bước đơn giản sau đây là cần thiết để chuyển đổi [DWG](https://docs.fileformat.com/cad/dwg/) sang [PDF](https://docs.fileformat.com/pdf/).

1. Tải file DWG vào một instance của **Image**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và đặt các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và đặt thuộc tính **VectorRasterizationOptions**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **PdfOptions** như tham số thứ hai.

Mẫu mã dưới đây cho thấy cách xuất Bản vẽ DWG sang PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


### **Các Đối tượng AutoCAD Hỗ trợ**

Các đối tượng AutoCAD sau đây được hỗ trợ.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Xuất Layout DWG Cụ thể sang PDF**

Cách tiếp cận này hoạt động như sau:

1. Tải file DWG bằng phương thức factory **Aspose.CAD.Image.load**.
1. Tạo một instance của lớp **CadRasterizationOptions** và đặt chiều cao và chiều rộng trang kết quả.
1. Đặt thuộc tính **Layouts** cho đối tượng **CadRasterizationOptions**.
1. Tạo một instance của lớp **PdfOptions** và đặt thuộc tính **VectorRasterizationOptions** của nó.
1. Xuất hình ảnh ra PDF bằng phương thức **Image.save()**.

Mẫu mã dưới đây cho thấy cách chuyển đổi một layout cụ thể của DWG sang PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **Xuất DWG sang PDF/A và PDF/E**

Cách tiếp cận này hoạt động như sau:

1. Tải file DWG bằng phương thức factory **Image.load**.
1. Tạo một instance của lớp **CadRasterizationOptions**.
1. Tạo một instance của lớp **PdfOptions** và đặt thuộc tính **VectorRasterizationOptions** của nó.
1. Đặt thuộc tính tuân thủ PDF và lưu lại.
1. Xuất hình ảnh ra PDF bằng phương thức **Image.save()**.

Mẫu mã dưới đây cho thấy cách chuyển đổi một file DWG sang PDF/A và PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Chuyển đổi Bản vẽ DWG sang DXF**

Aspose.CAD cung cấp tính năng tải file DWG AutoCAD và xuất nó sang định dạng DXF. Cách tiếp cận chuyển đổi DWG sang DXF hoạt động như sau:

1. Tải file bản vẽ DWG bằng phương thức factory **Image.load**.
1. Xuất bản vẽ DWG ra DXF bằng phương thức **Image.save()**.

Mẫu mã dưới đây cho thấy cách chuyển đổi một file DWG sang định dạng DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Chuyển đổi Bản vẽ DWG sang SVG**

Aspose.CAD cho API Python có thể tải các bản vẽ AutoCAD ở định dạng DWG và chuyển đổi nó sang SVG. Chủ đề này giải thích cách sử dụng API Aspose.CAD để thực hiện chuyển đổi DWG sang định dạng SVG thông qua các bước đơn giản như được định nghĩa dưới đây.

1. Tải file DWG vào một instance của **Image**.
1. Tạo một đối tượng của lớp **SvgOptions** và đặt các thuộc tính cần thiết.
1. Xuất bản vẽ DWG ra SVG bằng phương thức **Image.save()**.

Mẫu mã dưới đây cho thấy cách chuyển đổi một file DWG sang định dạng SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
