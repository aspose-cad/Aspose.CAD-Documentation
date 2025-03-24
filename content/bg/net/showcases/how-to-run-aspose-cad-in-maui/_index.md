---
title: Как да стартирате Aspose.CAD в мултиплатформен App UI (MAUI)
type: docs
description: "Стартиране на Aspose.CAD в мултиплатформен App UI (MAUI)."
weight: 71
url: /bg/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Предварителни изисквания
- Visual Studio 2022.
- Използва се .NET 7 SDK в примера.


## MAUI

.NET Мултиплатформен App UI (.NET MAUI) е кросплатформен фреймуърк за създаване на нативни мобилни и десктоп приложения с C# и XAML.
С помощта на .NET MAUI можете да разработвате приложения, които могат да работят на Android, iOS, macOS и Windows от един общ код.

.NET MAUI е с отворен код и е еволюцията на Xamarin.Forms, разширена от мобилни до десктоп сценарии, с UI контроли преработени от основата за производителност и разширяемост.
Ако преди сте използвали Xamarin.Forms за изграждане на кросплатформени потребителски интерфейси, ще забележите много прилики с .NET MAUI.
Въпреки това, има и някои разлики.
С помощта на .NET MAUI можете да създавате мултиплатформени приложения, използвайки един проект, но можете да добавяте специфичен за платформата код и ресурси, ако е необходимо.
Една от основните цели на .NET MAUI е да ви позволи да реализирате колкото се може повече от логиката на вашето приложение и подредбата на потребителския интерфейс в един единствен код.


## Инсталиране на MAUI

1. За да създадете .NET MAUI приложения, ще ви трябва най-новата версия на Visual Studio 2022
1. Или инсталирайте Visual Studio, или модифицирайте съществуващата си инсталация и инсталирайте разработваща натовареност за .NET Мултиплатформен App UI с подразбиращите се опции за инсталация:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## Създаване на проект

1. Стартирайте Visual Studio. В началния прозорец кликнете върху „Създаване на нов проект“, за да създадете нов проект:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. В прозореца „Създаване на нов проект“, изберете MAUI от падащото меню „Всички типове проекти“, изберете шаблона за .NET MAUI App и кликнете върху бутона „Следващ“:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. В прозореца „Конфигуриране на новия проект“ дайте име на проекта си, изберете подходящо местоположение за него и кликнете върху бутона „Следващ“:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. В прозореца „Допълнителна информация“ изберете версията на .NET, която искате да целите, и кликнете върху бутона „Създаване“:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Изчакайте проектът да бъде създаден и зависимостите му да бъдат възстановени
1. Инсталирайте най-новата версия на Aspose.CAD от NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Заменете кода в MainPage.xaml
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
            Text="Добре дошли в .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Сладък dot net бот, който ви маха с ръка!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Здравей, свят!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Добре дошли в .NET Мултиплатформен App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Добре дошли в dot net Мултиплатформен App UI"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Изберете файл"
                SemanticProperties.Hint="Брои колко пъти кликнете"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Изчисти"
                SemanticProperties.Hint="Брои колко пъти кликнете"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Добавете нови методи в MainPage.xaml.cs
{{% alert color="primary" %}} 
Не забравяйте да добавите `using Aspose.CAD` и `using Aspose.CAD.ImageOptions` в файла.
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
        PickerTitle = "всякакъв"
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


## Дебъгване на Windows машина

1. В лентата с инструменти на Visual Studio използвайте падащото меню „Debug Target“, за да изберете Framework и след това записа net7.0-windows:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. В лентата с инструменти на Visual Studio натиснете бутона "Windows Machine", за да изградите и стартирате приложението:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. В работещото приложение натиснете бутона "Изберете файл" няколко пъти и наблюдавайте, че броят на кликванията на бутона се увеличава:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Изберете необходимия файл и кликнете „отвори“:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. След обработката на файла изображение на конвертирания файл трябва да се появи на екрана:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## Инсталиране на Android емулатор

1. В лентата с инструменти на Visual Studio използвайте падащото меню „Debug Target“, за да изберете Android Emulators и след това записа Android Emulator
1. В лентата с инструменти на Visual Studio натиснете бутона "Android Emulator":<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. В прозореца „Лицензионно споразумение на Android SDK“ натиснете бутона "Приемам":<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. В прозореца „Лицензионно споразумение на Android SDK“ натиснете бутона "Приемам":<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. В диалоговия прозорец на Контрол на потребителския акаунт натиснете бутона "Да":<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. В прозореца за приемане на лицензиите натиснете бутона "Приемам":<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. В лентата с инструменти на Visual Studio натиснете бутона "Android Emulator":<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. В диалоговия прозорец на Контрол на потребителския акаунт натиснете бутона "Да":<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. В прозореца "Ново устройство" натиснете бутона "Създай":<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Затворете прозореца на мениджъра на Android устройства


## Дебъгване с Android Emulator

1. В лентата с инструменти на Visual Studio натиснете бутона Pixel 5 - API 33 (Android 13.0 - API 33), за да изградите и стартирате приложението:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. В работещото приложение в Android емулатора натиснете бутона „Изберете файл“ няколко пъти и наблюдавайте, че броят на кликванията на бутона се увеличава:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Изберете необходимия файл и кликнете „изберете“:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. След обработката на файла изображение на конвертирания файл трябва да се появи на екрана:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## Повече примери

За повече примери как можете да използвате Aspose.CAD в Docker, вижте [примери](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Вижте също.

- [Инсталирайте AWS Toolkit за Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Инсталирайте Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Инсталирайте Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Преминаване към Linux контейнери](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Допълнителна информация за [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
