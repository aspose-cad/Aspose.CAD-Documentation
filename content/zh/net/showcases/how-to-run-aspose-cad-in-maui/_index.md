---
title: 如何在多平台应用UI(MAUI)中运行Aspose.CAD
type: docs
description: "在多平台应用UI(MAUI)中运行Aspose.CAD。"
weight: 71
url: /zh/net/showcases/how-to-run-aspose-cad-in-maui/
---

## 先决条件
- Visual Studio 2022。
- 示例中使用了.NET 7 SDK。


## MAUI

.NET 多平台应用UI (.NET MAUI) 是一个跨平台框架，用于使用C#和XAML创建本地移动和桌面应用程序。
使用.NET MAUI，您可以从单一共享代码库开发可在Android、iOS、macOS和Windows上运行的应用程序。

.NET MAUI是开源的，是Xamarin.Forms的演变，从移动扩展到桌面场景，UI控件从零重建以提高性能和扩展性。
如果您以前使用Xamarin.Forms构建跨平台用户界面，您会注意到与.NET MAUI有许多相似之处。
然而，也存在一些差异。
使用.NET MAUI，您可以使用单一项目创建多平台应用程序，但如果需要，可以添加特定于平台的源代码和资源。
.NET MAUI的一个关键目标是使您能够尽可能在单一代码库中实现应用程序逻辑和UI布局。


## 安装 MAUI

1. 要创建.NET MAUI应用程序，您需要最新版本的Visual Studio 2022
1. 安装Visual Studio或修改您现有的安装，安装.NET 多平台应用UI开发工作负载及其默认可选安装选项：<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## 创建项目

1. 启动Visual Studio。在启动窗口中，单击创建新项目以创建新项目：<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. 在创建新项目窗口中，在所有项目类型下拉列表中选择MAUI，选择.NET MAUI应用程序模板，然后单击下一步按钮：<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. 在配置新项目窗口中，给您的项目命名，选择合适的位置，然后单击下一步按钮：<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. 在附加信息窗口中，选择您希望目标的.NET版本并单击创建按钮：<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. 等待项目创建并恢复其依赖项
1. 从NuGet安装最新版本的Aspose.CAD：<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. 替换MainPage.xaml中的代码
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
            Text="欢迎使用.NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="可爱的点网机器人向您挥手！"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="你好，世界!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="欢迎使用.NET 多平台应用UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="欢迎使用点网多平台应用UI"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="选择文件"
                SemanticProperties.Hint="计算您点击的次数"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="清除"
                SemanticProperties.Hint="计算您点击的次数"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. 在MainPage.xaml.cs中添加新方法
{{% alert color="primary" %}} 
不要忘记在文件中添加using Aspose.CAD和using Aspose.CAD.ImageOptions。
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
        PickerTitle = "任意"
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


## 调试Windows机器

1. 在Visual Studio工具栏中，使用调试目标下拉列表选择Framework，然后选择net7.0-windows条目：<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. 在Visual Studio工具栏中，按下Windows机器按钮以构建并运行应用程序：<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. 在运行的应用程序中，按"选择文件"按钮几次，观察按钮点击次数的增加：<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. 选择所需文件并点击打开：<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. 处理文件后，转换后文件的图像应出现在屏幕上：<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## 安装Android模拟器

1. 在Visual Studio工具栏中，使用调试目标下拉列表选择Android模拟器，然后选择Android模拟器条目
1. 在Visual Studio工具栏中，按下Android模拟器按钮：<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. 在Android SDK - 许可协议窗口中，按下接受按钮：<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. 在Android SDK - 许可协议窗口中，按下接受按钮：<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. 在用户帐户控制对话框中，按下是按钮：<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. 在许可接受窗口中，按下接受按钮：<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. 在Visual Studio工具栏中，按下Android模拟器按钮：<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. 在用户帐户控制对话框中，按下是按钮：<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. 在新设备窗口中，按下创建按钮：<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. 关闭Android设备管理器窗口


## 使用Android模拟器调试

1. 在Visual Studio工具栏中，按下Pixel 5 - API 33 (Android 13.0 - API 33)按钮以构建和运行应用程序：<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. 在Android模拟器中运行的应用程序中，按"选择文件"按钮几次，观察按钮点击次数的增加：<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. 选择所需文件并点击选择：<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. 处理文件后，转换后文件的图像应出现在屏幕上：<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## 更多示例

有关如何在Docker中使用Aspose.CAD的更多示例，请参阅[示例](https://github.com/aspose-cad/Aspose.CAD-Documentation)。


## 另见。

- [为Visual Studio 2022安装AWS工具包](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [在Windows上安装Docker桌面](https://docs.docker.com/docker-for-windows/install/)
- [在Mac上安装Docker桌面](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022，.NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [切换到Linux容器](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)选项
- 有关 [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) 的其他信息
