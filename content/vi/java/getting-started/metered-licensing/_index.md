---
title: Cấp phép theo lượng sử dụng
type: docs
weight: 60
url: /vi/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD cho phép các nhà phát triển áp dụng khóa theo lượng sử dụng. Đây là một cơ chế cấp phép mới. Cơ chế cấp phép mới này sẽ được sử dụng cùng với phương pháp cấp phép hiện có. Những khách hàng nào muốn được tính phí dựa trên mức sử dụng các tính năng của API có thể sử dụng cấp phép theo lượng sử dụng. Để biết thêm chi tiết, vui lòng tham khảo phần [Câu hỏi thường gặp về cấp phép theo lượng sử dụng](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Cấp phép theo lượng sử dụng**
Dưới đây là các bước đơn giản để sử dụng lớp Metered.

1. Tạo một phiên bản của lớp Metered.
2. Truyền khóa công khai và khóa riêng vào phương thức setMeteredKey.
3. Thực hiện xử lý (thực hiện tác vụ).
4. Gọi phương thức getConsumptionQuantity của lớp Metered.
5. Nó sẽ trả về số lượng/yếu tố các yêu cầu API mà bạn đã sử dụng cho đến nay.

Dưới đây là mã mẫu minh họa cách thiết lập khóa công khai và khóa riêng theo lượng sử dụng:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
