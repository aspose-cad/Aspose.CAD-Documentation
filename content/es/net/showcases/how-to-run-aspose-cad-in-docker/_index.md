---
title: Cómo ejecutar Aspose.CAD en Docker
type: docs
description: "Ejecute Aspose.CAD en un contenedor Docker para Linux, Windows Server y cualquier sistema operativo."
weight: 71
url: /es/net/showcases/how-to-run-aspose-cad-in-docker
---

## Requisitos previos
- Docker debe estar instalado en su sistema. Para obtener información sobre cómo instalar Docker en Windows o Mac, consulte los enlaces en la sección "Ver también".
- Visual Studio 2022.
- Se utiliza el SDK de .NET 6 en el ejemplo.

## Aplicación Hello World

En este ejemplo, creará una simple aplicación de consola Hello World que dibuja una elipse y la guarda como una imagen. La aplicación puede ser construida y ejecutada en Docker.

## Crear la aplicación de consola

Para crear el programa Hello World, siga los pasos a continuación:
1. Una vez que Docker esté instalado, asegúrese de que use contenedores de Linux (por defecto). Si es necesario, seleccione la opción Cambiar a contenedores de Linux en el menú de Docker Desktop.
2. En Visual Studio, cree una aplicación de consola .NET 6.<br>
![Un diálogo de proyecto de aplicación de consola .NET 6](/_assets/1.png)<br>
3. Instale la última versión de Aspose.CAD desde NuGet.<br>
![Aspose.CAD en NuGet](/_assets/2.png)<br>
4. Dado que la aplicación se ejecutará en Linux, puede ser necesario instalar fuentes adicionales. Podría preferir ttf-mscorefonts-installer.
5. Cuando se hayan agregado todas las dependencias necesarias, escriba un simple programa que cree una elipse y la guarde como una imagen:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Tenga en cuenta que la carpeta "TestOut" se ha especificado como una carpeta de salida para guardar documentos de salida. Al ejecutar la aplicación en Docker, una carpeta en la máquina anfitriona se montará en esta carpeta en el contenedor. Esto le permitirá ver fácilmente la salida generada por Aspose.CAD en el contenedor de Docker.

### Configuración de un Dockerfile

 El siguiente paso es crear y configurar el Dockerfile.

1. Cree el Dockerfile y colóquelo junto al archivo de solución de su aplicación. Mantenga este nombre de archivo sin extensión (el predeterminado).
2. En el Dockerfile, especifique:


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
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

 Lo anterior es un Dockerfile simple, que contiene las siguientes instrucciones:

- La imagen del SDK que se utilizará. Aquí está la imagen de .NET 6. Docker la descargará cuando se ejecute la construcción. La versión del SDK se especifica como una etiqueta.
- Después, puede ser necesario instalar fuentes porque la imagen del SDK contiene muy pocas fuentes. Además, puede usar fuentes locales copiadas a la imagen de Docker.
- El directorio de trabajo, que se especifica en la siguiente línea.
- El comando para copiar todo al contenedor, publicar la aplicación y especificar el punto de entrada.


## Construcción y ejecución de la aplicación en Docker
 
 Ahora la aplicación puede ser construida y ejecutada en Docker. Abra su terminal preferida, cambie el directorio a la carpeta con la aplicación (carpeta donde se encuentran el archivo de solución y el Dockerfile) y ejecute el siguiente comando:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

 La primera vez que se ejecute este comando, puede tardar más, ya que Docker necesita descargar las imágenes requeridas. Una vez que se complete el comando anterior, ejecute el siguiente comando:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Preste atención al argumento de montaje, porque, como se mencionó anteriormente, una carpeta en la máquina anfitriona se monta en la carpeta del contenedor, para ver fácilmente los resultados de la ejecución de la aplicación. Las rutas en Linux son sensibles a mayúsculas y minúsculas.
{{% /alert %}}

## Más ejemplos

Para más muestras de cómo puede usar Aspose.CAD en Docker, consulte los [ejemplos](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Ver también

- [Instalar Docker Desktop en Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalar Docker Desktop en Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK de .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- opción [Cambiar a contenedores de Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Información adicional sobre [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
