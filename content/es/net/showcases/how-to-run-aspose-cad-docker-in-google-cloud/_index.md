---
title: Cómo ejecutar la imagen de Docker de Aspose.CAD en Google Cloud
type: docs
description: "Ejecutar la imagen de Docker de Aspose.CAD en Google Cloud."
weight: 75
url: /es/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Requisitos previos

- Docker debe estar instalado en su sistema. Para obtener información sobre cómo instalar Docker en Windows o Mac, consulte los enlaces en la sección "Véase también".
- Visual Studio 2022.
- Google CLI.
- Se utiliza el SDK de .NET Core 3.1 en el ejemplo.
- Postman

## Función de Google Cloud Run

Cloud Run es un entorno de computación completamente gestionado para implementar y escalar contenedores HTTP sin servidor sin preocuparse por aprovisionar máquinas, configurar clústeres o escalar automáticamente.

- Sin bloqueo de proveedor - Debido a que Cloud Run utiliza contenedores OCI estándar e implementa la API estándar de Knative Serving, puede portar fácilmente sus aplicaciones a entornos locales o a cualquier otro entorno en la nube.
- Escalado automático rápido - Los microservicios implementados en Cloud Run escalan automáticamente según la cantidad de solicitudes entrantes, sin que usted tenga que configurar o gestionar un clúster de Kubernetes completo. Cloud Run escala a cero, es decir, no utiliza recursos si no hay solicitudes.
- Dividir tráfico - Cloud Run le permite dividir el tráfico entre múltiples versiones, por lo que puede realizar implementaciones graduales como implementaciones canarias o implementaciones azul/verde.
- Dominios personalizados - Puede configurar el mapeo de dominios personalizados en Cloud Run y este aprovisionará un certificado TLS para su dominio.
- Redundancia automática - Cloud Run ofrece redundancia automática, por lo que no tiene que preocuparse por crear múltiples instancias para alta disponibilidad.

Cloud Run y Cloud Functions son servicios completamente gestionados que se ejecutan en la infraestructura sin servidor de Google Cloud, escalan automáticamente y manejan solicitudes o eventos HTTP. Sin embargo, tienen algunas diferencias importantes:

- Cloud Functions permite implementar fragmentos de código (funciones) escritos en un conjunto limitado de lenguajes de programación, mientras que Cloud Run le permite implementar imágenes de contenedor utilizando el lenguaje de programación de su elección.
- Cloud Run también admite el uso de cualquier herramienta o biblioteca del sistema de su aplicación; Cloud Functions no le permite usar ejecutables personalizados.
- Cloud Run ofrece una duración de tiempo de espera de solicitud más larga de hasta 60 minutos, mientras que con Cloud Functions el tiempo de espera de las solicitudes puede establecerse hasta 9 minutos.
- Cloud Functions solo envía una solicitud a la vez a cada instancia de función, mientras que por defecto Cloud Run está configurado para enviar múltiples solicitudes concurrentes en cada instancia de contenedor. Esto es útil para mejorar la latencia y reducir costos si se esperan grandes volúmenes.

## Creando el proyecto de Google Cloud Function

{{% alert color="primary" %}} 
Asegúrese de tener los derechos suficientes para crear la función de Google Cloud Run y las imágenes en el repositorio de Artifact Registry.
{{% /alert %}}

Para crear el programa de Google Cloud Function, siga los pasos a continuación:

1. Instalar el SDK de .NET Core 3.1.
1. Instale el paquete de plantilla:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. A continuación, cree un directorio para su proyecto y use dotnet new para crear una nueva función HTTP:
{{< highlight plain >}}
mkdir AsposeFunctions //crear carpeta
cd AsposeFunctions //ir a la carpeta AsposeFunctions
dotnet new gcf-http //crear proyecto de Google Cloud Function con activador http
{{< /highlight >}}
{{% alert color="primary" %}} 
Esto crea AsposeFunctions.csproj y Function.cs en el directorio actual. Abra Function.cs para revisar el código y proporcione un mensaje personalizado si lo desea.
{{% /alert %}}
1. Ejemplo de código para el archivo csproj (AsposeFunctions.csproj).
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
1. Ejemplo de código para convertir la imagen cad a un archivo png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// La lógica para su función va aquí.
        /// </summary>
        /// <param name="context">El contexto HTTP, que contiene la solicitud y la respuesta.</param>
        /// <returns>Tarea que representa la operación asíncrona.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //archivo del formulario
                var file = context.Request.Body; //datos binarios
                
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
1. Compile su función localmente de la siguiente manera:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Una vez que el servidor esté en funcionamiento, navegue a http://localhost:8080 para invocar la función. Presione Ctrl-C en la consola para detener el servidor.

