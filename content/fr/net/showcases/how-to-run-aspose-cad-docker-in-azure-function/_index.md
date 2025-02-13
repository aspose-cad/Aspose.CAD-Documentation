---
title: Comment exécuter l'image Docker Aspose.CAD dans Azure Function
type: docs
description: "Exécutez l'image Docker Aspose.CAD dans Azure Function."
weight: 73
url: /fr/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Prérequis
- Docker doit être installé sur votre système. Pour des informations sur l'installation de Docker sur Windows ou Mac, consultez les liens dans la section « Voir aussi ».
- Visual Studio 2022.
- Le SDK .NET 6 est utilisé dans l'exemple.
- Postman

## Fonction Azure

Dans cet exemple, vous créez une fonction de conversion simple qui convertit un fichier CAD et l'enregistre sous forme d'image. L'application peut ensuite être construite dans Docker et exécutée dans Azure Function.

## Création de la fonction Azure

Pour créer le programme de fonction Azure, suivez les étapes ci-dessous :
1. Une fois Docker installé, assurez-vous qu'il utilise les conteneurs Linux (par défaut). Si nécessaire, sélectionnez l'option Passer aux conteneurs Linux dans le menu Docker Desktops.
1. Dans Visual Studio, créez une fonction Azure NET 6.<br>
![Une boîte de dialogue de projet Azure Function NET 6](/_assets/showcases/azure/Create-project.png)<br>
1. Informations supplémentaires.<br>
![Une boîte de dialogue de projet Azure Function NET 6](/_assets/showcases/azure/Additional-information.png)<br>
1. Installez la dernière version d'Aspose.CAD depuis NuGet.<br>
![Aspose.CAD sur NuGet](/_assets/showcases/azure/NuGet.png)<br>
1. Étant donné que l'application sera exécutée sur Linux, vous devrez peut-être installer des polices supplémentaires. Vous pouvez préférer ttf-mscorefonts-installer.
1. Lorsque toutes les dépendances requises sont ajoutées, écrivez un programme simple qui crée une ellipse et l'enregistre sous forme d'image :<br>

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

### Configuration d'un Dockerfile

 La prochaine étape consiste à créer et configurer le Dockerfile dans le dossier racine du projet.

1. Créez le Dockerfile et placez-le à côté du fichier de solution de votre application. Gardez ce nom de fichier sans extension (par défaut).
![Dossier racine du projet](/_assets/showcases/azure/root-folder.png)<br>
1. Dans le Dockerfile, spécifiez :

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

 Ce qui précède est un Dockerfile simple, qui contient les instructions suivantes :

- L'image SDK à utiliser. Ici, c'est l'image .NET 6. Docker la téléchargera lorsque la construction sera exécutée. La version du SDK est spécifiée comme un tag.
- Ensuite, vous devrez peut-être installer des polices car l'image SDK contient très peu de polices. De plus, vous pouvez utiliser des polices locales copiées dans l'image Docker.
- Le répertoire de travail, qui est spécifié dans la ligne suivante.
- La commande pour copier tout dans le conteneur, publier l'application et spécifier le point d'entrée.

## Docker Hub
1. Connexion à Docker Hub
1. Créez un dépôt public

## Construction et exécution de l'application dans Docker
 
 Maintenant, l'application peut être construite et exécutée dans Docker. Ouvrez votre invite de commande préférée, changez de répertoire vers le dossier avec l'application (dossier où le fichier de solution et le Dockerfile sont placés) et exécutez la commande suivante :

{{< highlight plain >}}
//exemple
docker build -t <nom d'utilisateur>/<nom du dépôt> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
La première fois que vous exécutez cette commande, cela peut prendre plus de temps car Docker doit télécharger les images nécessaires. Une fois la commande précédente terminée, exécutez la commande suivante pour pousser l'image vers docker hub :
 
{{< highlight plain >}}
//exemple
docker push <nom d'utilisateur>/<nom du dépôt>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Connexion à Azure.
1. Choisissez les services Azure.
1. Choisissez Function App et créez une fonction.<br>
![Bouton créer une fonction Azure](/_assets/showcases/azure/create-function.png)<br>
1. Répétez les paramètres de base comme dans l'image ci-dessous.<br>
![Paramètres de création de fonction Azure](/_assets/showcases/azure/create-function-setting.png)<br>
1. Cliquez sur 'Examiner + créer' -> Créer.
1. Attendez que le déploiement se termine.
1. Cliquez sur le bouton 'Accéder à la ressource'.<br>
![Bouton Ressource](/_assets/showcases/azure/go-to-resource.png)<br>
1. Arrêtez la fonction aspose-cad-docker-example.<br>
![Arrêter le conteneur](/_assets/showcases/azure/stop-container.png)<br>
1. Allez dans le menu du centre de déploiement et faites les réglages appropriés.<br>
![Centre de déploiement](/_assets/showcases/azure/deployment-center.png)<br>
1. Enregistrez les paramètres
1. Copiez l'URL du Webhook des paramètres du centre de déploiement.<br>
![URL du Webhook](/_assets/showcases/azure/webhook-url.png)<br>
1. Allez sur Docker Hub, sélectionnez votre dépôt et sélectionnez les webhooks.
1. Collez l'URL du 'Webhook' d'Azure dans l'URL du webhook Docker Hub et définissez le nom.<br>
![Paramètres du webhook dans Docker](/_assets/showcases/azure/webhook.png)<br>
1. Cliquez sur le bouton créer.
1. Retournez au menu de synthèse de la fonction Azure et démarrez le conteneur.<br>
![Menu de synthèse](/_assets/showcases/azure/overview.png)<br>

## Exemple d'exécution

1. Paramètres de Postman.<br>
![Paramètres de Postman](/_assets/showcases/azure/postman-settings.png)<br>
1. Sélectionnez n'importe quel fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Cliquez sur le bouton envoyer.

{{% alert color="primary" %}} 
Si la réponse est réussie, cliquez sur Enregistrer dans le fichier et vous recevrez le fichier converti au format png.
{{% /alert %}}

## Autres exemples

Pour plus d'exemples sur la façon d'utiliser Aspose.CAD dans Docker, consultez les [exemples](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Voir aussi

- [Installer Docker Desktop sur Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installer Docker Desktop sur Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Option [Passer aux conteneurs Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Informations supplémentaires sur [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
