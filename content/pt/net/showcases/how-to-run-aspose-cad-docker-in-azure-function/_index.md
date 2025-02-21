---
title: Como Executar a Imagem Docker do Aspose.CAD na Função Azure
type: docs
description: "Executar a imagem Docker do Aspose.CAD na Função Azure."
weight: 73
url: /pt/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Pré-requisitos
- O Docker deve estar instalado em seu sistema. Para informações sobre como instalar o Docker no Windows ou Mac, consulte os links na seção “Veja Também”.
- Visual Studio 2022.
- O SDK .NET 6 é usado no exemplo.
- Postman

## Função Azure

Neste exemplo, você cria uma função de conversão simples que converte um arquivo CAD e o salva como uma imagem. O aplicativo pode então ser construído no Docker e executado na Função Azure.

## Criando a Função Azure

Para criar o programa da Função Azure, siga os passos abaixo:
1. Uma vez que o Docker esteja instalado, certifique-se de que ele utiliza Contêineres Linux (padrão). Se necessário, selecione a opção Mudar para contêineres Linux no menu do Docker Desktop.
1. No Visual Studio, crie uma Função Azure .NET 6.<br>
![Diálogo do projeto da Função Azure .NET 6](/_assets/showcases/azure/Create-project.png)<br>
1. Informações adicionais.<br>
![Diálogo do projeto da Função Azure .NET 6](/_assets/showcases/azure/Additional-information.png)<br>
1. Instale a versão mais recente do Aspose.CAD do NuGet.<br>
![Aspose.CAD no NuGet](/_assets/showcases/azure/NuGet.png)<br>
1. Como o aplicativo será executado no Linux, pode ser necessário instalar fontes adicionais. Você pode preferir o ttf-mscorefonts-installer.
1. Quando todas as dependências necessárias forem adicionadas, escreva um programa simples que crie uma elipse e a salve como uma imagem:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("A função de trigger HTTP em C# processou uma solicitação.");
        try
        {
            using (var image = (CadImage)Image.Load(req.Body))
            {
                var ms = new MemoryStream();
                image.Save(ms, new PngOptions());

                ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);

                return new FileContentResult(ms.ToArray(), "application/octet-stream")
                {
                    FileDownloadName = "Export.png"
                };
            }
        }
        catch (Exception e)
        {
            return new OkObjectResult(e.Message);
        }
    }
}
{{< /highlight >}}

### Configurando um Dockerfile

 O próximo passo é criar e configurar o Dockerfile na pasta raiz do projeto.

1. Crie o Dockerfile e coloque-o ao lado do arquivo de solução do seu aplicativo. Mantenha este nome de arquivo sem extensão (o padrão).
![Pasta raiz do projeto](/_assets/showcases/azure/root-folder.png)<br>
1. No Dockerfile, especifique:


{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
WORKDIR "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

 O acima é um Dockerfile simples, que contém as seguintes instruções:

- A imagem do SDK a ser usada. Aqui é a imagem .NET 6. O Docker a baixará quando a construção for executada. A versão do SDK é especificada como uma tag.
- Em seguida, pode ser necessário instalar fontes porque a imagem do SDK contém muito poucas fontes. Além disso, você pode usar fontes locais copiadas para a imagem do docker.
- O diretório de trabalho, que é especificado na próxima linha.
- O comando para copiar tudo para o contêiner, publicar o aplicativo e especificar o ponto de entrada.

## Docker Hub
1. Faça login no Docker Hub
1. Crie um repositório público

## Construindo e Executando o Aplicativo no Docker
 
 Agora o aplicativo pode ser construído e executado no Docker. Abra seu prompt de comando favorito, mude o diretório para a pasta com o aplicativo (pasta onde o arquivo de solução e o Dockerfile estão colocados) e execute o seguinte comando:

{{< highlight plain >}}
//exemplo
docker build -t <nome de usuário>/<nome do repositório> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
Da primeira vez que você executar este comando, pode levar mais tempo porque o Docker precisa baixar as imagens necessárias. Após a conclusão do comando anterior, execute o seguinte comando para enviar a imagem para o docker hub:
 
{{< highlight plain >}}
//exemplo
docker push <nome de usuário>/<nome do repositório>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Faça login no Azure.
1. Escolha os serviços do Azure.
1. Escolha Aplicativo de Função e crie uma função.<br>
![Botão criar função Azure](/_assets/showcases/azure/create-function.png)<br>
1. Repita as configurações básicas conforme na imagem abaixo.<br>
![Configurações de criar função Azure](/_assets/showcases/azure/create-function-setting.png)<br>
1. Clique em 'Rever + criar' -> Criar.
1. Aguarde o término da implantação.
1. Clique no botão 'Ir para o recurso'.<br>
![Botão de recurso](/_assets/showcases/azure/go-to-resource.png)<br>
1. Pare a função aspose-cad-docker-example.<br>
![Parar contêiner](/_assets/showcases/azure/stop-container.png)<br>
1. Vá para o menu do centro de implantação e faça as configurações apropriadas.<br>
![Centro de implantação](/_assets/showcases/azure/deployment-center.png)<br>
1. Salve as configurações
1. Copie a URL do Webhook das configurações do centro de implantação.<br>
![Webhook url](/_assets/showcases/azure/webhook-url.png)<br>
1. Vá para o Docker Hub, selecione seu repositório e selecione webhooks.
1. Cole a 'URL do Webhook' do Azure na URL do webhook do Docker Hub e defina o nome.<br>
![Configurações do Webhook no docker](/_assets/showcases/azure/webhook.png)<br>
1. Clique no botão criar.
1. Retorne à visão geral da função Azure e inicie o contêiner.<br>
![Menu de visão geral](/_assets/showcases/azure/overview.png)<br>

## Exemplo de Execução

1. Configurações do Postman.<br>
![Menu de visão geral](/_assets/showcases/azure/postman-settings.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Clique no botão enviar.

{{% alert color="primary" %}} 
Se a resposta for bem-sucedida, clique em Salvar como arquivo e você receberá o arquivo convertido em formato png
{{% /alert %}}

## Mais Exemplos

Para mais exemplos de como você pode usar o Aspose.CAD no Docker, consulte os [exemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Veja Também

- [Instalar Docker Desktop no Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop no Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Mudar para contêineres Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opção
- Informações adicionais sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
