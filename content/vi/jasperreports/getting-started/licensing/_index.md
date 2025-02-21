---
title: Cấp phép
type: docs
weight: 40
url: /vi/jasperreports/getting-started/licensing/
---
## **Gọi setLicense**
Để áp dụng giấy phép:

Lưu tệp giấy phép vào một thư mục trên ổ đĩa của bạn. Ví dụ C:\Lic\Aspose.CAD.JasperReport.lic.
Gọi phương thức License.setLicense(filename) và truyền tên tệp làm tham số. Khi câu lệnh này được gọi, giấy phép sẽ được thiết lập và thông điệp đánh giá sẽ không xuất hiện trên các hình ảnh nữa.
Đoạn mã sau thiết lập giấy phép cho Aspose.CAD cho JasperReports.

{{< highlight java >}}

// Thiết lập giấy phép

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Bạn chỉ cần gọi phương thức setLicense() một lần cho mỗi quy trình hoặc ứng dụng.

{{% /alert %}}

## **Thiết lập tham số Giấy phép Xuất khẩu trong applicationContext.xml**
{{% alert color="primary" %}}
Phương pháp này có thể được áp dụng với JasperServer.
{{% /alert %}}
1. Tải giấy phép về máy tính của bạn và sao chép nó vào thư mục \apache-tomcat\webapps\jasperserver\WEB-INF, nơi đứng cho thư mục cài đặt JasperServer.
2. Tìm tệp \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml và thêm các dòng sau:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