## Desplegar la imagen docker en Google Cloud

1. Inicie sesión en Google Cloud.
1. Cree un proyecto si no existe.
1. Vaya a 'Artifact Registry' y cree un repositorio.<br>
![Crear repositorio de artefactos](/_assets/showcases/google/create-artifact-repository.png)<br>
1. Seleccione el nuevo repositorio en Artifact Registry.
![Seleccionar repositorio de artefactos](/_assets/showcases/google/select-artifact.png)<br>
1. Haga clic en 'INSTRUCCIÓN DE CONFIGURACIÓN' y copie el comando 'Configurar Docker'.<br>
![INSTRUCCIÓN DE CONFIGURACIÓN](/_assets/showcases/google/setup-instruction.png)<br>
1. Agregue una entrada de credHelper de Docker al archivo de configuración de Docker, o cree el archivo si no existe.
{{< highlight plain >}}
//ejemplo
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Cree un Dockerfile en el directorio raíz del proyecto y edite el DockerFile como en la <a href="#configuring-a-dockerfile">sección de configuración de un Dockerfile</a>.
1. Inicie Docker Desktop.
1. Compile la imagen docker con el camino del repositorio en la nube.
{{< highlight plain >}}
//ejemplo
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Empuje la imagen al Google Cloud Artifact Registry
{{< highlight plain >}}
//ejemplo
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Crear servicio de Google Cloud Run 

1. Vaya a Cloud Run.
1. Cree un servicio de Cloud Run.<br>
![Crear servicio de Cloud Run](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. En el campo de URL de imagen del contenedor, seleccione el contenedor de 'ARTIFACT REGISTRY'.<br>
![URL de imagen del contenedor](/_assets/showcases/google/container-url.png)<br>
1. Verifique otras configuraciones como se indica a continuación.<br>
![Configuraciones del servicio](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Espere a que finalice la implementación.
1. URL del servicio para trabajar con la aplicación de conversión.<br>
![URL del servicio](/_assets/showcases/google/url-service.png)<br>

### Configurando un Dockerfile

 El siguiente paso es editar el Dockerfile en el proyecto.

1. En el Dockerfile, especifique:

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

 Lo anterior es un Dockerfile simple, que contiene las siguientes instrucciones:

- La imagen del SDK que se utilizará. Aquí es la imagen de Net Core 3.1. Docker la descargará cuando se ejecute la compilación. La versión del SDK se especifica como una etiqueta.
- Después, es posible que necesite instalar fuentes porque la imagen del SDK contiene muy pocas fuentes. Además, puede usar fuentes locales copiadas a la imagen docker.
- El directorio de trabajo, que se especifica en la siguiente línea.
- El comando para copiar todo al contenedor, publicar la aplicación y especificar el punto de entrada.

## Ejemplo de ejecución

1. Configuraciones de Postman.<br>
![Menú de resumen](/_assets/showcases/google/postman-settings.png)<br>
1. Seleccione cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Haga clic en el botón enviar.

{{% alert color="primary" %}} 
Si la respuesta es exitosa, haga clic en Guardar en archivo y recibirá el archivo convertido en formato png.
{{% /alert %}}

## Más ejemplos

Para más ejemplos de cómo puede utilizar Aspose.CAD en Docker, consulte los [ejemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Véase también.

- [Instalar Docker Desktop en Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop en Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK de .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Cambiar a contenedores de Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opción
- Información adicional sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
