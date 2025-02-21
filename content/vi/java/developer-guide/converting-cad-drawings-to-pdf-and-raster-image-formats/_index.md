---
title: Chuyển đổi bản vẽ CAD sang định dạng PDF và hình ảnh raster
type: docs
weight: 30
url: /vi/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java trực tiếp ghi thông tin về API và số phiên bản trong tài liệu đầu ra. Ví dụ, khi kết xuất tài liệu sang PDF, Aspose.CAD for Java sẽ điền trường ứng dụng với giá trị 'Aspose.CAD' và trường nhà sản xuất PDF với một giá trị, ví dụ 'Aspose.CAD v 17.9'.

Xin lưu ý rằng bạn không thể yêu cầu Aspose.CAD for Java thay đổi hoặc loại bỏ thông tin này khỏi tài liệu đầu ra.

{{% /alert %}} 
## **Chuyển đổi bản vẽ CAD sang định dạng hình ảnh raster**
Aspose.CAD for Java có khả năng chuyển đổi các định dạng bản vẽ CAD như [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) sang các định dạng hình ảnh raster được hỗ trợ như [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). API Aspose.CAD for Java đã cung cấp các phương thức hiệu quả và dễ sử dụng để đạt được mục tiêu này.
Bạn có thể chuyển đổi bất kỳ định dạng bản vẽ CAD nào sang các định dạng hình ảnh raster bằng các bước đơn giản như đã trình bày dưới đây.

