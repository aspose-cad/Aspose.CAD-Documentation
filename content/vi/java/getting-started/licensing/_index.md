---
title: Cấp phép
type: docs
weight: 50
url: /vi/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Bạn có thể tải xuống phiên bản đánh giá của **Aspose.CAD** cho Java từ [trang tải xuống của nó](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). Phiên bản đánh giá cung cấp hoàn toàn các khả năng giống như phiên bản có giấy phép của sản phẩm. Hơn nữa, phiên bản đánh giá đơn giản trở thành có giấy phép khi bạn mua một giấy phép và thêm một vài dòng mã để áp dụng giấy phép.

Khi bạn cảm thấy hài lòng với việc đánh giá **Aspose.CAD**, bạn có thể [mua một giấy phép](https://purchase.aspose.com/buy) tại trang web của Aspose. Hãy làm quen với các loại đăng ký khác nhau mà họ cung cấp. Nếu bạn có bất kỳ câu hỏi nào, đừng ngần ngại liên hệ với đội ngũ bán hàng của Aspose.

Mỗi giấy phép Aspose đi kèm với một năm đăng ký miễn phí cho các bản nâng cấp mới hoặc sửa chữa được phát hành trong thời gian này. Hỗ trợ kỹ thuật là miễn phí và không giới hạn và được cung cấp cho cả người dùng có giấy phép và người dùng đánh giá.

{{% /alert %}}

Nếu bạn muốn kiểm tra **Aspose.CAD** mà không có giới hạn của phiên bản đánh giá, hãy yêu cầu một giấy phép tạm thời 30 ngày. Vui lòng tham khảo [Làm thế nào để nhận Giấy phép Tạm thời?](https://purchase.aspose.com/temporary-license) để biết thêm thông tin.

## **Thiết lập Giấy phép**

Giấy phép là một tệp XML văn bản thuần có chứa các chi tiết như tên sản phẩm, số lượng lập trình viên được cấp phép, ngày hết hạn đăng ký, và nhiều hơn nữa. Tệp này đã được ký số, vì vậy hãy không sửa đổi tệp; ngay cả việc thêm một dòng ngắt không cố ý vào tệp cũng sẽ làm cho nó trở nên không hợp lệ.

Bạn cần thiết lập giấy phép trước khi thực hiện bất kỳ thao tác nào với các tệp AutoCAD. Bạn chỉ cần thiết lập giấy phép một lần cho mỗi ứng dụng hoặc quy trình.

Giấy phép có thể được tải lên từ một luồng hoặc tệp ở những vị trí sau:

1. Đường dẫn rõ ràng.
1. Thư mục chứa Aspose.CAD.jar.

Sử dụng phương thức License.setLicense() để cấp phép cho thành phần. Thường thì cách dễ nhất để thiết lập giấy phép là đặt tệp giấy phép trong cùng thư mục với Aspose.CAD.jar và chỉ chỉ định tên tệp mà không có đường dẫn như minh họa trong ví dụ sau:

### **Ví dụ 1**

Trong ví dụ này, **Aspose.CAD** sẽ cố gắng tìm tệp giấy phép trong thư mục chứa các JAR của ứng dụng của bạn.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Ví dụ 2**

Khởi tạo một giấy phép từ một luồng.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Xác thực Giấy phép**

Có thể xác thực xem giấy phép đã được thiết lập đúng cách hay chưa. Lớp License có trường isLicensed sẽ trả về true nếu giấy phép đã được thiết lập đúng cách.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Giấy phép đã được thiết lập!");

}

{{< /highlight >}}
