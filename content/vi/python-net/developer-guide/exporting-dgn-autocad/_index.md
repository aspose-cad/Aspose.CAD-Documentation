---
title: Xuất DGN AutoCAD
type: docs
weight: 50
url: /vi/python-net/developer-guide/exporting-dgn-autocad/
---

## **Xuất định dạng DGN AutoCAD sang PDF**

Aspose.CAD cho API Python đã giới thiệu chức năng để tải tệp DGN AutoCAD và chuyển đổi nó sang định dạng PDF. Lớp **CadImage** phục vụ mục đích này.

Bạn cần tải một tệp DGN hiện có dưới dạng **CadImage**. Tạo một thể hiện của lớp **CadRasterizationOptions** và đặt các thuộc tính khác nhau. Tạo một thể hiện của lớp **PdfOptions** và truyền thể hiện **CadRasterizationOptions**. Bây giờ gọi phương thức **save** của thể hiện lớp **CadImage**.

### Mã mẫu

Dưới đây là minh họa mã để chuyển đổi/xuất [DGN](https://docs.fileformat.com/cad/dgn/) sang [PDF](https://docs.fileformat.com/pdf/) định dạng.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Xuất định dạng DGN AutoCAD sang định dạng hình ảnh raster**

Aspose.CAD cho API Python đã giới thiệu chức năng để tải tệp DGN AutoCAD và chuyển đổi nó sang hình ảnh raster. Lớp **CadImage** phục vụ mục đích này.

Bạn cần tải một tệp DGN hiện có dưới dạng **CadImage**. Tạo một thể hiện của lớp **CadRasterizationOptions** và đặt các thuộc tính khác nhau. Tạo một thể hiện của lớp **JpegOptions** và truyền thể hiện **CadRasterizationOptions**. Bây giờ gọi phương thức **save** của thể hiện lớp **CadImage**.

### Mã mẫu

Dưới đây là minh họa mã để chuyển đổi/xuất [DGN](https://docs.fileformat.com/cad/dgn/) sang hình ảnh [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Hỗ trợ thực thể 3D cho DGN v7**

Aspose.CAD cho API Python đã giới thiệu chức năng để tải tệp [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD và hỗ trợ các thực thể 3D cho DGN v7. Lớp **CadImage** phục vụ mục đích này. Mỗi hình ảnh [DGN](https://docs.fileformat.com/cad/dgn/) hỗ trợ 9 chế độ xem đã định nghĩa trước. Nó được đánh số từ 1 đến 9. Nếu chế độ xem không được định nghĩa khi xuất, đối với các định dạng đầu ra nhiều trang (như PDF), tất cả các chế độ xem sẽ được xuất, mỗi chế độ xem trên một trang riêng biệt. Các thực thể 3D được hỗ trợ trên định dạng tệp DGN, cũng như 2D. Để làm điều này, **VectorRasterizationOptions** được sử dụng, TypeOfEntities không còn được sử dụng nữa cho định dạng DGN (cả 2D và 3D được hỗ trợ đồng thời).

### Mã mẫu

Dưới đây là mã mẫu để xem các phần tử DGN được hỗ trợ.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
