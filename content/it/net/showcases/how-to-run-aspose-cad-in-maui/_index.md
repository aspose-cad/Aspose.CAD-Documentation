---
title: Come Eseguire Aspose.CAD in un'App UI Multi-piattaforma (MAUI)
type: docs
description: "Esegui Aspose.CAD in un'App UI Multi-piattaforma (MAUI)."
weight: 71
url: /it/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Prerequisiti
- Visual Studio 2022.
- SDK .NET 7 utilizzato nell'esempio.


## MAUI

.NET Multi-platform App UI (.NET MAUI) è un framework cross-platform per creare app native per dispositivi mobile e desktop con C# e XAML.
Utilizzando .NET MAUI, puoi sviluppare app che possono essere eseguite su Android, iOS, macOS e Windows da un'unica base di codice condivisa.

.NET MAUI è open-source ed è l'evoluzione di Xamarin.Forms, esteso da scenari mobile a desktop, con controlli UI ricostruiti da zero per prestazioni ed estensibilità.
Se hai precedentemente utilizzato Xamarin.Forms per costruire interfacce utente cross-platform, noterai molte somiglianze con .NET MAUI.
Tuttavia, ci sono anche alcune differenze.
Con .NET MAUI, puoi creare app multi-piattaforma utilizzando un unico progetto, ma puoi aggiungere codice sorgente e risorse specifiche per la piattaforma se necessario.
Uno degli obiettivi principali di .NET MAUI è permetterti di implementare quanto più possibile della logica della tua app e del layout UI in un'unica base di codice.


## Installazione di MAUI

1. Per creare app .NET MAUI, avrai bisogno dell'ultima versione di Visual Studio 2022
1. Installa Visual Studio, oppure modifica l'installazione esistente, e installa il carico di lavoro per lo sviluppo di .NET Multi-platform App UI con le sue opzioni di installazione predefinite:<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## Crea progetto

1. Avvia Visual Studio. Nella finestra di avvio, fai clic su Crea un nuovo progetto per creare un nuovo progetto:<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. Nella finestra Crea un nuovo progetto, seleziona MAUI nel menu a discesa Tutti i tipi di progetto, seleziona il modello di App .NET MAUI e fai clic sul pulsante Avanti:<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. Nella finestra Configura il tuo nuovo progetto, dai un nome al tuo progetto, scegli una posizione adeguata per esso e fai clic sul pulsante Avanti:<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. Nella finestra Ulteriori informazioni, scegli la versione di .NET che desideri targettare e fai clic sul pulsante Crea:<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. Attendi che il progetto venga creato e che le sue dipendenze vengano ripristinate
1. Installa l'ultima versione di Aspose.CAD da NuGet:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. Sostituisci il codice in MainPage.xaml
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
            Text="Benvenuto in .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Carino dot net bot che ti saluta!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Ciao, Mondo!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Benvenuto in .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Benvenuto in dot net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Seleziona file"
                SemanticProperties.Hint="Conta il numero di volte che clicchi"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Pulisci"
                SemanticProperties.Hint="Conta il numero di volte che clicchi"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Aggiungi nuovi metodi in MainPage.xaml.cs
{{% alert color="primary" %}} 
Non dimenticare di aggiungere using Aspose.CAD e using Aspose.CAD.ImageOptions nel file.
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
        PickerTitle = "qualunque"
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


## Debug su Macchina Windows

1. Nella barra degli strumenti di Visual Studio, utilizza il menu a discesa Debug Target per selezionare Framework e poi l'entry net7.0-windows:<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. Nella barra degli strumenti di Visual Studio, premi il pulsante Windows Machine per compilare ed eseguire l'app:<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. Nell'app in esecuzione, premi il pulsante "Seleziona file" diverse volte e osserva che il conteggio dei clic sui pulsanti aumenta:<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. Seleziona il file richiesto e fai clic su apri:<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. Dopo aver elaborato il file, un'immagine del file convertito dovrebbe apparire sullo schermo:<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Installa Emulator Android

1. Nella barra degli strumenti di Visual Studio, utilizza il menu a discesa Debug Target per selezionare Android Emulators e poi l'entry Android Emulator
1. Nella barra degli strumenti di Visual Studio, premi il pulsante Android Emulator:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Nella finestra dell'Accordo di Licenza dell'SDK Android, premi il pulsante Accetta:<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Nella finestra dell'Accordo di Licenza dell'SDK Android, premi il pulsante Accetta:<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. Nella finestra di Controllo dell'Account Utente, premi il pulsante Sì:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. Nella finestra di Accettazione della Licenza, premi il pulsante Accetta:<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. Nella barra degli strumenti di Visual Studio, premi il pulsante Android Emulator:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Nella finestra di Controllo dell'Account Utente, premi il pulsante Sì:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. Nella finestra Nuovo Dispositivo, premi il pulsante Crea:<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Chiudi la finestra di Android Device Manager


## Debug con Emulator Android

1. Nella barra degli strumenti di Visual Studio, premi il pulsante Pixel 5 - API 33 (Android 13.0 - API 33) per compilare ed eseguire l'app:<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. Nell'app in esecuzione nell'emulatore Android, premi il pulsante "Seleziona file" diverse volte e osserva che il conteggio dei clic sui pulsanti aumenta:<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. Seleziona il file richiesto e fai clic su seleziona:<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. Dopo aver elaborato il file, un'immagine del file convertito dovrebbe apparire sullo schermo:<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## Altri Esempi

Per ulteriori esempi su come puoi utilizzare Aspose.CAD in Docker, consulta gli [esempi](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Vedi Anche.

- [Installa AWS Toolkit per Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installa Docker Desktop su Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installa Docker Desktop su Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 7](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Passa a contenitori Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opzione
- Ulteriori informazioni su [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
