---
title: Hur man kör Aspose.CAD i Multi-platform App UI (MAUI)
type: docs
description: "Kör Aspose.CAD i en Multi-platform App UI (MAUI)."
weight: 71
url: /sv/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Förutsättningar
- Visual Studio 2022.
- NET 7 SDK används i exemplet.


## MAUI

.NET Multi-platform App UI (.NET MAUI) är ett plattformsoberoende ramverk för att skapa inbyggda mobil- och skrivbordsappar med C# och XAML.
Med .NET MAUI kan du utveckla appar som kan köras på Android, iOS, macOS och Windows från en enda delad kodbas.

.NET MAUI är öppen källkod och är utvecklingen av Xamarin.Forms, utvidgad från mobil till skrivbordsscenarier, med användargränssnittskontroller ombyggda från grunden för prestanda och utbyggbarhet.
Om du tidigare har använt Xamarin.Forms för att bygga plattformsoberoende användargränssnitt kommer du att märka många likheter med .NET MAUI.
Det finns emellertid också vissa skillnader.
Med .NET MAUI kan du skapa plattformsoberoende appar med ett enda projekt, men du kan lägga till plattformspecifik källkod och resurser om det behövs.
Ett av de viktiga målen med .NET MAUI är att möjliggöra för dig att implementera så mycket av din app-logik och UI-layout som möjligt i en enda kodbas.


## Installation MAUI

1. För att skapa .NET MAUI-appar behöver du den senaste versionen av Visual Studio 2022
1. Antingen installera Visual Studio eller modifiera din befintliga installation och installera .NET Multi-platform App UI utvecklingsarbetsbelastning med dess standardalternativ för valfri installation:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## Skapa projekt

1. Starta Visual Studio. I startfönstret, klicka på Skapa ett nytt projekt för att skapa ett nytt projekt:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. I fönstret Skapa ett nytt projekt, välj MAUI i rullgardinsmenyn för Alla projekttyper, välj .NET MAUI App-mallen och klicka på Nästa-knappen:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. I fönstret Konfigurera ditt nya projekt, namnge ditt projekt, välj en lämplig plats för det och klicka på Nästa-knappen:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. I fönstret Ytterligare information, välj den version av .NET som du vill rikta in dig på och klicka på Skapa-knappen:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Vänta på att projektet ska skapas och dess beroenden återställas
1. Installera den senaste versionen av Aspose.CAD från NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Ersätt koden i MainPage.xaml
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
            Text="Välkommen till .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Söt dot net-bot som vinkar hej till dig!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Hej, världen!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Välkommen till .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Välkommen till dot net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Välj fil"
                SemanticProperties.Hint="Räknar antalet gånger du klickar"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Rensa"
                SemanticProperties.Hint="Räknar antalet gånger du klickar"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Lägg till nya metoder i MainPage.xaml.cs
{{% alert color="primary" %}} 
Glöm inte att lägga till using Aspose.CAD och using Aspose.CAD.ImageOptions i filen.
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


## Felsök Windows-maskin

1. I Visual Studio-menyn, använd rullgardinsmenyn för Felsök mål för att välja Ramverk och sedan net7.0-windows-posten:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. I Visual Studio-menyn, tryck på Windows-maskinknappen för att bygga och köra appen:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. I den körande appen, tryck på "Välj fil"-knappen flera gånger och observera att antalet knapptryckningar ökar:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Välj den nödvändiga filen och klicka på öppna:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. Efter att filen har bearbetats bör en bild av den konverterade filen dyka upp på skärmen:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## Installera Android Emulator

1. I Visual Studio-menyn, använd rullgardinsmenyn för Felsök mål för att välja Android Emulatorer och sedan Android Emulator-posten
1. I Visual Studio-menyn, tryck på Android Emulator-knappen:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. I fönstret Android SDK - Licensavtal, tryck på Acceptera-knappen:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. I fönstret Android SDK - Licensavtal, tryck på Acceptera-knappen:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. I dialogrutan för användarkontroll, tryck på Yes-knappen:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. I fönstret Licensacceptans, tryck på Acceptera-knappen:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. I Visual Studio-menyn, tryck på Android Emulator-knappen:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. I dialogrutan för användarkontroll, tryck på Yes-knappen:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. I fönstret Ny enhet, tryck på Skapa-knappen:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Stäng fönstret Android Device Manager


## Felsöka med Android Emulator

1. I Visual Studio-menyn, tryck på Pixel 5 - API 33 (Android 13.0 - API 33)-knappen för att bygga och köra appen:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. I den körande appen i Android-emulatorn, tryck på "Välj fil"-knappen flera gånger och observera att antalet knapptryckningar ökar:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Välj den nödvändiga filen och klicka på välj:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. Efter att filen har bearbetats bör en bild av den konverterade filen dyka upp på skärmen:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## Fler exempel

För fler exempel på hur du kan använda Aspose.CAD i Docker, se [exemplen](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Se även.

- [Installera AWS Toolkit för Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installera Docker Desktop på Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installera Docker Desktop på Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Byt till Linux-containrar](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) alternativ
- Ytterligare information om [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
