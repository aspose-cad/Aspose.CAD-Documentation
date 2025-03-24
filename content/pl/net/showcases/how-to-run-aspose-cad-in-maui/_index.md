---
title: Jak uruchomić Aspose.CAD w Multi-platform App UI(MAUI)
type: docs
description: "Uruchom Aspose.CAD w Multi-platform App UI(MAUI)."
weight: 71
url: /pl/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Wymagania wstępne
- Visual Studio 2022.
- SDK .NET 7 jest używany w przykładzie.


## MAUI

.NET Multi-platform App UI (.NET MAUI) to framework wieloplatformowy do tworzenia natywnych aplikacji mobilnych i desktopowych w C# i XAML.
Korzystając z .NET MAUI, możesz rozwijać aplikacje, które będą działać na Androidzie, iOS, macOS i Windows z jednej wspólnej bazy kodu.

.NET MAUI jest projektem open-source i stanowi rozwinięcie Xamarin.Forms, rozszerzone z urządzeń mobilnych na scenariusze desktopowe, z kontrolkami UI przebudowanymi od podstaw dla wydajności i możliwości rozbudowy.
Jeśli wcześniej używałeś Xamarin.Forms do budowy interfejsów użytkownika wieloplatformowych, zauważysz wiele podobieństw do .NET MAUI.
Jednak są także pewne różnice.
Korzystając z .NET MAUI, możesz tworzyć aplikacje wieloplatformowe korzystając z jednego projektu, ale możesz dodać specyficzny dla platformy kod źródłowy i zasoby, jeśli zajdzie taka potrzeba.
Jednym z głównych celów .NET MAUI jest umożliwienie implementacji jak największej części logiki aplikacji i układu UI w jednej bazie kodu.


## Instalacja MAUI

1. Aby stworzyć aplikacje .NET MAUI, potrzebujesz najnowszej wersji Visual Studio 2022
1. Zainstaluj Visual Studio lub zmodyfikuj istniejącą instalację, a następnie zainstaluj zadanie deweloperskie .NET Multi-platform App UI z domyślnymi opcjami instalacyjnymi:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## Utwórz projekt

1. Uruchom Visual Studio. W oknie startowym kliknij Utwórz nowy projekt, aby stworzyć nowy projekt:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. W oknie Utwórz nowy projekt wybierz MAUI w rozwijanej liście Wszystkie typy projektów, wybierz szablon aplikacji .NET MAUI i kliknij przycisk Dalej:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. W oknie Konfiguruj swój nowy projekt, nadaj swojemu projektowi nazwę, wybierz odpowiednią lokalizację dla niego i kliknij przycisk Dalej:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. W oknie Dodatkowe informacje wybierz wersję .NET, którą chcesz obsługiwać i kliknij przycisk Utwórz:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Poczekaj, aż projekt zostanie utworzony, a zależności przywrócone
1. Zainstaluj najnowszą wersję Aspose.CAD z NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Zastąp kod w MainPage.xaml
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
            Text="Witamy w .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Uroczy bot dotnet machający do Ciebie!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Witaj, świecie!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Witamy w .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Witamy w dotnet Multi platform App UI"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Wybierz plik"
                SemanticProperties.Hint="Zlicza ile razy klikasz"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Wyczyść"
                SemanticProperties.Hint="Zlicza ile razy klikasz"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Dodaj nowe metody w MainPage.xaml.cs
{{% alert color="primary" %}} 
Nie zapomnij dodać using Aspose.CAD i using Aspose.CAD.ImageOptions w pliku.
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
        PickerTitle = "dowolny"
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


## Debugowanie na komputerze z Windows

1. W pasku narzędzi Visual Studio użyj rozwijanej listy Cel debugowania, aby wybrać Framework, a następnie wpis net7.0-windows:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. W pasku narzędzi Visual Studio naciśnij przycisk Komputer z Windows, aby zbudować i uruchomić aplikację:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. W działającej aplikacji naciśnij przycisk "Wybierz plik" kilka razy i zauważ, że liczba kliknięć przycisku wzrasta:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Wybierz wymagany plik i kliknij otwórz:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. Po przetworzeniu pliku, obraz przetworzonego pliku powinien pojawić się na ekranie:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## Instalacja Emulatora Androida

1. W pasku narzędzi Visual Studio użyj rozwijanej listy Cel debugowania, aby wybrać Emulator Androida, a następnie wybierz wpis Emulator Androida
1. W pasku narzędzi Visual Studio naciśnij przycisk Emulator Androida:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. W oknie Umowa licencyjna SDK Androida, naciśnij przycisk Akceptuj:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. W oknie Umowa licencyjna SDK Androida, naciśnij przycisk Akceptuj:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. W oknie Kontrola konta użytkownika naciśnij przycisk Tak:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. W oknie Akceptacja licencji naciśnij przycisk Akceptuj:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. W pasku narzędzi Visual Studio naciśnij przycisk Emulator Androida:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. W oknie Kontrola konta użytkownika, naciśnij przycisk Tak:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. W oknie Nowe urządzenie naciśnij przycisk Utwórz:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Zamknij okno Menedżera urządzeń Android


## Debugowanie z Emulatora Androida

1. W pasku narzędzi Visual Studio naciśnij przycisk Pixel 5 - API 33 (Android 13.0 - API 33), aby zbudować i uruchomić aplikację:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. W działającej aplikacji w emulatorze Android naciśnij przycisk "Wybierz plik" kilka razy i zauważ, że liczba kliknięć przycisku wzrasta:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Wybierz wymagany plik i kliknij wybierz:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. Po przetworzeniu pliku, obraz przetworzonego pliku powinien pojawić się na ekranie:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## Więcej przykładów

Aby zobaczyć więcej przykładów użycia Aspose.CAD w Dockerze, zobacz [przykłady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Zobacz także.

- [Zainstaluj AWS Toolkit dla Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Zainstaluj Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Zainstaluj Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 7](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Przełącz na kontenery Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opcja
- Dodatkowe informacje na temat [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
