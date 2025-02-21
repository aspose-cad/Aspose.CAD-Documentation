---
title: Cấp phép theo mức sử dụng
type: docs
weight: 60
url: /vi/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD cho phép các nhà phát triển áp dụng khóa cấp phép theo mức sử dụng. Đây là một cơ chế cấp phép mới. Cơ chế cấp phép mới sẽ được sử dụng cùng với phương pháp cấp phép hiện tại. Những khách hàng nào muốn được tính phí dựa trên mức sử dụng các tính năng của API có thể sử dụng cấp phép theo mức sử dụng. Để biết thêm chi tiết, vui lòng tham khảo phần [Câu hỏi thường gặp về Cấp phép theo mức sử dụng](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Cấp phép theo mức sử dụng**
Dưới đây là các bước đơn giản để sử dụng lớp Metered.

1. Tạo một thể hiện của lớp Metered.
1. Truyền khóa công khai & khóa riêng tư vào phương thức SetMeteredKey.
1. Thực hiện xử lý (thực hiện công việc).
1. Gọi phương thức GetConsumptionQuantity của lớp Metered.
1. Nó sẽ trả về số lượng yêu cầu API mà bạn đã tiêu thụ đến thời điểm hiện tại.

Theo đây là mã mẫu minh họa cách đặt khóa công khai và riêng tư theo mức sử dụng.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
