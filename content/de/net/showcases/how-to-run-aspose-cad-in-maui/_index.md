---
title: So führen Sie Aspose.CAD in der Multi-Plattform-Anwendungs-UI (MAUI) aus
type: docs
description: "Führen Sie Aspose.CAD in einer Multi-Plattform-Anwendungs-UI (MAUI) aus."
weight: 71
url: /de/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Voraussetzungen
- Visual Studio 2022.
- .NET 7 SDK wird im Beispiel verwendet.


## MAUI

.NET Multi-Plattform-Anwendungs-UI (.NET MAUI) ist ein plattformübergreifendes Framework zur Erstellung nativer mobiler und Desktop-Anwendungen mit C# und XAML.
Mit .NET MAUI können Sie Anwendungen entwickeln, die von einer einzigen gemeinsam genutzten Codebasis auf Android, iOS, macOS und Windows ausgeführt werden können.

.NET MAUI ist Open Source und die Evolution von Xamarin.Forms, erweitert von mobilen zu Desktop-Szenarien, mit UI-Steuerelementen, die von Grund auf für Leistung und Erweiterbarkeit neu entwickelt wurden.
Wenn Sie zuvor Xamarin.Forms verwendet haben, um plattformübergreifende Benutzeroberflächen zu erstellen, werden Sie viele Ähnlichkeiten mit .NET MAUI feststellen.
Es gibt jedoch auch einige Unterschiede.
Mit .NET MAUI können Sie Multi-Plattform-Anwendungen mit einem einzigen Projekt erstellen, aber Sie können bei Bedarf plattformspezifischen Quellcode und Ressourcen hinzufügen.
Eines der Hauptziele von .NET MAUI ist es, Ihnen zu ermöglichen, so viel wie möglich von Ihrer Anwendungslogik und Ihrem UI-Layout in einer einzigen Codebasis zu implementieren.


## Installation MAUI

1. Um .NET MAUI-Anwendungen zu erstellen, benötigen Sie die neueste Version von Visual Studio 2022
1. Installieren Sie entweder Visual Studio oder ändern Sie Ihre vorhandene Installation und installieren Sie die Entwicklungsarbeitslast für .NET Multi-Plattform-Anwendungs-UI mit den Standardoptionen für die optionale Installation:<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## Projekt erstellen

1. Starten Sie Visual Studio. Klicken Sie im Startfenster auf Neues Projekt erstellen, um ein neues Projekt zu erstellen:<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. Wählen Sie im Fenster Neues Projekt erstellen im Dropdown Menü "Alle Projekttypen" MAUI aus, wählen Sie die .NET MAUI App-Vorlage und klicken Sie auf die Schaltfläche Weiter:<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. Geben Sie im Fenster Konfigurieren Sie Ihr neues Projekt einen Namen für Ihr Projekt an, wählen Sie einen geeigneten Speicherort und klicken Sie auf die Schaltfläche Weiter:<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. Wählen Sie im Fenster Zusätzliche Informationen die Version von .NET aus, auf die Sie abzielen möchten, und klicken Sie auf die Schaltfläche Erstellen:<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. Warten Sie, bis das Projekt erstellt und seine Abhängigkeiten wiederhergestellt sind
1. Installieren Sie die neueste Aspose.CAD-Version von NuGet:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. Ersetzen Sie den Code in MainPage.xaml
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
            Text="Willkommen bei .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Süßer Dot-Net-Bot, der Ihnen zuwinkt!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Hallo, Welt!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Willkommen bei .NET Multi-Plattform-Anwendungs-UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Willkommen bei Dot Net Multi Plattform Anwendungs UI"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Datei auswählen"
                SemanticProperties.Hint="Zählt die Anzahl der Klicks"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Löschen"
                SemanticProperties.Hint="Zählt die Anzahl der Klicks"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Fügen Sie neue Methoden in MainPage.xaml.cs hinzu
{{% alert color="primary" %}} 
Vergessen Sie nicht, using Aspose.CAD und using Aspose.CAD.ImageOptions in die Datei hinzuzufügen.
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
        PickerTitle = "irgendeine"
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


## Debuggen auf Windows Maschine

1. Wählen Sie in der Visual Studio-Toolleiste im Dropdown Menü Debugziel die Option Framework und dann den Eintrag net7.0-windows:<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. Drücken Sie in der Visual Studio-Toolleiste die Schaltfläche Windows-Maschine, um die App zu erstellen und auszuführen:<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. Drücken Sie in der laufenden App mehrmals die Schaltfläche "Datei auswählen" und beobachten Sie, dass die Anzahl der Button-Klicks erhöht wird:<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. Wählen Sie die erforderliche Datei aus und klicken Sie auf Öffnen:<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. Nach der Verarbeitung der Datei sollte ein Bild der konvertierten Datei auf dem Bildschirm angezeigt werden:<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Installieren des Android-Emulators

1. Wählen Sie in der Visual Studio-Toolleiste im Dropdown Menü Debugziel Android-Emulatoren und dann den Eintrag Android-Emulator aus.
1. Drücken Sie in der Visual Studio-Toolleiste die Schaltfläche Android-Emulator:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Drücken Sie im Fenster Lizenzvereinbarung des Android SDK die Schaltfläche Akzeptieren:<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Drücken Sie im Fenster Lizenzvereinbarung des Android SDK die Schaltfläche Akzeptieren:<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. Drücken Sie im Dialogfeld Benutzerkontensteuerung die Schaltfläche Ja:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. Drücken Sie im Fenster Lizenzannahme die Schaltfläche Akzeptieren:<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. Drücken Sie in der Visual Studio-Toolleiste die Schaltfläche Android-Emulator:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Drücken Sie im Dialogfeld Benutzerkontensteuerung die Schaltfläche Ja:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. Drücken Sie im Fenster Neues Gerät die Schaltfläche Erstellen:<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Schließen Sie das Fenster Android-Geräte-Manager


## Debugging mit Android-Emulator

1. Drücken Sie in der Visual Studio-Toolleiste die Schaltfläche Pixel 5 - API 33 (Android 13.0 - API 33), um die App zu erstellen und auszuführen:<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. Drücken Sie in der laufenden App im Android-Emulator mehrmals die Schaltfläche "Datei auswählen" und beobachten Sie, dass die Anzahl der Button-Klicks erhöht wird:<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. Wählen Sie die erforderliche Datei aus und klicken Sie auf Auswählen:<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. Nach der Verarbeitung der Datei sollte ein Bild der konvertierten Datei auf dem Bildschirm angezeigt werden:<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## Weitere Beispiele

Für weitere Beispiele, wie Sie Aspose.CAD in Docker verwenden können, siehe die [Beispiele](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Siehe auch.

- [Installieren Sie das AWS-Toolkit für Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installieren Sie Docker Desktop unter Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installieren Sie Docker Desktop auf dem Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Wechseln zu Linux-Containern](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) Option
- Zusätzliche Informationen zum [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
