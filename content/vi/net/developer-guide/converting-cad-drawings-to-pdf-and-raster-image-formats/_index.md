---
title: Chuyển DWG DXF sang PDF C# | Chuyển đổi Tệp Auto CAD sang PDF JPEG PNG trong C# .NET
type: docs
weight: 30
url: /vi/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG sang PDF C#, DXF sang PDF C#, DWF DWT sang PDF C#, chuyển đổi AutoCAD, chuyển đổi DWG, chuyển đổi DWF, chuyển đổi DWT, chuyển đổi DXF, chuyển đổi autocad sang pdf, chuyển đổi DWG sang PDF, chuyển đổi DWG sang PNG, chuyển đổi DWG sang TIFF, chuyển đổi DWG sang JPG"
description: Sử dụng công cụ chuyển đổi AutoCAD sang PDF C# .NET để chuyển DWG hoặc DXF sang PDF trong C#. Bạn có thể chuyển DWG, DWF, DWT và DXF sang PDF, JPEG, PNG, BMP, GIF và TIFF trong C# .NET.
---

## **Chuyển DWG hoặc DXF sang PNG JPEG BMP GIF hoặc TIFF trong C#**

Aspose.CAD cho .NET có thể chuyển đổi các định dạng bản vẽ AutoCAD như [DXF](https://docs.fileformat.com/cad/dxf/) và [DWG](https://docs.fileformat.com/cad/dwg/) sang [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) và [GIF](https://docs.fileformat.com/image/gif/). Nó đã cung cấp API hiệu quả và dễ sử dụng để đạt được mục tiêu này.

Bạn có thể chuyển đổi bất kỳ định dạng bản vẽ AutoCAD nào được hỗ trợ sang định dạng hình ảnh bitmap theo các bước đơn giản như được giải thích dưới đây.

1. Tải tệp DWG hoặc DXF vào lớp [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Tạo một thể hiện của [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Đặt/thay đổi kích thước của hình ảnh bằng cách sử dụng [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) và [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Tạo một thể hiện của [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Đặt thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) thành [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) đã tạo ở bước trước.
1. Lưu bản vẽ AutoCAD dưới dạng PDF bằng cách sử dụng [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) bằng cách truyền đường dẫn tệp (hoặc một đối tượng MemoryStream) cũng như thể hiện của [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) đã tạo ở bước trước.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Mặc định, API chỉ kết xuất layout "Model". Tuy nhiên, bạn cũng có thể chỉ định các layout mà bạn lựa chọn khi chuyển đổi các bản vẽ CAD sang định dạng hình ảnh.

## **Tùy chỉnh Chuyển đổi CAD**

Quy trình chuyển đổi CAD sang [PDF](https://docs.fileformat.com/pdf/) & CAD sang hình ảnh raster có thể cấu hình cao, vì lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) đã được triển khai theo cách cung cấp nhiều tính năng tùy chọn mà khi được thiết lập có thể ghi đè quá trình kết xuất theo nhu cầu của ứng dụng.

### **Lớp CadRasterizationOptions**

Lớp **CadRasterizationOptions** là chung cho tất cả các định dạng CAD được hỗ trợ như DWG & DXF, do đó thông tin được chia sẻ trong bài viết này hợp lệ cho cả hai định dạng CAD đã đề cập.

Các thuộc tính lớp **CadRasterizationOptions** hữu ích nhất là:

|**Thuộc tính**|**Giá trị mặc định**|**Bắt buộc**|**Mô tả**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Có|Chỉ định chiều rộng trang.|
|**PageHeight**|**0**|Có|Chỉ định chiều cao trang|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Không|Chỉ định xem bản vẽ có nên được tự động thu nhỏ hay không. Giá trị mặc định tự động thu nhỏ hình ảnh để phù hợp với kích thước canvas. Chuyển sang chế độ **GrowToFit**, hoặc sử dụng cài đặt **None** để tắt thu nhỏ tự động.|
|**BackgroundColor**|**Color.White**|Không|Chỉ định màu nền của hình ảnh đầu ra.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Không|Chỉ định chế độ tô màu của thực thể. Chỉ định tùy chọn **UseObjectColor** để vẽ các thực thể bằng màu gốc của chúng, hoặc tùy chọn **UseDrawColor** để ghi đè màu gốc.|
|**DrawColor**|**Color.Black**|Không|Chỉ định màu của thực thể đã bị ghi đè (chỉ khi **DrawType** được đặt thành giá trị thuộc tính **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Không|Chỉ định nếu việc tự động tỷ lệ layout cần được thực hiện để phù hợp với layout Model.|

### **Cài đặt Kích thước & Chế độ Canvas**

Xuất từ CAD sang PDF hoặc định dạng hình ảnh raster không phải là một nhiệm vụ đơn giản. Vì PDF hoặc hình ảnh kết quả yêu cầu phải xác định kích thước canvas, chúng ta cần chỉ định kích thước đầu ra cho trang PDF để kết xuất bản vẽ một cách chính xác. Đặt các thuộc tính **CadRasterizationOptions.PageWidth** và **CadRasterizationOptions.PageHeight** một cách rõ ràng, nếu không bạn có thể gặp **ImageSaveException**.

Ngoài ra, bạn có thể chỉ định các tùy chọn tỷ lệ kích thước. Các tùy chọn tỷ lệ được thiết lập bởi thuộc tính **CadRasterizationOptions.ScaleMethod**. Sử dụng tùy chọn này để tự động điều chỉnh kích thước hình ảnh theo giá trị của **CadRasterizationOptions.PageWidth** và **CadRasterizationOptions.PageHeight**. Mặc định **CadRasterizationOptions.ScaleMethod** được đặt ở chế độ **ScaleType.ShrinkToFit**. Thuộc tính này xác định hành vi sau:

- Nếu kích thước bản vẽ CAD lớn hơn kích thước canvas kết quả, thì kích thước bản vẽ sẽ được giảm xuống để vừa vặn vào canvas kết quả trong khi vẫn giữ tỉ lệ.
- Nếu kích thước bản vẽ CAD nhỏ hơn kích thước canvas kết quả, hãy đặt thuộc tính **CadRasterizationOptions.ScaleMethod** thành **ScaleType.GrowToFit** để tăng kích thước bản vẽ cho phù hợp với canvas PDF trong khi vẫn giữ tỉ lệ.
- Hoặc vô hiệu hóa thu nhỏ tự động với tùy chọn **ScaleType.None**.

Mẫu mã dưới đây cho thấy cách sử dụng tùy chọn tự động thu nhỏ.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Cài đặt Màu Nền & Màu Vẽ**

Mặc định, bảng màu cho canvas kết quả được đặt theo chế độ tài liệu chung. Điều đó có nghĩa là tất cả các thực thể bên trong bản vẽ CAD được vẽ bằng bút màu đen trên nền trắng. Các cài đặt này có thể thay đổi bằng cách sử dụng các thuộc tính **CadRasterizationOptions.BackgroundColor** và **CadRasterizationOptions.DrawColor**. Thay đổi thuộc tính **CadRasterizationOptions.DrawColor** cũng yêu cầu phải đặt thuộc tính **CadRasterizationOptions.DrawType** để sử dụng màu vẽ. Thuộc tính **CadRasterizationOptions.DrawType** kiểm soát việc các thực thể CAD có giữ nguyên màu của chúng hay không hoặc bị chuyển đổi sang màu tùy chỉnh. Để giữ nguyên màu của thực thể, hãy chỉ định **CadRasterizationOptions.DrawType** là **CadDrawTypeMode.UseObjectColor**, nếu không hãy chỉ định giá trị **CadDrawTypeMode.UseDrawColor**.

Mẫu mã dưới đây cho thấy cách sử dụng các thuộc tính màu khác nhau.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Thiết lập Tự động Tỷ lệ Layout**

Hầu hết các bản vẽ CAD có hơn một layout được lưu trong một tệp duy nhất, và mỗi layout có thể có kích thước khác nhau. Khi kết xuất các bản vẽ CAD như vậy sang PDF, mỗi trang của PDF có thể có tỷ lệ khác nhau tùy theo kích thước layout. Để làm cho việc kết xuất đồng nhất, các API Aspose.CAD đã cấp cho thuộc tính **CadRasterizationOptions.AutomaticLayoutsScaling**. Giá trị mặc định của nó là **false** nhưng khi true, API sẽ cố gắng tìm tỷ lệ tương ứng cho mỗi layout riêng biệt và vẽ chúng một cách tương ứng bằng cách thực hiện thao tác thay đổi kích thước tự động theo kích thước trang.

Dưới đây là cách thuộc tính **CadRasterizationOptions.AutomaticLayoutsScaling** hoạt động phối hợp với thuộc tính **CadRasterizationOptions.ScaleMethod**.

1. Nếu **ScaleMethod** được thiết lập là **ScaleType.ShrinkToFit** hoặc **ScaleType.GrowToFit** với **AutomaticLayoutsScaling** đặt thành false thì tất cả các layout (bao gồm cả Model) sẽ được xử lý theo tùy chọn đầu tiên.
1. Nếu **ScaleMethod** được thiết lập là **ScaleType.ShrinkToFit** hoặc **ScaleType.GrowToFit** với **AutomaticLayoutsScaling** đặt thành true thì tất cả các layout (trừ Model) sẽ được xử lý theo kích thước của chúng trong khi Model sẽ được xử lý theo tùy chọn đầu tiên.
1. Nếu **ScaleMethod** được thiết lập là **ScaleType.None** với **AutomaticLayoutsScaling** đặt thành true hoặc false thì sẽ không có tỷ lệ nào được thực hiện.

Mẫu mã dưới đây cho thấy cách thiết lập tỷ lệ tự động cho việc chuyển đổi CAD sang PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Chuyển đổi Layouts AutoCAD DXF hoặc DWG sang PNG hoặc Các định dạng Hình ảnh Khác trong C#**

API Aspose.CAD cho .NET có thể chuyển các layout CAD của các định dạng được hỗ trợ như DXF và DWG sang PNG BMP TIFF JPEG và GIF. API cũng cung cấp hỗ trợ để kết xuất các layout cụ thể của một bản vẽ CAD thành các lớp PSD khác nhau.

Dưới đây là cách bạn có thể đạt được điều này theo các bước đơn giản sau.

- Tải tệp DWG hoặc DXF vào lớp **Image**.
- Đặt/thay đổi chiều rộng và chiều cao của hình ảnh.
- Đặt tên layout mong muốn bằng cách sử dụng thuộc tính CadRasterizationOptions.Layouts.
- Tạo một thể hiện của **ImageOptionsBase** và đặt thuộc tính **VectorRasterizationOptions** của nó thành thể hiện của **CadRasterizationOptions** đã tạo ở bước trước.
- Lưu layout CAD dưới dạng TIFF hoặc hình ảnh.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Thuộc tính **CadRasterizationOptions.Layouts** là kiểu mảng chuỗi vì vậy bạn có thể chỉ định nhiều layouts hơn một lần cho việc chuyển đổi sang các định dạng hình ảnh có thể có. Khi chỉ định nhiều layout cho thuộc tính **CadRasterizationOptions.Layouts**, hình ảnh TIFF kết quả sẽ có nhiều trang, hình ảnh GIF sẽ có nhiều khung và định dạng [PSD](https://docs.fileformat.com/image/psd/) sẽ có nhiều lớp, nơi mỗi trang/khung/lớp đại diện cho một layout AutoCAD riêng biệt. Trong trường hợp bất kỳ định dạng hình ảnh nào khác như PNG, BMP, JPEG được chọn để lưu kết quả thì API sẽ chỉ kết xuất layout mặc định; tức là "Model".

{{% /alert %}}

## **Kích hoạt Theo dõi cho Quy trình Kết xuất CAD**

Aspose.CAD đã giới thiệu một loạt các lớp và các trường enumeration hỗ trợ để hỗ trợ theo dõi quy trình kết xuất CAD. Với những thay đổi này, việc chuyển đổi CAD sang PDF giờ đây có thể đạt được như sau đồng thời kích hoạt theo dõi.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Việc theo dõi quy trình kết xuất CAD có thể phát hiện các vấn đề có thể xảy ra sau.

1. Thiếu hoặc bị hỏng thông tin tiêu đề.
1. Thiếu thông tin layout.
1. Thiếu thực thể khối.
1. Thiếu kiểu kích thước.
1. Thiếu kiểu.

## **Thay thế Phông chữ khi Chuyển đổi Bản vẽ CAD**

Có khả năng một bản vẽ CAD cụ thể sử dụng một phông chữ cụ thể mà không có trên máy mà quá trình chuyển đổi CAD sang PDF hay CAD sang hình ảnh raster đang diễn ra. Trong những tình huống như vậy, API Aspose.CAD sẽ kích hoạt ngoại lệ phù hợp để làm nổi bật các phông chữ bị thiếu và dừng quy trình chuyển đổi vì API yêu cầu các phông chữ này để kết xuất nội dung một cách chính xác vào PDF hoặc hình ảnh kết quả.

API Aspose.CAD cung cấp một cách dễ dàng để sử dụng cơ chế thay thế các phông chữ yêu cầu bằng các phông chữ sẵn có. Thuộc tính **CadImage.Styles** trả về một thể hiện của **CadStylesDictionary** mà từ đó chứa **CadStyleTableObject** cho mỗi kiểu trong bản vẽ CAD, trong khi **CadStyleTableObject.PrimaryFontName** có thể được sử dụng để chỉ định tên phông chữ sẵn có.

Mẫu mã sau đây minh họa cách sử dụng API Aspose.CAD cho .NET để thay đổi phông chữ của tất cả các kiểu trong một bản vẽ CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Cũng có thể thay đổi phông chữ của chỉ một kiểu nhất định bằng cách truy cập nó qua tên kiểu. Mẫu mã dưới đây minh họa cách sử dụng phương pháp này.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Chuyển đổi Các lớp CAD sang định dạng Hình ảnh Raster**

API Aspose.CAD cho .NET đã cung cấp một phương tiện hiệu quả & dễ sử dụng để chỉ định tên của lớp CAD cần thiết và kết xuất nó thành định dạng hình ảnh bitmap. Dưới đây là cách bạn có thể đạt được điều này trong 5 bước đơn giản như được liệt kê dưới đây.

1. Tải tệp CAD vào một thể hiện của **Image** bằng cách sử dụng phương pháp nhà máy **Load**.
1. Tạo một thể hiện của **CadRasterizationOptions** và đặt các thuộc tính bắt buộc của nó như **PageWidth** & **PageHeight**.
1. Thêm tên lớp mong muốn bằng cách sử dụng phương pháp **CadRasterizationOptions.Layers.Add**.
1. Tạo một thể hiện của **ImageOptionsBase** và đặt thuộc tính **VectorRasterizationOptions** của nó thành thể hiện của **CadRasterizationOptions** đã tạo ở bước trước.
1. Gọi phương thức **Image.Save** bằng cách truyền đường dẫn tệp (hoặc một đối tượng MemoryStream) cùng với thể hiện của **ImageOptionsBase** đã tạo ở bước trước.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Chuyển đổi Tất cả Các Lớp CAD sang Hình ảnh Riêng biệt**

Bạn có thể lấy tất cả các lớp từ một bản vẽ CAD bằng cách sử dụng **CadImage.Layers** và kết xuất mỗi lớp thành hình ảnh riêng biệt như được trình bày dưới đây.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Chuyển đổi Các lớp DWF CAD sang định dạng Hình ảnh Raster**

API Aspose.CAD cho .NET đã cung cấp một phương tiện hiệu quả & dễ sử dụng để chỉ định tên của lớp CAD cần thiết và kết xuất nó thành định dạng hình ảnh bitmap. Dưới đây là cách bạn có thể đạt được điều này trong 5 bước đơn giản như được liệt kê dưới đây.

1. Tải tệp CAD DWF vào một thể hiện của **Image** bằng cách sử dụng phương pháp nhà máy **Load**.
1. Tạo một thể hiện của **CadRasterizationOptions** và đặt các thuộc tính bắt buộc của nó như **PageWidth** & **PageHeight**.
1. Thêm tên lớp mong muốn bằng cách sử dụng phương pháp **CadRasterizationOptions.Layers.Add**.
1. Tạo một thể hiện của **ImageOptionsBase** và đặt thuộc tính **VectorRasterizationOptions** của nó thành thể hiện của **CadRasterizationOptions** đã tạo ở bước trước.
1. Gọi phương thức **Image.Save** bằng cách truyền đường dẫn tệp (hoặc một đối tượng MemoryStream) cùng với thể hiện của **ImageOptionsBase** đã tạo ở bước trước.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD cho .NET trực tiếp ghi thông tin về API và Số phiên bản trong các tài liệu đầu ra. Ví dụ, khi kết xuất Tài liệu sang PDF, Aspose.CAD cho .NET sẽ điền trường Ứng dụng với giá trị 'Aspose.CAD' và trường Nhà sản xuất PDF với một giá trị, ví dụ 'Aspose.CAD v 17.10'.

Xin lưu ý rằng bạn không thể hướng dẫn Aspose.CAD cho .NET thay đổi hoặc loại bỏ thông tin này từ các Tài liệu đầu ra.
