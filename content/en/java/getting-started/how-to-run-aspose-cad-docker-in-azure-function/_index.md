---
title: How to Run Aspose.CAD Docker image in Azure Function
type: docs
description: "Run Aspose.CAD Docker image in Azure Function."
weight: 71
url: /java/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Prerequisites
- Docker must be installed on your system. For information on how to install Docker on Windows or Mac, refer to the links in the “See Also” section.
- IntelliJ IDEA.
- Azure Toolkit for IntelliJ.
- Postman.

## Azure Function

In this example, you create a simple conversion function that converts a CAD file and saves it as an image. The application can then be built in Docker and run in Azure Function.

## Creating the Azure Function

To create the Azure Function program, follow the steps below:
1. Once Docker is installed, make sure that it uses Linux Containers (default). If necessary, select the Switch to Linux containers option from the Docker Desktops menu.
1. Create Azure Function project in IntelliJ IDEA.<br>
![Create azure function project](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Create azure function project-final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->Sing In and select OAuth 2.0 authentication.<br>
![Azure sign In](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Log in browser.
1. Select Subscription name.
1. Add docker support.<br>
![Azure sign In](/_assets/java/java-azure/add-docker-support.png)<br>
1. Edit the DockerFile as in the <a href="#configuring-a-dockerfile">Configuring a Dockerfile</a> section.
1. Add blocks for repository aspose.cad in pom.xml.
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

1. When all required dependencies are added, write a simple program that creates an ellipse and saves it as an image:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * This function listens at endpoint "/api/HttpExample". Two ways to invoke it using "curl" command in bash:
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP trigger processed a request.");

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

### Configuring a Dockerfile

 The next step is to create and configure the Dockerfile in root project folder.

1. In the Dockerfile, specify:
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

 The above is a simple Dockerfile, which contains the following instructions:

- The SDK image to be used. Docker will download it when the build is run. The version of SDK is specified as a tag.
- The working directory, which is specified in the next line.
- The command to copy everything to container, publish the application, and specify the entry point.

## Docker Hub
1. Login Docker Hub
1. Create public Repository

## Building and Running the Application in Docker
 
 Now the application can be built and run in Docker. Open your favorite command prompt, change directory to the folder with the application (folder where the solution file and the Dockerfile are placed) and run the following command:


1. Build dockerfile command in console
{{< highlight plain >}}
//example
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. The first time you run this command, it may take longer because Docker needs to download the necessary images. After the previous command completes, run the following command to push the image to docker hub.
{{< highlight plain >}}
//example
docker push <user name>/<repository name>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Run dockerfile in IDE and after push to docker hub.<br>
![Run docker in ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Enter the name of the image, as in the Docker HUb repository.<br>
![Run docker in ide-next](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Wait for the end.

## Azure

1. Login Azure.
1. Choose Azure services.
1. Choose Function App and create a function.<br>
![Azure create function button](/_assets/java/java-azure/create-function-azure.png)<br>
1. Repeat the basic settings as in the image below.<br>
![Azure create function settings](/_assets/java/java-azure/create-function-settings.png)<br>
1. Click 'Review + create' -> Create.
1. Wait for deployment to finish.
1. Click 'Go to resorce' button.<br>
![Resource button](/_assets/java/java-azure/go-to-resource.png)<br>
1. Stop aspose-cad-docker-example function.<br>
![Stop conteiner](/_assets/java/java-azure/stop-container.png)<br>
1. Go to the deployment center menu and make the appropriate settings.<br>
![Deployment center](/_assets/java/java-azure/deployment-center.png)<br>
1. Save settings
1. Copy Webhook URL from deployment center settings.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Go to Docker Hub, select your repository and select webhooks.
1. Paste the 'Webhook url' from Azure into the Docker Hub webhook url and set the name.<br>
![Webhook settings in docker](/_assets/java/java-azure/webhook.png)<br>
1. Click create button.
1. Return to overview azure function and start container.<br>
![Overview menu](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
It may take a few minutes for the function to start.
{{% /alert %}}

## Execution example

1. Postman settings.<br>
![Overview menu](/_assets/java/java-azure/postman-settings.png)<br>
1. Select any DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG file.
1. Click the send button.
1. Save result
![Save responce](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
If the answer is successful, click Save to file and you will receive the converted file in png format
{{% /alert %}}

## More Examples

For more samples of how you can use Aspose.CAD in Docker, see the [examples](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## See Also

- [Install Docker Desktop on Windows](https://docs.docker.com/docker-for-windows/install/)
- [Install Docker Desktop on Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option