---
title: Aspose.CAD를 멀티 플랫폼 앱 UI(MAUI)에서 실행하는 방법
type: docs
description: "멀티 플랫폼 앱 UI(MAUI)에서 Aspose.CAD를 실행합니다."
weight: 71
url: /ko/net/showcases/how-to-run-aspose-cad-in-maui/
---

## 필수 조건
- Visual Studio 2022.
- 예제에서는 .NET 7 SDK가 사용됩니다.


## MAUI

.NET 멀티 플랫폼 앱 UI(.NET MAUI)는 C#과 XAML을 사용하여 네이티브 모바일 및 데스크탑 앱을 만들기 위한 크로스 플랫폼 프레임워크입니다.
.NET MAUI를 사용하면 단일 공유 코드 기반에서 Android, iOS, macOS 및 Windows에서 실행할 수 있는 앱을 개발할 수 있습니다.

.NET MAUI는 오픈 소스이며 Xamarin.Forms의 발전으로, 모바일에서 데스크탑 시나리오로 확장되었으며, 성능과 확장성을 위해 UI 컨트롤이 처음부터 다시 구축되었습니다.
이전에 Xamarin.Forms를 사용하여 크로스 플랫폼 사용자 인터페이스를 구축한 경우 .NET MAUI와의 많은 유사점을 발견할 수 있습니다.
그러나 몇 가지 차이점도 있습니다.
.NET MAUI를 사용하면 단일 프로젝트를 사용하여 멀티 플랫폼 앱을 만들 수 있지만 필요에 따라 플랫폼별 소스 코드와 리소스를 추가할 수 있습니다.
.NET MAUI의 주요 목표 중 하나는 가능한 한 많은 앱 로직과 UI 레이아웃을 단일 코드 기반으로 구현할 수 있도록 하는 것입니다.


## MAUI 설치

1. .NET MAUI 앱을 생성하려면 최신 버전의 Visual Studio 2022가 필요합니다.
1. Visual Studio를 설치하거나 기존 설치를 수정하고, 기본 선택 설치 옵션으로 .NET 멀티 플랫폼 앱 UI 개발 워크로드를 설치합니다:<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## 프로젝트 생성

1. Visual Studio를 실행합니다. 시작 창에서 새 프로젝트 만들기를 클릭하여 새 프로젝트를 생성합니다:<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. 새 프로젝트 만들기 창에서 모든 프로젝트 유형 드롭다운에서 MAUI를 선택하고, .NET MAUI 앱 템플릿을 선택한 후 다음 버튼을 클릭합니다:<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. 새 프로젝트 구성 창에서 프로젝트 이름을 지정하고 알맞은 위치를 선택한 다음 다음 버튼을 클릭합니다:<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. 추가 정보 창에서 대상으로 삼을 .NET 버전을 선택하고 생성 버튼을 클릭합니다:<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. 프로젝트가 생성되고 의존성이 복원될 때까지 기다립니다.
1. NuGet에서 Aspose.CAD의 최신 버전을 설치합니다:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. MainPage.xaml의 코드를 교체합니다
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
            Text="환영합니다 .NET MAUI에!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="귀여운 닷넷 봇이 여러분에게 손을 흔들고 있습니다!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="안녕하세요, 세상!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text=".NET 멀티 플랫폼 앱 UI에 오신 것을 환영합니다"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="닷넷 멀티 플랫폼 앱 UI에 오신 것을 환영합니다"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="파일 선택"
                SemanticProperties.Hint="클릭한 횟수를 셉니다"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="지우기"
                SemanticProperties.Hint="클릭한 횟수를 셉니다"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. MainPage.xaml.cs에 새 메서드 추가
{{% alert color="primary" %}} 
Aspose.CAD 및 Aspose.CAD.ImageOptions를 파일에 추가하는 것을 잊지 마세요.
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
        PickerTitle = "파일 선택"
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


## Windows 머신에서 디버깅

1. Visual Studio 도구 모음에서 디버그 대상을 사용하여 Framework를 선택한 후 net7.0-windows 항목을 선택합니다:<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. Visual Studio 도구 모음에서 Windows 머신 버튼을 눌러 앱을 빌드하고 실행합니다:<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. 실행 중인 앱에서 "파일 선택" 버튼을 여러 번 누르고 클릭 횟수가 증가하는지 확인합니다:<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. 필요한 파일을 선택하고 열기를 클릭합니다:<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. 파일 처리가 완료된 후 변환된 파일의 이미지가 화면에 나타납니다:<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Android 에뮬레이터 설치

1. Visual Studio 도구 모음에서 디버그 대상을 사용하여 Android Emulators를 선택하고 Android Emulator 항목을 선택합니다.
1. Visual Studio 도구 모음에서 Android Emulator 버튼을 누릅니다:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Android SDK - 라이센스 동의 창에서 수락 버튼을 누릅니다:<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Android SDK - 라이센스 동의 창에서 수락 버튼을 누릅니다:<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. 사용자 계정 컨트롤 대화상자에서 예 버튼을 누릅니다:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. 라이센스 수락 창에서 수락 버튼을 누릅니다:<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. Visual Studio 도구 모음에서 Android Emulator 버튼을 누릅니다:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. 사용자 계정 컨트롤 대화상자에서 예 버튼을 누릅니다:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. 새 장치 창에서 만들기 버튼을 누릅니다:<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Android Device Manager 창을 닫습니다.


## Android 에뮬레이터로 디버깅

1. Visual Studio 도구 모음에서 Pixel 5 - API 33 (Android 13.0 - API 33) 버튼을 눌러 앱을 빌드하고 실행합니다:<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. Android 에뮬레이터에서 실행 중인 앱에서 "파일 선택" 버튼을 여러 번 누르고 클릭 횟수가 증가하는지 확인합니다:<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. 필요한 파일을 선택하고 선택 버튼을 클릭합니다:<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. 파일 처리가 완료된 후 변환된 파일의 이미지가 화면에 나타납니다:<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## 더 많은 예제

Docker에서 Aspose.CAD를 사용하는 방법에 대한 샘플은 [예제](https://github.com/aspose-cad/Aspose.CAD-Documentation)를 참조하세요.


## 참고하십시오.

- [Visual Studio 2022용 AWS 도구 설치](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Windows에서 Docker Desktop 설치](https://docs.docker.com/docker-for-windows/install/)
- [Mac에서 Docker Desktop 설치](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Linux 컨테이너로 전환](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 옵션
- [.NET Core SDK에 대한 추가 정보](https://hub.docker.com/_/microsoft-dotnet-sdk)
