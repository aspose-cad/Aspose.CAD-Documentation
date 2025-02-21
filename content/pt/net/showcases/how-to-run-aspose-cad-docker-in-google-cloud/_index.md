---
title: Como Executar a Imagem Docker do Aspose.CAD no Google Cloud
type: docs
description: "Executar a imagem Docker do Aspose.CAD no Google Cloud."
weight: 75
url: /pt/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Pré-requisitos

- O Docker deve estar instalado em seu sistema. Para informações sobre como instalar o Docker no Windows ou Mac, consulte os links na seção "Veja Também".
- Visual Studio 2022.
- Google CLI.
- O SDK do .NET Core 3.1 é usado no exemplo.
- Postman

## Função do Google Cloud Run

O Cloud Run é um ambiente de computação totalmente gerenciado para implantar e escalar contêineres HTTP sem servidor, sem se preocupar com a provisão de máquinas, configuração de clusters ou escalonamento automático.

- Sem bloqueio de fornecedor - Como o Cloud Run utiliza contêineres OCI padrão e implementa a API padrão Knative Serving, você pode facilmente transferir seus aplicativos para ambientes on-premises ou qualquer outro ambiente em nuvem.
- Escalonamento automático rápido - Microserviços implantados no Cloud Run escalam automaticamente com base no número de solicitações recebidas, sem que você precise configurar ou gerenciar um cluster Kubernetes completo. O Cloud Run escala para zero — ou seja, não utiliza recursos — se não houver solicitações.
- Divisão de tráfego - O Cloud Run permite que você divida o tráfego entre várias revisões, para que você possa realizar implantações graduais, como implantações canário ou implantações blue/green.
- Domínios personalizados - Você pode configurar o mapeamento de domínio personalizado no Cloud Run e ele provisionará um certificado TLS para seu domínio.
- Redundância automática - O Cloud Run oferece redundância automática, para que você não precise se preocupar em criar várias instâncias para alta disponibilidade.

O Cloud Run e as Funções do Cloud são serviços totalmente gerenciados que operam na infraestrutura sem servidor do Google Cloud, escalonam automaticamente e lidam com solicitações ou eventos HTTP. No entanto, eles têm algumas diferenças importantes:

- O Cloud Functions permite que você implante trechos de código (funções) escritos em um conjunto limitado de linguagens de programação, enquanto o Cloud Run permite que você implante imagens de contêiner usando a linguagem de programação de sua escolha.
- O Cloud Run também suporta o uso de qualquer ferramenta ou biblioteca de sistema de seu aplicativo; o Cloud Functions não permite que você use executáveis personalizados.
- O Cloud Run oferece uma duração mais longa de tempo limite de solicitações de até 60 minutos, enquanto com o Cloud Functions, o tempo limite das solicitações pode ser definido em até 9 minutos.
- O Cloud Functions envia apenas uma solicitação por vez para cada instância de função, enquanto o Cloud Run, por padrão, é configurado para enviar várias solicitações simultâneas em cada instância de contêiner. Isso é útil para melhorar a latência e reduzir custos se você estiver esperando grandes volumes.

## Criando o projeto da Função do Google Cloud

{{% alert color="primary" %}} 
Certifique-se de ter direitos suficientes para criar funções e imagens do Google Cloud Run no repositório do Artifact Registry.
{{% /alert %}}

Para criar o programa da Função do Google Cloud, siga os passos abaixo:

1. Instale o SDK do .NET Core 3.1.
1. Instale o pacote de modelo:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Em seguida, crie um diretório para seu projeto e use dotnet new para criar uma nova função HTTP:
{{< highlight plain >}}
mkdir AsposeFunctions //criar pasta
cd AsposeFunctions //ir para a pasta AsposeFunctions
dotnet new gcf-http //criar projeto da Função do Google Cloud com gatilho http
{{< /highlight >}}
{{% alert color="primary" %}} 
Isso cria AsposeFunctions.csproj e Function.cs no diretório atual. Abra Function.cs para revisar o código e forneça uma mensagem personalizada, se desejar.
{{% /alert %}}
1. Exemplo de código para arquivo csproj (AsposeFunctions.csproj).
{{< highlight plain >}}
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Aspose.CAD" Version="22.7.0" />
    <PackageReference Include="Google.Cloud.Functions.Hosting" Version="1.0.0" />
  </ItemGroup>