1. Tải tệp CAD vào một thể hiện của [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Tạo một thể hiện của [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) và thiết lập các thuộc tính bắt buộc của nó như [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Tạo một thể hiện của **ImageOptionsBase** và thiết lập thuộc tính [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) của nó tới thể hiện của **CadRasterizationOptions** được tạo ở bước trước.
1. Gọi **Image.save** bằng cách truyền đường dẫn tệp (hoặc một đối tượng MemoryStream) cũng như thể hiện của [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) được tạo ở bước trước.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Theo mặc định, API chỉ kết xuất bố cục "Mô hình". Tuy nhiên, bạn cũng có thể chỉ định các bố cục mà bạn chọn trong khi chuyển đổi bản vẽ CAD sang định dạng hình ảnh.
## **Tùy chỉnh chuyển đổi CAD**
Quy trình chuyển đổi CAD sang [PDF](https://docs.fileformat.com/pdf/) & CAD sang hình ảnh raster có thể tùy chỉnh cao vì lớp [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) đã được triển khai theo cách cung cấp nhiều tính năng tùy chọn mà khi thiết lập có thể ghi đè quá trình kết xuất theo nhu cầu của ứng dụng.
### **Lớp CadRasterizationOptions**
Lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) là chung cho tất cả các định dạng CAD được hỗ trợ như [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), do đó, thông tin được chia sẻ trong bài viết này là hợp lệ cho cả hai định dạng CAD đã đề cập.

Các thuộc tính hữu ích nhất của lớp **CadRasterizationOptions** là:

|**Thuộc tính**|**Giá trị mặc định**|**Cần thiết**|**Mô tả**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Có|Chỉ định chiều rộng trang.|
|**PageHeight**|**0**|Có|Chỉ định chiều cao trang|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Không|Chỉ định xem bản vẽ có nên được tự động thu nhỏ không. Giá trị mặc định sẽ tự động thu nhỏ hình ảnh để phù hợp với kích thước canvas. Chuyển sang chế độ **GrowToFit**, hoặc sử dụng thiết lập **None** để tắt thu nhỏ tự động.|
|**BackgroundColor**|**Color.White**|Không|Chỉ định màu nền của hình ảnh đầu ra.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Không|Chỉ định chế độ tô màu của thực thể. Chỉ định tùy chọn **UseObjectColor** để vẽ các thực thể bằng màu gốc của chúng, hoặc tùy chọn **UseDrawColor** để ghi đè các màu gốc.|
|**DrawColor**|**Color.Black**|Không|Chỉ định màu của thực thể bị ghi đè (chỉ nếu **DrawType** được thiết lập thành giá trị thuộc tính **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Không|Chỉ định xem có cần thực hiện việc tự động thay đổi kích thước bố cục để phù hợp với bố cục Mô hình hay không.|
### **Thiết lập kích thước canvas & chế độ**
Xuất từ CAD sang PDF hoặc CAD sang các định dạng hình ảnh raster không phải là một nhiệm vụ đơn giản. Vì PDF hoặc hình ảnh cuối cùng cần có kích thước canvas được xác định, chúng ta cần phải chỉ định kích thước đầu ra cho trang PDF để kết xuất bản vẽ một cách chính xác. Thiết lập các thuộc tính **CadRasterizationOptions.PageWidth** và **CadRasterizationOptions.PageHeight** một cách rõ ràng, nếu không bạn có thể gặp phải **ImageSaveException**.

Ngoài ra, bạn có thể chỉ định các tùy chọn tỷ lệ kích thước. Các tùy chọn tỷ lệ được thiết lập bởi thuộc tính **CadRasterizationOptions.ScaleMethod**. Sử dụng tùy chọn này để tự động điều chỉnh kích thước hình ảnh theo các giá trị **CadRasterizationOptions.PageWidth** và **CadRasterizationOptions.PageHeight**. Theo mặc định, **CadRasterizationOptions.ScaleMethod** được thiết lập thành chế độ **ScaleType.ShrinkToFit**. Thuộc tính này định nghĩa hành vi như sau:

- Nếu kích thước bản vẽ CAD lớn hơn kích thước canvas kết quả, thì kích thước bản vẽ sẽ được giảm xuống để phù hợp với canvas kết quả trong khi giữ nguyên tỷ lệ.
- Nếu kích thước bản vẽ CAD nhỏ hơn kích thước canvas kết quả, hãy thiết lập thuộc tính **CadRasterizationOptions.ScaleMethod** thành **ScaleType.GrowToFit** để tăng kích thước bản vẽ để phù hợp với kích thước canvas PDF trong khi giữ nguyên tỷ lệ.
- Hoặc tắt thu nhỏ tự động bằng tùy chọn **ScaleType.None**.

Mẫu mã dưới đây cho thấy tùy chọn tự động thu nhỏ được sử dụng.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Thiết lập màu nền & màu vẽ**
Theo mặc định, bảng màu cho canvas kết quả được thiết lập theo sơ đồ tài liệu chung. Điều này có nghĩa là tất cả các thực thể bên trong bản vẽ CAD được vẽ bằng một bút màu đen trên nền trắng. Các thiết lập này có thể được thay đổi bằng các thuộc tính **CadRasterizationOptions.BackgroundColor** và **CadRasterizationOptions.DrawColor**. Việc thay đổi thuộc tính **CadRasterizationOptions.DrawColor** cũng yêu cầu thiết lập thuộc tính **CadRasterizationOptions.DrawType** để sử dụng màu vẽ được chọn. Thuộc tính **CadRasterizationOptions.DrawType** điều khiển việc các thực thể CAD có giữ lại màu sắc của chúng hay sẽ được chuyển đổi sang các màu tùy chỉnh. Để giữ lại màu sắc của thực thể, hãy chỉ định **CadRasterizationOptions.DrawType** thành **CadDrawTypeMode.UseObjectColor**, nếu không hãy chỉ định giá trị **CadDrawTypeMode.UseDrawColor**.

Mẫu mã dưới đây cho thấy cách sử dụng các thuộc tính màu sắc khác nhau.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Thiết lập tự động thay đổi kích thước bố cục**
Hầu hết các bản vẽ CAD có hơn một bố cục được lưu trữ trong một tệp, và mỗi bố cục có thể có các kích thước khác nhau. Khi kết xuất các bản vẽ CAD như vậy sang PDF, mỗi trang của PDF có thể có tỷ lệ khác nhau tùy thuộc vào kích thước bố cục. Để làm cho quá trình kết xuất đồng nhất, các API Aspose.CAD đã cung cấp thuộc tính **CadRasterizationOptions.AutomaticLayoutsScaling**. Giá trị mặc định của nó là **false** nhưng khi true, API sẽ cố gắng tìm kiếm một tỷ lệ tương ứng cho mỗi bố cục riêng biệt và vẽ chúng theo cách tương ứng bằng cách thực hiện thao tác thay đổi kích thước tự động theo kích thước trang.

Dưới đây là cách thuộc tính **CadRasterizationOptions.AutomaticLayoutsScaling** hoạt động cùng với thuộc tính **CadRasterizationOptions.ScaleMethod**.

1. Nếu **ScaleMethod** được thiết lập thành **ScaleType.ShrinkToFit** hoặc **ScaleType.GrowToFit** với **AutomaticLayoutsScaling** được thiết lập là false thì tất cả các bố cục (bao gồm cả Mô hình) sẽ được xử lý theo tùy chọn đầu tiên.
1. Nếu **ScaleMethod** được thiết lập thành **ScaleType.ShrinkToFit** hoặc **ScaleType.GrowToFit** với **AutomaticLayoutsScaling** được thiết lập là true thì tất cả các bố cục (trừ Mô hình) sẽ được xử lý theo kích thước của chúng trong khi Mô hình sẽ được xử lý theo tùy chọn đầu tiên.
1. Nếu **ScaleMethod** được thiết lập thành **ScaleType.None** với **AutomaticLayoutsScaling** được thiết lập là true hoặc false thì sẽ không có thao tác thu nhỏ nào được thực hiện.

Mẫu mã dưới đây cho thấy cách thiết lập tự động thay đổi kích thước cho việc chuyển đổi CAD sang PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Chuyển đổi bố cục CAD sang các định dạng hình ảnh raster**
API Aspose.CAD for Java có khả năng chuyển đổi các bố cục CAD của các định dạng được hỗ trợ như DXF & DWG sang các hình ảnh raster như PNG, BMP, TIFF, JPEG & GIF. API cũng cung cấp hỗ trợ để kết xuất các bố cục cụ thể của một bản vẽ CAD sang các lớp PSD khác nhau. 
API Aspose.CAD for Java đã cung cấp các phương thức hiệu quả và dễ sử dụng để chỉ định danh sách các bố cục CAD cần thiết và kết xuất chúng sang các định dạng hình ảnh raster. Dưới đây là cách để thực hiện điều này trong 5 bước đơn giản như đã liệt kê dưới đây.

1. Tải tệp CAD vào một thể hiện của **Image** bằng cách sử dụng phương thức factory **load**.
1. Tạo một thể hiện của **CadRasterizationOptions** và thiết lập các thuộc tính bắt buộc của nó như **PageWidth** & **PageHeight**.
1. Chỉ định tên(s) bố cục mong muốn bằng cách sử dụng thuộc tính CadRasterizationOptions.Layouts.
1. Tạo một thể hiện của **ImageOptionsBase** và thiết lập thuộc tính **VectorRasterizationOptions** của nó tới thể hiện của **CadRasterizationOptions** được tạo ở bước trước.
1. Gọi phương thức **Image.Save** bằng cách truyền đường dẫn tệp (hoặc một đối tượng MemoryStream) cũng như thể hiện của **ImageOptionsBase** được tạo ở bước trước.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Thuộc tính **CadRasterizationOptions.Layouts** là loại mảng chuỗi vì vậy bạn có thể chỉ định nhiều hơn một bố cục cùng một lúc cho việc chuyển đổi thành các định dạng hình ảnh có thể. Khi chỉ định nhiều bố cục cho thuộc tính **CadRasterizationOptions.Layouts**, hình ảnh TIFF kết quả sẽ có nhiều trang, hình ảnh GIF sẽ có nhiều khung và định dạng PSD sẽ có nhiều lớp, nơi mỗi trang/khung/lớp đại diện cho một bố cục AutoCAD riêng biệt. Trong trường hợp bất kỳ định dạng hình ảnh khác như PNG, BMP, JPEG được chọn để lưu kết quả thì API sẽ chỉ kết xuất bố cục mặc định; tức là "Mô hình".

{{% /alert %}} 
## **Bật theo dõi cho quá trình kết xuất CAD**
Aspose.CAD đã giới thiệu một loạt các lớp và các trường liệt kê hỗ trợ để trợ giúp theo dõi quá trình kết xuất CAD. Với những thay đổi này, việc chuyển đổi CAD sang PDF bây giờ có thể được thực hiện như sau trong khi kích hoạt theo dõi.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Theo dõi quá trình kết xuất CAD có thể phát hiện các vấn đề khả thi sau.

1. Thông tin tiêu đề bị thiếu hoặc bị hỏng.
1. Thông tin bố cục bị thiếu.
1. Thiếu các thực thể khối.
1. Thiếu kiểu kích thước.
1. Thiếu kiểu dáng.
## **Thay thế phông chữ khi chuyển đổi bản vẽ CAD**
Có khả năng là một bản vẽ CAD nhất định sử dụng một phông chữ cụ thể mà không có trên máy nơi quá trình chuyển đổi CAD sang PDF hoặc CAD sang hình ảnh raster đang diễn ra. Trong những tình huống như vậy, API Aspose.CAD sẽ kích hoạt một ngoại lệ phù hợp để làm nổi bật các phông chữ bị thiếu và dừng quá trình chuyển đổi vì API yêu cầu các phông chữ này để kết xuất nội dung lên PDF và/hoặc hình ảnh đầu ra một cách chính xác.
API Aspose.CAD cung cấp một cách dễ dàng để sử dụng cơ chế thay thế các phông chữ cần thiết bằng các phông chữ có sẵn. Thuộc tính **CadImage.Styles** trả về một thể hiện của **CadStylesDictionary** mà chứa **CadStyleTableObject** cho mỗi kiểu trong bản vẽ CAD, trong khi đó **CadStyleTableObject.PrimaryFontName** có thể được sử dụng để chỉ định tên phông chữ có sẵn.

Mẫu mã sau đây minh họa việc sử dụng API Aspose.CAD for Java để thay đổi phông chữ của tất cả các kiểu trong một bản vẽ CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Cũng có thể thay đổi phông chữ của chỉ một kiểu cụ thể bằng cách truy cập qua tên kiểu. Mẫu mã sau đây minh họa việc sử dụng cách tiếp cận này.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Chuyển đổi các lớp CAD sang định dạng hình ảnh raster**
API Aspose.CAD for Java đã cung cấp một phương thức hiệu quả và dễ sử dụng để chỉ định tên của lớp CAD cần thiết và kết xuất nó sang các định dạng hình ảnh raster. Dưới đây là cách bạn có thể thực hiện điều này trong 5 bước đơn giản như đã liệt kê dưới đây.

1. Tải tệp CAD vào một thể hiện của **Image** bằng cách sử dụng phương thức factory **load**.
1. Tạo một thể hiện của **CadRasterizationOptions** và thiết lập các thuộc tính bắt buộc của nó như **PageWidth** & **PageHeight**.
1. Thêm tên lớp mong muốn bằng cách sử dụng phương thức **CadRasterizationOptions.Layers.add**.
1. Tạo một thể hiện của **ImageOptionsBase** và thiết lập thuộc tính **VectorRasterizationOptions** của nó tới thể hiện của **CadRasterizationOptions** được tạo ở bước trước.
1. Gọi phương thức **Image.save** bằng cách truyền đường dẫn tệp (hoặc một đối tượng MemoryStream) cũng như thể hiện của **ImageOptionsBase** được tạo ở bước trước.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Chuyển đổi tất cả các lớp CAD thành hình ảnh riêng biệt**
Bạn có thể lấy tất cả các lớp từ một bản vẽ CAD bằng cách sử dụng **CadImage.Layers** và kết xuất mỗi lớp thành hình ảnh riêng biệt như được minh họa dưới đây.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Chuyển đổi các lớp CAD DWF sang định dạng hình ảnh raster**
API Aspose.CAD for Java đã cung cấp một phương thức hiệu quả và dễ sử dụng để chỉ định tên của lớp CAD cần thiết và kết xuất nó sang các định dạng hình ảnh raster. Dưới đây là cách bạn có thể thực hiện điều này trong 5 bước đơn giản như đã liệt kê dưới đây.

1. Tải tệp CAD DWF vào một thể hiện của **Image** bằng cách sử dụng phương thức factory **Load**.
1. Tạo một thể hiện của **CadRasterizationOptions** và thiết lập các thuộc tính bắt buộc của nó như **PageWidth** & **PageHeight**.
1. Thêm tên lớp mong muốn bằng cách sử dụng phương thức **CadRasterizationOptions.Layers.Add**.
1. Tạo một thể hiện của **ImageOptionsBase** và thiết lập thuộc tính **VectorRasterizationOptions** của nó tới thể hiện của **CadRasterizationOptions** được tạo ở bước trước.
1. Gọi phương thức **Image.Save** bằng cách truyền đường dẫn tệp (hoặc một đối tượng MemoryStream) cũng như thể hiện của **ImageOptionsBase** được tạo ở bước trước.

Dưới đây là mã nguồn hoàn chỉnh.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
