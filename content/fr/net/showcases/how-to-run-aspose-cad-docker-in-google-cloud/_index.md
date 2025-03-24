---
title: Comment exécuter l'image Docker Aspose.CAD dans Google Cloud
type: docs
description: "Exécutez l'image Docker Aspose.CAD dans Google Cloud."
weight: 75
url: /fr/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Prérequis

- Docker doit être installé sur votre système. Pour des informations sur comment installer Docker sur Windows ou Mac, consultez les liens dans la section « Voir aussi ».
- Visual Studio 2022.
- Google CLI.
- Le SDK NET Core 3.1 est utilisé dans l'exemple.
- Postman

## Fonction de Google Cloud Run

Cloud Run est un environnement informatique géré pour déployer et mettre à l'échelle des conteneurs HTTP sans serveur, sans se soucier de l'approvisionnement des machines, de la configuration des clusters ou de l'autoscaling.

- Pas de verrouillage du fournisseur - Comme Cloud Run utilise des conteneurs OCI standard et implémente l'API standard Knative Serving, vous pouvez facilement transférer vos applications vers un environnement sur site ou tout autre environnement cloud. 
- Autoscaling rapide - Les microservices déployés dans Cloud Run se mettent à l'échelle automatiquement en fonction du nombre de requêtes entrantes, sans que vous ayez à configurer ou gérer un cluster Kubernetes complet. Cloud Run s'échelle à zéro - c'est-à-dire qu'il n'utilise aucune ressource - s'il n'y a pas de requêtes.
- Trafic partagé - Cloud Run vous permet de diviser le trafic entre plusieurs révisions, afin que vous puissiez effectuer des déploiements progressifs tels que des déploiements canari ou des déploiements bleu/vert.
- Domaines personnalisés - Vous pouvez configurer la cartographie de domaines personnalisés dans Cloud Run et il provisionnera un certificat TLS pour votre domaine. 
- Redondance automatique - Cloud Run offre une redondance automatique, vous n'avez donc pas à vous soucier de créer plusieurs instances pour une haute disponibilité.

Cloud Run et Cloud Functions sont tous deux des services entièrement gérés qui s'exécutent sur l'infrastructure sans serveur de Google Cloud, se mettent à l'échelle automatiquement et gèrent les requêtes HTTP ou les événements. Cependant, ils présentent des différences importantes :

- Cloud Functions vous permet de déployer des extraits de code (fonctions) écrits dans un ensemble limité de langages de programmation, tandis que Cloud Run vous permet de déployer des images de conteneurs en utilisant le langage de programmation de votre choix. 
- Cloud Run prend également en charge l'utilisation de tout outil ou bibliothèque système de votre application ; Cloud Functions ne vous permet pas d'utiliser des exécutables personnalisés. 
- Cloud Run offre une durée de timeout de requête plus longue allant jusqu'à 60 minutes, tandis qu'avec Cloud Functions, le timeout des requêtes peut être défini jusqu'à 9 minutes. 
- Cloud Functions n'envoie qu'une seule requête à la fois à chaque instance de fonction, tandis que par défaut, Cloud Run est configuré pour envoyer plusieurs requêtes concurrentes sur chaque instance de conteneur. Cela est utile pour améliorer la latence et réduire les coûts si vous attendez des volumes importants. 

## Création du projet Google Cloud Function

{{% alert color="primary" %}} 
Assurez-vous que vous disposez de droits suffisants pour créer des fonctions Google Cloud Run et des images dans le référentiel Artifact Registry.
{{% /alert %}}

Pour créer le programme Google Cloud Function, suivez les étapes ci-dessous :

