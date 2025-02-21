---
title: Bản vẽ DGN
type: docs
weight: 10
url: /vi/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Bản vẽ định dạng DGN như một phần của DWG**

Aspose.CAD cho Java cho phép các nhà phát triển xuất một tệp DWG với lớp DGN nhúng bên trong. Dưới đây là mã minh họa cách truy cập lớp DGN bên trong một tệp DWG khi xuất tệp DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Hỗ trợ thực thể 3D cho DGN v7**

API Aspose.CAD cho Java đã giới thiệu chức năng tải một tệp DGN AutoCAD và hỗ trợ thực thể 3D cho DGN v7. Lớp [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) phục vụ mục đích này. Mỗi hình ảnh DGN hỗ trợ 9 chế độ xem được xác định trước. Chúng được đánh số từ 1 đến 9. Nếu chế độ xem không được xác định khi xuất, đối với các định dạng đầu ra nhiều trang (như PDF), tất cả các chế độ xem sẽ được xuất, mỗi chế độ xem trên một trang riêng. Các thực thể 3D được hỗ trợ trên định dạng tệp DGN, cũng như 2D. 
VectorRasterizationOptions.TypeOfEntities không còn được sử dụng nữa cho định dạng DGN (cả 2D và 3D đều được hỗ trợ đồng thời).

Mã mẫu để xem các phần tử DGN được hỗ trợ.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
