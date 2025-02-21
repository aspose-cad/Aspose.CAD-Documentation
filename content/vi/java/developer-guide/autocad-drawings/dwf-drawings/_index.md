---
title: Các bản vẽ DWF
type: docs
weight: 20
url: /vi/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Xuất Bản Vẽ DWF Sang PDF**

API Aspose.CAD cho Java có thể tải bản vẽ AutoCAD ở định dạng DWF và chuyển đổi nó sang PDF. Chủ đề này giải thích cách sử dụng API Aspose.CAD để thực hiện việc chuyển đổi từ DWF sang định dạng PDF thông qua các bước đơn giản như đã định nghĩa phía dưới.

### **Chuyển đổi Tệp DWF Sang PDF**

Các bước đơn giản sau đây là cần thiết để chuyển đổi DWF sang PDF.

1. Tải tệp DWF vào một thể hiện của [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Gọi [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) làm tham số thứ hai.

Mẫu mã dưới đây cho thấy cách xuất một Bản vẽ DWF ra PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Hỗ Trợ Các Lớp trong DWF**

Aspose.CAD cung cấp tính năng để tải các thực thể bản vẽ DWF của AutoCAD và hiển thị chúng như một bản vẽ hoàn chỉnh sang định dạng JPG.

1. Tải tệp bản vẽ DWF bằng cách sử dụng phương thức [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory.
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Thêm các lớp mong muốn.
1. Gọi [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) trong khi truyền một đối tượng của [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) làm tham số thứ hai.

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp bằng cách sử dụng các cài đặt mặc định.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
