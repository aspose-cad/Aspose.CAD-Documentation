---
title: Aspose.CADをマルチプラットフォームアプリUI(MAUI)で実行する方法
type: docs
description: "マルチプラットフォームアプリUI(MAUI)でAspose.CADを実行します。"
weight: 71
url: /ja/net/showcases/how-to-run-aspose-cad-in-maui/
---

## 前提条件
- Visual Studio 2022。
- サンプルでは、.NET 7 SDKが使用されています。


## MAUI

.NETマルチプラットフォームアプリUI（.NET MAUI）は、C#とXAMLを使用してネイティブのモバイルおよびデスクトップアプリを作成するためのクロスプラットフォームフレームワークです。
.NET MAUIを使用すると、Android、iOS、macOS、Windowsで動作するアプリを単一の共有コードベースから開発できます。

.NET MAUIはオープンソースであり、Xamarin.Formsの進化版であり、モバイルからデスクトップシナリオに拡張されており、パフォーマンスと拡張性のためにゼロから再構築されたUIコントロールがあります。
以前にXamarin.Formsを使用してクロスプラットフォームのユーザーインターフェースを構築していた場合、.NET MAUIとの多くの類似点に気付くでしょう。
ただし、いくつかの違いもあります。
.NET MAUIを使用すると、単一のプロジェクトでマルチプラットフォームアプリを作成できますが、必要に応じてプラットフォーム固有のソースコードやリソースを追加できます。
.NET MAUIの主要な目標の1つは、可能な限りアプリのロジックやUIレイアウトを単一のコードベースで実装できるようにすることです。


## MAUIのインストール

1. .NET MAUIアプリを作成するには、最新バージョンのVisual Studio 2022が必要です。
1. Visual Studioをインストールするか、既存のインストールを変更して、.NETマルチプラットフォームアプリUI開発ワークロードをデフォルトのオプションでインストールします：<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## プロジェクトの作成

1. Visual Studioを起動します。スタートウィンドウで「新しいプロジェクトの作成」をクリックして、新しいプロジェクトを作成します：<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. 「新しいプロジェクトの作成」ウィンドウで、「すべてのプロジェクトタイプ」ドロップダウンからMAUIを選択し、「.NET MAUIアプリ」テンプレートを選択して「次へ」ボタンをクリックします：<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. 「新しいプロジェクトの構成」ウィンドウで、プロジェクト名を付け、適切な場所を選択して「次へ」ボタンをクリックします：<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. 「追加情報」ウィンドウで、ターゲットとする.NETのバージョンを選択し、「作成」ボタンをクリックします：<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. プロジェクトが作成され、その依存関係が復元されるのを待ちます。
1. NuGetから最新のAspose.CADバージョンをインストールします：<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. MainPage.xamlのコードを置き換えます
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
            Text="ようこそ、.NET MAUIへ!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="かわいいドットネットボットがあなたに手を振っています！"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="こんにちは、世界！"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text=".NETマルチプラットフォームアプリUIへようこそ"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="ドットネットマルチプラットフォームアプリUIへようこそ"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="ファイルを選択"
                SemanticProperties.Hint="クリックした回数をカウントします"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="クリア"
                SemanticProperties.Hint="クリックした回数をカウントします"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. MainPage.xaml.csに新しいメソッドを追加します
{{% alert color="primary" %}} 
Aspose.CADとAspose.CAD.ImageOptionsをファイルに追加するのを忘れないでください。
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


## Windowsマシンでのデバッグ

1. Visual Studioのツールバーで、デバッグターゲットドロップダウンを使用して「Framework」を選択し、次に「net7.0-windows」エントリを選択します：<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. Visual Studioのツールバーで「Windowsマシン」ボタンを押して、アプリをビルドして実行します：<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. 実行中のアプリで「ファイルを選択」ボタンを何度か押し、ボタンのクリック回数が増加するのを観察します：<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. 必要なファイルを選択し、「開く」をクリックします：<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. ファイルの処理後、変換されたファイルの画像が画面に表示されるはずです：<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Androidエミュレーターのインストール

1. Visual Studioのツールバーで、デバッグターゲットドロップダウンを使用して「Androidエミュレーター」を選択し、次に「Androidエミュレーター」エントリを選択します。
1. Visual Studioのツールバーで「Androidエミュレーター」ボタンを押します：<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Android SDK - ライセンス契約ウィンドウで「同意」ボタンを押します：<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Android SDK - ライセンス契約ウィンドウで「同意」ボタンを押します：<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. ユーザーアカウント制御ダイアログで「はい」ボタンを押します：<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. ライセンス受諾ウィンドウで「同意」ボタンを押します：<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. Visual Studioのツールバーで「Androidエミュレーター」ボタンを押します：<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. ユーザーアカウント制御ダイアログで「はい」ボタンを押します：<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. 新しいデバイスウィンドウで「作成」ボタンを押します：<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Androidデバイスマネージャーウィンドウを閉じます。


## Androidエミュレーターでのデバッグ

1. Visual Studioのツールバーで「Pixel 5 - API 33 (Android 13.0 - API 33)」ボタンを押してアプリをビルドして実行します：<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. Androidエミュレーターの実行中のアプリで「ファイルを選択」ボタンを何度か押し、ボタンのクリック回数が増加するのを観察します：<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. 必要なファイルを選択し、「選択」をクリックします：<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. ファイルの処理後、変換されたファイルの画像が画面に表示されるはずです：<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## その他の例

DockerでAspose.CADを使用する方法のさらなるサンプルについては、[examples](https://github.com/aspose-cad/Aspose.CAD-Documentation)を参照してください。


## 参照

- [Visual Studio 2022用AWSツールキットのインストール](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [WindowsでDocker Desktopをインストール](https://docs.docker.com/docker-for-windows/install/)
- [MacでDocker Desktopをインストール](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022、.NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Linuxコンテナに切り替え](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)オプション
- [.NET Core SDKに関する追加情報](https://hub.docker.com/_/microsoft-dotnet-sdk)
