---
title: Cấp giấy phép
type: docs
weight: 50
url: /vi/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Khi bạn hài lòng với việc đánh giá Aspose.CAD cho .NET, hãy mua một giấy phép tại trang web Aspose: [Cổng mua sắm](https://purchase.aspose.com/buy). Hãy làm quen với các loại giấy phép khác nhau có sẵn. Nếu bạn có bất kỳ câu hỏi nào, [liên hệ với đội ngũ bán hàng của Aspose](https://about.aspose.com/contact) và họ sẽ sẵn sàng giúp bạn.

Mỗi giấy phép Aspose đều đi kèm với một năm đăng ký để nâng cấp miễn phí cho bất kỳ phiên bản mới nào hoặc các bản sửa lỗi phát hành trong thời gian này. Chúng tôi cung cấp hỗ trợ kỹ thuật miễn phí và không giới hạn cho cả người dùng có giấy phép và người dùng thử nghiệm.

Giấy phép là một tệp XML văn bản thuần túy chứa các chi tiết như tên sản phẩm, số lượng nhà phát triển có giấy phép, ngày hết hạn đăng ký, và v.v. Tệp này được ký điện tử, do đó đừng chỉnh sửa tệp: ngay cả việc thêm một dòng trống vào tệp cũng sẽ làm vô hiệu hóa nó.

{{% /alert %}}

## **Khi nào nên áp dụng giấy phép**

Hãy làm theo những quy tắc đơn giản này:

- Giấy phép chỉ cần được thiết lập một lần cho mỗi miền ứng dụng.
- Bạn cần thiết lập giấy phép trước khi sử dụng bất kỳ lớp Aspose.CAD nào khác.
- Việc gọi SetLicense nhiều lần là không gây hại, nhưng lãng phí thời gian xử lý.
- Nếu bạn đang phát triển một ứng dụng Windows Forms hoặc console, hãy gọi SetLicense trong mã khởi động, trước khi sử dụng các lớp Aspose.CAD.
- Khi phát triển một ứng dụng ASP.NET, hãy gọi SetLicense từ tệp Global.asax.cs (Global.asax.vb), trong phương thức Protected Application_Start. Nó được gọi một lần khi ứng dụng khởi động.
- Không gọi SetLicense từ bên trong các phương thức Page_Load vì điều này có nghĩa là giấy phép sẽ được nạp mỗi lần một trang web được tải.
- Nếu bạn đang phát triển một thư viện lớp, hãy gọi SetLicense từ một nhà xây dựng tĩnh của lớp sử dụng Aspose.CAD. Nhà xây dựng tĩnh sẽ được thực thi trước khi một thể hiện của lớp của bạn được tạo ra, đảm bảo giấy phép Aspose.CAD được thiết lập đúng cách.

## **Áp dụng giấy phép bằng cách sử dụng tệp hoặc đối tượng luồng**

Sử dụng phương thức **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** để cấp giấy phép cho thành phần. Cách đơn giản nhất để thiết lập giấy phép là đặt tệp giấy phép trong cùng một thư mục với Aspose.CAD.dll và chỉ định tên tệp, không có đường dẫn, như được hiển thị bên dưới.

### **Tải giấy phép từ tệp**

Mã mẫu này khởi tạo một giấy phép được lưu trữ trong một tệp hoặc trong một tài nguyên nhúng.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Tải giấy phép từ đối tượng luồng**

Mã mẫu này khởi tạo giấy phép từ luồng.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
