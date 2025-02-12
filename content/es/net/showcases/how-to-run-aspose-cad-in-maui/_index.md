---
title: Cómo ejecutar Aspose.CAD en la UI de aplicaciones multiplataforma (MAUI)
type: docs
description: "Ejecutar Aspose.CAD en una UI de aplicaciones multiplataforma (MAUI)."
weight: 71
url: /es/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Requisitos previos
- Visual Studio 2022.
- Se utiliza el SDK de .NET 7 en el ejemplo.


## MAUI

La UI de aplicaciones multiplataforma de .NET (.NET MAUI) es un marco de trabajo multiplataforma para crear aplicaciones móviles y de escritorio nativas con C# y XAML. 
Usando .NET MAUI, puedes desarrollar aplicaciones que se pueden ejecutar en Android, iOS, macOS y Windows desde una única base de código compartida.

.NET MAUI es de código abierto y es la evolución de Xamarin.Forms, ampliándose de escenarios móviles a de escritorio, con controles de UI reconstruidos desde cero para rendimiento y extensibilidad. 
Si has utilizado anteriormente Xamarin.Forms para construir interfaces de usuario multiplataforma, notarás muchas similitudes con .NET MAUI. 
Sin embargo, también hay algunas diferencias. 
Usando .NET MAUI, puedes crear aplicaciones multiplataforma utilizando un solo proyecto, pero puedes agregar código fuente y recursos específicos de la plataforma si es necesario. 
Uno de los principales objetivos de .NET MAUI es permitirte implementar la mayor parte de tu lógica de aplicación y diseño de UI posible en una única base de código.


## Instalación de MAUI

1. Para crear aplicaciones .NET MAUI, necesitarás la última versión de Visual Studio 2022.
1. Ya sea instalando Visual Studio o modificando tu instalación existente, instala la carga de trabajo de desarrollo de la UI de aplicaciones multiplataforma de .NET con sus opciones de instalación opcionales predeterminadas:<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)


## Crear proyecto

1. Lanza Visual Studio. En la ventana de inicio, haz clic en Crear un nuevo proyecto para crear un nuevo proyecto:<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. En la ventana Crear un nuevo proyecto, selecciona MAUI en el menú desplegable Todos los tipos de proyectos, selecciona la plantilla de aplicación .NET MAUI y haz clic en el botón Siguiente:<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. En la ventana Configura tu nuevo proyecto, nombra tu proyecto, elige una ubicación adecuada para él y haz clic en el botón Siguiente:<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. En la ventana Información adicional, elige la versión de .NET a la que te gustaría dirigirte y haz clic en el botón Crear:<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. Espera a que se cree el proyecto y se restauren sus dependencias.
1. Instala la última versión de Aspose.CAD desde NuGet:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. Reemplaza el código en MainPage.xaml
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
            Text="¡Bienvenido a .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="¡Lindo bot de dot net saludándote!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="¡Hola, Mundo!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Bienvenido a la UI de aplicaciones multiplataforma de .NET"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Bienvenido a la UI de aplicaciones multiplataforma de dot net"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Seleccionar archivo"
                SemanticProperties.Hint="Cuenta el número de veces que haces clic"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Limpiar"
                SemanticProperties.Hint="Cuenta el número de veces que haces clic"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Agrega nuevos métodos en MainPage.xaml.cs
{{% alert color="primary" %}} 
No olvides agregar using Aspose.CAD y using Aspose.CAD.ImageOptions en el archivo.
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
        PickerTitle = "cualquier"
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


## Depurar en la máquina con Windows

1. En la barra de herramientas de Visual Studio, usa el menú desplegable Objetivo de depuración para seleccionar el marco y luego la entrada net7.0-windows:<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. En la barra de herramientas de Visual Studio, presiona el botón Máquina Windows para construir y ejecutar la aplicación:<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. En la aplicación en ejecución, presiona el botón "Seleccionar archivo" varias veces y observa que el contador de clics en los botones se incrementa:<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. Selecciona el archivo requerido y haz clic en abrir:<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. Después de procesar el archivo, debería aparecer en la pantalla una imagen del archivo convertido:<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)


## Instalar el emulador de Android

1. En la barra de herramientas de Visual Studio, utiliza el menú desplegable Objetivo de depuración para seleccionar Emuladores de Android y luego la entrada Emulador de Android.
1. En la barra de herramientas de Visual Studio, presiona el botón Emulador de Android:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. En la ventana Acuerdo de licencia de Android SDK, presiona el botón Aceptar:<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. En la ventana Acuerdo de licencia de Android SDK, presiona el botón Aceptar:<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. En el cuadro de diálogo Control de cuentas de usuario, presiona el botón Sí:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. En la ventana Aceptación de licencia, presiona el botón Aceptar:<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. En la barra de herramientas de Visual Studio, presiona el botón Emulador de Android:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. En el cuadro de diálogo Control de cuentas de usuario, presiona el botón Sí:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. En la ventana Nuevo dispositivo, presiona el botón Crear:<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Cierra la ventana del Administrador de dispositivos Android.


## Depuración con el emulador de Android

1. En la barra de herramientas de Visual Studio, presiona el botón Pixel 5 - API 33 (Android 13.0 - API 33) para construir y ejecutar la aplicación:<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. En la aplicación en ejecución en el emulador de Android, presiona el botón "Seleccionar archivo" varias veces y observa que el contador de clics en los botones se incrementa:<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. Selecciona el archivo requerido y haz clic en seleccionar:<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. Después de procesar el archivo, debería aparecer en la pantalla una imagen del archivo convertido:<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)


## Más ejemplos

Para más ejemplos de cómo puedes usar Aspose.CAD en Docker, mira los [ejemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Ver también.

- [Instalar AWS Toolkit para Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instalar Docker Desktop en Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop en Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK de .NET 7](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Cambiar a contenedores de Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opción
- Información adicional sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
