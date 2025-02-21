---
title: Cách Chạy Các Ví Dụ
type: docs
weight: 70
url: /vi/net/showcases/how-to-run-the-examples/
---

## **Yêu Cầu Phần Mềm**

Vui lòng đảm bảo rằng bạn đáp ứng các yêu cầu sau trước khi tải xuống và chạy các ví dụ.

1. Visual Studio 2010 trở lên
1. NuGet Package Manager đã được cài đặt trong Visual Studio. Đảm bảo rằng phiên bản API NuGet mới nhất được cài đặt trong Visual Studio. Để biết chi tiết về cách cài đặt trình quản lý gói NuGet, vui lòng kiểm tra https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Đi tới Tools->Options->NuGet Package Manager->Package Sources và đảm bảo rằng tùy chọn **nuget.org** đã được chọn
1. Dự án ví dụ sử dụng tính năng NuGet Automatic Package Restore, vì vậy bạn nên có kết nối internet hoạt động. Nếu bạn không có kết nối internet hoạt động trên máy mà các ví dụ sẽ được thực hiện, vui lòng kiểm tra [Cài Đặt](/vi/cad/net/installation/) để thêm tham chiếu đến Aspose.CAD.dll trong dự án ví dụ.

## **Tải Về Từ GitHub**

Tất cả các ví dụ của Aspose.CAD cho .NET đều được lưu trữ trên [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Bạn có thể sao chép kho lưu trữ bằng cách sử dụng ứng dụng GitHub yêu thích của mình hoặc tải tệp ZIP từ [đây](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Giải nén nội dung của tệp ZIP vào bất kỳ thư mục nào trên máy tính của bạn. Tất cả các ví dụ đều nằm trong thư mục **Examples**.
- Có một tệp giải pháp Visual Studio cho C#.
- Các dự án được tạo trong Visual Studio 2013, nhưng các tệp giải pháp tương thích với Visual Studio 2010 SP1 và cao hơn.
- Mở tệp giải pháp trong Visual Studio và xây dựng dự án.
- Ở lần chạy đầu tiên, các phụ thuộc sẽ tự động được tải xuống qua NuGet.
- Thư mục **Data** ở thư mục gốc của **Examples** chứa các tệp đầu vào mà các ví dụ CSharp sử dụng. Bạn phải tải xuống thư mục **Data** cùng với dự án ví dụ.
- Mở tệp RunExamples.cs, tất cả các ví dụ được gọi từ đây.
- Bỏ dấu comment các ví dụ bạn muốn chạy trong dự án.

Vui lòng thoải mái liên hệ với chúng tôi qua Diễn Đàn nếu bạn gặp bất kỳ vấn đề nào trong việc thiết lập hoặc chạy các ví dụ.

## **Đóng Góp**

Nếu bạn muốn thêm hoặc cải thiện một ví dụ, chúng tôi khuyến khích bạn đóng góp cho dự án. Tất cả các ví dụ và dự án trình bày trong kho lưu trữ này đều mã nguồn mở và có thể được sử dụng miễn phí trong ứng dụng của riêng bạn.

Để đóng góp, bạn có thể phân nhánh kho lưu trữ, chỉnh sửa mã nguồn và tạo một yêu cầu kéo. Chúng tôi sẽ xem xét các thay đổi và bao gồm nó trong kho lưu trữ nếu thấy hữu ích.
