---
title: Lỗi callback trong quá trình xuất và tải
type: docs
weight: 40
url: /vi/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Xem xét lỗi callback trong quá trình xuất và tải**

Có thể trong quá trình xuất hoặc tải bản vẽ, chúng ta có thể gặp phải các lỗi liên quan đến cấu trúc của tệp 
(các phần trong tệp bây giờ là cần thiết nhưng trước đây thì không).
Một số lỗi trong số đó là nghiêm trọng và trong những trường hợp như vậy, ngoại lệ sẽ được ném ra, nhưng chúng ta cũng có thể bỏ qua một số lỗi bên trong và thông báo về điều đó bằng cách sử dụng các tin nhắn callback.
Dù sao, tất cả các tin nhắn này đều cần được chú ý vì chúng có thể giải thích ví dụ như các thực thể bị thiếu trong kết quả xuất hoặc các tác động khác.


### **Lỗi trong quá trình xuất**

Có một trường RenderResult trong [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
bao gồm IsRenderComplete để kiểm tra xem có lỗi trong quá trình xuất không và in thông tin về chúng:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Lỗi trong quá trình tải**

Một số vấn đề với các bản vẽ có thể được quan sát trước khi quá trình xuất bắt đầu.
Thuộc tính [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) trong đối tượng 
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) được sử dụng để lưu trữ tin nhắn về chúng.
Thuộc tính [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) hữu ích để quyết định liệu 
có cần ném ngoại lệ khi gặp lỗi tải hay không.

Dưới đây là ví dụ về cách sử dụng thuộc tính Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
