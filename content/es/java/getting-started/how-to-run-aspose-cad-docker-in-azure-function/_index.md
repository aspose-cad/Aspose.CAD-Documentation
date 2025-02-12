---
title: Cómo ejecutar la imagen Docker de Aspose.CAD en Azure Function
type: docs
description: "Ejecutar la imagen Docker de Aspose.CAD en Azure Function."
weight: 71
url: /es/java/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Prerrequisitos
- Docker debe estar instalado en su sistema. Para obtener información sobre cómo instalar Docker en Windows o Mac, consulte los enlaces en la sección "Ver también".
- IntelliJ IDEA.
- Azure Toolkit para IntelliJ.
- Postman.

## Azure Function

En este ejemplo, crea una función de conversión simple que convierte un archivo CAD y lo guarda como una imagen. La aplicación se puede construir en Docker y ejecutarse en Azure Function.

## Creando la Azure Function

Para crear el programa de Azure Function, siga los pasos a continuación:
1. Una vez que Docker esté instalado, asegúrese de que utiliza contenedores de Linux (por defecto). Si es necesario, seleccione la opción Cambiar a contenedores de Linux en el menú de Docker Desktop.
1. Crear un proyecto de Azure Function en IntelliJ IDEA.<br>
![Crear proyecto de función de Azure](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Crear proyecto de función de Azure - final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Herramientas->Azure->Iniciar sesión y seleccione la autenticación OAuth 2.0.<br>
![Iniciar sesión en Azure](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Inicie sesión en el navegador.
1. Seleccione el nombre de la suscripción.
1. Agregue soporte para Docker.<br>
![Agregar soporte de Docker](/_assets/java/java-azure/add-docker-support.png)<br>
1. Edite el DockerFile como en la sección <a href="#configuring-a-dockerfile">Configurando un Dockerfile</a>.
1. Agregue bloques para el repositorio aspose.cad en pom.xml.
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

1. Cuando todas las dependencias requeridas estén añadidas, escriba un programa simple que crea una elipse y la guarda como una imagen:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Esta función escucha en el punto de entrada "/api/HttpExample". Dos formas de invocarla utilizando el comando "curl" en bash:
     * 1. curl -d "Cuerpo HTTP" {tu host}/api/HttpExample
     * 2. curl "{tu host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("El desencadenador HTTP de Java procesó una solicitud.");

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

### Configurando un Dockerfile

 El siguiente paso es crear y configurar el Dockerfile en la carpeta raíz del proyecto.

1. En el Dockerfile, especifique:
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

 Lo anterior es un Dockerfile simple, que contiene las siguientes instrucciones:

- La imagen del SDK que se va a utilizar. Docker la descargará cuando se ejecute la construcción. La versión del SDK se especifica como una etiqueta.
- El directorio de trabajo, que se especifica en la siguiente línea.
- El comando para copiar todo al contenedor, publicar la aplicación y especificar el punto de entrada.

## Docker Hub
1. Iniciar sesión en Docker Hub
1. Crear un repositorio público

## Construyendo y ejecutando la aplicación en Docker
 
 Ahora se puede construir y ejecutar la aplicación en Docker. Abra su terminal favorita, cambie el directorio a la carpeta con la aplicación (la carpeta donde se encuentra el archivo de solución y el Dockerfile) y ejecute el siguiente comando:

1. Comando de Dockerfile build en la consola
{{< highlight plain >}}
//ejemplo
docker build -t <nombre de usuario>/<nombre del repositorio> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. La primera vez que ejecute este comando, puede tardar más porque Docker necesita descargar las imágenes necesarias. Después de que se complete el comando anterior, ejecute el siguiente comando para enviar la imagen a Docker Hub.
{{< highlight plain >}}
//ejemplo
docker push <nombre de usuario>/<nombre del repositorio>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Ejecutar dockerfile en IDE y después enviar a Docker Hub.<br>
![Ejecutar docker en ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Ingrese el nombre de la imagen, como en el repositorio de Docker Hub.<br>
![Ejecutar docker en ide-siguiente](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Espere a que finalice.

## Azure

1. Inicie sesión en Azure.
1. Elija los servicios de Azure.
1. Elija Function App y cree una función.<br>
![Botón de crear función de Azure](/_assets/java/java-azure/create-function-azure.png)<br>
1. Repita la configuración básica como en la imagen a continuación.<br>
![Configuración de función de Azure](/_assets/java/java-azure/create-function-settings.png)<br>
1. Haga clic en 'Revisar + crear' -> Crear.
1. Espere a que la implementación termine.
1. Haga clic en el botón 'Ir al recurso'.<br>
![Botón de recurso](/_assets/java/java-azure/go-to-resource.png)<br>
1. Detener la función aspose-cad-docker-example.<br>
![Detener contenedor](/_assets/java/java-azure/stop-container.png)<br>
1. Vaya al menú del centro de implementación y realice las configuraciones adecuadas.<br>
![Centro de implementación](/_assets/java/java-azure/deployment-center.png)<br>
1. Guardar configuraciones
1. Copie la URL del Webhook de la configuración del centro de implementación.<br>
![URL del Webhook](/_assets/java/java-azure/webhook-url.png)<br>
1. Vaya a Docker Hub, seleccione su repositorio y seleccione webhooks.
1. Pegue la 'URL del Webhook' de Azure en la URL del Webhook de Docker Hub y establezca el nombre.<br>
![Configuraciones del Webhook en Docker](/_assets/java/java-azure/webhook.png)<br>
1. Haga clic en el botón de crear.
1. Regrese a la función de Azure y inicie el contenedor.<br>
![Menú de resumen](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Puede tardar unos minutos en que la función se inicie.
{{% /alert %}}

## Ejemplo de ejecución

1. Configuraciones de Postman.<br>
![Configuraciones de Postman](/_assets/java/java-azure/postman-settings.png)<br>
1. Seleccione cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Haga clic en el botón enviar.
1. Guardar resultado
![Guardar respuesta](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Si la respuesta es exitosa, haga clic en Guardar en archivo y recibirá el archivo convertido en formato png.
{{% /alert %}}

## Más ejemplos

Para más muestras de cómo puede usar Aspose.CAD en Docker, consulte los [ejemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Ver también

- [Instalar Docker Desktop en Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop en Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Cambiar a contenedores de Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opción
