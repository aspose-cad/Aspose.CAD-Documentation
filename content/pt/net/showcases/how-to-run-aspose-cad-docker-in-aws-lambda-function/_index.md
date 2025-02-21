---
title: Como Executar a Imagem Docker Aspose.CAD na Função AWS Lambda
type: docs
description: "Executar a imagem Docker Aspose.CAD na Função AWS Lambda."
weight: 74
url: /pt/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Pré-requisitos
- O Docker deve estar instalado em seu sistema. Para informações sobre como instalar o Docker no Windows ou Mac, consulte os links na seção “Veja Também”.
- Visual Studio 2022.
- AWS Toolkit para Visual Studio 2022.
- O SDK .NET 6 é usado no exemplo.
- Postman

## Função AWS Lambda

Lambda é um serviço de computação que permite executar código sem provisionar ou gerenciar servidores. O Lambda executa seu código em uma infraestrutura de computação de alta disponibilidade e realiza toda a administração dos recursos de computação, incluindo manutenção de servidores e sistemas operacionais, provisionamento de capacidade e escalonamento automático, e registro. Com o Lambda, você pode executar código para virtualmente qualquer tipo de aplicação ou serviço de backend.

## Criando a Função AWS Lambda

{{% alert color="primary" %}} 
Certifique-se de ter direitos suficientes para criar funções e imagens AWS Lambda no Amazon Elastic Container Registry.
{{% /alert %}}

Para criar o programa da Função AWS Lambda, siga os passos abaixo:
1. Crie o Projeto AWS Lambda.<br>
![Criar botão da função AWS](/_assets/showcases/aws/create-project.png)<br>
1. Selecione .NET 6 (Imagem de Conteiner) e clique no botão 'Finalizar'.<br>
![Criar botão de função de contêiner](/_assets/showcases/aws/create-container.png)<br>
1. Abra o AWS Explorer no Visual Studio (Ver->AWS Explorer).
1. Adicione o perfil de credenciais da AWS no AWS Explorer.<br>
![Perfil de credenciais](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Insira o ID da Chave de Acesso e a Chave de Acesso Secreta, você pode obter essas chaves nas credenciais de segurança ou entrar em contato com o administrador e obter um arquivo csv para autorização.<br>
![Configurações do perfil da conta](/_assets/showcases/aws/account-profile.png)<br>
1. Instale as bibliotecas mais recentes do NuGet.<br>
![Gerenciador NuGet](/_assets/showcases/aws/nuget-manager.png)<br>
1. Exemplo de código para converter imagem cad em arquivo pdf.
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. Edite o DockerFile conforme a seção <a href="#configurando-um-dockerfile">Configurando um Dockerfile</a>.
1. Inicie o Docker Desktop.
1. Publique para a AWS Lambda.<br>
![Publicar aws lambda](/_assets/showcases/aws/publish-aws.png)<br>
1. Edite a configuração de upload.<br>
![Upload aws lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Clique no botão 'Upload'.<br>
![Upload aws lambda último](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Vá para a AWS e selecione Lambda.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Selecione sua nova função e crie a URL da função.<br>
![Configuração da URL da função](/_assets/showcases/aws/create-function-url.png)<br>
1. Selecione o tipo de autorização
- AWS_IAM - Apenas usuários e funções IAM autenticados podem fazer solicitações para sua URL de função.
- NONE - O Lambda não realizará autenticação IAM nas solicitações para sua URL de função. O endpoint da URL será público, a menos que você implemente sua própria lógica de autorização em sua função.

### Configurando um Dockerfile

 O próximo passo é editar e configurar o Dockerfile no projeto.

1. No Dockerfile, especifique:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 O acima é um Dockerfile simples, que contém as seguintes instruções:

- A imagem do SDK a ser utilizada. Aqui é a imagem .NET 6. O Docker a baixará quando a construção for executada. A versão do SDK é especificada como uma tag.
- Depois, pode ser necessário instalar fontes porque a imagem do SDK contém muito poucas fontes. Além disso, você pode usar fontes locais copiadas para a imagem do docker.
- O diretório de trabalho, que é especificado na linha seguinte.
- O comando para copiar tudo para o contêiner, publicar a aplicação e especificar o ponto de entrada.

## Exemplo de execução

1. Configurações do Postman.<br>
![Menu de visão geral](/_assets/showcases/aws/postman-settings.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Clique no botão enviar.

{{% alert color="primary" %}} 
Se a resposta for bem-sucedida, clique em Salvar para arquivo e você receberá o arquivo convertido em formato pdf
{{% /alert %}}

## Mais Exemplos

Para mais amostras de como você pode usar Aspose.CAD em Docker, veja os [exemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Veja Também.

- [Instalar AWS Toolkit para Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instalar Docker Desktop no Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop no Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Mudar para contêineres Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opção
- Informações adicionais sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
