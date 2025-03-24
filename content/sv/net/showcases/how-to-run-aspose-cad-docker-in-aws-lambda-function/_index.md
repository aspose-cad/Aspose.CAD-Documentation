---
title: Hur man kör Aspose.CAD Docker-bild i AWS Lambda-funktion
type: docs
description: "Kör Aspose.CAD Docker-bild i AWS Lambda-funktion."
weight: 74
url: /sv/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Förutsättningar
- Docker måste vara installerat på ditt system. För information om hur du installerar Docker på Windows eller Mac, se länkarna i avsnittet "Se Även".
- Visual Studio 2022.
- AWS Toolkit för Visual Studio 2022.
- NET 6 SDK används i exemplet.
- Postman.

## AWS Lambda-funktion

Lambda är en datatjänst som låter dig köra kod utan att provisionera eller hantera servrar. Lambda kör din kod på en infrastruktur med hög tillgänglighet och utför all administration av datorkällorna, inklusive server- och operativsystemunderhåll, kapacitetsprovisionering och automatisk skalning samt loggning. Med Lambda kan du köra kod för i stort sett vilken typ av applikation eller backend-tjänst som helst.

## Skapa AWS Lambda-funktionen

{{% alert color="primary" %}} 
Se till att du har tillräckliga rättigheter för att skapa AWS Lambda-funktioner och bilder i Amazon Elastic Container Registry.
{{% /alert %}}

För att skapa AWS Lambda-funktionsprogrammet, följ stegen nedan:
1. Skapa ett AWS Lambda-projekt.<br>
![Skapa AWS-funktion knapp](/cad/_assets/showcases/aws/create-project.png)<br>
1. Välj .NET 6 (Container Image) och klicka på 'Finish' knappen.<br>
![Skapa containerfunktion knapp](/cad/_assets/showcases/aws/create-container.png)<br>
1. Öppna AWS Explorer i Visual Studio (Visa->AWS Explorer).
1. Lägg till AWS autentiseringsprofil i AWS Explorer.<br>
![Credential profile](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Skriv in Access Key ID och Secret Access Key, du kan få dessa nycklar i Security credentials eller kontakta administratören och få en csv-fil för auktorisering.<br>
![Acount profile settings](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Installera de senaste biblioteken från NuGet.<br>
![NuGet Manager](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Kodexempel för att konvertera cad-bild till pdf-fil.
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
1. Redigera Dockerfilen enligt <a href="#configuring-a-dockerfile">Konfigurera en Dockerfil</a> avsnittet.
1. Starta Docker Desktop.
1. Publicera till AWS Lambda.<br>
![AWS lambda publicera](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Redigera uppladdningskonfiguration.<br>
![Ladda upp aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Klicka på 'Ladda upp' knappen.<br>
![Ladda upp aws lambda sist](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Gå till AWS och välj Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Välj din nya funktion och skapa funktions-URL.<br>
![Konfiguration URL-funktion](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Välj autentiseringstyp
- AWS_IAM - Endast autentiserade IAM-användare och roller kan göra förfrågningar till din funktions-URL.
- NONE - Lambda kommer inte att utföra IAM-autentisering på förfrågningar till din funktions-URL. URL-slutpunkten kommer att vara offentlig såvida du inte implementerar din egen auktoriseringslogik i din funktion.

### Konfigurera en Dockerfil

Nästa steg är att redigera och konfigurera Dockerfilen i projektet.

1. I Dockerfilen, specificera:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

Ovanstående är en enkel Dockerfil, som innehåller följande instruktioner:

- SDK-bilden som ska användas. Här är det Net 6-bilden. Docker kommer att ladda ner den när byggnaden körs. Versionen av SDK anges som en tagg.
- Efter det, kanske du behöver installera typsnitt eftersom SDK-bilden innehåller mycket få typsnitt. Du kan också använda lokala typsnitt som kopierats till dockerbilden.
- Arbetskatalogen, som specificeras i nästa rad.
- Kommandot för att kopiera allt till containern, publicera applikationen och specificera inträdespunkten.

## Exempel på körning

1. Postman-inställningar.<br>
![Översikt meny](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Välj valfri DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil.
1. Klicka på skicka-knappen.

{{% alert color="primary" %}} 
Om svaret är framgångsrikt, klicka på Spara till fil så kommer du att få den konverterade filen i pdf-format.
{{% /alert %}}

## Fler exempel

För fler prover på hur du kan använda Aspose.CAD i Docker, se [exemplen](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Se Även.

- [Installera AWS Toolkit för Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installera Docker Desktop på Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installera Docker Desktop på Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Byt till Linux-containrar](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) alternativ
- Ytterligare information om [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
