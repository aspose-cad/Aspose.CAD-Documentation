---
title: Hogyan futtassuk az Aspose.CAD Docker képet az Azure Function-ban
type: docs
description: "Futtassa az Aspose.CAD Docker képet az Azure Function-ban."
weight: 73
url: /hu/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Előfeltételek
- A Dockernek telepítve kell lennie a rendszerén. A Docker Windows-ra vagy Mac-re történő telepítéséről szóló információkért lásd a „Lásd még” szakasz hivatkozásait.
- Visual Studio 2022.
- A NET 6 SDK-t használják a példában.
- Postman

## Azure Function

Ebben a példában egy egyszerű konverziós funkciót hoz létre, amely egy CAD fájlt konvertál és képként ment. Az alkalmazás ezt követően Dockerben építhető és futtatható Azure Function-ban.

## Az Azure Function létrehozása

Az Azure Function program létrehozásához kövesse az alábbi lépéseket:
1. Miután a Docker telepítve van, győződjön meg arról, hogy Linux tartályokat használ (alapértelmezett). Szükség esetén válassza a "Váltás Linux tartályokra" lehetőséget a Docker asztali menüből.
1. A Visual Studio-ban hozzon létre egy NET 6 Azure Function-t.<br>
![Egy NET 6 Azure Function projekt párbeszédablak](/_assets/showcases/azure/Create-project.png)<br>
1. További információk.<br>
![Egy NET 6 Azure Function projekt párbeszédablak](/_assets/showcases/azure/Additional-information.png)<br>
1. Telepítse a legfrissebb Aspose.CAD verziót a NuGet-ből.<br>
![Aspose.CAD a NuGet-en](/_assets/showcases/azure/NuGet.png)<br>
1. Mivel az alkalmazást Linuxon futtatják, lehet, hogy további betűtípusokat kell telepítenie. Ajánlott a ttf-mscorefonts-installer.
1. Miután az összes szükséges függőséget hozzáadta, írjon egy egyszerű programot, amely létrehoz egy ellipszist és képként menti el:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("A C# HTTP trigger funkció kezelte a kérést.");
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

### Dockerfile konfigurálása

 A következő lépés a Dockerfile létrehozása és konfigurálása a projekt gyökérmappájában.

1. Hozza létre a Dockerfile-t, és helyezze el az alkalmazás megoldásfájljának közelében. Tartsa meg ezt a fájlnevet kiterjesztés nélkül (alapértelmezett).
![Gyökér projektmappa](/_assets/showcases/azure/root-folder.png)<br>
1. A Dockerfile-ban adja meg:


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

 A fenti egy egyszerű Dockerfile, amely a következő utasításokat tartalmazza:

- Használni kívánt SDK kép. Itt a NET 6 kép. A Docker ezt letölti, amikor a build fut. Az SDK verzióját címke formájában kell megadni.
- Ezt követően lehet, hogy betűtípusokat kell telepíteni, mert az SDK kép nagyon kevés betűtípust tartalmaz. Helyi betűtípusokat is használhat, amelyeket a Docker képbe másol.
- A munkakönyvtár, amelyet a következő sorban ad meg.
- Az a parancs, amely mindent átmásol a tartályba, közzéteszi az alkalmazást és megadja a belépési pontot.

## Docker Hub
1. Jelentkezzen be a Docker Hubra
1. Hozzon létre nyilvános tárolót

## Az alkalmazás összeállítása és futtatása Dockerben
 
 Most az alkalmazás összeállítható és futtatható Dockerben. Nyissa meg a kedvenc parancssorát, változtassa meg a könyvtárat a programot tartalmazó mappára (ahol a megoldásfájl és a Dockerfile található) és futtassa a következő parancsot:

{{< highlight plain >}}
//példa
docker build -t <felhasználónév>/<tárolónév> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
Amikor először futtatja ezt a parancsot, hosszabb ideig eltarthat, mivel a Dockernek le kell töltenie a szükséges képeket. Miután az előző parancs befejeződött, futtassa a következő parancsot az image feltöltésére a Docker Hubra:
 
{{< highlight plain >}}
//példa
docker push <felhasználónév>/<tárolónév>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Jelentkezzen be az Azure-ba.
1. Válassza az Azure szolgáltatásokat.
1. Válassza a Funkciós alkalmazást, és hozzon létre egy funkciót.<br>
![Azure funkció létrehozásának gombja](/_assets/showcases/azure/create-function.png)<br>
1. Ismételje meg az alapvető beállításokat az alábbi képen látható módon.<br>
![Azure funkció létrehozásának beállításai](/_assets/showcases/azure/create-function-setting.png)<br>
1. Kattintson a 'Felülvizsgálat + létrehozás' -> Létrehozás.
1. Várjon a telepítés befejezésére.
1. Kattintson a 'Menj a forráshoz' gombra.<br>
![Forrás gomb](/_assets/showcases/azure/go-to-resource.png)<br>
1. Állítsa le az aspose-cad-docker-example funkciót.<br>
![Container leállítása](/_assets/showcases/azure/stop-container.png)<br>
1. Menjen a telepítési központ menübe, és végezze el a megfelelő beállításokat.<br>
![Telepítési központ](/_assets/showcases/azure/deployment-center.png)<br>
1. Mentse a beállításokat
1. Másolja a Webhook URL-t a telepítési központ beállításaiból.<br>
![Webhook url](/_assets/showcases/azure/webhook-url.png)<br>
1. Menjen a Docker Hubra, válassza ki a tárolóját, és válassza a webhooks lehetőséget.
1. Illessze be az Azure-ból származó 'Webhook url'-t a Docker Hub webhook URL-jébe, és adjon nevet.<br>
![Webhook beállítások a dockerben](/_assets/showcases/azure/webhook.png)<br>
1. Kattintson a létrehozás gombra.
1. Térjen vissza az Áttekintés Azure funkcióhoz, és indítsa el a tartályt.<br>
![Áttekintés menü](/_assets/showcases/azure/overview.png)<br>

## Példa a végrehajtásra

1. Postman beállítások.<br>
![Áttekintés menü](/_assets/showcases/azure/postman-settings.png)<br>
1. Válasszon ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Kattintson a küldés gombra.

{{% alert color="primary" %}} 
Ha a válasz sikeres, kattintson a Fájl mentése gombra, és megkapja az átkonvertált fájlt png formátumban
{{% /alert %}}

## További példák

További példákért, hogy miként használhatja az Aspose.CAD-ot Dockerben, lásd a [példákat](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lásd még

- [Docker Desktop telepítése Windows-ra](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop telepítése Mac-re](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Váltás Linux tartályokra](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) lehetőség
- További információk a [.NET Core SDK-ról](https://hub.docker.com/_/microsoft-dotnet-sdk)
