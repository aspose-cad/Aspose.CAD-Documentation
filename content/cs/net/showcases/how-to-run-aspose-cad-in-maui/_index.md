---
title: Jak spustit Aspose.CAD v multiplatformní aplikaci UI(MAUI)
type: docs
description: "Spusťte Aspose.CAD v multiplatformní aplikaci UI(MAUI)."
weight: 71
url: /cs/jak-spustit-aspose-cad-v-maui
---

## Předpoklady
- Visual Studio 2022.
- Pro příklad je použit .NET 7 SDK.


## MAUI

.NET Multi-platform App UI (.NET MAUI) je framework pro vytváření nativních mobilních a desktopových aplikací s C# a XAML.
Pomocí .NET MAUI můžete vyvíjet aplikace, které mohou běžet na zařízeních s Androidem, iOS, macOS a Windows z jedné sdílené kódbáze.

.NET MAUI je open-source a je to evoluce Xamarin.Forms, rozšířená z mobilních na desktopové scénáře, s ovládacími prvky uživatelského rozhraní postavenými od základů pro výkon a rozšiřitelnost.
Pokud jste dříve používali Xamarin.Forms k vytváření uživatelských rozhraní pro více platforem, všimnete si mnoha podobností s .NET MAUI.
Nicméně existují také některé rozdíly.
Pomocí .NET MAUI můžete vytvářet multiplatformní aplikace pomocí jednoho projektu, ale případně můžete přidat platformně specifický zdrojový kód a prostředky.
Jedním z klíčových cílů .NET MAUI je umožnit vám implementovat co nejvíce logiky aplikace a rozvržení uživatelského rozhraní v jedné kódbázi.

## Instalace MAUI

1. Pro vytvoření aplikací .NET MAUI budete potřebovat nejnovější verzi Visual Studia 2022
1. Buď nainstalujte Visual Studio, nebo upravte již existující instalaci a nainstalujte pracovní zátěž vývoje .NET Multi-platform App UI s výchozími volitelnými instalačními možnostmi:<br>
![Vizuální instalátor](visual-installer.png)


## Vytvoření projektu

1. Spusťte Visual Studio. V úvodním okně klikněte na Vytvořit nový projekt pro vytvoření nového projektu:<br>
![Vytvořit projekt](create-project.png)<br>
1. V okně Vytvořit nový projekt vyberte MAUI v rozbalovacím seznamu Všechny typy projektů, vyberte šablonu Aplikace .NET MAUI a klikněte na tlačítko Další:<br>
![Vybrat typ projektu](select-project.png)<br>
1. V okně Konfigurovat nový projekt pojmenujte svůj projekt, vyberte pro něj vhodné umístění a klikněte na tlačítko Další:<br>
![Vybrat cestu projektu](select-project-path.png)<br>
1. V okně Další informace vyberte verzi .NET, pro kterou chcete cílit, a klikněte na tlačítko Vytvořit:<br>
![Cílový rámec](select-framework.png)<br>
1. Počkejte, dokud bude projekt vytvořen a jeho závislosti obnoveny
1. Nainstalujte nejnovější verzi Aspose.CAD z NuGet:<br>
![NuGet](nuget.png)<br>
1. Nahraďte kód v MainPage.xaml
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
            Text="Vítejte v .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Rozkošný robot dot net vám mává ahoj!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Ahoj, světe!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Vítejte v .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Vítejte v dot net Multiplatformní aplikaci U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Vybrat soubor"
                SemanticProperties.Hint="Počítá počet kliknutí na tlačítko"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Vymazat"
                SemanticProperties.Hint="Počítá počet kliknutí na tlačítko"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Přidejte nové metody do MainPage.xaml.cs
{{% alert color="primary" %}} 
Nesmíte zapomenout přidat using Aspose.CAD a using Aspose.CAD.ImageOptions do souboru.
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
        PickerTitle = "libovolný"
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


## Ladicí režim na Windows

1. V nástrojovém řádku Visual Studia použijte rozbalovací seznam Cíl ladicího režimu pro výběr Frameworku a poté položku net7.0-windows:<br>
![Cíl ladicího režimu](windows-mode.png)<br>
1. V nástrojovém řádku Visual Studia stiskněte tlačítko Windows Machine pro sestavení a spuštění aplikace:<br>
![Spustit ladění na Windows Machine](windows-start-debug.png)<br>
1. V běžící aplikaci stiskněte tlačítko "Vybrat soubor" několikrát a sledujte, že se počet kliknutí na tlačítko zvýší:<br>
![Domovská stránka](windows-home-page.png)<br>
1. Vyberte požadovaný soubor a klikněte na otevřít:<br>
![Vybrat soubor](select-file.png)<br>
1. Po zpracování souboru by se na obrazovce měl zobrazit obrázek konvertovaného souboru:<br>
![Výsledek ladění windows](windows-result.png)


## Instalace Android Emulátoru

1. V nástrojovém řádku Visual Studia použijte rozbalovací seznam Cíl ladicího režimu pro výběr Android Emulatoru a poté položku Android Emulator
1. V nástrojovém řádku Visual Studia stiskněte tlačítko Android Emulator:<br>
![Spustit tlačítko instalace Emulátoru](start-install-emulator.png)<br>
1. V okně Android SDK - Smluvní podmínky stiskněte tlačítko Přijmout:<br>
![Android SDK-Smluvní podmínky](android-sdk-1.png)<br>
1. V okně Android SDK - Smluvní podmínky stiskněte tlačítko Přijmout:<br>
![Android SDK ARM- Smluvní podmínky](android-sdk-2.png)<br>
1. V dialogu Uživatelského účtu stiskněte tlačítko Ano:<br>
![Správce SDK](android-sdk-3.png)<br>
1. V okně Přijetí licence stiskněte tlačítko Přijmout:<br>
![Správce SDK ARM- Smluvní podmínky](android-sdk-4.png)<br>
1. V nástrojovém řádku Visual Studia stiskněte tlačítko Android Emulator:<br>
![Spustit tlačítko instalace Emulátoru](start-install-emulator.png)<br>
1. V dialogu Uživatelského účtu stiskněte tlačítko Ano:<br>
![Správce zařízení Android](android-device-manager.png)<br>
1. V okně Nové zařízení stiskněte tlačítko Vytvořit:<br>
![Nové zařízení Android](android-new-device.png)<br>
1. Zavřete okno Správce zařízení Android


## Ladění s Android Emulátorem

1. V nástrojovém řádku Visual Studia stiskněte tlačítko Pixel 5 - API 33 (Android 13.0 - API 33) pro sestavení a spuštění aplikace:<br>
![Vybrat android Emulator](select-android-emulator.png)<br>
1. V běžící aplikaci v Android emulátoru stiskněte tlačítko "Vybrat soubor" několikrát a sledujte, že se počet kliknutí na tlačítko zvýší:<br>
![Domovská stránka Android Emulátoru](android-home-page.png)<br>
1. Vyberte požadovaný soubor a klikněte na vybrat:<br>
![Vybrat soubor v Androidu](android-select-file.png)<br>
1. Po zpracování souboru by se na obrazovce měl zobrazit obrázek konvertovaného souboru:<br>
![Výsledek ladění android](android-result.png)


## Další Příklady

Pro více vzorů použití Aspose.CAD v Dockeru podívejte se na [příklady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Viz také.

- [Instalovat AWS Toolkit for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instalovat Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalovat Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- Možnost [Přepnout na Linuxové kontejnery](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Další informace o [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
