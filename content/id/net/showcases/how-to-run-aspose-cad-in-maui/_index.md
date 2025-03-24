---
title: Cara Menjalankan Aspose.CAD di UI Aplikasi Multi-platform (MAUI)
type: docs
description: "Menjalankan Aspose.CAD di UI Aplikasi Multi-platform (MAUI)."
weight: 71
url: /id/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Prasyarat
- Visual Studio 2022.
- SDK .NET 7 digunakan dalam contoh ini.


## MAUI

.NET Multi-platform App UI (.NET MAUI) adalah framework lintas platform untuk membuat aplikasi mobile dan desktop native dengan C# dan XAML.
Dengan menggunakan .NET MAUI, Anda dapat mengembangkan aplikasi yang dapat berjalan di Android, iOS, macOS, dan Windows dari satu basis kode yang dibagikan.

.NET MAUI bersifat open-source dan merupakan evolusi dari Xamarin.Forms, diperluas dari skenario mobile ke desktop, dengan kontrol UI yang dibangun kembali dari awal untuk kinerja dan ekstensi.
Jika Anda pernah menggunakan Xamarin.Forms untuk membangun antarmuka pengguna lintas platform, Anda akan melihat banyak kesamaan dengan .NET MAUI.
Namun, ada juga beberapa perbedaan.
Dengan menggunakan .NET MAUI, Anda dapat membuat aplikasi multi-platform menggunakan satu proyek, tetapi Anda dapat menambahkan kode sumber dan sumber daya spesifik platform jika perlu.
Salah satu tujuan utama dari .NET MAUI adalah memungkinkan Anda mengimplementasikan sebanyak mungkin logika aplikasi dan tata letak UI Anda dalam satu basis kode.


## Instalasi MAUI

1. Untuk membuat aplikasi .NET MAUI, Anda perlu versi terbaru dari Visual Studio 2022
1. Install Visual Studio, atau modifikasi instalasi Anda yang sudah ada, dan instal beban pengembangan .NET Multi-platform App UI dengan pilihan instalasi opsional defaultnya:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## Buat proyek

1. Luncurkan Visual Studio. Di jendela awal, klik Buat proyek baru untuk membuat proyek baru:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. Di jendela Buat proyek baru, pilih MAUI di drop-down Semua jenis proyek, pilih template Aplikasi .NET MAUI, dan klik tombol Selanjutnya:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. Di jendela Konfigurasi proyek baru Anda, beri nama proyek Anda, pilih lokasi yang sesuai untuknya, dan klik tombol Selanjutnya:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. Di jendela Informasi tambahan, pilih versi .NET yang ingin Anda targetkan dan klik tombol Buat:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Tunggu proyek dibuat dan dependensinya dipulihkan
1. Instal versi terbaru Aspose.CAD dari NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Ganti kode di MainPage.xaml
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
            Text="Selamat datang di .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Robot dot net yang lucu melambai hi kepada Anda!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Halo, Dunia!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Selamat datang di UI Aplikasi Multi-platform .NET"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Selamat datang di dot net UI Aplikasi Multi-platform"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Pilih file"
                SemanticProperties.Hint="Menghitung jumlah klik yang Anda lakukan"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Bersihkan"
                SemanticProperties.Hint="Menghitung jumlah klik yang Anda lakukan"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Tambahkan metode baru di MainPage.xaml.cs
{{% alert color="primary" %}} 
Jangan lupa menambahkan using Aspose.CAD dan using Aspose.CAD.ImageOptions di file.
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


## Debug Mesin Windows

1. Di toolbar Visual Studio, gunakan drop-down Target Debug untuk memilih Framework dan kemudian entri net7.0-windows:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. Di toolbar Visual Studio, tekan tombol Mesin Windows untuk membangun dan menjalankan aplikasi:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. Di aplikasi yang berjalan, tekan tombol "Pilih file" beberapa kali dan amati bahwa jumlah klik tombol meningkat:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Pilih file yang diperlukan dan klik buka:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. Setelah memproses file, gambar dari file yang dikonversi harus muncul di layar:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## Instal Emulator Android

1. Di toolbar Visual Studio, gunakan drop-down Target Debug untuk memilih Emulator Android dan kemudian entri Emulator Android
1. Di toolbar Visual Studio, tekan tombol Emulator Android:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Di jendela Persetujuan Lisensi Android SDK, tekan tombol Terima:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. Di jendela Persetujuan Lisensi Android SDK, tekan tombol Terima:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. Di dialog Kontrol Akun Pengguna, tekan tombol Ya:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. Di jendela Penerimaan Lisensi, tekan tombol Terima:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. Di toolbar Visual Studio, tekan tombol Emulator Android:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Di dialog Kontrol Akun Pengguna, tekan tombol Ya:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. Di jendela Perangkat Baru, tekan tombol Buat:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Tutup jendela Pengelola Perangkat Android


## Debug dengan Emulator Android

1. Di toolbar Visual Studio, tekan tombol Pixel 5 - API 33 (Android 13.0 - API 33) untuk membangun dan menjalankan aplikasi:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. Di aplikasi yang berjalan di emulator Android, tekan tombol "Pilih file" beberapa kali dan amati bahwa jumlah klik tombol meningkat:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Pilih file yang diperlukan dan klik pilih:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. Setelah memproses file, gambar dari file yang dikonversi harus muncul di layar:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## Contoh Lain

Untuk lebih banyak contoh tentang bagaimana Anda dapat menggunakan Aspose.CAD di Docker, lihat [contoh](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lihat Juga.

- [Instal AWS Toolkit untuk Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instal Docker Desktop di Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instal Docker Desktop di Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 7](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Beralih ke kontainer Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opsi
- Informasi tambahan tentang [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
