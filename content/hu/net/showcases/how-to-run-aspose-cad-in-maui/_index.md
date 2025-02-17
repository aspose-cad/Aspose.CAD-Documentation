---
title: Hogyan futtassuk az Aspose.CAD-ot Multi-platform App UI (MAUI) alatt
type: docs
description: "Futtassa az Aspose.CAD-ot egy Multi-platform App UI (MAUI) alatt."
weight: 71
url: /hu/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Előfeltételek
- Visual Studio 2022.
- A NET 7 SDK használatban van a példában.


## MAUI

A .NET Multi-platform App UI (.NET MAUI) egy keresztplatformos keretrendszer, amely lehetővé teszi natív mobil és asztali alkalmazások létrehozását C# és XAML segítségével.
A .NET MAUI használatával olyan alkalmazásokat fejleszthet, amelyek Android, iOS, macOS és Windows platformokon futtatásra alkalmasak egyetlen, megosztott kódbázisból.

A .NET MAUI nyílt forráskódú, és a Xamarin.Forms fejlődése, amely a mobil megoldásokból az asztali szcenáriókra terjedt ki, a teljesítmény és a bővíthetőség érdekében újraépített UI vezérlőkkel.
Ha korábban a Xamarin.Forms-t használtad kereszt-platformos felhasználói felületek építésére, sok hasonlóságot fogsz észlelni a .NET MAUI-val.
Ugyanakkor van néhány különbség is.
A .NET MAUI használatával egyetlen projekt segítségével lehet környezetfüggetlen alkalmazásokat létrehozni, de ha szükséges, platform-specifikus forráskódot és erőforrásokat is hozzáadhatsz.
A .NET MAUI egyik fő célja, hogy lehetővé tegye az alkalmazás logika és UI elrendezésének lehető legteljesebb megvalósítását egyetlen kódbázisban.


## MAUI Telepítése

1. A .NET MAUI alkalmazások létrehozásához szükséged lesz a legfrissebb Visual Studio 2022 verzióra
1. Telepítheted a Visual Studio-t, vagy módosíthatod a meglévő telepítést, és telepítheted a .NET Multi-platform App UI fejlesztési munkaterhelést az alapértelmezett opcionális telepítési lehetőségeivel:<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## Projekt létrehozása

1. Indítsd el a Visual Studio-t. A kezdőképernyőn kattints az Új projekt létrehozása lehetőségre a projekt létrehozásához:<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. Az Új projekt létrehozása ablakban válaszd a MAUI-t az összes projekt típusa legördülő menüből, válaszd ki a .NET MAUI App sablont, és kattints a Tovább gombra:<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. A Te új projekted konfigurálása ablakban nevezd el a projekted, válassz ki egy megfelelő helyet, és kattints a Tovább gombra:<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. A További információk ablakban válaszd ki a célnak megfelelő .NET verziót és kattints a Létrehozás gombra:<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. Várj, amíg a projekt létrejön, és a függőségei helyreállnak
1. Telepítsd a legújabb Aspose.CAD verziót a NuGet-ből:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. Helyettesítsd a kódot a MainPage.xaml fájlban
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
            Text="Üdvözöljük a .NET MAUI-ban!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Aranyos pontnet robot, aki integet neked!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Helló, Világ!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Üdvözöljük a .NET Multi-platform App UI-n"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Üdvözöljük a dotnet Multi platform App UI-n"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Fájl kiválasztása"
                SemanticProperties.Hint="Számolja a kattintások számát"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Törlés"
                SemanticProperties.Hint="Számolja a kattintások számát"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Adj hozzá új metódusokat a MainPage.xaml.cs fájlban
{{% alert color="primary" %}} 
Ne felejtsd el hozzáadni az Aspose.CAD és az Aspose.CAD.ImageOptions használatát a fájlban.
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
        PickerTitle = "bármilyen"
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


## Hibakeresés Windows gépen

1. A Visual Studio eszköztáron használd a Hibakeresési cél legördülő menüt a Framework kiválasztásához, majd a net7.0-windows bejegyzést:<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. A Visual Studio eszköztáron nyomd meg a Windows gép gombot az alkalmazás fordításához és futtatásához:<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. A futó alkalmazásban nyomd meg többször a "Fájl kiválasztása" gombot, és figyeld meg, hogy a gombkattintások száma növekszik:<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. Válaszd ki a szükséges fájlt és kattints a megnyitásra:<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. A fájl feldolgozása után a képernyőn meg kell jelennie a konvertált fájl képének:<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Android Emulátor Telepítése

1. A Visual Studio eszköztáron használd a Hibakeresési cél legördülő menüt az Android Emulátorok kiválasztásához, majd az Android Emulátor bejegyzést
1. A Visual Studio eszköztáron nyomd meg az Android Emulátor gombot:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Az Android SDK - Licencszerződés ablakban nyomd meg az Elfogadom gombot:<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Az Android SDK - Licencszerződés ablakban nyomd meg az Elfogadom gombot:<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. A Felhasználói fiók-ellenőrzés párbeszédpanelen nyomd meg az Igen gombot:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. A Licencelfogadási ablakban nyomd meg az Elfogadom gombot:<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. A Visual Studio eszköztáron nyomd meg az Android Emulátor gombot:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. A Felhasználói fiók-ellenőrzés párbeszédpanelen nyomd meg az Igen gombot:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. Az Új eszköz ablakban nyomd meg a Létrehozás gombot:<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Zárd be az Android Eszközkezelő ablakot


## Hibakeresés Android Emulátorral

1. A Visual Studio eszköztáron nyomd meg a Pixel 5 - API 33 (Android 13.0 - API 33) gombot az alkalmazás fordításához és futtatásához:<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. A futó alkalmazásban az Android emulátorban nyomd meg többször a "Fájl kiválasztása" gombot, és figyeld meg, hogy a gombkattintások száma növekszik:<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. Válaszd ki a szükséges fájlt és kattints a kiválasztásra:<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. A fájl feldolgozása után a képernyőn meg kell jelennie a konvertált fájl képének:<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## További példák

További mintákért, mutasd meg, hogyan használhatod az Aspose.CAD-ot Dockerben, lásd a [példákat](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lásd még.

- [AWS Toolkit telepítése a Visual Studio 2022-höz](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Docker Desktop telepítése Windows rendszerre](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop telepítése Mac rendszerre](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Váltás Linux konténerekre](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opció
- További információk [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