1. Installez le SDK .NET Core 3.1.
2. Installez le package de modèle :
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
3. Ensuite, créez un répertoire pour votre projet et utilisez dotnet new pour créer une nouvelle fonction HTTP :
{{< highlight plain >}}
mkdir AsposeFunctions //créer un dossier
cd AsposeFunctions //aller dans le dossier AsposeFunctions
dotnet new gcf-http //créer le projet Google Cloud Function avec un déclencheur HTTP
{{< /highlight >}}
{{% alert color="primary" %}} 
Cela crée AsposeFunctions.csproj et Function.cs dans le répertoire courant. Ouvrez Function.cs pour revoir le code, et fournissez un message personnalisé si vous le souhaitez.
{{% /alert %}}
4. Exemple de code pour le fichier csproj (AsposeFunctions.csproj).
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
5. Exemple de code pour convertir l'image cad en fichier png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// La logique pour votre fonction va ici.
        /// </summary>
        /// <param name="context">Le contexte HTTP, contenant la requête et la réponse.</param>
        /// <returns>Une tâche représentant l'opération asynchrone.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //fichier de formulaire
                var file = context.Request.Body; //données binaires
                
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
6. Construisez votre fonction localement comme suit :
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
7. Une fois que le serveur est en cours d'exécution, accédez à http://localhost:8080 pour invoquer la fonction. Appuyez sur Ctrl-C dans la console pour arrêter le serveur.

## Déployer l'image docker sur Google Cloud

1. Connectez-vous à Google Cloud.
2. Créez un projet s'il n'existe pas.
3. Allez dans 'Artifact Registry' et créez un référentiel.<br>
![Créer un référentiel d'artifacts](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
4. Sélectionnez le nouveau référentiel dans Artifact Registry.
![Sélectionner le référentiel d'artifacts](/cad/_assets/showcases/google/select-artifact.png)<br>
5. Cliquez sur 'INSTRUCTIONS DE CONFIGURATION' et copiez la commande 'Configurer Docker'.<br>
![INSTRUCTIONS DE CONFIGURATION](/cad/_assets/showcases/google/setup-instruction.png)<br>
6. Ajoutez une entrée credHelper Docker au fichier de configuration Docker, ou créez le fichier s'il n'existe pas.
{{< highlight plain >}}
//exemple
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
7. Créez un Dockerfile dans le répertoire racine du projet et modifiez le DockerFile comme dans la section <a href="#configuring-a-dockerfile">Configuration d'un Dockerfile</a>.
8. Démarrez Docker Desktop.
9. Construisez l'image docker avec le chemin du référentiel cloud.
{{< highlight plain >}}
//exemple
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
10. Poussez l'image vers le Google Cloud Artifact Registry
{{< highlight plain >}}
//exemple
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Créer un service Google Cloud Run 

1. Allez dans Cloud Run.
2. Créez un service Cloud Run.<br>
![Créer un service Cloud Run](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
3. Dans le champ URL de l'image du conteneur, sélectionnez le conteneur de 'REGISTRE D'ARTIFACTS'.<br>
![URL de l'image du conteneur](/cad/_assets/showcases/google/container-url.png)<br>
4. Vérifiez les autres paramètres comme ci-dessous.<br>
![Paramètres du service](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
5. Attendez que le déploiement soit terminé.
6. URL du service à utiliser avec l'application de conversion.<br>
![Url service](/cad/_assets/showcases/google/url-service.png)<br>

### Configuration d'un Dockerfile

 L'étape suivante consiste à modifier le Dockerfile dans le projet.

1. Dans le Dockerfile, spécifiez :

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

 Ce qui précède est un Dockerfile simple, qui contient les instructions suivantes :

- L'image SDK à utiliser. Ici, il s'agit de l'image Net Core 3.1. Docker la téléchargera lorsque la construction sera lancée. La version du SDK est spécifiée comme une balise.
- Après, vous devrez peut-être installer des polices car l'image SDK contient très peu de polices. De plus, vous pouvez utiliser des polices locales copiées dans l'image docker.
- Le répertoire de travail, qui est spécifié à la ligne suivante.
- La commande pour tout copier dans le conteneur, publier l'application et spécifier le point d'entrée.

## Exemple d'exécution

1. Paramètres de Postman.<br>
![Menu d'aperçu](/cad/_assets/showcases/google/postman-settings.png)<br>
2. Sélectionnez n'importe quel fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
3. Cliquez sur le bouton envoyer.

{{% alert color="primary" %}} 
Si la réponse est réussie, cliquez sur Enregistrer dans un fichier et vous recevrez le fichier converti au format png
{{% /alert %}}

## Plus d'exemples

Pour plus d'exemples sur la façon dont vous pouvez utiliser Aspose.CAD dans Docker, consultez les [exemples](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Voir aussi.

- [Installer Docker Desktop sur Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installer Docker Desktop sur Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Passer aux conteneurs Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option
- Informations supplémentaires sur [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
