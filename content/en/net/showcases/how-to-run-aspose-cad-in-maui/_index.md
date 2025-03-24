---
title: How to Run Aspose.CAD in Multi-platform App UI(MAUI)
type: docs
description: "Run Aspose.CAD in a Multi-platform App UI(MAUI)."
weight: 71
url: /net/showcases/how-to-run-aspose-cad-in-maui/
---

## Prerequisites
- Visual Studio 2022.
- NET 7 SDK is used in the example.


## MAUI

.NET Multi-platform App UI (.NET MAUI) is a cross-platform framework for creating native mobile and desktop apps with C# and XAML.
Using .NET MAUI, you can develop apps that can run on Android, iOS, macOS, and Windows from a single shared code-base.

.NET MAUI is open-source and is the evolution of Xamarin.Forms, extended from mobile to desktop scenarios, with UI controls rebuilt from the ground up for performance and extensibility.
If you've previously used Xamarin.Forms to build cross-platform user interfaces, you'll notice many similarities with .NET MAUI.
However, there are also some differences.
Using .NET MAUI, you can create multi-platform apps using a single project, but you can add platform-specific source code and resources if necessary.
One of the key aims of .NET MAUI is to enable you to implement as much of your app logic and UI layout as possible in a single code-base.


## Installation MAUI

1. To create .NET MAUI apps, you'll need the latest version of Visual Studio 2022
1. Either install Visual Studio, or modify your existing installation, and install the .NET Multi-platform App UI development workload with its default optional installation options:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## Create project

1. Launch Visual Studio. In the start window, click Create a new project to create a new project:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. In the Create a new project window, select MAUI in the All project types drop-down, select the .NET MAUI App template, and click the Next button:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. In the Configure your new project window, name your project, choose a suitable location for it, and click the Next button:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. In the Additional information window, choose the version of .NET that you'd like to target and click the Create button:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Wait for the project to be created and its dependencies to be restored
1. Install the latest Aspose.CAD version from NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Replace the code in MainPage.xaml
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
            Text="Welcome to .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Cute dot net bot waving hi to you!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Hello, World!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Welcome to .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Welcome to dot net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Select file"
                SemanticProperties.Hint="Counts the number of times you click"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Clear"
                SemanticProperties.Hint="Counts the number of times you click"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Add new methods in MainPage.xaml.cs
{{% alert color="primary" %}} 
Don't forget add using Aspose.CAD and using Aspose.CAD.ImageOptions in file.
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
        PickerTitle = "any"
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


## Debug Windows Machine

1. In the Visual Studio toolbar, use the Debug Target drop-down to select Framework and then the net7.0-windows entry:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. In the Visual Studio toolbar, press the Windows Machine button to build and run the app:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. In the running app, press the "Select file" button several times and observe that the count of the number of button clicks is incremented:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Select the required file and click open:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. After processing the file, an image of the converted file should appear on the screen:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## Install Android Emulator

1. In the Visual Studio toolbar, use the Debug Target drop-down to select Android Emulators and then the Android Emulator entry
1. In the Visual Studio toolbar, press the Android Emulator button:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. In the Android SDK - License Agreement window, press the Accept button:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. In the Android SDK - License Agreement window, press the Accept button:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. In the User Account Control dialog, press the Yes button:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. In the License Acceptance window, press the Accept button:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. In the Visual Studio toolbar, press the Android Emulator button:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. In the User Account Control dialog, press the Yes button:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. In the New Device window, press the Create button:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Close the Android Device Manager window


## Debug with Android Emulator

1. In the Visual Studio toolbar, press the Pixel 5 - API 33 (Android 13.0 - API 33) button to build and run the app:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. In the running app in the Android emulator, press the "Select file" button several times and observe that the count of the number of button clicks is incremented:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Select the required file and click select:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. After processing the file, an image of the converted file should appear on the screen:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## More Examples

For more samples of how you can use Aspose.CAD in Docker, see the [examples](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## See Also.

- [Install AWS Toolkit for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Install Docker Desktop on Windows](https://docs.docker.com/docker-for-windows/install/)
- [Install Docker Desktop on Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option
- Additional information on [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)