</Project>
{{< /highlight >}}
1. Exemplo de código para converter imagem CAD em arquivo png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// A lógica para sua função vai aqui.
        /// </summary>
        /// <param name="context">O contexto HTTP, contendo a solicitação e a resposta.</param>
        /// <returns>Uma tarefa representando a operação assíncrona.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //arquivo de formulário
                var file = context.Request.Body; //dados binários
                
                var msFile = new MemoryStream();
                await file.CopyToAsync(msFile);
                msFile.Seek(0, SeekOrigin.Begin);
                
                using (var image = (CadImage)Image.Load(msFile))
                {
                    var ms = new MemoryStream();
                    image.Save(ms, new PngOptions());
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    context.Response.Headers.Add("Content-Type", "image/png");
                    context.Response.Headers.Add("Content-Disposition", "attachment;filename=result.png");

                    await context.Response.Body.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                }
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
{{< /highlight >}}
1. Compile sua função localmente da seguinte forma:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Uma vez que o servidor esteja em execução, acesse http://localhost:8080 para invocar a função. Pressione Ctrl-C no console para parar o servidor.

## Implantar a imagem docker no Google Cloud

1. Faça login no Google Cloud.
1. Crie um projeto se ele não existir.
1. Vá para 'Artifact Registry' e crie um repositório.<br>
![Criar Repositório de Artefatos](/_assets/showcases/google/create-artifact-repository.png)<br>
1. Selecione o novo repositório no Artifact Registry.
![Selecionar repositório de artefatos](/_assets/showcases/google/select-artifact.png)<br>
1. Clique em 'INSTRUÇÕES DE CONFIGURAÇÃO' e copie o comando 'Configurar Docker'.<br>
![INSTRUÇÕES DE CONFIGURAÇÃO](/_assets/showcases/google/setup-instruction.png)<br>
1. Adicione uma entrada credHelper do Docker ao arquivo de configuração do Docker, ou crie o arquivo se ele não existir.
{{< highlight plain >}}
//exemplo
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Crie um Dockerfile no diretório raiz do projeto e edite o DockerFile conforme na seção <a href="#configuring-a-dockerfile">Configurando um Dockerfile</a>.
1. Inicie o Docker Desktop.
1. Compile a imagem docker com o caminho do repositório em nuvem.
{{< highlight plain >}}
//exemplo
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Envie a imagem para o Google Cloud Artifact Registry
{{< highlight plain >}}
//exemplo
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Criar serviço do Google Cloud Run 

1. Vá para o Cloud Run.
1. Crie o serviço do Cloud Run.<br>
![Criar serviço do Cloud Run](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. No campo URL da Imagem do Contêiner, selecione o contêiner de 'REGISTRO DE ARTEFATOS'.<br>
![URL da Imagem do Contêiner](/_assets/showcases/google/container-url.png)<br>
1. Verifique outras configurações conforme abaixo.<br>
![Configurações do serviço](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Aguarde o término da implantação.
1. URL do serviço para trabalhar com o aplicativo de conversão.<br>
![URL do serviço](/_assets/showcases/google/url-service.png)<br>

### Configurando um Dockerfile

A próxima etapa é editar e configurar o Dockerfile no projeto.

1. No Dockerfile, especifique:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

O acima é um Dockerfile simples, que contém as seguintes instruções:

- A imagem SDK a ser usada. Aqui está a imagem do Net Core 3.1. O Docker a baixará quando a construção for executada. A versão do SDK é especificada como uma tag.
- Depois, você pode precisar instalar fontes porque a imagem do SDK contém muito poucas fontes. Além disso, você pode usar fontes locais copiadas para a imagem do Docker.
- O diretório de trabalho, que é especificado na linha seguinte.
- O comando para copiar tudo para o contêiner, publicar a aplicação e especificar o ponto de entrada.

## Exemplo de execução

1. Configurações do Postman.<br>
![Menu de visão geral](/_assets/showcases/google/postman-settings.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Clique no botão enviar.

{{% alert color="primary" %}} 
Se a resposta for bem-sucedida, clique em Salvar como arquivo e você receberá o arquivo convertido em formato png
{{% /alert %}}

## Mais Exemplos

Para mais exemplos de como você pode usar o Aspose.CAD no Docker, veja os [exemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Veja Também.

- [Instalar Docker Desktop no Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop no Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK do .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Mudar para contêineres Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opção
- Informações adicionais sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
