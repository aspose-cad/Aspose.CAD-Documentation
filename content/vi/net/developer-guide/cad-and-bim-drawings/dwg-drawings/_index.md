---
title: Bản vẽ DWG
type: docs
weight: 40
url: /vi/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Xuất Bản Vẽ DWG sang PDF**

Aspose.CAD cho .NET API có thể tải các bản vẽ AutoCAD ở định dạng [DWG](https://docs.fileformat.com/cad/dwg/) và chuyển đổi nó sang [PDF](https://docs.fileformat.com/pdf/). Chủ đề này giải thích cách sử dụng API Aspose.CAD để thực hiện việc chuyển đổi từ DWG sang định dạng PDF theo các bước đơn giản như đã mô tả bên dưới.

{{% alert color="primary" %}}

API hỗ trợ các phiên bản DWG AutoCAD sau:

- Phiên bản 16.0 phát hành 18 DWG 2004
- Phiên bản 16.1 DWG 2005
- Phiên bản 18.0 DWG 2010
- Phiên bản 19.0 DWG 2013

{{% /alert %}}

### **Định Dạng Tệp DWG**

Một [DWG](https://docs.fileformat.com/cad/dwg/) là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Dữ liệu hình ảnh vector cung cấp các hướng dẫn cho ứng dụng CAD về cách hiển thị DWG; siêu dữ liệu có thể chứa nhiều thông tin khác nhau về tệp, bao gồm dữ liệu cụ thể về vị trí và dữ liệu của khách hàng. Các thông số mở cho định dạng tệp DWG có thể được tìm thấy [trong PDF này](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Chuyển Đổi Tệp DWG sang PDF**

Các bước đơn giản sau đây cần thiết để chuyển đổi [DWG](https://docs.fileformat.com/cad/dwg/) sang [PDF](https://docs.fileformat.com/pdf/).

1. Tải tệp DWG vào một thể hiện của [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

Mẫu mã dưới đây cho thấy cách xuất Bản Vẽ DWG sang PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Tạo PDF Đơn Lẻ với Kích Thước Bố Cục Khác Nhau**

Aspose.CAD cho .NET cho phép bạn chuyển đổi tệp DWG thành một PDF duy nhất với kích thước bố cục khác nhau. Cách tiếp cận này hoạt động như sau:

1. Tải một tệp DWG bằng cách sử dụng phương thức nhà máy [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập chiều cao và chiều rộng trang kết quả.
1. Thêm [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) cần thiết cho đối tượng [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Tạo một thể hiện của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) của nó.
1. Xuất hình ảnh sang PDF bằng phương thức [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Mẫu mã dưới đây cho thấy cách tạo một [PDF](https://docs.fileformat.com/pdf/) đơn với các bố cục khác nhau.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Các Đối Tượng AutoCAD Hỗ Trợ**

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

## **Xuất Bố Cục DWG Cụ Thể sang PDF**

Cách tiếp cận này hoạt động như sau:

1. Tải một tệp DWG bằng cách sử dụng phương thức nhà máy [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập chiều cao và chiều rộng trang kết quả.
1. Thiết lập thuộc tính [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) cho đối tượng [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Tạo một thể hiện của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) của nó.
1. Xuất hình ảnh sang PDF bằng phương thức [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Mẫu mã dưới đây cho thấy cách chuyển đổi một bố cục cụ thể của DWG sang PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Hiển Thị Tài Liệu DWG bằng Cách Chỉ Định Tọa Độ**

Aspose.CAD cho .NET API hiện cung cấp một tính năng để hiển thị tài liệu DWG bằng cách cung cấp tọa độ chiều rộng và chiều cao của tài liệu.

Mẫu mã dưới đây cho thấy cách hiển thị một tài liệu DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Xuất DWG sang Raster hoặc PDF theo Kích Thước Cố Định**

Aspose.CAD cho .NET API có thể tải các bản vẽ AutoCAD ở định dạng DWG và chuyển đổi nó sang PDF hoặc Raster theo kích thước cố định.

Mẫu mã dưới đây cho thấy cách thực hiện tính năng này.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Xuất DWG sang PDF/A và PDF/E**

Cách tiếp cận này hoạt động như sau:

1. Tải một tệp DWG bằng cách sử dụng phương thức nhà máy [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Tạo một thể hiện của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) của nó.
1. Thiết lập thuộc tính tuân thủ PDF và lưu nó.
1. Xuất hình ảnh sang PDF bằng phương thức [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Mẫu mã dưới đây cho thấy cách chuyển đổi tệp DWG sang PDF/A và PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Hỗ Trợ Đường Khuất Tròn khi Xuất DWG/DXF sang BMP và PDF**

Cách tiếp cận này hoạt động như sau:

1. Tải một tệp DWG bằng cách sử dụng phương thức nhà máy [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập chiều cao và chiều rộng trang kết quả.
1. Tạo một thể hiện của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) của nó.
1. Xuất hình ảnh sang PDF bằng phương thức [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Mẫu mã dưới đây cho thấy cách thực hiện tính năng này.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Hỗ Trợ Đặt Khu Vực In cho Hình Ảnh DWG trong PDF Xuất Ra**

Aspose.CAD cho .NET API có thể tải các bản vẽ AutoCAD ở định dạng DWG và chuyển đổi nó sang PDF. Chủ đề này giải thích cách sử dụng API Aspose.CAD để đạt được hỗ trợ cho việc thiết lập khu vực in cho hình ảnh DWG trong PDF xuất ra.

Mẫu mã dưới đây cho thấy cách thực hiện tính năng này.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Hỗ Trợ Đọc Siêu Dữ Liệu XREF cho Tệp DWG**

1. Tải một tệp DWG bằng cách sử dụng phương thức nhà máy [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Duyệt qua từng thực thể hình ảnh.
1. Nếu một thực thể là CadUnderlay thì đó là thực thể XREF với siêu dữ liệu.

Mẫu mã dưới đây cho thấy cách đạt được tính năng này.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) có kiểu mảng chuỗi vì vậy bạn có thể chỉ định nhiều hơn một bố cục cùng một lúc cho việc chuyển đổi sang định dạng PDF. Khi chỉ định nhiều bố cục cho thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), PDF kết quả sẽ có nhiều trang, nơi mỗi trang đại diện cho một bố cục AutoCAD riêng biệt.

### **Liệt Kê Tất Cả Các Bố Cục**

Bạn có thể liệt kê tất cả các bố cục hiện có trong một bản vẽ AutoCAD bằng cách sử dụng đoạn mã sau.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Truy Cập Cờ Underlay cho Định Dạng DWG**

Aspose.CAD cho .NET đã triển khai các cờ underlay cho định dạng DWG và cho phép các nhà phát triển truy cập chúng. Dưới đây là một ví dụ đơn giản về mã.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Hỗ Trợ cho Các Thực Thể DWG**

Aspose.CAD cho .NET API có thể tải các bản vẽ AutoCAD ở định dạng DWG và hỗ trợ các thực thể khác nhau để làm việc.

### **Hỗ Trợ cho Thực Thể MLeader**

Một DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần tiếp theo mô tả một ví dụ về việc làm việc với thực thể MLeader bên trong tệp DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Hỗ Trợ Xuất Thực Thể DWG sang Hình Ảnh**

Một DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần tiếp theo mô tả một ví dụ về việc xuất một thực thể DWG cụ thể sang hình ảnh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Hỗ Trợ Thêm Văn Bản vào DWG**

Aspose.CAD cho .NET API có thể tải các bản vẽ AutoCAD ở định dạng DWG và hỗ trợ các thực thể khác nhau để làm việc. Một DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần tiếp theo mô tả cách chúng ta có thể thêm văn bản bên trong tệp DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Hỗ Trợ Nhập Hình Ảnh vào Tệp DWG**

Aspose.CAD cho .NET API có thể tải các bản vẽ AutoCAD ở định dạng DWG và hỗ trợ các thực thể khác nhau để làm việc. Một DWG là một tệp nhị phân chứa dữ liệu hình ảnh vector và siêu dữ liệu. Có nhiều thực thể khác nhau trong một tệp DWG. Phần tiếp theo mô tả cách chúng ta có thể nhập hình ảnh vào bên trong tệp DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Hỗ Trợ Lưới trong DWG**

Aspose.CAD cho .NET API hiện có thể truy cập các thực thể hỗ trợ lưới bao gồm các loại [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) và [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). Ví dụ sau mô tả cách chúng ta có thể truy cập các loại lưới.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Chuyển Đổi Bản Vẽ DWG sang DXF**

Aspose.CAD cung cấp tính năng tải tệp DWG AutoCAD và xuất nó sang định dạng DXF. Cách chuyển đổi từ DWG sang DXF hoạt động như sau:

1. Tải tệp bản vẽ DWG bằng cách sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Xuất bản vẽ DWG sang DXF bằng phương thức [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Mẫu mã dưới đây cho thấy cách chuyển đổi tệp DWG sang định dạng DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Chuyển Đổi Bản Vẽ DWG sang SVG**

Aspose.CAD cho .NET API có thể tải các bản vẽ AutoCAD ở định dạng DWG và chuyển đổi nó sang SVG. Chủ đề này giải thích cách sử dụng API Aspose.CAD để thực hiện việc chuyển đổi từ DWG sang định dạng SVG qua các bước đơn giản như đã mô tả dưới đây.

1. Tải tệp DWG vào một thể hiện của [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Tạo một đối tượng của lớp [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) và thiết lập các thuộc tính cần thiết.
1. Xuất bản vẽ DWG sang SVG bằng phương thức [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Mẫu mã dưới đây cho thấy cách chuyển đổi tệp DWG sang định dạng SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Tải Tệp DWG Lớn**

Aspose.CAD cho .NET cung cấp tiện ích để mở các tệp DWG rất lớn bằng cách sử dụng lớp [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Giờ đây, bạn có thể dễ dàng mở các tệp lớn với sự trợ giúp của đoạn mã mẫu dưới đây.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
