---
title: Comment exécuter l'image Docker Aspose.CAD dans Azure Function
type: docs
description: "Exécutez l'image Docker Aspose.CAD dans Azure Function."
weight: 71
url: /fr/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Prérequis
- Docker doit être installé sur votre système. Pour des informations sur la façon d'installer Docker sur Windows ou Mac, reportez-vous aux liens dans la section “Voir aussi”.
- IntelliJ IDEA.
- Azure Toolkit pour IntelliJ.
- Postman.

## Azure Function

Dans cet exemple, vous créez une fonction de conversion simple qui convertit un fichier CAD et le sauvegarde sous forme d'image. L'application peut ensuite être construite dans Docker et exécutée dans Azure Function.

## Création de la Fonction Azure

Pour créer le programme de la Fonction Azure, suivez les étapes ci-dessous :
1. Une fois Docker installé, assurez-vous qu'il utilise des conteneurs Linux (par défaut). Si nécessaire, sélectionnez l'option Passer à des conteneurs Linux dans le menu de Docker Desktop.
1. Créez un projet de fonction Azure dans IntelliJ IDEA.<br>
![Créer un projet de fonction azure](/cad/_assets/java/java-azure/create-function-ide-1.png)<br>
![Créer un projet de fonction azure-final](/cad/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Outils->Azure->Se connecter et sélectionner l'authentification OAuth 2.0.<br>
![Connexion Azure](/cad/_assets/java/java-azure/sign-in-azure.png)<br>
1. Connectez-vous sur le navigateur.
1. Sélectionnez le nom de l'abonnement.
1. Ajoutez le support de Docker.<br>
![Ajoutez le support de Docker](/cad/_assets/java/java-azure/add-docker-support.png)<br>
1. Modifiez le DockerFile comme dans la section <a href="#configuring-a-dockerfile">Configuration d'un Dockerfile</a>.
1. Ajoutez des blocs pour le dépôt aspose.cad dans pom.xml.
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

1. Une fois toutes les dépendances nécessaires ajoutées, écrivez un simple programme qui crée une ellipse et la sauvegarde sous forme d'image :<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Cette fonction écoute à l'endpoint "/api/HttpExample". Deux façons de l'invoquer en utilisant la commande "curl" dans bash :
     * 1. curl -d "Corps HTTP" {votre hôte}/api/HttpExample
     * 2. curl "{votre hôte}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Le déclencheur HTTP Java a traité une demande.");

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

### Configuration d'un Dockerfile

 L'étape suivante consiste à créer et configurer le Dockerfile dans le dossier principal du projet.

1. Dans le Dockerfile, spécifiez :
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

 Le fichier ci-dessus est un Dockerfile simple, qui contient les instructions suivantes :

- L'image SDK à utiliser. Docker la téléchargera lorsque la construction sera exécutée. La version de SDK est spécifiée comme une balise.
- Le répertoire de travail, qui est spécifié à la ligne suivante.
- La commande pour tout copier dans le conteneur, publier l'application et spécifier le point d'entrée.

## Docker Hub
1. Connectez-vous à Docker Hub
1. Créez un dépôt public

## Construction et exécution de l'application dans Docker
 
 Maintenant, l'application peut être construite et exécutée dans Docker. Ouvrez votre terminal préféré, changez de répertoire pour le dossier contenant l'application (dossier où le fichier de solution et le Dockerfile sont placés) et exécutez la commande suivante :


1. Commande de construction du dockerfile dans la console
{{< highlight plain >}}
//exemple
docker build -t <nom d'utilisateur>/<nom du dépôt> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. La première fois que vous exécutez cette commande, elle peut prendre plus de temps car Docker doit télécharger les images nécessaires. Une fois la commande précédente terminée, exécutez la commande suivante pour pousser l'image vers Docker Hub.
{{< highlight plain >}}
//exemple
docker push <nom d'utilisateur>/<nom du dépôt>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Exécutez le dockerfile dans l'IDE et après poussez vers Docker Hub.<br>
![Exécutez docker dans ide](/cad/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Entrez le nom de l'image, comme dans le dépôt Docker Hub.<br>
![Exécutez docker dans ide-next](/cad/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Attendez la fin.

## Azure

1. Connectez-vous à Azure.
1. Choisissez les services Azure.
1. Choisissez Fonction App et créez une fonction.<br>
![Bouton de création de fonction Azure](/cad/_assets/java/java-azure/create-function-azure.png)<br>
1. Répétez les paramètres de base comme sur l'image ci-dessous.<br>
![Paramètres de création de fonction Azure](/cad/_assets/java/java-azure/create-function-settings.png)<br>
1. Cliquez sur 'Revue + créer' -> Créer.
1. Attendez que le déploiement se termine.
1. Cliquez sur le bouton 'Aller à la ressource'.<br>
![Bouton de ressource](/cad/_assets/java/java-azure/go-to-resource.png)<br>
1. Arrêtez la fonction aspose-cad-docker-example.<br>
![Arrêter le conteneur](/cad/_assets/java/java-azure/stop-container.png)<br>
1. Allez dans le menu du centre de déploiement et effectuez les paramètres appropriés.<br>
![Centre de déploiement](/cad/_assets/java/java-azure/deployment-center.png)<br>
1. Enregistrez les paramètres
1. Copiez l'URL du Webhook à partir des paramètres du centre de déploiement.<br>
![URL du Webhook](/cad/_assets/java/java-azure/webhook-url.png)<br>
1. Allez sur Docker Hub, sélectionnez votre dépôt et sélectionnez webhooks.
1. Collez l'URL du Webhook de Azure dans l'URL webhook de Docker Hub et définissez le nom.<br>
![Paramètres du Webhook dans Docker](/cad/_assets/java/java-azure/webhook.png)<br>
1. Cliquez sur le bouton de création.
1. Retournez à l'aperçu de la fonction Azure et démarrez le conteneur.<br>
![Menu d'aperçu](/cad/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Il peut falloir quelques minutes pour que la fonction démarre.
{{% /alert %}}

## Exemple d'exécution

1. Paramètres de Postman.<br>
![Menu d'aperçu](/cad/_assets/java/java-azure/postman-settings.png)<br>
1. Sélectionnez n'importe quel fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Cliquez sur le bouton d'envoi.
1. Sauvegardez le résultat
![Sauvegarder la réponse](/cad/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Si la réponse est réussie, cliquez sur Enregistrer dans le fichier et vous recevrez le fichier converti au format png
{{% /alert %}}

## Plus d'exemples

Pour plus d'exemples de la manière dont vous pouvez utiliser Aspose.CAD dans Docker, consultez les [exemples](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Voir aussi

- [Installer Docker Desktop sur Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installer Docker Desktop sur Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- Option [Passer aux conteneurs Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
