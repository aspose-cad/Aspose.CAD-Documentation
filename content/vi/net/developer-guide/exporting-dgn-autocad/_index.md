---
title: Xuất DGN AutoCAD
type: docs
weight: 50
url: /vi/net/developer-guide/exporting-dgn-autocad/
---

## **Xuất định dạng DGN AutoCAD sang PDF**

Aspose.CAD cho API .NET đã giới thiệu tính năng để tải một tệp DGN AutoCAD và chuyển đổi nó sang định dạng PDF. Lớp [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) phục vụ cho mục đích này.

Bạn cần tải một tệp DGN hiện có dưới dạng [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính khác nhau. Tạo một thể hiện của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và truyền thể hiện [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Bây giờ gọi phương thức [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) của thể hiện lớp [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Mã mẫu

Dưới đây là mã minh họa để chuyển đổi/xuất [DGN](https://docs.fileformat.com/cad/dgn/) sang định dạng [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Xuất định dạng DGN AutoCAD sang định dạng hình ảnh Raster**

Aspose.CAD cho API .NET đã giới thiệu tính năng để tải một tệp DGN AutoCAD và chuyển đổi nó sang một hình ảnh raster. Lớp [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) phục vụ cho mục đích này.

Bạn cần tải một tệp DGN hiện có dưới dạng [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Tạo một thể hiện của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính khác nhau. Tạo một thể hiện của lớp [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) và truyền thể hiện [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Bây giờ gọi phương thức [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) của thể hiện lớp [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Mã mẫu

Dưới đây là mã minh họa để chuyển đổi/xuất [DGN](https://docs.fileformat.com/cad/dgn/) sang hình ảnh [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Hỗ trợ thực thể 3D cho DGN v7**

Aspose.CAD cho API .NET đã giới thiệu tính năng để tải một tệp [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD và hỗ trợ các thực thể 3D cho DGN v7. Lớp [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) phục vụ cho mục đích này. Mỗi hình ảnh [DGN](https://docs.fileformat.com/cad/dgn/) hỗ trợ 9 chế độ xem được định nghĩa trước. Nó được đánh số từ 1 đến 9. Nếu chế độ xem không được xác định khi xuất, đối với các định dạng đầu ra nhiều trang (như PDF) tất cả các chế độ xem sẽ được xuất, mỗi chế độ trên một trang riêng biệt. Các thực thể 3D được hỗ trợ trên định dạng tệp DGN, cũng như 2D. Để làm điều này, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) được sử dụng, TypeOfEntities không còn được sử dụng nữa cho định dạng DGN (cả 2D và 3D được hỗ trợ đồng thời).

### Mã mẫu

Dưới đây là mã mẫu để xem các phần tử DGN được hỗ trợ.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
