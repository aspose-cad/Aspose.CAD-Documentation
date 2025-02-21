---
title: Cài đặt
type: docs
weight: 30
url: /vi/net/getting-started/installation/
---

## **Cài đặt Aspose.CAD cho .NET thông qua NuGet**

NuGet là cách dễ nhất để tải về và cài đặt các API Aspose cho .NET. Mở Microsoft Visual Studio và trình quản lý gói NuGet. Tìm kiếm "aspose" để tìm API Aspose mong muốn. Nhấp vào "Cài đặt", API đã chọn sẽ được tải về và tham chiếu trong dự án của bạn.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **Tham chiếu Aspose.CAD từ một Dự án .NET**

Thực hiện các bước sau (giả sử bạn sử dụng Microsoft Visual Studio):

1. Trong **Trình quản lý giải pháp**, mở rộng nút dự án mà bạn muốn thêm tham chiếu.
1. Nhấp chuột phải vào nút **Tham chiếu** cho dự án và chọn **Thêm tham chiếu** từ menu ngữ cảnh.
1. Trong hộp thoại **Thêm tham chiếu** và duyệt đến vị trí tệp DLL.
1. Chọn tệp DLL *Aspose.CAD* và nhấp vào nút **OK**.
1. Tham chiếu *Aspose.CAD* sẽ xuất hiện dưới nút **Tham chiếu** của dự án của bạn.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **Cài đặt hoặc Cập nhật Aspose.CAD sử dụng bảng điều khiển Quản lý Gói**

Bạn có thể thực hiện các bước dưới đây để tham chiếu API [Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) thông qua bảng điều khiển quản lý gói:

1. Mở giải pháp/dự án của bạn trong Visual Studio.
1. Chọn Công cụ -> Trình quản lý gói thư viện -> Bảng điều khiển quản lý gói từ menu để mở bảng điều khiển quản lý gói.

![todo:image_alt_text](/_assets/install/installation_3.png)

Gõ lệnh “**Install-Package Aspose.CAD**” và nhấn enter để cài đặt bản phát hành đầy đủ mới nhất vào ứng dụng của bạn. Ngoài ra, bạn có thể thêm hậu tố "**-prerelease**" vào lệnh để chỉ định rằng bản phát hành mới nhất bao gồm các bản sửa lỗi cũng sẽ được cài đặt.

![todo:image_alt_text](/_assets/install/installation_4.png)

Bạn sẽ thấy thông báo "Đang tải Aspose.CAD..." xuất hiện ở góc dưới bên trái của cửa sổ cho biết rằng quá trình tải xuống đang diễn ra.

![todo:image_alt_text](/_assets/install/installation_5.png)

Khi tải xuống hoàn tất, bạn sẽ thấy các thông báo xác nhận sau. Nếu bạn không quen thuộc với [EULA của Aspose](https://about.aspose.com/legal/eula) thì sẽ là một ý tưởng hay khi đọc giấy phép được tham chiếu tại URL.

![todo:image_alt_text](/_assets/install/installation_6.png)

Bây giờ bạn nên tìm thấy rằng Aspose.CAD đã được thêm và tham chiếu thành công vào ứng dụng của bạn.

![todo:image_alt_text](/_assets/install/installation_7.png)

Trong bảng điều khiển quản lý gói, bạn cũng có thể sử dụng lệnh “**Update-Package Aspose.CAD**” và nhấn enter để kiểm tra bất kỳ cập nhật nào cho gói Aspose.CAD và cài đặt nếu có. Bạn cũng có thể thêm hậu tố "-prerelease" để cập nhật bản phát hành mới nhất.

## **Những điều cần cân nhắc khi chạy trên môi trường máy chủ chia sẻ**

Tất cả các thành phần Aspose .NET được khuyến nghị chạy với cài đặt quyền Full Trust. Điều này là vì thành phần Aspose .NET đôi khi cần truy cập cài đặt và tệp đăng ký nằm ở những nơi khác ngoài thư mục ảo, ví dụ: để đọc phông chữ, v.v. Hơn nữa, các thành phần Aspose.NET dựa trên các lớp hệ thống .NET cơ bản, một số trong số đó cũng yêu cầu quyền Full Trust để chạy trong một số trường hợp.

Các nhà cung cấp dịch vụ Internet cho phép nhiều ứng dụng từ các công ty khác nhau thường thực thi mức độ bảo mật Medium Trust. Trong trường hợp .NET 2.0, mức độ bảo mật như vậy có thể đặt ra các ràng buộc sau có thể ảnh hưởng đến khả năng của Aspose.CAD hoạt động đúng cách.

- **RegistryPermission** không khả dụng. Điều này có nghĩa là bạn không thể truy cập vào đăng ký, điều này là cần thiết để liệt kê các phông chữ đã cài đặt khi hiển thị tài liệu.
- **FileIOPermission** bị hạn chế. Điều này có nghĩa là bạn chỉ có thể truy cập các tệp trong hạng mục thư mục ảo của ứng dụng của bạn. Điều này có thể có nghĩa là phông chữ không thể được đọc trong quá trình xuất.

Vì những lý do đã nêu ở trên, khuyến nghị rằng Aspose.CAD được chạy trên quyền Full Trust. Bạn có thể thấy rằng một số tính năng của thư viện sẽ hoạt động khi thực hiện các tác vụ khác nhau trong Medium Trust trong khi một số sẽ không (như hiển thị) có thể do các lệnh gọi đến xử lý hình ảnh GDI+.

## **Yêu cầu hệ thống**

### **Hệ điều hành**

Aspose.CAD cho .NET hỗ trợ bất kỳ hệ điều hành 32-bit hoặc 64-bit nào mà .NET hoặc Mono framework được cài đặt, bao gồm, nhưng không giới hạn ở:

- Hệ điều hành máy tính để bàn Microsoft Windows (XP, Vista, 7, 8, 10) và hệ điều hành máy chủ (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS và những cái khác)
- Mac OS X

### **Các framework**

Aspose.CAD cho .NET hỗ trợ:

- Các phiên bản .NET Framework từ 2.0 đến 4.5 bao gồm cả các phiên bản Client Profile
- .NET Core
- Mono 2.6.7 trở lên

### **Môi trường phát triển**

Bạn có thể sử dụng Aspose.CAD cho .NET để phát triển ứng dụng trong bất kỳ môi trường phát triển nào nhắm đến nền tảng .NET, nhưng những môi trường sau đây được hỗ trợ một cách rõ ràng:

- Microsoft Visual Studio 2010 hoặc cao hơn
- MonoDevelop 2.4 và cao hơn
