---
title: Hogyan futtassuk az Aspose.CAD Docker képet a Google Cloud-ban
type: docs
description: "Futtassa az Aspose.CAD Docker képet a Google Cloud-ban."
weight: 75
url: /hu/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Előfeltételek

- A Dockernek telepítve kell lennie a rendszerén. Az információkhoz arról, hogyan telepítheti a Dockert Windows vagy Mac rendszeren, lásd a "További információk" szekció linkjeit.
- Visual Studio 2022.
- Google CLI.
- A példa a NET Core 3.1 SDK-t használja.
- Postman

## Google Cloud Run Funkció

A Cloud Run egy teljesen menedzselt számítási környezet a szerver nélküli HTTP konténerek telepítéséhez és méretezéséhez, anélkül, hogy aggódnia kellene a gépek biztosítása, a klaszterek konfigurálása vagy az automatikus méretezés miatt.

- Nincs szolgáltatóhoz való kötődés - Mivel a Cloud Run szabványos OCI konténereket használ, és megvalósítja a szabványos Knative Serving API-t, könnyen átkonfigurálhatja alkalmazásait helyi vagy bármely más felhő környezetre.
- Gyors automatikus méretezés - A Cloud Run-on telepített mikroservices automatikusan méreteződnek a bejövő kérdések számának megfelelően, anélkül, hogy Önnek konfigurálnia vagy kezelnia kellene egy teljes Kubernetes klasztert. A Cloud Run nullára méreteződik - azaz nem használ erőforrásokat - ha nincsenek kérések.
- Forgalom megosztása - A Cloud Run lehetővé teszi, hogy megossza a forgalmat több verzió között, így fokozatos telepítéseket, például kanári telepítéseket vagy kék/zöld telepítéseket végezhet.
- Egyedi domainok - Beállíthat egyedi domain-térképezést a Cloud Run-ban, és automatikusan biztosít egy TLS tanúsítványt a doménjéhez.
- Automatikus redundancia - A Cloud Run automatikus redundanciát kínál, így nem kell aggódnia a magas rendelkezésre állás érdekében történő több példány létrehozása miatt.

A Cloud Run és a Cloud Functions mindkét teljesen menedzselt szolgáltatás, amely a Google Cloud szerver nélküli infrastruktúráján fut, automatikusan méreteződik, és kezeli a HTTP kéréseket vagy eseményeket. Azonban egyes fontos különbségek vannak:

- A Cloud Functions lehetővé teszi, hogy korlátozott számú programozási nyelven írt kóddarabokat (funkciókat) telepítsen, míg a Cloud Run lehetővé teszi, hogy a választott programozási nyelvet használva telepítse a konténerképeket.
- A Cloud Run támogatja bármely eszköz vagy rendszerszintű könyvtár használatát az alkalmazásából; a Cloud Functions nem engedi meg a testreszabott végrehajthatók használatát.
- A Cloud Run hosszabb kérési időtúllépési időt kínál, akár 60 percig, míg a Cloud Functions esetében a kérési időtúllépés legfeljebb 9 percig állítható be.
- A Cloud Functions minden egyes funkciópéldányhoz egyszerre csak egyetlen kérést küld, míg alapértelmezés szerint a Cloud Run többszörös párhuzamos kérést küld minden konténerpéldányon. Ez segít csökkenteni a késleltetést és a költségeket, ha nagyobb mennyiségekre számít.

## Google Cloud Function projekt létrehozása

{{% alert color="primary" %}} 
Győződjön meg róla, hogy elegendő joggal rendelkezik a Google Cloud Run funkciók és képek létrehozásához az Artifact Registry tárolóban.
{{% /alert %}}

A Google Cloud Function program létrehozásához kövesse az alábbi lépéseket:

