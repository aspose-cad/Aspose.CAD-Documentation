---
title: Bản vẽ DXF
type: docs
weight: 60
url: /vi/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Xuất bản vẽ DXF sang PDF**

Aspose.CAD cung cấp tính năng tải các thực thể bản vẽ DXF AutoCAD và chuyển đổi chúng thành một bản vẽ hoàn chỉnh sang định dạng PDF. Phương pháp chuyển đổi DXF sang PDF hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng phương thức [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

Mẫu mã dưới đây cho thấy cách chuyển đổi tệp bằng cách sử dụng các cài đặt mặc định.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Định dạng được hỗ trợ**

Hiện tại, chúng tôi hoàn toàn hỗ trợ các định dạng tệp DXF AutoCAD 2010. Các phiên bản DXF trước đây không được đảm bảo là hợp lệ 100%. Chúng tôi dự định sẽ bao gồm nhiều định dạng và tính năng hơn trong các phiên bản Aspose.CAD tương lai.

### **Thực thể được hỗ trợ**

Hiện tại, chúng tôi hỗ trợ tất cả các thực thể 2D phổ biến và các tham số mặc định cơ bản của chúng như sau:

1. Kích thước căn chỉnh
1. Kích thước góc
1. Đoạn thẳng
1. Thuộc tính
1. Tham chiếu Block
1. Hình tròn
1. Kích thước đường kính
1. Hình elip
1. Mẫu
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
1. Xline

{{% alert color="primary" %}}

Nếu trong quá trình phân tích, chúng tôi gặp một số thực thể hoặc thuộc tính mà chúng tôi không hỗ trợ, thực thể hoặc thuộc tính đó sẽ bị bỏ qua một cách im lặng.

{{% /alert %}}

### **Quản lý bộ nhớ**

Thuộc tính [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) của lớp [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) có thể được sử dụng để kiểm soát việc phân bổ lại bộ nhớ. Phân bổ lại có khả năng xảy ra nhất cho các bộ nhớ đã được phân bổ trước. Nó có thể xảy ra khi hệ thống phát hiện rằng không gian đã phân bổ sẽ không đủ.

- Nếu [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) được thiết lập thành giá trị mặc định, **False**, không gian sẽ được phân bổ lại vào cùng một trung gian.
- Khi được thiết lập thành **True**, phân bổ lại không thể vượt quá không gian tối đa đã chỉ định. Trong trường hợp này, bộ nhớ đã được phân bổ mà cần phân bổ lại sẽ được giải phóng và không gian mở rộng sẽ được phân bổ trên đĩa.

## **Xuất lớp cụ thể của bản vẽ DXF sang PDF**

Phương pháp này hoạt động như sau:

1. Mở tệp bản vẽ DXF bằng phương thức [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Tạo một phiên bản của [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và xác định các thuộc tính [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) và [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Thêm các lớp vào đối tượng của [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Tạo một phiên bản của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Gọi phương thức [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) và truyền đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

Mẫu mã dưới đây cho thấy cách chuyển đổi một lớp cụ thể của DXF sang PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Kết xuất tệp PDF như một phần của bản vẽ DXF**

Phương pháp này hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng phương thức [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và tải các tệp PDF.
1. Thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) và [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) và lưu tệp.

Mẫu mã dưới đây cho thấy cách kết xuất tệp PDF như một phần của bản vẽ DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Xuất DGN nhúng cho định dạng DXF**

Aspose.CAD cung cấp tính năng tải các tệp DXF AutoCAD và xuất DGN nhúng cho định dạng DXF.

Mẫu mã dưới đây cho thấy cách đạt được yêu cầu đã chỉ định.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Hỗ trợ lưu tệp DXF**

Aspose.CAD cung cấp tính năng tải các tệp DXF AutoCAD và thực hiện thay đổi trong đó và lưu lại dưới dạng tệp DXF.

Mẫu mã dưới đây cho thấy cách đạt được yêu cầu đã chỉ định.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Xuất DXF sang WMF**

Phương pháp này hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng phương thức [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và tải các tệp PDF.
1. Thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) và [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) và lưu tệp.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Xuất Layout DXF cụ thể sang PDF**

Phương pháp này hoạt động như sau:

1. Mở tệp bản vẽ DXF bằng phương thức [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Tạo một phiên bản của [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và xác định các thuộc tính [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) và [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Chỉ định tên layout mong muốn bằng thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Tạo một phiên bản của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Xuất bản vẽ sang PDF bằng cách gọi phương thức [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) và truyền đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

Mẫu mã dưới đây cho thấy cách chuyển đổi một layout cụ thể của DXF sang PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) là kiểu mảng chuỗi vì vậy bạn có thể chỉ định nhiều hơn một layout cùng một lúc để có thể chuyển đổi sang định dạng PDF. Khi chỉ định nhiều layout cho thuộc tính [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), PDF kết quả sẽ có nhiều trang, mỗi trang đại diện cho một layout AutoCAD riêng lẻ.

{{% /alert %}}

## **Hỗ trợ cắt khối**

Aspose.CAD cung cấp tính năng cắt khối. Phương pháp cắt khối hoạt động như sau:

1. Tải tệp bản vẽ DXF bằng phương thức [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và tải các tệp PDF.
1. Thiết lập các thuộc tính mong muốn của [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai và lưu tệp.

Mẫu mã dưới đây cho thấy cách cắt khối hoạt động.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Xuất hình ảnh sang DXF**

Sử dụng Aspose.CAD, bạn có thể xuất hình ảnh sang định dạng DXF. Sử dụng phương pháp này, bạn có thể thực hiện các hành động sau:

1. Đặt phông chữ mới
1. Ẩn các thực thể
1. Cập nhật văn bản

Mẫu mã dưới đây cho bạn thấy cách thực hiện các hành động đã liệt kê ở trên.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Xuất lớp cụ thể của bản vẽ DXF sang hình ảnh**

Phương pháp này hoạt động như sau:

1. Mở tệp bản vẽ DXF bằng phương thức [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Tạo một phiên bản của [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và xác định các thuộc tính [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) và [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Thêm các lớp vào đối tượng của [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Tạo một phiên bản của [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Xuất bản vẽ sang PDF bằng cách sử dụng phương thức [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Mẫu mã dưới đây cho thấy cách chuyển đổi một lớp cụ thể của DXF sang hình ảnh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
