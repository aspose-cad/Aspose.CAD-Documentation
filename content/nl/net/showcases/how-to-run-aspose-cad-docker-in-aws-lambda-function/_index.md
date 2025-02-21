---
title: Hoe de Aspose.CAD Docker-afbeelding in AWS Lambda-functie te draaien
type: docs
description: "Draai de Aspose.CAD Docker-afbeelding in AWS Lambda-functie."
weight: 74
url: /nl/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Vereisten
- Docker moet op uw systeem zijn geïnstalleerd. Voor informatie over hoe Docker op Windows of Mac te installeren, verwijst u naar de links in de sectie "Zie ook".
- Visual Studio 2022.
- AWS Toolkit voor Visual Studio 2022.
- NET 6 SDK wordt in het voorbeeld gebruikt.
- Postman

## AWS Lambda-functie

Lambda is een compute-service waarmee u code kunt uitvoeren zonder servers te provisioneren of te beheren. Lambda voert uw code uit op een compute-infrastructuur met hoge beschikbaarheid en verzorgt al het beheer van de compute-resources, inclusief server- en besturingssysteemonderhoud, capaciteitsprovisionering en automatische schaling, en logging. Met Lambda kunt u code uitvoeren voor vrijwel elk type applicatie of backend-service.

## De AWS Lambda-functie maken

{{% alert color="primary" %}} 
Zorg ervoor dat u voldoende rechten heeft om AWS Lambda-functies en afbeeldingen in het Amazon Elastic Container Registry te maken.
{{% /alert %}}

Om het AWS Lambda Functieprogramma te maken, volgt u de onderstaande stappen:
1. Maak een AWS Lambda Project.<br>
![Maak AWS functie knop](/_assets/showcases/aws/create-project.png)<br>
1. Selecteer .NET 6(Container Image) en klik op de knop 'Voltooien'.<br>
![Maak containerfunctie knop](/_assets/showcases/aws/create-container.png)<br>
1. Open AWS Explorer in Visual Studio (View->AWS Explorer).
1. Voeg AWS-referentiesprofiel toe in AWS Explorer.<br>
![Referentieprofiel](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Voer Access Key ID en Secret Access Key in, u kunt deze sleutels krijgen in beveiligingsreferenties of neem contact op met de beheerder en krijg een csv-bestand voor autorisatie.<br>
![Account profielinstellingen](/_assets/showcases/aws/account-profile.png)<br>
1. Installeer de nieuwste bibliotheken van NuGet.<br>
![NuGet Manager](/_assets/showcases/aws/nuget-manager.png)<br>
1. Codevoorbeeld voor het converteren van cad-afbeelding naar pdf-bestand.
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
1. Bewerk het DockerFile zoals in de <a href="#configuring-a-dockerfile">Configurerende een Dockerfile</a> sectie.
1. Start Docker Desktop.
1. Publiceer naar AWS Lambda.<br>
![AWS lambda publiceren](/_assets/showcases/aws/publish-aws.png)<br>
1. Bewerk uploadconfiguratie.<br>
![Upload aws lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Klik op de knop 'Uploaden'.<br>
![Upload aws lambda laatste](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Ga naar AWS en selecteer Lambda.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Selecteer uw nieuwe functie en maak url functie.<br>
![Configuratie url functie](/_assets/showcases/aws/create-function-url.png)<br>
1. Selecteer auth-type
- AWS_IAM - Alleen geauthenticeerde IAM-gebruikers en -rollen kunnen verzoeken indienen naar uw functie-URL.
- NONE - Lambda voert geen IAM-authenticatie uit op verzoeken aan uw functie-URL. De URL-eindpunt zal openbaar zijn, tenzij u uw eigen autorisatie-logica in uw functie implementeert.

### Configureren van een Dockerfile

 De volgende stap is om de Dockerfile in het project te configureren.

1. Geef in het Dockerfile aan:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Het bovenstaande is een eenvoudige Dockerfile, die de volgende instructies bevat:

- De SDK-afbeelding die moet worden gebruikt. Hier is het de Net 6-afbeelding. Docker zal het downloaden wanneer de build wordt uitgevoerd. De versie van de SDK wordt gespecificeerd als een tag.
- Daarna moet u mogelijk lettertypen installeren, omdat de SDK-afbeelding zeer weinig lettertypen bevat. U kunt ook lokale lettertypen gebruiken die naar de docker-afbeelding zijn gekopieerd.
- De werkdirectory, die in de volgende regel is gespecificeerd.
- Het commando om alles naar de container te kopiëren, de applicatie te publiceren en de toegangspunt op te geven.

## Voorbeeld van uitvoering

1. Postman-instellingen.<br>
![Overzichtsmenu](/_assets/showcases/aws/postman-settings.png)<br>
1. Selecteer een DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-bestand.
1. Klik op de verzendknop.

{{% alert color="primary" %}} 
Als het antwoord succesvol is, klik dan op Opslaan naar bestand en u ontvangt het geconverteerde bestand in pdf-formaat
{{% /alert %}}

## Meer Voorbeelden

Voor meer voorbeelden van hoe u Aspose.CAD in Docker kunt gebruiken, zie de [voorbeelden](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Zie ook.

- [Installeer AWS Toolkit voor Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installeer Docker Desktop op Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installeer Docker Desktop op Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Overschakelen naar Linux-containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) optie
- extra informatie over [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
