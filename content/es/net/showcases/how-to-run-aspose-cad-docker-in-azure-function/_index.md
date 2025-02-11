---
title: Cómo ejecutar la imagen Docker de Aspose.CAD en Azure Function
type: docs
description: "Ejecutar la imagen Docker de Aspose.CAD en Azure Function."
weight: 73
url: /es/net/showcases/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Requisitos previos
- Docker debe estar instalado en su sistema. Para obtener información sobre cómo instalar Docker en Windows o Mac, consulte los enlaces en la sección “Véase también”.
- Visual Studio 2022.
- Se utiliza el SDK de NET 6 en el ejemplo.
- Postman

## Azure Function

En este ejemplo, creas una función de conversión simple que convierte un archivo CAD y lo guarda como una imagen. La aplicación se puede construir en Docker y ejecutarlo en Azure Function.

## Creando la Azure Function

Para crear el programa de Azure Function, siga los pasos a continuación:
1. Una vez que Docker esté instalado, asegúrese de que utiliza contenedores de Linux (predeterminado). Si es necesario, seleccione la opción Cambiar a contenedores de Linux en el menú de escritorio de Docker.
1. En Visual Studio, crea una Azure Function de NET 6.<br>
![Un diálogo de proyecto de Azure Function de NET 6](/es/_assets/Create-project.png)<br>
1. Información adicional.<br>
![Un diálogo de proyecto de Azure Function de NET 6](/es/_assets/Additional-information.png)<br>
1. Instala la última versión de Aspose.CAD desde NuGet.<br>
![Aspose.CAD en NuGet](/es/_assets/NuGet.png)<br>
1. Dado que la aplicación se ejecutará en Linux, es posible que necesite instalar fuentes adicionales. Puede preferir ttf-mscorefonts-installer.
1. Cuando todas las dependencias necesarias estén añadidas, escriba un programa simple que cree una elipse y la guarde como una imagen:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("La función de activación HTTP de C# procesó una solicitud.");
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

### Configurando un Dockerfile

El siguiente paso es crear y configurar el Dockerfile en la carpeta raíz del proyecto.

1. Crea el Dockerfile y colócalo junto al archivo de solución de tu aplicación. Mantén este nombre de archivo sin extensión (el predeterminado).
![Carpeta raíz del proyecto](/es/_assets/root-folder.png)<br>
1. En el Dockerfile, especifica:

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

El anterior es un Dockerfile simple, que contiene las siguientes instrucciones:

- La imagen del SDK que se va a utilizar. Aquí está la imagen de Net 6. Docker la descargará cuando se ejecute la construcción. La versión del SDK se especifica como una etiqueta.
- Después, es posible que necesite instalar fuentes porque la imagen del SDK contiene muy pocas fuentes. Además, puede usar fuentes locales copiadas en la imagen de docker.
- El directorio de trabajo, que se especifica en la siguiente línea.
- El comando para copiar todo al contenedor, publicar la aplicación y especificar el punto de entrada.

## Docker Hub
1. Iniciar sesión en Docker Hub
1. Crear un repositorio público

## Construyendo y ejecutando la aplicación en Docker

Ahora la aplicación se puede construir y ejecutar en Docker. Abre tu símbolo del sistema favorito, cambia el directorio a la carpeta con la aplicación (carpeta donde se encuentra el archivo de solución y el Dockerfile) y ejecuta el siguiente comando:

{{< highlight plain >}}
//ejemplo
docker build -t <nombre de usuario>/<nombre del repositorio> .

docker build -t usuario/asposefunction .
{{< /highlight >}}

La primera vez que ejecutes este comando, puede tardar más porque Docker necesita descargar las imágenes necesarias. Después de que se complete el comando anterior, ejecuta el siguiente comando para subir la imagen a Docker Hub:

{{< highlight plain >}}
//ejemplo
docker push <nombre de usuario>/<nombre del repositorio>:tagname

docker push usuario/asposefunction:latest
{{< /highlight >}}

## Azure

1. Inicia sesión en Azure.
1. Elige servicios de Azure.
1. Elige Function App y crea una función.<br>
![Botón de crear función de Azure](/es/_assets/create-function.png)<br>
1. Repite la configuración básica como en la imagen a continuación.<br>
![Configuraciones de creación de función de Azure](/es/_assets/create-function-setting.png)<br>
1. Haz clic en 'Revisar + crear' -> Crear.
1. Espera a que la implementación finalice.
1. Haz clic en el botón 'Ir a recurso'.<br>
![Botón de recurso](/es/_assets/go-to-resource.png)<br>
1. Detén la función aspose-cad-docker-example.<br>
![Detener contenedor](/es/_assets/stop-container.png)<br>
1. Ve al menú del centro de implementación y realiza las configuraciones apropiadas.<br>
![Centro de implementación](/es/_assets/deployment-center.png)<br>
1. Guarda la configuración
1. Copia la URL de Webhook de la configuración del centro de implementación.<br>
![URL de Webhook](/es/_assets/webhook-url.png)<br>
1. Ve a Docker Hub, selecciona tu repositorio y selecciona webhooks.
1. Pega la 'URL de Webhook' de Azure en la URL de webhook de Docker Hub y establece el nombre.<br>
![Configuración de Webhook en docker](/es/_assets/webhook.png)<br>
1. Haz clic en el botón de crear.
1. Regresa a la función de resumen de Azure y inicia el contenedor.<br>
![Menú de resumen](/es/_assets/overview.png)<br>

## Ejemplo de ejecución

1. Configuraciones de Postman.<br>
![Menú de resumen](/es/_assets/postman-settings.png)<br>
1. Selecciona cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Haz clic en el botón enviar.

{{% alert color="primary" %}} 
Si la respuesta es exitosa, haz clic en Guardar como archivo y recibirás el archivo convertido en formato png
{{% /alert %}}

## Más ejemplos

Para más muestras de cómo puedes usar Aspose.CAD en Docker, consulta los [ejemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Véase también

- [Instalar Docker Desktop en Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop en Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Opción [Cambiar a contenedores de Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Información adicional sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
