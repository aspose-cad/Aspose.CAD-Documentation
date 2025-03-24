---
title: Как запустить Aspose.CAD в Multi-platform App UI(MAUI)
type: docs
description: "Запустите Aspose.CAD в Multi-platform App UI(MAUI)."
weight: 71
url: /ru/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Предварительные требования
- Visual Studio 2022.
- Используется .NET 7 SDK в примере.

## MAUI

.NET Multi-platform App UI (.NET MAUI) - это кросс-платформенный фреймворк для создания нативных мобильных и настольных приложений с C# и XAML. С помощью .NET MAUI вы можете разрабатывать приложения, которые могут работать на Android, iOS, macOS и Windows из одной общей кодовой базы.

.NET MAUI является опенсорсным и представляет собой эволюцию Xamarin.Forms, расширенной от мобильных к настольным сценариям, с элементами управления UI, которые были заново разработаны для производительности и расширяемости. Если вы ранее использовали Xamarin.Forms для создания кросс-платформенных пользовательских интерфейсов, вы заметите много схожестей с .NET MAUI. Однако есть также некоторые различия. Используя .NET MAUI, вы можете создавать многоплатформенные приложения с использованием одного проекта, но при необходимости вы можете добавить специфичный для платформы исходный код и ресурсы. Одна из ключевых целей .NET MAUI - дать вам возможность реализовать как можно больше вашей логики приложения и макета UI в одной кодовой базе.

## Установка MAUI

1. Чтобы создать приложения .NET MAUI, вам потребуется последняя версия Visual Studio 2022
1. Установите Visual Studio или измените вашу существующую установку, и установите рабочую нагрузку разработки .NET Multi-platform App UI с ее стандартными дополнительными вариантами установки:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)

## Создание проекта

1. Запустите Visual Studio. В начальном окне нажмите Создать новый проект для создания нового проекта:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. В окне Создать новый проект выберите MAUI в выпадающем списке Все типы проектов, выберите шаблон .NET MAUI App и нажмите кнопку Дальше:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. В окне Настроить ваш новый проект введите имя вашего проекта, выберите подходящее место для него и нажмите кнопку Дальше:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. В окне Дополнительная информация выберите версию .NET, на которую вы хотите нацелиться, и нажмите кнопку Создать:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Дождитесь создания проекта и восстановления его зависимостей
1. Установите последнюю версию Aspose.CAD из NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Замените код в MainPage.xaml
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
            Text="Добро пожаловать в .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Милый бот dot net, машущий вам!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Привет, мир!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Добро пожаловать в .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Добро пожаловать в dot net Multi platform App UI"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Выбрать файл"
                SemanticProperties.Hint="Подсчитывает количество нажатий кнопки"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Очистить"
                SemanticProperties.Hint="Подсчитывает количество нажатий кнопки"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Добавьте новые методы в MainPage.xaml.cs
{{% alert color="primary" %}} 
Не забудьте добавить using Aspose.CAD и using Aspose.CAD.ImageOptions в файл.
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

## Отладка на Windows машине

1. В панели инструментов Visual Studio используйте выпадающий список Целевой отладчик для выбора Framework, затем выберите элемент net7.0-windows:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. В панели инструментов Visual Studio нажмите кнопку Windows Machine, чтобы построить и запустить приложение:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. В работающем приложении нажмите кнопку "Выбрать файл" несколько раз и наблюдайте, как увеличивается количество нажатий кнопки:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Выберите необходимый файл и нажмите открыть:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. После обработки файла на экране должно появиться изображение конвертированного файла:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)

## Установка эмулятора Android

1. В панели инструментов Visual Studio используйте выпадающий список Целевой отладчик для выбора Эмуляторов Android и затем выберите элемент Android Emulator
1. В панели инструментов Visual Studio нажмите кнопку Android Emulator:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. В окне Лицензионное соглашение Android SDK нажмите кнопку Принять:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. В окне Лицензионное соглашение Android SDK нажмите кнопку Принять:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. В диалоговом окне Управление учетными записями пользователей нажмите кнопку Да:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. В окне Принятие лицензии нажмите кнопку Принять:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. В панели инструментов Visual Studio нажмите кнопку Android Emulator:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. В диалоговом окне Управление учетными записями пользователей нажмите кнопку Да:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. В окне Новое устройство нажмите кнопку Создать:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Закройте окно Менеджер устройств Android

## Отладка с эмулятором Android

1. В панели инструментов Visual Studio нажмите кнопку Pixel 5 - API 33 (Android 13.0 - API 33), чтобы построить и запустить приложение:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. В работающем приложении в эмуляторе Android нажмите кнопку "Выбрать файл" несколько раз и наблюдайте, как увеличивается количество нажатий кнопки:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Выберите необходимый файл и нажмите выбрать:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. После обработки файла на экране должно появиться изображение конвертированного файла:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)

## Больше примеров

Для получения дополнительных примеров того, как вы можете использовать Aspose.CAD в Docker, смотрите [пример](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## См. также.

- [Установить AWS Toolkit для Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Установить Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Установить Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Переключиться на контейнеры Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Дополнительная информация о [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
