---
title: Як запустити Aspose.CAD у Multi-platform App UI(MAUI)
type: docs
description: "Запустіть Aspose.CAD у Multi-platform App UI(MAUI)."
weight: 71
url: /uk/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Попередні вимоги
- Visual Studio 2022.
- Для прикладу використовується .NET 7 SDK.


## MAUI

.NET Multi-platform App UI (.NET MAUI) — це крос-платформенний фреймворк для створення рідних мобільних і настільних додатків на C# і XAML.
Використовуючи .NET MAUI, ви можете розробляти додатки, які можуть працювати на Android, iOS, macOS і Windows з єдиної загальної бази коду.

.NET MAUI є відкритим кодом і є еволюцією Xamarin.Forms, розширеною від мобільних до настільних сценаріїв, з UI-контролями, реконструйованими з нуля для продуктивності та розширюваності.
Якщо ви раніше використовували Xamarin.Forms для створення крос-платформних інтерфейсів користувача, ви помітите багато подібностей з .NET MAUI.
Однак є також деякі відмінності.
Використовуючи .NET MAUI, ви можете створювати мультиплатформенні додатки, використовуючи єдиний проект, але при необхідності можете додавати специфічний для платформи вихідний код та ресурси.
Однією з основних цілей .NET MAUI є можливість реалізувати якомога більше логіки вашого додатка та макету UI в єдиній базі коду.


## Встановлення MAUI

1. Щоб створити .NET MAUI додатки, вам потрібна остання версія Visual Studio 2022
1. Встановіть Visual Studio або змініть свою існуючу установку та встановіть робоче навантаження для розробки .NET Multi-platform App UI з його стандартними варіантами установки:<br>
![Встановлювач Visual](/cad/_assets/showcases/maui/visual-installer.png)


## Створення проекту

1. Запустіть Visual Studio. У вікні запуску натисніть Створити новий проект, щоб створити новий проект:<br>
![Створити проект](/cad/_assets/showcases/maui/create-project.png)<br>
1. У вікні Створення нового проекту виберіть MAUI у спадному меню Усі типи проектів, виберіть шаблон .NET MAUI App і натисніть кнопку Далі:<br>
![Вибрати тип проекту](/cad/_assets/showcases/maui/select-project.png)<br>
1. У вікні Налаштування нового проекту дайте ім'я своєму проекту, виберіть відповідне місце і натисніть кнопку Далі:<br>
![Вибрати шлях проекту](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. У вікні Додаткова інформація виберіть версію .NET, на яку ви хочете націлити, і натисніть кнопку Створити:<br>
![Націлена платформа](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Дочекайтесь створення проекту та відновлення його залежностей
1. Встановіть останню версію Aspose.CAD з NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Замініть код у MainPage.xaml
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
            Text="Ласкаво просимо до .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Милий бот .NET, який вітає вас!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Привіт, svět!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Ласкаво просимо до .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Ласкаво просимо до .NET Multi-platform App UI"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Вибрати файл"
                SemanticProperties.Hint="Підрахунок кількості натиснень"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Очистити"
                SemanticProperties.Hint="Підрахунок кількості натиснень"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Додайте нові методи в MainPage.xaml.cs
{{% alert color="primary" %}} 
Не забудьте додати using Aspose.CAD та using Aspose.CAD.ImageOptions в файл.
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
        PickerTitle = "будь-який"
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


## Налагодження на Windows Machine

1. У панелі інструментів Visual Studio використовуйте спадний список Ціль налагодження для вибору Framework, а потім виберіть запис net7.0-windows:<br>
![Ціль налагодження](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. У панелі інструментів Visual Studio натисніть кнопку Windows Machine, щоб зібрати та запустити додаток:<br>
![Почати налагодження на Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. У запущеному додатку кілька разів натисніть кнопку "Вибрати файл" і спостерігайте, що кількість натиснень кнопки збільшується:<br>
![Головна сторінка](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Виберіть потрібний файл і натисніть відкриття:<br>
![Вибрати файл](/cad/_assets/showcases/maui/select-file.png)<br>
1. Після обробки файлу на екрані повинно з'явитися зображення конвертованого файлу:<br>
![Результат налагодження windows](/cad/_assets/showcases/maui/windows-result.png)


## Встановлення Android Emulator

1. У панелі інструментів Visual Studio використовуйте спадний список Ціль налагодження для вибору Android Emulators, а потім виберіть запис Android Emulator
1. У панелі інструментів Visual Studio натисніть кнопку Android Emulator:<br>
![Почати встановлення емулятора](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. У вікні Ліцензійна угода Android SDK натисніть кнопку Приймати:<br>
![Android SDK-Ліцензійна угода](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. У вікні Ліцензійна угода Android SDK натисніть кнопку Приймати:<br>
![Android SDK ARM -Ліцензійна угода](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. У діалоговому вікні Управління обліковими записами натисніть кнопку Так:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. У вікні Прийняття ліцензії натисніть кнопку Приймати:<br>
![SDK ARManagerM -Ліцензійна угода](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. У панелі інструментів Visual Studio натисніть кнопку Android Emulator:<br>
![Почати встановлення емулятора](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. У діалоговому вікні Управління обліковими записами натисніть кнопку Так:<br>
![Управління Android пристроями](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. У вікні Новий пристрій натисніть кнопку Створити:<br>
![Новий Android пристрій](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Закрийте вікно Менеджера Android пристроїв


## Налагодження з Android Emulator

1. У панелі інструментів Visual Studio натисніть кнопку Pixel 5 - API 33 (Android 13.0 - API 33), щоб зібрати і запустити додаток:<br>
![Вибрати емулятор Android](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. У запущеному додатку в емуляторі Android натисніть кнопку "Вибрати файл" кілька разів і спостерігайте, що кількість натиснень кнопки збільшується:<br>
![Головна сторінка емулятора Android](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Виберіть потрібний файл і натисніть вибрати:<br>
![Вибрати файл в андроїд](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. Після обробки файлу на екрані повинно з'явитися зображення конвертованого файлу:<br>
![Результат налагодження android](/cad/_assets/showcases/maui/android-result.png)


## Більше прикладів

Для інших прикладів того, як ви можете використовувати Aspose.CAD у Docker, дивіться [приклади](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Дивіться також.

- [Встановлення AWS Toolkit для Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Встановлення Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Встановлення Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Переключитися на контейнери Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опція
- Додаткова інформація про [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
