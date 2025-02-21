---
title: Bản vẽ DWF
type: docs
weight: 20
url: /vi/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Xuất Bản Vẽ DWF sang PDF**

Aspose.CAD cung cấp tính năng để tải các thực thể bản vẽ AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) và tạo ra chúng như một bản vẽ hoàn chỉnh sang định dạng [PDF](https://docs.fileformat.com/pdf/). Cách tiếp cận chuyển đổi từ [DWF](https://docs.fileformat.com/cad/dwf/) sang [PDF](https://docs.fileformat.com/pdf/) hoạt động như sau:

1. Tải tệp bản vẽ [DWF](https://docs.fileformat.com/cad/dwf/) sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) làm tham số thứ hai.

### Mẫu Mã

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp sử dụng cài đặt mặc định.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Trích Xuất Các Lớp từ Bản Vẽ DWF**

Aspose.CAD cung cấp tính năng để tải các thực thể bản vẽ AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) và tạo ra chúng như một bản vẽ hoàn chỉnh sang định dạng [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Tải tệp bản vẽ [DWF](https://docs.fileformat.com/cad/dwf/) sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Trích xuất tên các lớp sử dụng đối tượng [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) làm tham số thứ hai.

### Mẫu Mã

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp sử dụng cài đặt mặc định.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Hỗ Trợ Các Lớp trong DWF**

Aspose.CAD cung cấp tính năng để tải các thực thể bản vẽ AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) và tạo ra chúng như một bản vẽ hoàn chỉnh sang định dạng [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Tải tệp bản vẽ [DWF](https://docs.fileformat.com/cad/dwf/) sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Thêm các lớp mong muốn.
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) làm tham số thứ hai.

### Mẫu Mã

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp sử dụng cài đặt mặc định.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Xuất Bản Vẽ DWF sang BMP**

Aspose.CAD cung cấp tính năng để tải các thực thể bản vẽ AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) và tạo ra chúng như một bản vẽ hoàn chỉnh sang định dạng [BMP](https://docs.fileformat.com/image/bmp/). Cách tiếp cận chuyển đổi từ [DWF](https://docs.fileformat.com/cad/dwf/) sang [BMP](https://docs.fileformat.com/image/bmp/) hoạt động như sau:

1. Tải tệp bản vẽ [DWF](https://docs.fileformat.com/cad/dwf/) sử dụng phương thức nhà máy [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Tạo một đối tượng của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) và thiết lập các thuộc tính [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Tạo một đối tượng của lớp [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Gọi [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) trong khi truyền một đối tượng của [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) làm tham số thứ hai.

### Mẫu Mã

Mẫu mã dưới đây cho thấy cách chuyển đổi một tệp [DWF](https://docs.fileformat.com/cad/dwf/) sang [BMP](https://docs.fileformat.com/image/bmp/) sử dụng cài đặt mặc định.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
