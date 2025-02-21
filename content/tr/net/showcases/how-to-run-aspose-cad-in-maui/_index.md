---
title: Aspose.CAD'i Çoklu Platform Uygulama Arayüzünde (MAUI) Nasıl Çalıştırılır
type: docs
description: "Aspose.CAD'i Çoklu Platform Uygulama Arayüzünde (MAUI) çalıştırın."
weight: 71
url: /tr/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Ön Gereksinimler
- Visual Studio 2022.
- Örnek için .NET 7 SDK kullanılmıştır.


## MAUI

.NET Çoklu Platform Uygulama Arayüzü (.NET MAUI), C# ve XAML ile yerel mobil ve masaüstü uygulamaları oluşturmak için kullanılan bir çapraz platform çerçevesidir.
.NET MAUI kullanarak, tek bir paylaşılan kod tabanından Android, iOS, macOS ve Windows üzerinde çalışabilen uygulamalar geliştirebilirsiniz.

.NET MAUI açık kaynaklıdır ve Xamarin.Forms'un evrimi olup, mobil senaryolardan masaüstü senaryolarına uzanır ve performans ve genişletilebilirlik için sıfırdan yeniden inşa edilmiş UI kontrollerine sahiptir.
Daha önce Xamarin.Forms kullanarak çapraz platform kullanıcı arayüzleri oluşturduysanız, .NET MAUI ile birçok benzerlik göreceksiniz.
Ancak bazı farklılıklar da vardır.
.NET MAUI kullanarak, tek bir proje ile çoklu platform uygulamaları oluşturabilirsiniz, ancak gerekirse platforma özgü kaynak kodu ve kaynaklar ekleyebilirsiniz.
.NET MAUI'nin ana hedeflerinden biri, uygulama mantığınızı ve UI düzeninizi mümkün olduğunca tek bir kod tabanında uygulamanıza olanak tanımaktır.


## MAUI Yüklemesi

1. .NET MAUI uygulamaları oluşturmak için en son Visual Studio 2022 sürümüne ihtiyacınız olacak
1. Visual Studio'yu kurun veya mevcut kurulumunuzu değiştirin ve varsayılan isteğe bağlı kurulum seçenekleriyle .NET Çoklu Platform Uygulama Arayüzü geliştirme yükünü yükleyin:<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## Proje Oluşturma

1. Visual Studio'yu başlatın. Başlangıç penceresinde, yeni bir proje oluşturmak için Yeni bir proje oluştur'a tıklayın:<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. Yeni bir proje oluştur penceresinde, Tüm proje türleri açılır menüsünden MAUI'yi seçin, .NET MAUI Uygulama şablonunu seçin ve İleri butonuna tıklayın:<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. Yeni projeyi yapılandır penceresinde, projenize bir ad verin, uygun bir konum seçin ve İleri butonuna tıklayın:<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. Ek bilgi penceresinde, hedeflemek istediğiniz .NET sürümünü seçin ve Oluştur butonuna tıklayın:<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. Projeyi oluşturmayı ve bağımlılıklarını geri yüklemeyi bekleyin
1. NuGet'ten en son Aspose.CAD sürümünü yükleyin:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. MainPage.xaml dosyasındaki kodu değiştirin
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
            Text=".NET MAUI'ye hoş geldiniz!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Size selam veren sevimli dot net bot!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Merhaba, Dünya!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text=".NET Çoklu Platform Uygulama Arayüzü'ne hoş geldiniz"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Dot net Çoklu platform Uygulama Arayüzüne hoş geldiniz"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Dosya seç"
                SemanticProperties.Hint="Tıkladığınızda sayımı yapar"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Temizle"
                SemanticProperties.Hint="Tıkladığınızda sayımı yapar"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. MainPage.xaml.cs dosyasına yeni yöntemler ekleyin
{{% alert color="primary" %}} 
Aspose.CAD ve Aspose.CAD.ImageOptions kullanmayı unutmayın.
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
        PickerTitle = "herhangi"
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


## Windows Makinesinde Hata Ayıklama

1. Visual Studio araç çubuğunda, Hedef Drop-down menüsünü kullanarak Framework'ü seçin ve ardından net7.0-windows girişini seçin:<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. Visual Studio araç çubuğunda, uygulamayı oluşturmak ve çalıştırmak için Windows Makinesi butonuna basın:<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. Çalışan uygulamada, "Dosya seç" butonuna birkaç kez basın ve butona tıklama sayısının arttığını gözlemleyin:<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. Gerekli dosyayı seçin ve aç'a tıklayın:<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. Dosya işlendiğinde, ekranınıza dönüştürülen dosyanın bir resmi gelmelidir:<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Android Emulator Yüklemesi

1. Visual Studio araç çubuğunda, Hedef Drop-down menüsünü kullanarak Android Emulator'ü seçin ve ardından Android Emulator girişini seçin
1. Visual Studio araç çubuğunda, Android Emulator butonuna basın:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Android SDK - Lisans Sözleşmesi penceresinde, Kabul et butonuna basın:<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Android SDK - Lisans Sözleşmesi penceresinde, Kabul et butonuna basın:<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. Kullanıcı Hesabı Denetimi penceresinde, Evet butonuna basın:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. Lisans Kabulü penceresinde, Kabul et butonuna basın:<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. Visual Studio araç çubuğunda, Android Emulator butonuna basın:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Kullanıcı Hesabı Denetimi penceresinde, Evet butonuna basın:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. Yeni Cihaz penceresinde, Oluştur butonuna basın:<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Android Cihaz Yöneticisi penceresini kapatın


## Android Emulator ile Hata Ayıklama

1. Visual Studio araç çubuğunda, uygulamayı oluşturmak ve çalıştırmak için Pixel 5 - API 33 (Android 13.0 - API 33) butonuna basın:<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. Android emülatöründeki çalışmakta olan uygulamada, "Dosya seç" butonuna birkaç kez basın ve butona tıklama sayısının arttığını gözlemleyin:<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. Gerekli dosyayı seçin ve seç butonuna tıklayın:<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. Dosya işlendiğinde, ekranınıza dönüştürülen dosyanın bir resmi gelmelidir:<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## Daha Fazla Örnek

Aspose.CAD'i Docker'da nasıl kullanabileceğinizle ilgili daha fazla örnek için [örnekler](https://github.com/aspose-cad/Aspose.CAD-Documentation) bağlantısına bakın.


## Ayrıca Bakınız.

- [Visual Studio 2022 için AWS Toolkit'i yükleyin](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Windows'ta Docker Desktop'u yükleyin](https://docs.docker.com/docker-for-windows/install/)
- [Mac'te Docker Desktop'u yükleyin](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Linux konteynerlerine geçin](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) seçeneği
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) hakkında ek bilgiler
