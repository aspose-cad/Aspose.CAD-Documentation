---
title: Cómo ejecutar la imagen de Docker de Aspose.CAD en la función AWS Lambda
type: docs
description: "Ejecutar la imagen de Docker de Aspose.CAD en la función AWS Lambda."
weight: 74
url: /es/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Prerrequisitos
- Docker debe estar instalado en su sistema. Para obtener información sobre cómo instalar Docker en Windows o Mac, consulte los enlaces en la sección "Ver También".
- Visual Studio 2022.
- AWS Toolkit para Visual Studio 2022.
- Se utiliza .NET 6 SDK en el ejemplo.
- Postman

## Función AWS Lambda

Lambda es un servicio de computación que le permite ejecutar código sin aprovisionar o administrar servidores. Lambda ejecuta su código en una infraestructura de computación de alta disponibilidad y realiza toda la administración de los recursos computacionales, incluyendo el mantenimiento del servidor y del sistema operativo, aprovisionamiento de capacidad y escalado automático, y registro. Con Lambda, puede ejecutar código para prácticamente cualquier tipo de aplicación o servicio de backend.

## Creando la función AWS Lambda

{{% alert color="primary" %}} 
Asegúrese de tener los derechos suficientes para crear funciones e imágenes de AWS Lambda en el Registro de Contenedores Elásticos de Amazon.
{{% /alert %}}

Para crear el programa de la Función AWS Lambda, siga los pasos a continuación:
1. Cree el Proyecto de AWS Lambda.<br>
![Crear botón de función AWS](/_assets/showcases/aws/create-project.png)<br>
1. Seleccione .NET 6 (Imagen de Contenedor) y haga clic en el botón 'Finalizar'.<br>
![Crear botón de función de contenedor](/_assets/showcases/aws/create-container.png)<br>
1. Abra AWS Explorer en Visual Studio (Ver->AWS Explorer).
1. Agregue el perfil de credenciales de AWS en AWS Explorer.<br>
![Perfil de credenciales](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Ingrese el ID de clave de acceso y la clave de acceso secreta, puede obtener estas claves en las credenciales de seguridad o contactar al administrador y obtener un archivo csv para autorización.<br>
![Configuración del perfil de la cuenta](/_assets/showcases/aws/account-profile.png)<br>
1. Instale las últimas bibliotecas de NuGet.<br>
![Administrador de NuGet](/_assets/showcases/aws/nuget-manager.png)<br>
1. Ejemplo de código para convertir una imagen CAD a un archivo PDF.
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
1. Edite el DockerFile como en la sección <a href="#configuring-a-dockerfile">Configuración de un Dockerfile</a>.
1. Inicie Docker Desktop.
1. Publique en AWS Lambda.<br>
![Publicación en AWS lambda](/_assets/showcases/aws/publish-aws.png)<br>
1. Edite la configuración de carga.<br>
![Subir AWS Lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Haga clic en el botón 'Subir'.<br>
![Subir AWS Lambda último](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Vaya a AWS y seleccione Lambda.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Seleccione su nueva función y cree la URL de la función.<br>
![Configuración de la URL de la función](/_assets/showcases/aws/create-function-url.png)<br>
1. Seleccione el tipo de autenticación
- AWS_IAM - Solo los usuarios y roles IAM autenticados pueden realizar solicitudes a la URL de su función.
- NONE - Lambda no realizará autenticación IAM en las solicitudes a la URL de su función. El punto final de la URL será público a menos que implemente su propia lógica de autorización en su función.

### Configuración de un Dockerfile

 El siguiente paso es editar la configuración del Dockerfile en el proyecto.

1. En el Dockerfile, especifique:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Lo anterior es un Dockerfile simple, que contiene las siguientes instrucciones:

- La imagen del SDK que se utilizará. Aquí está la imagen de Net 6. Docker la descargará cuando se ejecute la construcción. La versión del SDK se especifica como una etiqueta.
- Después, puede necesitar instalar fuentes porque la imagen del SDK contiene muy pocas fuentes. Además, puede usar fuentes locales copiadas en la imagen docker.
- El directorio de trabajo, que se especifica en la siguiente línea.
- El comando para copiar todo al contenedor, publicar la aplicación y especificar el punto de entrada.

## Ejemplo de ejecución

1. Configuración de Postman.<br>
![Menú de la vista general](/_assets/showcases/aws/postman-settings.png)<br>
1. Seleccione cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Haga clic en el botón enviar.

{{% alert color="primary" %}} 
Si la respuesta es exitosa, haga clic en Guardar en archivo y recibirá el archivo convertido en formato pdf.
{{% /alert %}}

## Más Ejemplos

Para más muestras de cómo puede utilizar Aspose.CAD en Docker, consulte los [ejemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Ver También.

- [Instalar AWS Toolkit para Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instalar Docker Desktop en Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop en Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Opción [Cambiar a contenedores de Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Información adicional sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
