---
title: Comment exécuter Aspose.CAD dans l'interface utilisateur d'application multiplateforme (MAUI)
type: docs
description: "Exécuter Aspose.CAD dans une interface utilisateur d'application multiplateforme (MAUI)."
weight: 71
url: /fr/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Prérequis
- Visual Studio 2022.
- Le SDK .NET 7 est utilisé dans l'exemple.


## MAUI

L'interface utilisateur d'application multiplateforme .NET (.NET MAUI) est un cadre multiplateforme pour créer des applications mobiles et de bureau natives avec C# et XAML.
Avec .NET MAUI, vous pouvez développer des applications qui peuvent fonctionner sur Android, iOS, macOS et Windows à partir d'une base de code partagée unique.

.NET MAUI est open-source et est l'évolution de Xamarin.Forms, étendue des scénarios mobiles aux scénarios de bureau, avec des contrôles UI reconstruits de zéro pour la performance et l'extensibilité.
Si vous avez déjà utilisé Xamarin.Forms pour créer des interfaces utilisateur multiplateformes, vous remarquerez de nombreuses similarités avec .NET MAUI.
Cependant, il existe également certaines différences.
Avec .NET MAUI, vous pouvez créer des applications multiplateformes à l'aide d'un seul projet, mais vous pouvez ajouter du code source spécifique à la plateforme et des ressources si nécessaire.
L'un des principaux objectifs de .NET MAUI est de vous permettre de mettre en œuvre autant de logique de votre application et de mise en page UI que possible dans une seule base de code.


## Installation de MAUI

1. Pour créer des applications .NET MAUI, vous aurez besoin de la version la plus récente de Visual Studio 2022
1. Soit installez Visual Studio, soit modifiez votre installation existante, et installez la charge de travail de développement de l'interface utilisateur d'application multiplateforme .NET avec ses options d'installation optionnelles par défaut :<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## Créer un projet

1. Lancez Visual Studio. Dans la fenêtre de démarrage, cliquez sur Créer un nouveau projet pour créer un nouveau projet :<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. Dans la fenêtre Créer un nouveau projet, sélectionnez MAUI dans le menu déroulant Tous les types de projets, sélectionnez le modèle d'application .NET MAUI et cliquez sur le bouton Suivant :<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. Dans la fenêtre Configurer votre nouveau projet, nommez votre projet, choisissez un emplacement approprié pour celui-ci et cliquez sur le bouton Suivant :<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. Dans la fenêtre Informations supplémentaires, choisissez la version de .NET que vous souhaitez cibler et cliquez sur le bouton Créer :<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. Attendez que le projet soit créé et que ses dépendances soient restaurées
1. Installez la dernière version d'Aspose.CAD depuis NuGet :<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. Remplacez le code dans MainPage.xaml
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
            Text="Bienvenue dans .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Mignon petit bot dot net qui vous fait signe!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Bonjour, le monde !"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Bienvenue dans l'interface utilisateur d'application multiplateforme .NET"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Bienvenue dans l'interface utilisateur d'application multiplateforme dot net"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Sélectionner un fichier"
                SemanticProperties.Hint="Comptez le nombre de fois que vous cliquez"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Effacer"
                SemanticProperties.Hint="Comptez le nombre de fois que vous cliquez"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Ajoutez de nouvelles méthodes dans MainPage.xaml.cs
{{% alert color="primary" %}} 
N'oubliez pas d'ajouter using Aspose.CAD et using Aspose.CAD.ImageOptions dans le fichier.
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


## Déboguer un ordinateur Windows

1. Dans la barre d'outils Visual Studio, utilisez le menu déroulant Cible de débogage pour sélectionner Framework, puis l'entrée net7.0-windows :<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. Dans la barre d'outils Visual Studio, appuyez sur le bouton Ordinateur Windows pour construire et exécuter l'application :<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. Dans l'application en cours d'exécution, appuyez plusieurs fois sur le bouton "Sélectionner un fichier" et observez que le nombre de clics sur le bouton augmente :<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. Sélectionnez le fichier requis et cliquez sur ouvrir :<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. Après le traitement du fichier, une image du fichier converti devrait apparaître à l'écran :<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Installer l'émulateur Android

1. Dans la barre d'outils Visual Studio, utilisez le menu déroulant Cible de débogage pour sélectionner Émulateurs Android, puis l'entrée Émulateur Android
1. Dans la barre d'outils Visual Studio, appuyez sur le bouton Émulateur Android :<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Dans la fenêtre Accord de licence du SDK Android, appuyez sur le bouton Accepter :<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Dans la fenêtre Accord de licence du SDK Android, appuyez sur le bouton Accepter :<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. Dans la boîte de dialogue Contrôle de compte d'utilisateur, appuyez sur le bouton Oui :<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. Dans la fenêtre Acceptation de la licence, appuyez sur le bouton Accepter :<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. Dans la barre d'outils Visual Studio, appuyez sur le bouton Émulateur Android :<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Dans la boîte de dialogue Contrôle de compte d'utilisateur, appuyez sur le bouton Oui :<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. Dans la fenêtre Nouvel appareil, appuyez sur le bouton Créer :<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Fermez la fenêtre du Gestionnaire d'appareils Android


## Déboguer avec l'émulateur Android

1. Dans la barre d'outils Visual Studio, appuyez sur le bouton Pixel 5 - API 33 (Android 13.0 - API 33) pour construire et exécuter l'application :<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. Dans l'application en cours d'exécution dans l'émulateur Android, appuyez plusieurs fois sur le bouton "Sélectionner un fichier" et observez que le nombre de clics sur le bouton augmente :<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. Sélectionnez le fichier requis et cliquez sur sélectionner :<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. Après le traitement du fichier, une image du fichier converti devrait apparaître à l'écran :<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## Plus d'exemples

Pour plus d'exemples sur la façon d'utiliser Aspose.CAD dans Docker, consultez les [exemples](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Voir aussi.

- [Installer AWS Toolkit pour Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installer Docker Desktop sur Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installer Docker Desktop sur Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 7](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Passer aux conteneurs Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option
- Informations supplémentaires sur le [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
