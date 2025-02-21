---
title: Xuất DGN AutoCAD
type: docs
weight: 50
url: /vi/java/developer-guide/exporting-dgn-autocad/
---

## **Xuất định dạng DGN AutoCAD sang PDF**

Aspose.CAD cho API Java đã giới thiệu tính năng tải một tệp [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD và chuyển đổi nó sang định dạng [PDF](https://docs.fileformat.com/pdf/). Lớp [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) phục vụ mục đích này.

Bạn cần tải một tệp DGN hiện có dưới dạng [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập các thuộc tính khác nhau. Tạo một thể hiện của lớp [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) và truyền thể hiện [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) vào. Bây giờ gọi phương thức [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) của thể hiện lớp [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Mã mẫu

Dưới đây là minh họa mã để chuyển đổi/xuất DGN sang định dạng PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Xuất định dạng DGN AutoCAD sang định dạng hình ảnh raster**

Aspose.CAD cho API Java đã giới thiệu tính năng tải một tệp [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD và chuyển đổi nó sang hình ảnh raster. Lớp [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) phục vụ mục đích này.

Bạn cần tải một tệp DGN hiện có dưới dạng [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập các thuộc tính khác nhau. Tạo một thể hiện của lớp [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) và truyền thể hiện [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) vào. Bây giờ gọi phương thức [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) của thể hiện lớp [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Mã mẫu

Dưới đây là minh họa mã để chuyển đổi/xuất [DGN](https://docs.fileformat.com/cad/dgn/) sang hình ảnh [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
