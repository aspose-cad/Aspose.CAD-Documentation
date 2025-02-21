---
title: Cài đặt Demos
type: docs
weight: 40
url: /vi/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD cho Python bao gồm một số dự án demo để giúp bạn bắt đầu.

Các demo được cung cấp với Aspose.CAD cho Python là các demo Python tiêu chuẩn đã được chỉnh sửa để trình bày cách sử dụng các xuất khẩu mới.

{{% /alert %}}

Để chạy các demo Aspose.CAD cho Python, hãy thực hiện các bước sau:

1. Tải xuống Python (ví dụ https://sourceforge.net/projects/python-net/files/archive/). Hãy chắc chắn tải xuống toàn bộ dự án đã lưu trữ cùng với mã nguồn và demo, không chỉ một JAR đơn lẻ.
1. Giải nén dự án đã lưu trữ vào một vị trí trên ổ đĩa cứng của bạn, ví dụ C:\.
1. Sao chép tất cả các thư mục demo từ thư mục \samples của **aspose-cad-xx.x.zip** vào **\InstallDir\demo\samples**, nơi "\InstallDir" là vị trí mà bạn đã giải nén Python. Bước này là cần thiết vì các tập lệnh xây dựng demo phụ thuộc vào cấu trúc thư mục của Python, nếu không bạn sẽ cần phải chỉnh sửa các tập lệnh xây dựng.
1. Sao chép **aspose-cad-pythons-xx.x.jar** từ thư mục \lib của **aspose-cad-pythons-xx.x.zip** vào **\InstallDir\lib**.
1. Chuẩn bị Công cụ Xây dựng Ant và Trình Quản Lý Phụ Thuộc Ivy, xem **\InstallDir\readme.txt**.
1. Chỉnh sửa **build.xml** tại **\InstallDir\demo\samples**, thêm aspose-cad-pythons-xx.x.jar vào classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Thay đổi thư mục hiện tại thành **\InstallDir\demo\hsqldb** và chạy dòng lệnh sau:
   **ant runServer**
1. Thay đổi thư mục hiện tại thành một trong các demo Aspose.CAD cho Python, ví dụ **\InstallDir\demo\samples\charts.ai** và chạy các lệnh sau trong dòng lệnh:
   **ant test** - để tạo ra các tệp báo cáo.
1. Mở một trong các tài liệu kết quả để xem, ví dụ **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
