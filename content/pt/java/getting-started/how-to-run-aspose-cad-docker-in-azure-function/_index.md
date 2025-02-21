---
title: Como Executar a Imagem Docker Aspose.CAD na Função Azure
type: docs
description: "Execute a imagem Docker Aspose.CAD na Função Azure."
weight: 71
url: /pt/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Pré-Requisitos
- O Docker deve estar instalado em seu sistema. Para informações sobre como instalar o Docker no Windows ou Mac, consulte os links na seção “Veja Também”.
- IntelliJ IDEA.
- Azure Toolkit para IntelliJ.
- Postman.

## Função Azure

Neste exemplo, você cria uma função simples de conversão que converte um arquivo CAD e o salva como uma imagem. O aplicativo pode então ser construído no Docker e executado na Função Azure.

## Criando a Função Azure

Para criar o programa da Função Azure, siga os passos abaixo:
1. Após a instalação do Docker, certifique-se de que ele está usando Contêineres Linux (padrão). Se necessário, selecione a opção Alternar para contêineres Linux no menu do Docker Desktops.
1. Crie o projeto da Função Azure no IntelliJ IDEA.<br>
![Criar projeto de função azure](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Criar projeto de função azure-final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Ferramentas->Azure->Entrar e selecione a autenticação OAuth 2.0.<br>
![Entrar no Azure](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Faça login no navegador.
1. Selecione o nome da assinatura.
1. Adicione suporte a docker.<br>
![Adicionar suporte a docker](/_assets/java/java-azure/add-docker-support.png)<br>
1. Edite o DockerFile conforme na seção <a href="#configuring-a-dockerfile">Configurando um Dockerfile</a>.
1. Adicione blocos para o repositório aspose.cad no pom.xml.
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. Quando todas as dependências necessárias forem adicionadas, escreva um programa simples que cria uma elipse e a salva como uma imagem:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Esta função escuta no endpoint "/api/HttpExample". Duas maneiras de invocá-la usando o comando "curl" no bash:
     * 1. curl -d "Corpo HTTP" {seu host}/api/HttpExample
     * 2. curl "{seu host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP trigger processou uma solicitação.");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### Configurando um Dockerfile

 O próximo passo é criar e configurar o Dockerfile na pasta raiz do projeto.

1. No Dockerfile, especifique:
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

 O acima é um Dockerfile simples, que contém as seguintes instruções:

- A imagem SDK a ser usada. O Docker a baixará quando a construção for executada. A versão do SDK é especificada como uma tag.
- O diretório de trabalho, que é especificado na linha seguinte.
- O comando para copiar tudo para o contêiner, publicar o aplicativo e especificar o ponto de entrada.

## Docker Hub
1. Login no Docker Hub
1. Criar repositório público

## Construindo e Executando o Aplicativo no Docker
 
 Agora o aplicativo pode ser construído e executado no Docker. Abra seu console favorito, mude o diretório para a pasta com o aplicativo (pasta onde o arquivo da solução e o Dockerfile estão colocados) e execute o seguinte comando:


1. Comando dockerfile de construção no console
{{< highlight plain >}}
//exemplo
docker build -t <nome de usuário>/<nome do repositório> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. A primeira vez que você executar este comando, pode demorar mais porque o Docker precisa baixar as imagens necessárias. Após o comando anterior ser concluído, execute o seguinte comando para enviar a imagem para o docker hub.
{{< highlight plain >}}
//exemplo
docker push <nome de usuário>/<nome do repositório>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Execute o dockerfile no IDE e após enviar para o docker hub.<br>
![Executar docker no ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Insira o nome da imagem, conforme no repositório Docker Hub.<br>
![Executar docker no ide-próximo](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Aguarde o término.

## Azure

1. Login no Azure.
1. Escolha os serviços do Azure.
1. Escolha Função App e crie uma função.<br>
![Botão criar função Azure](/_assets/java/java-azure/create-function-azure.png)<br>
1. Repita as configurações básicas conforme na imagem abaixo.<br>
![Configurações de criar função Azure](/_assets/java/java-azure/create-function-settings.png)<br>
1. Clique em 'Rever + criar' -> Criar.
1. Aguarde a conclusão da implantação.
1. Clique no botão 'Ir para o recurso'.<br>
![Botão de recurso](/_assets/java/java-azure/go-to-resource.png)<br>
1. Pare a função aspose-cad-docker-example.<br>
![Parar contêiner](/_assets/java/java-azure/stop-container.png)<br>
1. Vá para o menu do centro de implantação e faça as configurações apropriadas.<br>
![Centro de implantação](/_assets/java/java-azure/deployment-center.png)<br>
1. Salve as configurações
1. Copie a URL do Webhook das configurações do centro de implantação.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Vá para o Docker Hub, selecione seu repositório e selecione webhooks.
1. Cole a 'Webhook url' do Azure na URL do webhook do Docker Hub e defina o nome.<br>
![Configurações do webhook no docker](/_assets/java/java-azure/webhook.png)<br>
1. Clique no botão criar.
1. Volte para a função de visualização do Azure e inicie o contêiner.<br>
![Menu de visualização](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Pode levar alguns minutos para a função iniciar.
{{% /alert %}}

## Exemplo de Execução

1. Configurações do Postman.<br>
![Configurações do Postman](/_assets/java/java-azure/postman-settings.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Clique no botão enviar.
1. Salve o resultado
![Salvar resposta](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Se a resposta for bem-sucedida, clique em Salvar para arquivo e você receberá o arquivo convertido em formato png
{{% /alert %}}

## Mais Exemplos

Para mais exemplos de como você pode usar Aspose.CAD no Docker, veja os [exemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Veja Também

- [Instalar Docker Desktop no Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop no Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Alternar para contêineres Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opção