1. Telepítse a .NET Core SDK 3.1-et.
1. Telepítse a sabloncsomagot:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Ezután hozzon létre egy mappát a projektjének, és használja a dotnet new parancsot egy új HTTP funkció létrehozásához:
{{< highlight plain >}}
mkdir AsposeFunctions //mappa létrehozása
cd AsposeFunctions //menj a AsposeFunctions mappába
dotnet new gcf-http //Google Cloud Function projekt létrehozása http triggerrel
{{< /highlight >}}
{{% alert color="primary" %}} 
Ez létrehozza az AsposeFunctions.csproj és a Function.cs fájlokat az aktuális könyvtárban. Nyissa meg a Function.cs-t a kód áttekintéséhez, és adjon meg egy egyedi üzenetet, ha szeretné.
{{% /alert %}}
1. Kód példa a csproj fájlhoz (AsposeFunctions.csproj).
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
1. Kód példa a cad kép png fájlra való konvertálásához (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// A funkció logikája itt található.
        /// </summary>
        /// <param name="context">A HTTP kontextus, amely tartalmazza a kérdést és a választ.</param>
        /// <returns>A feladat, amely az aszinkron műveletet képviseli.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //form fájl
                var file = context.Request.Body; //bináris adat
                
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
1. Építse meg a funkciót helyben az alábbiak szerint:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Miután a szerver fut, böngésszen el a http://localhost:8080 oldalra a funkció meghívásához. Nyomja meg a Ctrl-C gombot a konzolban a szerver leállításához.

## Docker kép telepítése a Google Cloud-ba

1. Jelentkezzen be a Google Cloudba.
1. Hozzon létre egy projektet, ha még nem létezik.
1. Lépjen az 'Artifact Registry'-be, és hozzon létre egy tárolót.<br>
![Artifact Repository létrehozása](/_assets/showcases/google/create-artifact-repository.png)<br>
1. Válassza ki az új tárolót az Artifact Registry-ben.
![Artifact Repository kiválasztása](/_assets/showcases/google/select-artifact.png)<br>
1. Kattintson a 'BEÁLLÍTÁSI ÚTMUTATÓRA', és másolja a 'Docker konfigurálása' parancsot.<br>
![BEÁLLÍTÁSI ÚTMUTATÓ](/_assets/showcases/google/setup-instruction.png)<br>
1. Adjon hozzá egy Docker credHelper bejegyzést a Docker konfigurációs fájljához, vagy hozza létre a fájlt, ha még nem létezik.
{{< highlight plain >}}
//példa
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Hozzon létre egy Dockerfile-t a projekt gyökérkönyvtárában, és szerkessze a DockerFile-t a <a href="#dockerfile-beallitas">Dockerfile beállítása</a> szakaszban leírtak szerint.
1. Indítsa el a Docker Desktop-ot.
1. Építse meg a Docker képet a felhő tároló elérési útjával.
{{< highlight plain >}}
//példa
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Tolja a képet a Google Cloud Artifact Registry-be
{{< highlight plain >}}
//példa
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Google Gloud Run szolgáltatás létrehozása 

1. Lépjen a Cloud Run-ra.
1. Hozzon létre Cloud Run szolgáltatást.<br>
![Cloud Run szolgáltatás létrehozása](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. A Konténerkép URL mezőben válassza ki a konténert az 'ARTIFACT REGISTRY'-ből.<br>
![Konténerkép URL](/_assets/showcases/google/container-url.png)<br>
1. Ellenőrizze a többi beállítást az alábbiak szerint.<br>
![Szolgáltatás beállításai](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Várjon, amíg a telepítés befejeződik.
1. Szolgáltatás URL a konverziós alkalmazás használatához.<br>
![Szolgáltatás URL](/_assets/showcases/google/url-service.png)<br>

### Dockerfile beállítása

 A következő lépés a Dockerfile szerkesztése a projektben.

1. A Dockerfile-ban adja meg:

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

 A fenti egy egyszerű Dockerfile, amely a következő utasításokat tartalmazza:

- Az SDK kép, amelyet használni kell. Itt a Net Core 3.1 képet használjuk. A Docker letölti, amikor a build fut.
- Ezenkívül fontokat is telepítenie kell, mert az SDK kép nagyon kevés fontot tartalmaz. Emellett használhat helyi fontokat is, amelyeket a Docker képre másolt.
- A munkakönyvtár, amelyet a következő sorban határozunk meg.
- A parancs, amely mindent átmásol a konténerbe, közzéteszi az alkalmazást, és megadja a belépési pontot.

## Futtatási példa

1. Postman beállítások.<br>
![Áttekintő menü](/_assets/showcases/google/postman-settings.png)<br>
1. Válasszon ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Kattintson a küldés gombra.

{{% alert color="primary" %}} 
Ha a válasz sikeres, kattintson a Fájl mentése gombra, és megkapja a konvertált fájlt png formátumban.
{{% /alert %}}

## További példák

További példákért arról, hogyan használhatja az Aspose.CAD-ot Dockerben, lásd a [példákat](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## További információk.

- [Docker Desktop telepítése Windows-ra](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop telepítése Mac-re](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Váltás Linux konténerekre](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opció
- További információk a [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)-ról
