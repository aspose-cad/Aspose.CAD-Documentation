---
title: Cấp phép theo lượng sử dụng
type: docs
weight: 40
url: /vi/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD cho phép các nhà phát triển áp dụng khóa theo lượng sử dụng. Đây là một cơ chế cấp phép mới. Cơ chế cấp phép mới sẽ được sử dụng cùng với phương pháp cấp phép hiện có. Những khách hàng muốn được tính phí dựa trên mức sử dụng các tính năng của API có thể sử dụng cấp phép theo lượng sử dụng. Để biết thêm chi tiết, vui lòng tham khảo phần [Câu hỏi thường gặp về Cấp phép theo lượng sử dụng](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Cấp phép theo lượng sử dụng**
Dưới đây là các bước đơn giản để sử dụng lớp Metered.

1. Tạo một thể hiện của lớp Metered.
1. Truyền khóa công khai & khóa riêng tư cho phương thức SetMeteredKey.
1. Thực hiện xử lý (thực hiện tác vụ).
1. Gọi phương thức GetConsumptionQuantity của lớp Metered.
1. Nó sẽ trả về số lượng yêu cầu API mà bạn đã tiêu thụ cho đến nay.

Dưới đây là đoạn mã mẫu minh họa cách thiết lập khóa công khai và khóa riêng tư theo lượng sử dụng.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
