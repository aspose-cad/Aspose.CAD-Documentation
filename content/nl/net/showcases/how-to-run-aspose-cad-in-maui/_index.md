---
title: Hoe Aspose.CAD te draaien in Multi-platform App UI(MAUI)
type: docs
description: "Draaien Aspose.CAD in een Multi-platform App UI(MAUI)."
weight: 71
url: /nl/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Vereisten
- Visual Studio 2022.
- NET 7 SDK wordt gebruikt in het voorbeeld.


## MAUI

.NET Multi-platform App UI (.NET MAUI) is een cross-platform framework voor het creëren van native mobiele en desktop apps met C# en XAML.  
Met .NET MAUI kunt u apps ontwikkelen die op Android, iOS, macOS en Windows kunnen draaien vanuit een enkele gedeelde codebasis.

.NET MAUI is open-source en is de evolutie van Xamarin.Forms, uitgebreid van mobiele naar desktop scenario's, met UI-controllen die vanaf de grond opnieuw zijn opgebouwd voor prestaties en uitbreidbaarheid.  
Als u eerder Xamarin.Forms hebt gebruikt om cross-platform gebruikersinterfaces te bouwen, zult u veel overeenkomsten met .NET MAUI opmerken.  
Er zijn echter ook enkele verschillen.  
Met .NET MAUI kunt u multi-platform apps creëren met behulp van een enkel project, maar u kunt indien nodig platform-specifieke broncode en middelen toevoegen.  
Een van de belangrijkste doelstellingen van .NET MAUI is om u in staat te stellen zoveel mogelijk van uw app-logica en UI-indeling in één codebasis te implementeren.


## Installatie MAUI

1. Om .NET MAUI-apps te maken, heeft u de nieuwste versie van Visual Studio 2022 nodig.
1. Installeer Visual Studio of wijzig uw bestaande installatie en installeer de .NET Multi-platform App UI ontwikkelwerkbelasting met de standaardopties voor optionele installatie:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## Project aanmaken

1. Start Visual Studio. Klik in het startvenster op Een nieuw project maken om een nieuw project te creëren:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. Selecteer in het venster Een nieuw project maken MAUI in de vervolgkeuzelijst Alle projecttypen, selecteer de .NET MAUI-apptemplate en klik op de knop Volgende:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. Geef in het venster Configureer uw nieuwe project een naam voor uw project, kies een geschikte locatie en klik op de knop Volgende:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. Kies in het venster Extra informatie de versie van .NET waarop u wilt richten en klik op de knop Maken:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Wacht tot het project is aangemaakt en zijn afhankelijkheden zijn hersteld.
1. Installeer de nieuwste versie van Aspose.CAD vanuit NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Vervang de code in MainPage.xaml
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
            Text="Welkom bij .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Schattige dot net bot die hi naar je zwaait!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Hallo, Wereld!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Welkom bij .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Welkom bij dot net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Bestand selecteren"
                SemanticProperties.Hint="Tel het aantal keren dat je klikt"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Wissen"
                SemanticProperties.Hint="Tel het aantal keren dat je klikt"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Voeg nieuwe methoden toe in MainPage.xaml.cs
{{% alert color="primary" %}} 
Vergeet niet om using Aspose.CAD en using Aspose.CAD.ImageOptions in het bestand toe te voegen.
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
        PickerTitle = "enig"
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


## Debuggen op Windows-machine

1. Gebruik op de Visual Studio werkbalk de vervolgkeuzelijst Debugdoel om Framework te selecteren en vervolgens de net7.0-windows-invoer:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. Druk op de Visual Studio-werkbalk op de knop Windows-machine om de app te bouwen en uit te voeren:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. Druk in de draaiende app verschillende keren op de knop "Selecteer bestand" en observeer dat het aantal keren dat op de knop is geklikt toeneemt:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Selecteer het vereiste bestand en klik op openen:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. Na de verwerking van het bestand moet er een afbeelding van het geconverteerde bestand op het scherm verschijnen:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## Installeer Android Emulator

1. Gebruik op de Visual Studio werkbalk de vervolgkeuzelijst Debugdoel om Android-emulators te selecteren en vervolgens de Android-emulatorinvoer te selecteren.
1. Druk op de Visual Studio-werkbalk op de knop Android Emulator:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Druk in het venster Android SDK - Licentieovereenkomst op de knop Accepteren:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. Druk in het venster Android SDK - Licentieovereenkomst op de knop Accepteren:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. Druk in het dialoogvenster Gebruikersaccountbeheer op de knop Ja:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. Druk in het venster Acceptatie van licentie op de knop Accepteren:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. Druk op de Visual Studio-werkbalk op de knop Android Emulator:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Druk in het dialoogvenster Gebruikersaccountbeheer op de knop Ja:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. Druk in het venster Nieuw apparaat op de knop Maken:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Sluit het venster Android Device Manager.


## Debuggen met Android Emulator

1. Druk op de Visual Studio-werkbalk op de knop Pixel 5 - API 33 (Android 13.0 - API 33) om de app te bouwen en uit te voeren:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. Druk in de draaiende app in de Android-emulator meerdere keren op de knop "Selecteer bestand" en observeer dat het aantal keren dat op de knop is geklikt toeneemt:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Selecteer het vereiste bestand en klik op selecteren:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. Na de verwerking van het bestand moet er een afbeelding van het geconverteerde bestand op het scherm verschijnen:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## Meer Voorbeelden

Voor meer voorbeelden van hoe u Aspose.CAD in Docker kunt gebruiken, zie de [voorbeelden](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Zie Ook.

- [Installeer AWS Toolkit voor Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installeer Docker Desktop op Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installeer Docker Desktop op Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Schakel over naar Linux-containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) optie
- Aanvullende informatie over [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
