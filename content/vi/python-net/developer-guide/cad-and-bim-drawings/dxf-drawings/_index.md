---
title: Bản vẽ DXF
type: docs
weight: 10
url: /vi/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Xuất bản vẽ DXF sang PDF**

Aspose.CAD cung cấp tính năng tải các thực thể bản vẽ DXF AutoCAD và kết xuất chúng dưới dạng một bản vẽ hoàn chỉnh sang định dạng PDF. Phương pháp chuyển đổi DXF sang PDF hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng cách sử dụng phương thức **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và thiết lập các thuộc tính **page_height** & **page_width**.
1. Tạo một đối tượng của lớp **PdfOptions** và thiết lập thuộc tính **VectorRasterizationOptions**.
1. Gọi **Image.save** trong khi truyền một đối tượng của **PdfOptions** làm tham số thứ hai.

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp bằng cách sử dụng các cài đặt mặc định.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Các định dạng được hỗ trợ**

Hiện tại, chúng tôi hoàn toàn hỗ trợ định dạng tệp AutoCAD DXF 2010. Các phiên bản DXF trước đó không đảm bảo 100% hợp lệ. Chúng tôi đang lên kế hoạch đưa thêm nhiều định dạng và tính năng trong các phiên bản Aspose.CAD tương lai.

### **Các thực thể được hỗ trợ**

Hiện tại, chúng tôi hỗ trợ tất cả các thực thể 2D phổ biến và các tham số mặc định cơ bản của chúng như sau:

1. Kích thước căn chỉnh
1. Kích thước góc
1. Đường cung
1. Thuộc tính
1. Tham chiếu Khối
1. Hình tròn
1. Kích thước đường kính
1. Hình elip
1. Đường gạch
1. Đường thẳng
1. Văn bản nhiều dòng
1. Kích thước tọa độ
1. Điểm
1. Đường đa tuyến
1. Kích thước bán kính
1. Tia
1. Kích thước xoay
1. Bảng
1. Văn bản
1. Đường chéo

{{% alert color="primary" %}}

Nếu trong quá trình phân tích chúng tôi gặp một thực thể hoặc thuộc tính mà chúng tôi không hỗ trợ, thực thể hoặc thuộc tính đó sẽ bị lướt qua một cách im lặng.

{{% /alert %}}

## **Xuất lót DGN nhúng cho định dạng DXF**

Aspose.CAD cung cấp tính năng tải các tệp DXF AutoCAD và xuất lót DGN nhúng cho định dạng DXF.

Mẫu mã dưới đây cho thấy cách đạt được các yêu cầu đã xác định.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Hỗ trợ lưu tệp DXF**

Aspose.CAD cung cấp tính năng tải các tệp DXF AutoCAD, thực hiện thay đổi và lưu lại như một tệp DXF.

Mẫu mã dưới đây cho thấy cách đạt được các yêu cầu đã xác định.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Xuất DXF sang WMF**

Phương pháp này hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng cách sử dụng phương thức **Image.load**.
1. Tạo một đối tượng của lớp **CadRasterizationOptions** và tải các tệp PDF.
1. thiết lập các thuộc tính **page_height** & **page_width**.
1. Gọi **Image.save** và lưu tệp.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
