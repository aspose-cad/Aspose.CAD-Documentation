---
title: Hogyan futtassuk az Aspose.CAD Docker képet az AWS Lambda funkcióban
type: docs
description: "Futtassa az Aspose.CAD Docker képet az AWS Lambda funkcióban."
weight: 74
url: /hu/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Előfeltételek
- A Dockernek telepítve kell lennie a rendszerén. A Docker Windows vagy Mac telepítéséről szóló információkért lásd a „Lásd még” szakaszban található linkeket.
- Visual Studio 2022.
- AWS Toolkit for Visual Studio 2022.
- A példában a NET 6 SDK van használatban.
- Postman

## AWS Lambda funkció

A Lambda egy számítási szolgáltatás, amely lehetővé teszi, hogy kódot futtasson anélkül, hogy szervereket kellene telepítenie vagy kezelnie. A Lambda a kódját egy nagy rendelkezésre állású számítási infrastruktúrán futtatja, és elvégzi a számítási erőforrások, például a szerverek és az operációs rendszer karbantartásának, a kapacitás biztosításának és az automatikus skálázásnak, valamint a naplózásnak az összes adminisztrációját. A Lambda segítségével gyakorlatilag bármilyen típusú alkalmazás vagy háttérszolgáltatás kódját futtathatja.

## Az AWS Lambda funkció létrehozása

{{% alert color="primary" %}} 
Győződjön meg arról, hogy elegendő joggal rendelkezik AWS Lambda funkciók és képek létrehozásához az Amazon Elastic Container Registry-ben.
{{% /alert %}}

Az AWS Lambda funkció program létrehozásához kövesse az alábbi lépéseket:
1. Hozzon létre AWS Lambda projektet.<br>
![AWS funkció létrehozása gomb](/_assets/showcases/aws/create-project.png)<br>
1. Válassza a .NET 6 (Konténerkép) lehetőséget, és kattintson a 'Kész' gombra.<br>
![Konténer funkció létrehozása gomb](/_assets/showcases/aws/create-container.png)<br>
1. Nyissa meg az AWS Explorert a Visual Studio-ban (Nézet->AWS Explorer).
1. Adjon hozzá AWS hitelesítő profilt az AWS Explorerhez.<br>
![Hitelesítő profil](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Adja meg az Access Key ID-t és a Secret Access Key-t, ezeket a kulcsokat a Biztonsági hitelesítésekben találja, vagy lépjen kapcsolatba a rendszergazdával, és kérjen egy csv fájlt az engedélyezéshez.<br>
![Fiók profil beállításai](/_assets/showcases/aws/account-profile.png)<br>
1. Telepítse a legújabb könyvtárakat a NuGet-től.<br>
![NuGet kezelő](/_assets/showcases/aws/nuget-manager.png)<br>
1. Kódminta a cad kép pdf fájllá konvertálásához.
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
1. Szerkessze a DockerFile-t, ahogy az a <a href="#configuring-a-dockerfile">Dockerfile konfigurálása</a> szakaszban található.
1. Indítsa el a Docker Desktop-ot.
1. Publikálás az AWS Lambda-ra.<br>
![AWS lambda publikálás](/_assets/showcases/aws/publish-aws.png)<br>
1. Szerkessze a feltöltési konfigurációt.<br>
![AWS lambda feltöltés](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Kattintson a 'Feltöltés' gombra.<br>
![AWS lambda utolsó feltöltés](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Lépjen az AWS-hez, és válassza a Lambdát.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Válassza ki új funkcióját, és hozzon létre egy URL funkciót.<br>
![URL funkció konfigurálása](/_assets/showcases/aws/create-function-url.png)<br>
1. Válassza ki az autentikálási típust
- AWS_IAM - Csak az azonosított IAM felhasználók és szerepek kérhetik a funkció URL-jét.
- NINCS - A Lambda nem hajt végre IAM hitelesítést a funkció URL-jével kapcsolatos kérésekben. Az URL végpont nyilvános lesz, hacsak nem valósít meg saját engedélyezési logikát a funkciójában.

### Dockerfile konfigurálása

A következő lépés a Dockerfile konfigurálása a projektben.

1. A Dockerfile-ben adja meg:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

A fenti egy egyszerű Dockerfile, amely a következő utasításokat tartalmazza:

- Az SDK kép, amelyet használni kell. Itt a Net 6 kép. A Docker letölti, amikor a build végrehajtásra kerül. Az SDK verziója címkeként van megadva.
- Ezt követően lehet, hogy fonts-ot is telepítenie kell, mert az SDK kép nagyon kevés betűt tartalmaz. Ezenkívül használhat helyi betűtípusokat is, amelyeket a docker képhez másol.
- A munkakönyvtár, amely a következő sorban van meghatározva.
- Az utasítás, hogy mindent másoljon a konténerbe, publikálja az alkalmazást, és határozza meg a belépési pontot.

## Végrehajtási példa

1. Postman beállítások.<br>
![Áttekintés menü](/_assets/showcases/aws/postman-settings.png)<br>
1. Válasszon ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Kattintson a küldés gombra.

{{% alert color="primary" %}} 
Ha a válasz sikeres, kattintson a Fájl mentése gombra, és megkapja a konvertált fájlt pdf formátumban
{{% /alert %}}

## További példák

További példákért arról, hogyan használhatja az Aspose.CAD-ot Dockerben, nézze meg a [példákat](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lásd még.

- [AWS Toolkit telepítése a Visual Studio 2022-höz](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Docker Desktop telepítése Windowsra](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop telepítése Macre](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Váltás Linux konténerekre](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opció
- További információ a [.NET Core SDK-ról](https://hub.docker.com/_/microsoft-dotnet-sdk)
