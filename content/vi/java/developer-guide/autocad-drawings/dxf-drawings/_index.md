---
title: Bản vẽ DXF
type: docs
weight: 60
url: /vi/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Xuất Bản Vẽ DXF sang PDF**

Aspose.CAD cung cấp tính năng tải các thực thể bản vẽ DXF của AutoCAD và chuyển chúng thành một bản vẽ hoàn chỉnh ở định dạng PDF. Cách tiếp cận chuyển đổi DXF sang PDF hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng cách sử dụng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Gọi Image.Save trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) như tham số thứ hai.

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp bằng cách sử dụng các thiết lập mặc định.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Định Dạng Hỗ Trợ**

Tại thời điểm này, chúng tôi hoàn toàn hỗ trợ các định dạng tệp DXF 2010 của AutoCAD. Các phiên bản DXF trước đó không được đảm bảo là 100% hợp lệ. Chúng tôi dự định bao gồm nhiều định dạng và tính năng hơn trong các phiên bản tương lai của Aspose.CAD.

### **Thực Thể Hỗ Trợ**

Tại thời điểm này, chúng tôi hỗ trợ tất cả các thực thể 2D phổ biến và các tham số mặc định cơ bản của chúng như sau:

1. Kích thước Aligned
1. Kích thước Góc
1. Cung tròn
1. Thuộc tính
1. Tham chiếu Khối
1. Hình tròn
1. Kích thước Đường kính
1. Hình elip
1. Lưới
1. Đường thẳng
1. Văn bản Đa dòng
1. Kích thước Ordinate
1. Điểm
1. Đường Polyline
1. Kích thước Radial
1. Tia
1. Kích thước Bị xoay
1. Bảng
1. Văn bản
1. Xline

{{% alert color="primary" %}}

Nếu trong quá trình phân tích mà chúng tôi gặp phải một thực thể hoặc thuộc tính mà chúng tôi không hỗ trợ, thực thể hoặc thuộc tính đó sẽ bị bỏ qua một cách im lặng.

{{% /alert %}}

### **Quản lý Bộ Nhớ**

Thuộc tính [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) có thể được sử dụng để kiểm soát việc phân bổ lại bộ nhớ. Việc phân bổ lại có khả năng xảy ra nhiều nhất cho các bộ nhớ đã được phân bổ trước. Nó có thể xảy ra khi hệ thống phát hiện rằng không gian đã được phân bổ là không đủ.

- Nếu [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) được thiết lập về giá trị mặc định, **False**, không gian sẽ được phân bổ lại cho cùng một môi trường.
- Khi được đặt là **True**, việc phân bổ lại không thể vượt quá không gian tối đa đã chỉ định. Trong trường hợp này, bộ nhớ đã được phân bổ hiện có trong bộ nhớ (cần phân bổ lại) sẽ được giải phóng và không gian mở rộng sẽ được phân bổ trên đĩa.

## **Xuất Lớp Cụ Thể của Bản Vẽ DXF sang PDF**

Cách tiếp cận này hoạt động như sau:

1. Mở tệp bản vẽ DXF bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một thể hiện của [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và chỉ định các thuộc tính [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) .
1. Thêm các lớp vào đối tượng của [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Tạo một thể hiện của [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Xuất bản vẽ sang PDF bằng cách sử dụng phương thức [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Mẫu mã dưới đây cho thấy cách chuyển đổi một lớp cụ thể của DXF sang PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Xuất Lớp Cụ Thể của Bản Vẽ DXF sang Hình Ảnh**

Cách tiếp cận này hoạt động như sau:

1. Mở tệp bản vẽ DXF bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một thể hiện của [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và chỉ định [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) .
1. Thêm các lớp vào đối tượng của [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Tạo một thể hiện của [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) & thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Xuất bản vẽ sang Hình Ảnh bằng cách sử dụng phương thức [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Mẫu mã dưới đây cho thấy cách chuyển đổi một lớp cụ thể của DXF sang Hình Ảnh.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Xử lý các tệp PDF như một phần của bản vẽ DXF**

Cách tiếp cận này hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và tải các tệp PDF.
1. Thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Gọi [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) và lưu tệp.

Mẫu mã dưới đây cho thấy cách xử lý các tệp PDF như một phần của bản vẽ DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Xuất DXF sang WMF**

Cách tiếp cận này hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và tải các tệp PDF.
1. Thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Gọi [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) và lưu tệp.

Mẫu mã dưới đây cho thấy cách xuất DXF sang WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Hỗ Trợ Lưu Tệp DXF**

Aspose.CAD cung cấp tính năng tải tệp DXF của AutoCAD và thực hiện các thay đổi đối với nó và lưu lại như một tệp DXF. Mẫu mã dưới đây cho thấy cách đạt được các yêu cầu cụ thể.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Xuất DGN nhúng dành cho định dạng DXF**

Aspose.CAD cung cấp tính năng tải các tệp DXF của AutoCAD và xuất DGN nhúng cho định dạng DXF.

Mẫu mã dưới đây cho thấy cách đạt được các yêu cầu cụ thể.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Xuất Lớp DXF Cụ Thể sang PDF**

Cách tiếp cận này hoạt động như sau:

1. Mở tệp bản vẽ DXF bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một thể hiện của [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và chỉ định [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) .
1. Chỉ định tên lớp mong muốn bằng cách sử dụng thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Tạo một thể hiện của [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Xuất bản vẽ sang PDF bằng cách sử dụng phương thức [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Mẫu mã dưới đây cho thấy cách chuyển đổi một lớp cụ thể của DXF sang PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) là loại mảng chuỗi vì vậy bạn có thể chỉ định nhiều hơn một lớp cùng một lúc để chuyển đổi sang định dạng PDF. Khi chỉ định nhiều lớp cho thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) , PDF kết quả sẽ có nhiều trang, nơi mỗi trang đại diện cho một lớp AutoCAD riêng lẻ.

{{% /alert %}}

## **Truy cập các đối tượng ATTRIB và MTEXT**

Cách tiếp cận này hoạt động như sau:

1. Mở tệp bản vẽ DXF bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Truy cập các thực thể bên trong tệp CAD.
1. Kiểm tra các thực thể [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) và [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Thêm vào danh sách tạm thời để xử lý sau

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Giải mã các Đối tượng Chèn CAD**

Cách tiếp cận này hoạt động như sau:

1. Mở tệp **DXF** bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Truy cập các thực thể bên trong tệp CAD.
1. Kiểm tra các thực thể [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Kiểm tra danh sách các loại [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Xử lý các thực thể.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Hỗ Trợ cắt khối**

Aspose.CAD cung cấp tính năng cắt khối. Cách tiếp cận cắt khối hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và tải các tệp PDF.
1. Thiết lập các thuộc tính mong muốn của [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Gọi [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) như tham số thứ hai và lưu tệp.

Mẫu mã dưới đây cho thấy cách cắt khối hoạt động.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Xuất Hình Ảnh sang DXF**

Sử dụng Aspose.CAD, bạn có thể xuất hình ảnh sang định dạng DXF. Bằng cách sử dụng cách tiếp cận này, bạn có thể thực hiện các hành động sau:

1. Đặt phông chữ mới
1. Ẩn các thực thể
1. Cập nhật văn bản

Mẫu mã dưới đây cho thấy cách thực hiện các hành động trên.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
