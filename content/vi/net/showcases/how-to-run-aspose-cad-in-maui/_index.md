---
title: Cách chạy Aspose.CAD trong Multi-platform App UI (MAUI)
type: docs
description: "Chạy Aspose.CAD trong Multi-platform App UI (MAUI)."
weight: 71
url: /vi/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Điều kiện tiên quyết
- Visual Studio 2022.
- SDK NET 7 được sử dụng trong ví dụ này.

## MAUI

.NET Multi-platform App UI (.NET MAUI) là một khung đa nền tảng để tạo ra các ứng dụng di động và máy tính để bàn gốc với C# và XAML.
Sử dụng .NET MAUI, bạn có thể phát triển các ứng dụng có thể chạy trên Android, iOS, macOS và Windows từ một mã nguồn chia sẻ duy nhất.

.NET MAUI là mã nguồn mở và là sự phát triển của Xamarin.Forms, mở rộng từ các kịch bản di động đến máy tính để bàn, với các điều khiển UI được xây dựng lại từ đầu cho hiệu suất và khả năng mở rộng.
Nếu bạn đã từng sử dụng Xamarin.Forms để xây dựng giao diện người dùng đa nền tảng, bạn sẽ nhận thấy nhiều điểm tương đồng với .NET MAUI.
Tuy nhiên, vẫn có một số khác biệt.
Sử dụng .NET MAUI, bạn có thể tạo ứng dụng đa nền tảng bằng một dự án duy nhất, nhưng bạn có thể thêm mã nguồn và tài nguyên cụ thể cho từng nền tảng nếu cần thiết.
Một trong những mục tiêu chính của .NET MAUI là cho phép bạn triển khai càng nhiều logic ứng dụng và bố cục UI càng tốt trong một mã nguồn duy nhất.

## Cài đặt MAUI

1. Để tạo ứng dụng .NET MAUI, bạn sẽ cần phiên bản mới nhất của Visual Studio 2022
1. Hoặc cài đặt Visual Studio, hoặc sửa đổi cài đặt hiện tại của bạn, và cài đặt gói phát triển .NET Multi-platform App UI với các tùy chọn cài đặt tùy chọn mặc định của nó:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)

## Tạo dự án

1. Mở Visual Studio. Trong cửa sổ khởi động, nhấp vào Tạo một dự án mới để tạo một dự án mới:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. Trong cửa sổ Tạo một dự án mới, chọn MAUI trong danh sách tất cả các loại dự án, chọn mẫu .NET MAUI App, và nhấn nút Tiếp theo:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. Trong cửa sổ Cấu hình dự án mới của bạn, đặt tên cho dự án, chọn một vị trí phù hợp cho nó, và nhấn nút Tiếp theo:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. Trong cửa sổ Thông tin bổ sung, chọn phiên bản .NET mà bạn muốn nhắm đến và nhấn nút Tạo:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Chờ cho dự án được tạo và các phụ thuộc được khôi phục
1. Cài đặt phiên bản mới nhất của Aspose.CAD từ NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Thay thế mã trong MainPage.xaml
{{< highlight plain >}}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MauiApp1.MainPage">

    <ScrollView>
        <VerticalStackLayout
            Spacing="25"
            Padding="30,0"
            VerticalOptions="Center">

             <Label 
            Text="Chào mừng đến với .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Con bot dot net dễ thương đang vẫy tay chào bạn!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Xin chào, Thế giới!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Chào mừng đến với .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Chào mừng đến với dot net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Chọn tệp"
                SemanticProperties.Hint="Đếm số lần bạn nhấp"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Xóa"
                SemanticProperties.Hint="Đếm số lần bạn nhấp"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Thêm các phương thức mới trong MainPage.xaml.cs
{{% alert color="primary" %}} 
Đừng quên thêm using Aspose.CAD và using Aspose.CAD.ImageOptions trong file.
{{% /alert %}}
{{< highlight plain >}}
private void OnCleanClicked(object sender, EventArgs e)
{
    Base64DecodedImage.Source = "dotnet_bot.png";
}
private async void OnSelectFileClicked(object sender, EventArgs e)
{
    var result = await FilePicker.PickAsync(new PickOptions()
    {
        PickerTitle = "bất kỳ"
    });
    if (result == null)
    {
        return;
    }
    var stream = await result.OpenReadAsync();
    var img = Aspose.CAD.Image.Load(stream);
    var ms = new MemoryStream();
    await img.SaveAsync(ms, new PngOptions());
    Base64DecodedImage.Source = ImageSource.FromStream(() => ms);
}
{{< /highlight >}}

## Gỡ lỗi trên máy Windows

1. Trong thanh công cụ Visual Studio, sử dụng danh sách thả xuống Mục tiêu gỡ lỗi để chọn Framework và sau đó chọn mục net7.0-windows:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. Trong thanh công cụ Visual Studio, nhấn nút Máy Windows để xây dựng và chạy ứng dụng:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. Trong ứng dụng đang chạy, nhấn nút "Chọn tệp" nhiều lần và quan sát rằng số lần nhấp vào nút được tăng lên:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Chọn tệp cần thiết và nhấn mở:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. Sau khi xử lý tệp, một hình ảnh của tệp đã chuyển đổi sẽ xuất hiện trên màn hình:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)

## Cài đặt trình giả lập Android

1. Trong thanh công cụ Visual Studio, sử dụng danh sách thả xuống Mục tiêu gỡ lỗi để chọn Trình giả lập Android và sau đó chọn mục Trình giả lập Android
1. Trong thanh công cụ Visual Studio, nhấn nút Trình giả lập Android:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Trong cửa sổ Thỏa thuận cấp phép SDK Android, nhấn nút Chấp nhận:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. Trong cửa sổ Thỏa thuận cấp phép SDK Android, nhấn nút Chấp nhận:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. Trong hộp thoại Kiểm soát tài khoản người dùng, nhấn nút Có:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. Trong cửa sổ Chấp nhận giấy phép, nhấn nút Chấp nhận:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. Trong thanh công cụ Visual Studio, nhấn nút Trình giả lập Android:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Trong hộp thoại Kiểm soát tài khoản người dùng, nhấn nút Có:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. Trong cửa sổ Thiết bị mới, nhấn nút Tạo:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Đóng cửa sổ Trình quản lý thiết bị Android

## Gỡ lỗi bằng Trình giả lập Android

1. Trong thanh công cụ Visual Studio, nhấn nút Pixel 5 - API 33 (Android 13.0 - API 33) để xây dựng và chạy ứng dụng:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. Trong ứng dụng đang chạy trên trình giả lập Android, nhấn nút "Chọn tệp" nhiều lần và quan sát rằng số lần nhấp vào nút được tăng lên:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Chọn tệp cần thiết và nhấn chọn:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. Sau khi xử lý tệp, một hình ảnh của tệp đã chuyển đổi sẽ xuất hiện trên màn hình:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)

## Thêm ví dụ

Để biết thêm mẫu về cách bạn có thể sử dụng Aspose.CAD trong Docker, hãy xem [ví dụ](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Xem thêm.

- [Cài đặt AWS Toolkit cho Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Cài đặt Docker Desktop trên Windows](https://docs.docker.com/docker-for-windows/install/)
- [Cài đặt Docker Desktop trên Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Chuyển sang các container Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) tùy chọn
- Thông tin bổ sung về [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
