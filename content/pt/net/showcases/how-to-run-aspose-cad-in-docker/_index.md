---
title: Como Executar Aspose.CAD no Docker
type: docs
description: "Execute Aspose.CAD em um contêiner Docker para Linux, Windows Server e qualquer OS."
weight: 71
url: /pt/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Pré-requisitos
- O Docker deve estar instalado em seu sistema. Para informações sobre como instalar o Docker no Windows ou Mac, consulte os links na seção “Veja Também”.
- Visual Studio 2022.
- O SDK .NET 6 é utilizado no exemplo.

## Aplicativo Hello World

Neste exemplo, você cria um simples aplicativo de console Hello World que desenha uma elipse e a salva como uma imagem. O aplicativo pode então ser construído e executado no Docker.

## Criando o Aplicativo de Console

Para criar o programa Hello World, siga os passos abaixo:
1. Uma vez que o Docker esteja instalado, certifique-se de que ele usa Contêineres Linux (padrão). Se necessário, selecione a opção Mudar para contêineres Linux no menu do Docker Desktop.
1. No Visual Studio, crie um aplicativo de console .NET 6.<br>
![Um projeto de aplicativo de console .NET 6](/_assets/showcases/docker/1.png)<br>
1. Instale a versão mais recente do Aspose.CAD do NuGet.<br>
![Aspose.CAD no NuGet](/_assets/showcases/docker/2.png)<br>
1. Como o aplicativo será executado no Linux, pode ser necessário instalar fontes adicionais. Você pode preferir o ttf-mscorefonts-installer.
1. Quando todas as dependências necessárias forem adicionadas, escreva um programa simples que cria uma elipse e a salva como uma imagem:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Observe que a pasta “TestOut” é especificada como uma pasta de saída para salvar documentos de saída. Ao executar o aplicativo no Docker, uma pasta na máquina host será montada a esta pasta no contêiner. Isso permitirá que você visualize facilmente a saída gerada pelo Aspose.CAD no contêiner Docker.

### Configurando um Dockerfile

A próxima etapa é criar e configurar o Dockerfile.

1. Crie o Dockerfile e coloque-o ao lado do arquivo de solução do seu aplicativo. Mantenha esse nome de arquivo sem extensão (o padrão).
1. No Dockerfile, especifique:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

O acima é um Dockerfile simples, que contém as seguintes instruções:

- A imagem do SDK a ser usada. Aqui é a imagem .NET 6. O Docker fará o download quando a construção for executada. A versão do SDK é especificada como uma tag.
- Após isso, você pode precisar instalar fontes porque a imagem do SDK contém muito poucas fontes. Além disso, você pode usar fontes locais copiados para a imagem do Docker.
- O diretório de trabalho, que é especificado na linha seguinte.
- O comando para copiar tudo para o contêiner, publicar o aplicativo e especificar o ponto de entrada.

## Construindo e Executando o Aplicativo no Docker
 
Agora o aplicativo pode ser construído e executado no Docker. Abra seu prompt de comando favorito, mude o diretório para a pasta com o aplicativo (pasta onde o arquivo de solução e o Dockerfile estão colocados) e execute o seguinte comando:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

A primeira vez que este comando é executado, pode demorar mais, pois o Docker precisa baixar as imagens necessárias. Uma vez que o comando anterior seja concluído, execute o seguinte comando:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Preste atenção ao argumento de montagem, pois, como mencionado anteriormente, uma pasta na máquina host é montada na pasta do contêiner, para ver facilmente os resultados da execução do aplicativo. Os caminhos no Linux são sensíveis a maiúsculas e minúsculas.
{{% /alert %}}

## Mais Exemplos

Para mais exemplos de como você pode usar o Aspose.CAD no Docker, veja os [exemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Veja Também

- [Instalar Docker Desktop no Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop no Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Mudar para contêineres Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opção
- Informações adicionais sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
