---
title: چگونه Aspose.CAD را در UI برنامه چند پلتفرم (MAUI) اجرا کنیم
type: docs
description: "اجرای Aspose.CAD در یک UI برنامه چند پلتفرم (MAUI)."
weight: 71
url: /fa/net/showcases/how-to-run-aspose-cad-in-maui
---

## پیش نیازها
- Visual Studio 2022.
- NET 7 SDK در این مثال استفاده شده است.

## MAUI

.NET Multi-platform App UI (.NET MAUI) یک فریم‌ورک چند پلتفرمی برای ایجاد برنامه‌های بومی موبایل و دسکتاپ با C# و XAML است.
با استفاده از .NET MAUI، می‌توانید برنامه‌هایی توسعه دهید که می‌توانند بر روی Android، iOS، macOS و Windows از یک کد پایه مشترک اجرا شوند.

.NET MAUI متن باز است و تکامل Xamarin.Forms می‌باشد که از موارد موبایل به سناریوهای دسکتاپ گسترش یافته و کنترل‌های UI آن از پایه برای عملکرد و قابلیت گسترش بازسازی شده‌اند.
اگر قبلاً از Xamarin.Forms برای ساخت رابط‌های کاربری چند پلتفرمی استفاده کرده‌اید، متوجه بسیاری از شباهت‌ها با .NET MAUI خواهید شد.
با این حال، تفاوت‌هایی نیز وجود دارد.
با استفاده از .NET MAUI، می‌توانید برنامه‌های چند پلتفرمی را با استفاده از یک پروژه واحد ایجاد کنید، اما اگر لازم باشد می‌توانید کد و منابع خاص پلتفرم را اضافه کنید.
یکی از اهداف کلیدی .NET MAUI این است که به شما اجازه دهد تا تا حد امکان منطق برنامه و چیدمان UI خود را در یک کد پایه واحد پیاده‌سازی کنید.

## نصب MAUI

1. برای ایجاد برنامه‌های .NET MAUI، به آخرین نسخه Visual Studio 2022 نیاز خواهید داشت.
1. یا Visual Studio را نصب کنید، یا نصب موجود خود را اصلاح کنید و بار کاری توسعه UI برنامه چند پلتفرم .NET را با گزینه‌های نصب پیش‌فرضش نصب کنید:<br>
![نصب‌کننده_visual](/_assets/visual-installer.png)

## ایجاد پروژه

1. Visual Studio را راه‌اندازی کنید. در پنجره شروع، روی "Create a new project" کلیک کنید تا یک پروژه جدید ایجاد کنید:<br>
![ایجاد پروژه](/_assets/create-project.png)<br>
1. در پنجره "Create a new project"، MAUI را در منوی کشویی "All project types" انتخاب کنید، الگوی .NET MAUI App را انتخاب کنید و روی دکمه Next کلیک کنید:<br>
![انتخاب نوع پروژه](/_assets/select-project.png)<br>
1. در پنجره "Configure your new project"، نام پروژه خود را انتخاب کنید، مکان مناسبی برای آن انتخاب کنید و روی دکمه Next کلیک کنید:<br>
![انتخاب مسیر پروژه](/_assets/select-project-path.png)<br>
1. در پنجره "Additional information"، نسخه .NET که می‌خواهید هدف قرار دهید را انتخاب کنید و روی دکمه Create کلیک کنید:<br>
![فریم‌ورک هدف](/_assets/select-framework.png)<br>
1. منتظر بمانید تا پروژه ایجاد شود و وابستگی‌های آن بازگردانی شوند.
1. آخرین نسخه Aspose.CAD را از NuGet نصب کنید:<br>
![NuGet](/_assets/nuget.png)<br>
1. کد موجود در MainPage.xaml را جایگزین کنید
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
            Text="به .NET MAUI خوش آمدید!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="ربات دات نت جالب که برای شما دست wave می‌زند!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="سلام، دنیا!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="به UI برنامه چندپلتفرمی .NET خوش آمدید"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="به دات نت UI برنامه چندپلتفرمی خوش آمدید"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="انتخاب فایل"
                SemanticProperties.Hint="تعداد دفعات کلیک شما را شمارش می‌کند"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="پاک کردن"
                SemanticProperties.Hint="تعداد دفعات کلیک شما را شمارش می‌کند"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. متدهای جدیدی در MainPage.xaml.cs اضافه کنید
{{% alert color="primary" %}} 
فراموش نکنید که از Aspose.CAD و Aspose.CAD.ImageOptions در فایل استفاده کنید.
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
        PickerTitle = "هر چیزی"
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

