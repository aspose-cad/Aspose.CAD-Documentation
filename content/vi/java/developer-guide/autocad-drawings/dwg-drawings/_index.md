---
title: Bản vẽ DWG
type: docs
weight: 40
url: /vi/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Xuất bản vẽ DWG sang PDF**

Aspose.CAD cho Java API có thể tải các bản vẽ AutoCAD ở định dạng DWG và chuyển đổi chúng sang PDF. Chủ đề này giải thích cách sử dụng API Aspose.CAD để thực hiện việc chuyển đổi từ DWG sang định dạng PDF thông qua các bước đơn giản như đã định nghĩa ở phía trước.

{{% alert color="primary" %}}

API hỗ trợ các phiên bản DWG AutoCAD sau:

- DWG phiên bản 2004  16.0 phát hành 18
- DWG phiên bản 2005  16.1
- DWG phiên bản 2010 18.0
- DWG phiên bản 2013 19.0

{{% /alert %}}

### **Định dạng tệp DWG**

DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Dữ liệu hình ảnh vector cung cấp hướng dẫn cho ứng dụng CAD về cách hiển thị DWG; siêu dữ liệu có thể chứa nhiều thông tin khác nhau về tệp, bao gồm dữ liệu theo vị trí và cũng là dữ liệu của khách hàng. Các thông số kỹ thuật mở cho định dạng tệp DWG có thể được tìm thấy [trong PDF này](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Chuyển đổi tệp DWG sang PDF**

Các bước đơn giản sau đây là cần thiết để chuyển đổi DWG sang PDF.

1. Tải tệp DWG vào một phiên bản của [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Gọi phương thức [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) và truyền đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) làm tham số thứ hai.

Mẫu mã bên dưới cho thấy cách xuất bản vẽ DWG sang PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Tạo PDF Đơn với Các Kích Thước Bố Cục Khác Nhau**

Aspose.CAD cho Java cho phép bạn chuyển đổi tệp DWG thành một PDF đơn với các kích thước bố cục khác nhau. Cách làm này hoạt động như sau:

1. Tải một tệp DWG bằng cách sử dụng phương thức nhà máy [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Tạo một phiên bản của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập chiều cao và chiều rộng trang kết quả.
1. Thêm các [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) cần thiết cho đối tượng [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Tạo một phiên bản của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Xuất hình ảnh sang PDF bằng cách sử dụng phương thức [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Mẫu mã bên dưới cho thấy cách tạo một PDF đơn với các bố cục khác nhau.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Xuất DWG sang PDF/A và PDF/E**

Các bước đơn giản sau đây là cần thiết để chuyển đổi DWG sang PDF.

1. Tải tệp DWG vào một phiên bản của [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Gọi phương thức [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) và truyền đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) vào tham số thứ hai.

Mẫu mã bên dưới cho thấy cách xuất các bản vẽ DWG sang PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Các Đối Tượng AutoCAD Hỗ Trợ**

Các đối tượng AutoCAD sau được hỗ trợ.

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

## **Xuất Bố Cục DWG Cụ Thể sang PDF**

Cách làm này hoạt động như sau:

1. Tải một tệp DWG bằng cách sử dụng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) nhà máy.
1. Tạo một phiên bản của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập chiều cao và chiều rộng trang kết quả.
1. Thiết lập thuộc tính [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) cho đối tượng [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Tạo một phiên bản của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Xuất hình ảnh sang PDF bằng cách sử dụng phương thức [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Mẫu mã bên dưới cho thấy cách chuyển đổi một bố cục cụ thể của DWG sang PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Xuất DWG sang Raster hoặc PDF sử dụng Kích Thước Cố Định**

Aspose.CAD cho Java API có thể tải các bản vẽ AutoCAD ở định dạng DWG, và chuyển đổi chúng sang PDF hoặc Raster sử dụng kích thước cố định.

Mẫu mã bên dưới cho thấy cách thực hiện tính năng này.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Hỗ trợ các đường ẩn bo tròn khi xuất DWG/DXF sang BMP và PDF**

Cách làm này hoạt động như sau:

1. Tải một tệp DWG bằng cách sử dụng phương thức [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) nhà máy.
1. Tạo một phiên bản của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Tạo một phiên bản của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập chiều cao và chiều rộng trang kết quả.
1. Tạo một phiên bản của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) .
1. Xuất hình ảnh sang PDF bằng cách sử dụng phương thức [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Mẫu mã bên dưới cho thấy cách thực hiện tính năng này.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Hỗ trợ thiết lập khu vực in cho hình ảnh DWG trong PDF xuất ra**

Aspose.CAD cho Java API có thể tải các bản vẽ AutoCAD ở định dạng DWG và chuyển đổi chúng sang PDF. Chủ đề này giải thích cách sử dụng API Aspose.CAD để đạt được sự hỗ trợ cho việc thiết lập một khu vực in cho hình ảnh DWG trong PDF xuất ra.

Mẫu mã bên dưới cho thấy cách thực hiện tính năng này.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Hỗ trợ đọc siêu dữ liệu XREF cho tệp DWG**

1. Tải một tệp DWG bằng cách sử dụng phương thức [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) nhà máy.
1. Duyệt qua từng thực thể hình ảnh.
1. Nếu thực thể là [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) thì là thực thể XREF với siêu dữ liệu.

Mẫu mã bên dưới cho thấy cách đạt được tính năng này.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Tài liệu DWG bằng cách xác định tọa độ**

Aspose.CAD cho Java API hiện cung cấp tính năng để kết xuất tài liệu DWG bằng cách cung cấp tọa độ của chiều rộng và chiều cao của tài liệu.

Mẫu mã bên dưới cho thấy cách kết xuất một tài liệu DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) là kiểu mảng chuỗi vì vậy bạn có thể chỉ định nhiều hơn một bố cục cùng một lúc cho việc chuyển đổi sang định dạng PDF có thể. Khi chỉ định nhiều bố cục cho thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), PDF kết quả sẽ có nhiều trang, nơi mỗi trang đại diện cho một bố cục AutoCAD riêng biệt.

### **Liệt kê tất cả các bố cục**

Bạn có thể liệt kê tất cả các bố cục có trong một bản vẽ AutoCAD bằng cách sử dụng mẫu mã sau.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Lấy Giá Trị Thuộc Tính Khối Của Tham Chiếu Ngoài**

Aspose.CAD cho Java API cho phép bạn lấy một tham chiếu ngoài của một thuộc tính khối. API Aspose.CAD phơi bày thuộc tính [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) để lấy tham chiếu ngoài của một thuộc tính khối trong một bộ [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Mẫu mã sau đây minh họa cách lấy một tham chiếu ngoài của một thuộc tính khối.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Tìm kiếm văn bản trong tệp DWG AutoCAD**

Aspose.CAD cho Java API cho phép bạn tìm kiếm văn bản trong một tệp DWG AutoCAD. API Aspose.CAD phơi bày lớp [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) đại diện cho các thực thể văn bản trong tệp DWG AutoCAD. Lớp [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) cũng được bao gồm trong API Aspose.CAD vì một số thực thể khác cũng có thể chứa văn bản.

Mẫu mã sau đây minh họa cách tìm kiếm văn bản trong tệp DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Tìm kiếm Văn Bản Trong Bố Cục Cụ Thể**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Truy cập Cờ Bỏ Qua cho Định Dạng DWG**

Aspose.CAD cho Java đã triển khai các cờ bỏ qua cho định dạng DWG và cho phép các nhà phát triển truy cập chúng. Dưới đây là một minh họa mã đơn giản.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Hỗ trợ Các Thực Thể DWG**

Aspose.CAD cho Java API có thể tải các bản vẽ AutoCAD ở định dạng DWG và hỗ trợ các thực thể khác nhau để làm việc.

### **Hỗ trợ Thực Thể MLeader**

DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần sau đây mô tả một ví dụ về việc làm việc với thực thể MLeader bên trong tệp DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Hỗ trợ Xuất Thực Thể DWG sang Hình Ảnh**

DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần sau đây mô tả một ví dụ về việc xuất một thực thể DWG cụ thể sang hình ảnh.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Hỗ trợ Nhập Hình Ảnh vào Tệp DWG**

Aspose.CAD cho Java API có thể tải các bản vẽ AutoCAD ở định dạng DWG và hỗ trợ các thực thể khác nhau để làm việc. Một DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần sau đây mô tả cách mà chúng ta có thể nhập hình ảnh vào bên trong tệp DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Hỗ trợ Thêm văn bản vào DWG**

Aspose.CAD cho Java API có thể tải các bản vẽ AutoCAD ở định dạng DWG và hỗ trợ các thực thể khác nhau để làm việc. Một DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần sau đây mô tả cách mà chúng ta có thể thêm văn bản vào bên trong tệp DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Hỗ trợ Lưới trong DWG**

Aspose.CAD cho Java API hiện có thể truy cập vào các thực thể hỗ trợ lưới bao gồm các loại [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) và [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). Ví dụ sau đây mô tả cách mà chúng ta có thể truy cập các loại lưới.

## **Chuyển đổi Bản Vẽ DWG sang DXF**

Aspose.CAD cung cấp tính năng để tải tệp DWG của AutoCAD và xuất nó sang định dạng DXF. Cách tiếp cận chuyển đổi từ DWG sang DXF hoạt động như sau:

1. Tải tệp bản vẽ DWG bằng cách sử dụng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) nhà máy.
1. Xuất bản vẽ DWG sang DXF bằng cách sử dụng phương thức [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Mẫu mã bên dưới cho thấy cách chuyển đổi một tệp DWG sang định dạng DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Chuyển đổi Bản Vẽ DWG sang SVG**

API Aspose.CAD có thể tải các bản vẽ AutoCAD ở định dạng DWG và chuyển đổi chúng sang SVG. Chủ đề này giải thích cách sử dụng API Aspose.CAD để thực hiện việc chuyển đổi từ DWG sang định dạng SVG thông qua các bước đơn giản như đã định nghĩa bên dưới.

1. Tải tệp DWG vào một phiên bản của [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Tạo một đối tượng của lớp [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) và thiết lập các thuộc tính cần thiết.
1. Xuất bản vẽ DWG sang SVG bằng cách sử dụng phương thức [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Mẫu mã bên dưới cho thấy cách chuyển đổi một tệp DWG sang định dạng SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
