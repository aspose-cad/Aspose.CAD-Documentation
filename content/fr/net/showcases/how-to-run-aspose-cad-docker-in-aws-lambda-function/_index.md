---
title: Comment exécuter l'image Docker Aspose.CAD dans une fonction AWS Lambda
type: docs
description: "Exécuter l'image Docker Aspose.CAD dans une fonction AWS Lambda."
weight: 74
url: /fr/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Prérequis
- Docker doit être installé sur votre système. Pour des informations sur la manière d'installer Docker sur Windows ou Mac, consultez les liens dans la section “Voir aussi”.
- Visual Studio 2022.
- AWS Toolkit pour Visual Studio 2022.
- Le SDK NET 6 est utilisé dans l'exemple.
- Postman

## Fonction AWS Lambda

Lambda est un service de calcul qui vous permet d'exécuter du code sans provisionner ou gérer des serveurs. Lambda exécute votre code sur une infrastructure de calcul à haute disponibilité et effectue toute l'administration des ressources de calcul, y compris la maintenance des serveurs et du système d'exploitation, la provision de capacité et la mise à l'échelle automatique, et la journalisation. Avec Lambda, vous pouvez exécuter du code pour pratiquement tout type d'application ou de service backend.

## Création de la fonction AWS Lambda

{{% alert color="primary" %}} 
Assurez-vous d'avoir les droits suffiants pour créer des fonctions AWS Lambda et des images dans le registre de conteneurs élastiques Amazon.
{{% /alert %}}

Pour créer le programme de fonction AWS Lambda, suivez les étapes ci-dessous :
1. Créez un projet AWS Lambda.<br>
![Créez un bouton de fonction AWS](/cad/_assets/showcases/aws/create-project.png)<br>
1. Sélectionnez .NET 6 (Image de conteneur) et cliquez sur le bouton 'Terminer'.<br>
![Créez un bouton de fonction de conteneur](/cad/_assets/showcases/aws/create-container.png)<br>
1. Ouvrez AWS Explorer dans Visual Studio (Affichage->AWS Explorer).
1. Ajoutez le profil d'identifiants AWS dans AWS Explorer.<br>
![Profil d'identifiants](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Entrez l'ID de clé d'accès et la clé d'accès secrète, vous pouvez obtenir ces clés dans les identifiants de sécurité ou contacter l'administrateur et obtenir un fichier csv pour l'autorisation.<br>
![Paramètres du profil de compte](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Installez les dernières bibliothèques depuis NuGet.<br>
![Gestionnaire NuGet](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Exemple de code pour convertir une image cad en fichier pdf.
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
1. Modifiez le DockerFile comme dans la section <a href="#configuring-a-dockerfile">Configuration d'un Dockerfile</a>.
1. Démarrez Docker Desktop.
1. Publiez sur AWS Lambda.<br>
![Publier sur AWS lambda](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Modifiez la configuration de téléchargement.<br>
![Télécharger aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Cliquez sur le bouton 'Télécharger'.<br>
![Télécharger aws lambda dernier](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Accédez à AWS et sélectionnez Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Sélectionnez votre nouvelle fonction et créez l'URL de fonction.<br>
![Configuration url de fonction](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Sélectionnez le type d'authentification
- AWS_IAM - Seuls les utilisateurs et rôles IAM authentifiés peuvent effectuer des demandes à l'URL de votre fonction.
- AUCUN - Lambda ne procédera pas à une authentification IAM pour les demandes à l'URL de votre fonction. Le point de terminaison de l'URL sera public à moins que vous n'implémentiez votre propre logique d'autorisation dans votre fonction.

### Configuration d'un Dockerfile

 La prochaine étape consiste à éditer et à configurer le Dockerfile dans le projet.

1. Dans le Dockerfile, spécifiez :

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Ce qui précède est un Dockerfile simple, qui contient les instructions suivantes :

- L'image SDK à utiliser. Ici, il s'agit de l'image Net 6. Docker la téléchargera lors de l'exécution de la build. La version du SDK est spécifiée comme tag.
- Ensuite, vous devrez peut-être installer des polices car l'image SDK contient très peu de polices. De plus, vous pouvez utiliser des polices locales copiées dans l'image Docker.
- Le répertoire de travail, qui est spécifié à la ligne suivante.
- La commande pour copier tout dans le conteneur, publier l'application et spécifier le point d'entrée.

## Exemple d'exécution

1. Paramètres de Postman.<br>
![Menu d'aperçu](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Sélectionnez n'importe quel fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Cliquez sur le bouton envoyer.

{{% alert color="primary" %}} 
Si la réponse est réussie, cliquez sur Enregistrer sous fichier et vous recevrez le fichier converti au format pdf
{{% /alert %}}

## Plus d'exemples

Pour plus d'exemples sur la façon d'utiliser Aspose.CAD dans Docker, consultez les [exemples](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Voir aussi.

- [Installer AWS Toolkit pour Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installer Docker Desktop sur Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installer Docker Desktop sur Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Option [Changer vers des conteneurs Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Informations supplémentaires sur [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
