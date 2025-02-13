---
title: Comment exécuter Aspose.CAD dans Docker
type: docs
description: "Exécutez Aspose.CAD dans un conteneur Docker pour Linux, Windows Server et tout autre OS."
weight: 71
url: /fr/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Prérequis
- Docker doit être installé sur votre système. Pour des informations sur la façon d'installer Docker sur Windows ou Mac, référez-vous aux liens de la section "Voir aussi".
- Visual Studio 2022.
- Le SDK NET 6 est utilisé dans cet exemple.

## Application Hello World

Dans cet exemple, vous créez une simple application console Hello World qui dessine une ellipse et l'enregistre en tant qu'image. L'application peut ensuite être construite et exécutée dans Docker.

## Création de l'application console

Pour créer le programme Hello World, suivez les étapes ci-dessous :
1. Une fois Docker installé, assurez-vous qu'il utilise des conteneurs Linux (par défaut). Si nécessaire, sélectionnez l'option Passer aux conteneurs Linux dans le menu de Docker Desktop.
1. Dans Visual Studio, créez une application console NET 6.<br>
![Une boîte de dialogue de projet d'application console NET 6](/_assets/showcases/docker/1.png)<br>
1. Installez la dernière version d'Aspose.CAD depuis NuGet.<br>
![Aspose.CAD sur NuGet](/_assets/showcases/docker/2.png)<br>
1. Étant donné que l'application sera exécutée sur Linux, vous devrez peut-être installer des polices supplémentaires. Vous pourriez préférer ttf-mscorefonts-installer.
1. Lorsque toutes les dépendances nécessaires sont ajoutées, écrivez un programme simple qui crée une ellipse et l'enregistre en tant qu'image :<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Notez que le dossier "TestOut" est spécifié comme dossier de sortie pour l'enregistrement des documents de sortie. Lors de l'exécution de l'application dans Docker, un dossier sur la machine hôte sera monté dans ce dossier dans le conteneur. Cela vous permettra de visualiser facilement les résultats générés par Aspose.CAD dans le conteneur Docker.

### Configuration d'un Dockerfile

 La prochaine étape consiste à créer et configurer le Dockerfile.

1. Créez le Dockerfile et placez-le à côté du fichier de solution de votre application. Gardez ce nom de fichier sans extension (par défaut).
1. Dans le Dockerfile, spécifiez :

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

 Ce Dockerfile est simple et contient les instructions suivantes :

- L'image SDK à utiliser. Ici, c'est l'image NET 6. Docker la téléchargera lorsque la construction sera exécutée. La version de SDK est spécifiée comme tag.
- Après, vous devrez peut-être installer des polices car l'image SDK contient très peu de polices. De plus, vous pouvez utiliser les polices locales copiées dans l'image Docker.
- Le répertoire de travail, qui est spécifié à la ligne suivante.
- La commande pour copier tout dans le conteneur, publier l'application, et spécifier le point d'entrée.

## Construction et exécution de l'application dans Docker

 Maintenant, l'application peut être construite et exécutée dans Docker. Ouvrez votre invite de commande préférée, changez de répertoire vers le dossier contenant l'application (dossier où le fichier de solution et le Dockerfile sont placés) et exécutez la commande suivante :

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

 La première fois que cette commande est exécutée, elle peut prendre plus de temps, car Docker doit télécharger les images requises. Une fois la commande précédente terminée, exécutez la commande suivante :

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Faites attention à l'argument de montage, car, comme mentionné précédemment, un dossier sur la machine hôte est monté dans le dossier du conteneur, pour voir facilement les résultats de l'exécution de l'application. Les chemins en Linux sont sensibles à la casse.
{{% /alert %}}

## Plus d'exemples

Pour plus d'exemples sur la façon dont vous pouvez utiliser Aspose.CAD dans Docker, consultez les [exemples](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Voir aussi

- [Installer Docker Desktop sur Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installer Docker Desktop sur Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Option Passer aux conteneurs Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Informations supplémentaires sur [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