## اشکال‌زدایی از ماشین ویندوز

1. در نوار ابزار Visual Studio، از منوی کشویی Debug Target برای انتخاب Framework و سپس ورودی net7.0-windows استفاده کنید:<br>
![هدف اشکال‌زدایی](/_assets/windows-mode.png)<br>
1. در نوار ابزار Visual Studio، روی دکمه Windows Machine کلیک کنید تا برنامه ساخته و اجرا شود:<br>
![شروع اشکال‌زدایی در ماشین ویندوز](/_assets/windows-start-debug.png)<br>
1. در برنامه در حال اجرا، چندین بار روی دکمه "انتخاب فایل" کلیک کنید و مشاهده کنید که تعداد کلیک‌های دکمه افزایش می‌یابد:<br>
![صفحه اصلی](/_assets/windows-home-page.png)<br>
1. فایل مورد نیاز را انتخاب کرده و روی باز کردن کلیک کنید:<br>
![انتخاب فایل](/_assets/select-file.png)<br>
1. پس از پردازش فایل، تصویری از فایل تبدیل شده باید روی صفحه ظاهر شود:<br>
![نتیجه اشکال‌زدایی ویندوز](/_assets/windows-result.png)

## نصب شبیه‌ساز Android

1. در نوار ابزار Visual Studio، از منوی کشویی Debug Target برای انتخاب Android Emulators و سپس ورودی Android Emulator استفاده کنید.
1. در نوار ابزار Visual Studio، روی دکمه Android Emulator کلیک کنید:<br>
![شروع نصب دکمه شبیه‌ساز](/_assets/start-install-emulator.png)<br>
1. در پنجره قرارداد مجوز Android SDK، روی دکمه Accept کلیک کنید:<br>
![مجوز SDK Android](/_assets/android-sdk-1.png)<br>
1. در پنجره قرارداد مجوز Android SDK، روی دکمه Accept کلیک کنید:<br>
![مجوز ARM SDK Android](/_assets/android-sdk-2.png)<br>
1. در گفتگوی کنترل حساب کاربری، روی دکمه Yes کلیک کنید:<br>
![مدیر SDK](/_assets/android-sdk-3.png)<br>
1. در پنجره پذیرش مجوز، روی دکمه Accept کلیک کنید:<br>
![مدیر مجوز SDK](/_assets/android-sdk-4.png)<br>
1. در نوار ابزار Visual Studio، روی دکمه Android Emulator کلیک کنید:<br>
![شروع نصب دکمه شبیه‌ساز](/_assets/start-install-emulator.png)<br>
1. در گفتگوی کنترل حساب کاربری، روی دکمه Yes کلیک کنید:<br>
![مدیر دستگاه Android](/_assets/android-device-manager.png)<br>
1. در پنجره دستگاه جدید، روی دکمه Create کلیک کنید:<br>
![دستگاه جدید Android](/_assets/android-new-device.png)<br>
1. پنجره مدیر دستگاه Android را ببندید.

## اشکال‌زدایی با شبیه‌ساز Android

1. در نوار ابزار Visual Studio، روی دکمه Pixel 5 - API 33 (Android 13.0 - API 33) کلیک کنید تا برنامه ساخته و اجرا شود:<br>
![انتخاب شبیه‌ساز Android](/_assets/select-android-emulator.png)<br>
1. در برنامه در حال اجرا در شبیه‌ساز Android، چندین بار روی دکمه "انتخاب فایل" کلیک کنید و مشاهده کنید که تعداد کلیک‌های دکمه افزایش می‌یابد:<br>
![صفحه اصلی شبیه‌ساز Android](/_assets/android-home-page.png)<br>
1. فایل مورد نیاز را انتخاب کرده و روی انتخاب کلیک کنید:<br>
![انتخاب فایل در Android](/_assets/android-select-file.png)<br>
1. پس از پردازش فایل، تصویری از فایل تبدیل شده باید روی صفحه ظاهر شود:<br>
![نتیجه اشکال‌زدایی Android](/_assets/android-result.png)

## مثال‌های بیشتر

برای نمونه‌های بیشتر اینکه چگونه می‌توانید از Aspose.CAD در Docker استفاده کنید، به [نمونه‌ها](https://github.com/aspose-cad/Aspose.CAD-Documentation) مراجعه کنید.

## همچنین ببینید.

- [نصب AWS Toolkit برای Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [نصب Docker Desktop در ویندوز](https://docs.docker.com/docker-for-windows/install/)
- [نصب Docker Desktop در مک](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- گزینه [تغییر به کانتینرهای لینوکس](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- اطلاعات اضافی در مورد [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
