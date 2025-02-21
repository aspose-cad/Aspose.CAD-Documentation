---
title: Cài đặt Demos
type: docs
weight: 40
url: /vi/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD cho JasperReports bao gồm một số dự án demo để giúp bạn bắt đầu.

Các demo được cung cấp với Aspose.CAD cho JasperReports là các demo tiêu chuẩn của JasperReports đã được chỉnh sửa để thể hiện việc sử dụng các trình xuất mới.

{{% /alert %}}

Để chạy các demo của Aspose.CAD cho JasperReports, thực hiện các bước sau:

1. Tải xuống JasperReports (ví dụ https://sourceforge.net/projects/jasperreports/files/archive/). Hãy chắc chắn tải xuống toàn bộ dự án lưu trữ với mã nguồn và demo, không chỉ một JAR đơn lẻ.
1. Giải nén dự án đã lưu trữ đến một vị trí nào đó trên ổ cứng của bạn, ví dụ C:\.
1. Sao chép tất cả các thư mục demo từ thư mục \samples của **aspose-cad-xx.x.zip** vào **\InstallDir\demo\samples**, trong đó "\InstallDir" là vị trí bạn đã giải nén JasperReports. Bước này là cần thiết vì các kịch bản xây dựng demo phụ thuộc vào cấu trúc thư mục của JasperReports, nếu không bạn sẽ cần phải sửa đổi các kịch bản xây dựng.
1. Sao chép **aspose-cad-jasperreports-xx.x.jar** từ thư mục \lib của **aspose-cad-jasperreports-xx.x.zip** vào **\InstallDir\lib**.
1. Chuẩn bị Công cụ Xây dựng Ant và Trình quản lý Phụ thuộc Ivy, xem **\InstallDir\readme.txt**.
1. Sửa đổi **build.xml** tại **\InstallDir\demo\samples**, thêm aspose-cad-jasperreports-xx.x.jar vào classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Chuyển thư mục hiện tại đến **\InstallDir\demo\hsqldb** và chạy lệnh sau trong dòng lệnh:
   **Ant runServer**
1. Chuyển thư mục hiện tại đến một trong các demo của Aspose.CAD cho JasperReports, ví dụ **\InstallDir\demo\samples\charts.ai** và chạy các lệnh sau trong dòng lệnh:
   **ant test** - để tạo các tệp báo cáo.
1. Mở một trong các tài liệu kết quả để xem, ví dụ **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
