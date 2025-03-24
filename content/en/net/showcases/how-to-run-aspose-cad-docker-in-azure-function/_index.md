---
title: How to Run Aspose.CAD Docker image in Azure Function
type: docs
description: "Run Aspose.CAD Docker image in Azure Function."
weight: 73
url: /net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Prerequisites
- Docker must be installed on your system. For information on how to install Docker on Windows or Mac, refer to the links in the “See Also” section.
- Visual Studio 2022.
- NET 6 SDK is used in the example.
- Postman

## Azure Function

In this example, you create a simple conversion function that converts a CAD file and saves it as an image. The application can then be built in Docker and run in Azure Function.

## Creating the Azure Function

To create the Azure Function program, follow the steps below:
1. Once Docker is installed, make sure that it uses Linux Containers (default). If necessary, select the Switch to Linux containers option from the Docker Desktops menu.
1. In Visual Studio, create a NET 6 Azure Function.<br>
![A NET 6 Azure Function project dialog](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Additional information.<br>
![A NET 6 Azure Function project dialog](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Install the latest Aspose.CAD version from NuGet.<br>
![Aspose.CAD on NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Since the application will be run on Linux, you may be needed to install additional fonts. You could prefer ttf-mscorefonts-installer.
1. When all required dependencies are added, write a simple program that creates an ellipse and saves it as an image:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");
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

### Configuring a Dockerfile

 The next step is to create and configure the Dockerfile in root project folder.

1. Create the Dockerfile and place it next to the solution file of your application. Keep this file name without extension (the default).
![Root project folder](/cad/_assets/showcases/azure/root-folder.png)<br>
1. In the Dockerfile, specify:


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

 The above is a simple Dockerfile, which contains the following instructions:

- The SDK image to be used. Here it is the Net 6 image. Docker will download it when the build is run. The version of SDK is specified as a tag.
- After, you may need to install Fonts because the SDK image contains very few fonts. Also, you can use local fonts copied to docker image.
- The working directory, which is specified in the next line.
- The command to copy everything to container, publish the application, and specify the entry point.

## Docker Hub
1. Login Docker Hub
1. Create public Repository

## Building and Running the Application in Docker
 
 Now the application can be built and run in Docker. Open your favorite command prompt, change directory to the folder with the application (folder where the solution file and the Dockerfile are placed) and run the following command:

{{< highlight plain >}}
//example
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
The first time you run this command, it may take longer because Docker needs to download the necessary images. After the previous command completes, run the following command to push the image to docker hub:
 
{{< highlight plain >}}
//example
docker push <user name>/<repository name>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Login Azure.
1. Choose Azure services.
1. Choose Function App and create a function.<br>
![Azure create function button](/cad/_assets/showcases/azure/create-function.png)<br>
1. Repeat the basic settings as in the image below.<br>
![Azure create function settings](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Click 'Review + create' -> Create.
1. Wait for deployment to finish.
1. Click 'Go to resorce' button.<br>
![Resource button](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Stop aspose-cad-docker-example function.<br>
![Stop conteiner](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Go to the deployment center menu and make the appropriate settings.<br>
![Deployment center](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Save settings
1. Copy Webhook URL from deployment center settings.<br>
![Webhook url](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Go to Docker Hub, select your repository and select webhooks.
1. Paste the 'Webhook url' from Azure into the Docker Hub webhook url and set the name.<br>
![Webhook settings in docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Click create button.
1. Return to overview azure function and start container.<br>
![Overview menu](/cad/_assets/showcases/azure/overview.png)<br>

## Execution example

1. Postman settings.<br>
![Overview menu](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Select any DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG file.
1. Click the send button.

{{% alert color="primary" %}} 
If the answer is successful, click Save to file and you will receive the converted file in png format
{{% /alert %}}

## More Examples

For more samples of how you can use Aspose.CAD in Docker, see the [examples](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## See Also

- [Install Docker Desktop on Windows](https://docs.docker.com/docker-for-windows/install/)
- [Install Docker Desktop on Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option
- Additional information on [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)