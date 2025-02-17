---
title: Hogyan futtassuk az Aspose.CAD Docker képet az Azure Function-ban
type: docs
description: "Aspose.CAD Docker képet futtatni az Azure Function-ban."
weight: 71
url: /hu/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Előfeltételek
- A Dockernek telepítve kell lennie a rendszeren. A Docker Windows vagy Mac rendszerre történő telepítéséről szóló információkért lásd a „Lásd még” szakaszban található linkeket.
- IntelliJ IDEA.
- Azure Toolkit for IntelliJ.
- Postman.

## Azure Function

Ebben a példában egy egyszerű átalakító funkciót hoz létre, amely egy CAD fájlt konvertál át, és képként menti el. Az alkalmazást Dockerben lehet építeni és futtatni az Azure Function-ban.

## Az Azure Function létrehozása

Az Azure Function program létrehozásához kövesse az alábbi lépéseket:
1. Miután a Dockert telepítette, győződjön meg arról, hogy Linux konténereket használ (alapértelmezett). Szükség esetén válassza a Váltás Linux konténerekre opciót a Docker Desktop menüjéből.
1. Hozzon létre Azure Function projektet az IntelliJ IDEA-ban.<br>
![Azure Function projekt létrehozása](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Azure Function projekt létrehozása - végleges](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Eszközök->Azure->Bejelentkezés, és válassza az OAuth 2.0 hitelesítést.<br>
![Azure bejelentkezés](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Jelentkezzen be a böngészőben.
1. Válassza ki az Előfizetés nevét.
1. Adjon hozzá Docker támogatást.<br>
![Docker támogatás hozzáadása](/_assets/java/java-azure/add-docker-support.png)<br>
1. Szerkessze a DockerFile-t a <a href="#configuring-a-dockerfile">Dockerfile konfigurálása</a> szakasz szerint.
1. Adjon hozzá blokkokat az aspose.cad tárolójához a pom.xml-ben.
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

1. Amikor minden szükséges függőség hozzá lett adva, írjon egy egyszerű programot, amely létrehoz egy ellipszist, és képként menti el:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Ez a funkció figyel az "/api/HttpExample" végponton. Két módja van a hívásának a "curl" parancs bashben:
     * 1. curl -d "HTTP Tartalom" {az Ön hosztja}/api/HttpExample
     * 2. curl "{az Ön hosztja}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("A Java HTTP trigger feldolgozta a kérést.");

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

### Dockerfile konfigurálása

A következő lépés a Dockerfile létrehozása és konfigurálása a projekt gyökérmappájában.

1. A Dockerfile-ban adja meg:
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

A fenti egy egyszerű Dockerfile, amely a következő utasításokat tartalmazza:

- A használandó SDK kép. A Docker letölti ezt, amikor a build fut. Az SDK verziója címke formájában van megadva.
- A munkakönyvtár, amelyet a következő sorban ad meg.
- Az utasítás, hogy mindent másoljon a konténerbe, publikálja az alkalmazást és megadja a belépési pontot.

## Docker Hub
1. Bejelentkezés a Docker Hub-ba
1. Nyilvános tároló létrehozása

## Az alkalmazás építése és futtatása Dockerben
 
 Most az alkalmazás Dockerben építhető és futtatható. Nyissa meg a kedvenc parancssorát, váltson a mappába, ahol az alkalmazás található (mappa, ahol a megoldás fájl és a Dockerfile található), és futtassa a következő parancsot:

1. Dockerfile építési parancs a konzolban
{{< highlight plain >}}
//példa
docker build -t <felhasználónév>/<tárolónév> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. Amikor először futtatja ezt a parancsot, tovább tarthat, mert a Dockernek le kell töltenie a szükséges képeket. Miután az előző parancs befejeződött, futtassa a következő parancsot, hogy feltöltse a képet a Docker Hub-ra.
{{< highlight plain >}}
//példa
docker push <felhasználónév>/<tárolónév>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Futtassa a Dockerfile-t az IDE-ben, majd töltse fel a Docker Hub-ra.<br>
![Docker futtatás IDE-ben](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Adja meg a kép nevét, ahogyan a Docker Hub tárolóban van.<br>
![Docker futtatás IDE-ben - következő](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Várja meg a végét.

## Azure

1. Bejelentkezés az Azure-ba.
1. Válassza az Azure szolgáltatásokat.
1. Válassza a Function App-ot, és hozzon létre egy funkciót.<br>
![Azure funkció létrehozás gomb](/_assets/java/java-azure/create-function-azure.png)<br>
1. Ismételje meg az alapbeállításokat az alábbi kép szerint.<br>
![Azure funkció beállítások](/_assets/java/java-azure/create-function-settings.png)<br>
1. Kattintson a 'Áttekintés + létrehozás' -> Létrehozás gombra.
1. Várja meg a telepítés befejezését.
1. Kattintson az 'Ugrás az erőforráshoz' gombra.<br>
![Erőforrás gomb](/_assets/java/java-azure/go-to-resource.png)<br>
1. Állítsa le az aspose-cad-docker-example funkciót.<br>
![Konténer leállítása](/_assets/java/java-azure/stop-container.png)<br>
1. Lépjen a telepítési központ menübe és végezze el a megfelelő beállításokat.<br>
![Telepítési központ](/_assets/java/java-azure/deployment-center.png)<br>
1. Mentse a beállításokat.
1. Másolja a Webhook URL-t a telepítési központ beállításaiból.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Lépjen a Docker Hub-ra, válassza ki a tárolóját, és válassza a webhooks-t.
1. Illessze be az Azure-ból származó 'Webhook url'-t a Docker Hub webhook url-be, és adjon nevet neki.<br>
![Webhook beállítások Dockerben](/_assets/java/java-azure/webhook.png)<br>
1. Kattintson a létrehozás gombra.
1. Térjen vissza az áttekintéshez az Azure funkcióhoz, és indítsa el a konténert.<br>
![Áttekintés menü](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Előfordulhat, hogy néhány percbe telik, mire a funkció elindul.
{{% /alert %}}

## Példa futtatásra

1. Postman beállítások.<br>
![Postman beállítások](/_assets/java/java-azure/postman-settings.png)<br>
1. Válasszon ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Kattintson a küldés gombra.
1. Mentse az eredményt.
![Kimenet mentése](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Ha a válasz sikeres, kattintson a Mentés fájlba gombra, és megkapja a konvertált fájlt png formátumban
{{% /alert %}}

## További példák

További mintákért arról, hogyan használhatja az Aspose.CAD-ot Dockerben, tekintse meg a [példákat](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lásd még

- [Docker Desktop telepítése Windowsra](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop telepítése Mac-re](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Váltás Linux konténerekre](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opción
