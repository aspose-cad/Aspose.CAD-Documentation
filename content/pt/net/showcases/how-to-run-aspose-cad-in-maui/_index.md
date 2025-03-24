---
title: Como Executar Aspose.CAD em MAUI (Multi-platform App UI)
type: docs
description: "Execute Aspose.CAD em uma Multi-platform App UI (MAUI)."
weight: 71
url: /pt/net/showcases/how-to-run-aspose-cad-in-maui/
---

## Pré-requisitos
- Visual Studio 2022.
- O SDK .NET 7 é usado no exemplo.


## MAUI

.NET Multi-platform App UI (.NET MAUI) é uma estrutura multiplataforma para criar aplicativos nativos para dispositivos móveis e desktop com C# e XAML.
Usando o .NET MAUI, você pode desenvolver aplicativos que podem ser executados no Android, iOS, macOS e Windows a partir de uma única base de código compartilhada.

O .NET MAUI é de código aberto e é a evolução do Xamarin.Forms, estendido de cenários móveis para desktop, com controles de UI reconstruídos do zero para desempenho e extensibilidade.
Se você já usou o Xamarin.Forms para construir interfaces de usuário multiplataforma, notará muitas semelhanças com o .NET MAUI.
No entanto, também existem algumas diferenças.
Usando o .NET MAUI, você pode criar aplicativos multiplataforma usando um único projeto, mas pode adicionar código-fonte e recursos específicos da plataforma, se necessário.
Um dos principais objetivos do .NET MAUI é permitir que você implemente o máximo possível da lógica do seu aplicativo e do layout da UI em uma única base de código.


## Instalação do MAUI

1. Para criar aplicativos .NET MAUI, você precisará da versão mais recente do Visual Studio 2022
1. Instale o Visual Studio ou modifique sua instalação existente e instale a carga de trabalho de desenvolvimento do .NET Multi-platform App UI com suas opções de instalação opcionais padrão:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## Criar projeto

1. Inicie o Visual Studio. Na janela inicial, clique em Criar um novo projeto para criar um novo projeto:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. Na janela Criar um novo projeto, selecione MAUI no menu suspenso Todos os tipos de projeto, selecione o modelo .NET MAUI App e clique no botão Avançar:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. Na janela Configurar seu novo projeto, nomeie seu projeto, escolha um local adequado para ele e clique no botão Avançar:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. Na janela Informações adicionais, escolha a versão do .NET que você gostaria de visar e clique no botão Criar:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. Aguarde a criação do projeto e a restauração de suas dependências
1. Instale a versão mais recente do Aspose.CAD a partir do NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. Substitua o código em MainPage.xaml
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
            Text="Bem-vindo ao .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Cute dot net bot acenando para você!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Olá, Mundo!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Bem-vindo à UI de Aplicativos Multi-plataforma do .NET"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Bem-vindo à UI de Aplicativos Multi-plataforma do dot net"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Selecionar arquivo"
                SemanticProperties.Hint="Conta o número de vezes que você clica"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Limpar"
                SemanticProperties.Hint="Conta o número de vezes que você clica"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Adicione novos métodos em MainPage.xaml.cs
{{% alert color="primary" %}} 
Não esqueça de adicionar using Aspose.CAD e using Aspose.CAD.ImageOptions no arquivo.
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
        PickerTitle = "qualquer"
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


## Depurar Máquina Windows

1. Na barra de ferramentas do Visual Studio, use o menu suspenso Alvo de Depuração para selecionar Framework e depois a entrada net7.0-windows:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. Na barra de ferramentas do Visual Studio, pressione o botão Máquina Windows para compilar e executar o aplicativo:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. No aplicativo em execução, pressione o botão "Selecionar arquivo" várias vezes e observe que a contagem do número de cliques no botão é incrementada:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. Selecione o arquivo necessário e clique em abrir:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. Após processar o arquivo, uma imagem do arquivo convertido deve aparecer na tela:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## Instalar Emulador Android

1. Na barra de ferramentas do Visual Studio, use o menu suspenso Alvo de Depuração para selecionar Emuladores Android e depois a entrada Emulador Android
1. Na barra de ferramentas do Visual Studio, pressione o botão Emulador Android:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Na janela Contrato de Licença do SDK Android, pressione o botão Aceitar:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. Na janela Contrato de Licença do SDK Android, pressione o botão Aceitar:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. Na caixa de diálogo Controle de Conta de Usuário, pressione o botão Sim:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. Na janela Aceitação de Licença, pressione o botão Aceitar:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. Na barra de ferramentas do Visual Studio, pressione o botão Emulador Android:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. Na caixa de diálogo Controle de Conta de Usuário, pressione o botão Sim:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. Na janela Novo Dispositivo, pressione o botão Criar:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. Feche a janela do Gerenciador de Dispositivos Android


## Depurar com Emulador Android

1. Na barra de ferramentas do Visual Studio, pressione o botão Pixel 5 - API 33 (Android 13.0 - API 33) para compilar e executar o aplicativo:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. No aplicativo em execução no emulador Android, pressione o botão "Selecionar arquivo" várias vezes e observe que a contagem do número de cliques no botão é incrementada:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. Selecione o arquivo necessário e clique em selecionar:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. Após processar o arquivo, uma imagem do arquivo convertido deve aparecer na tela:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## Mais Exemplos

Para mais exemplos de como você pode usar Aspose.CAD no Docker, veja os [exemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Veja Também.

- [Instalar AWS Toolkit para Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instalar Docker Desktop no Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop no Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 7](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Mudar para contêineres Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opção
- Informações adicionais sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
