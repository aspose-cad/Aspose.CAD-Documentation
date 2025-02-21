---  
title: Xuất font SHX  
type: docs  
weight: 40  
url: /vi/net/developer-guide/export-shx-fonts/  
---  
  
## **Xuất font SHX cho bản vẽ DXF/DWG**  
  
Một số bản vẽ có thể chứa font ở định dạng SHX đặc biệt, lưu giữ các ký hiệu của font dưới dạng hình dạng. Định dạng này yêu cầu quy trình tải bổ sung cho mỗi font được sử dụng trong bản vẽ. Apose.CAD có thể xuất bản vẽ với văn bản được viết bằng SHX và có nhiều tùy chọn khác nhau để thực hiện điều này. Cách đơn giản nhất để thực hiện điều này là sử dụng thuộc tính  
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) của  
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) đối tượng.  
     
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}  
  
Có thể tránh việc thiết lập tất cả các đường dẫn tới nhiều font SHX bằng ví dụ sau:  
  
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}  
  
Mỗi font SHX đi kèm với mã trang thích hợp liên quan đến nó. Những liên kết này được biết đến và một phần được nhúng vào Aspose.CAD cho các font SHX đã biết. Trong trường hợp có font SHX tùy chỉnh được sử dụng, có thể áp dụng thuộc tính ShxCodePages và thiết lập đường dẫn tới tệp SHX và mã trang tương ứng.  
   
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
