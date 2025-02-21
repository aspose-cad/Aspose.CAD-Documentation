---
title: Cấp phép
type: docs
weight: 40
url: /vi/python-net/getting-started/licensing/
---
## **Gọi setLicense**
Để áp dụng một giấy phép:

Lưu tệp giấy phép vào một thư mục trên ổ đĩa của bạn. Ví dụ C:\Lic\Aspose.CAD.Python.lic.
Gọi phương thức License.set_license(filename) và truyền tên tệp làm đối số. Khi lệnh này được gọi, giấy phép được thiết lập và thông báo đánh giá sẽ không còn xuất hiện trên bề mặt của các hình ảnh.
Đoạn mã sau đây thiết lập giấy phép cho Aspose.CAD cho Python.

{{< highlight java >}}

// Thiết lập giấy phép

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Bạn chỉ cần gọi phương thức set_license() một lần cho mỗi quy trình hoặc ứng dụng.

{{% /alert %}}

## **Thiết lập tham số giấy phép Exporter trong applicationContext.xml**
{{% alert color="primary" %}}
Phương thức này có thể được sử dụng với JasperServer.
{{% /alert %}}
1. Tải giấy phép về máy tính của bạn và sao chép nó vào thư mục \apache-tomcat\webapps\jasperserver\WEB-INF, nơi mà đứng cho thư mục cài đặt JasperServer.
2. Xác định tệp \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml và thêm các dòng sau:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
