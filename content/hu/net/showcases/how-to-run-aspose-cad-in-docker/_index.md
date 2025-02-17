---
title: Hogyan futtassuk az Aspose.CAD-ot Dockerben
type: docs
description: "Futtassa az Aspose.CAD-ot egy Docker konténerben Linux, Windows Server és bármely operációs rendszer számára."
weight: 71
url: /hu/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Előfeltételek
- A Dockernek telepítve kell lennie a rendszerében. Az információkért arról, hogyan telepítse a Dockert Windowsra vagy Mac-re, lásd a "Lásd még" szakaszban található linkeket.
- Visual Studio 2022.
- A NET 6 SDK-t használják a példában.

## Hello World alkalmazás

Ebben a példában létrehoz egy egyszerű Hello World konzolalkalmazást, amely ellipszist rajzol, és képként menti el. Az alkalmazást ezután Dockerben lehet buildelni és futtatni.

## Konzolalkalmazás létrehozása

A Hello World program létrehozásához kövesse az alábbi lépéseket:
1. Miután a Docker telepítve van, győződjön meg róla, hogy Linux konténereket használ (alapértelmezett). Szükség esetén válassza a Váltás Linux konténerekre lehetőséget a Docker Desktop menüjéből.
1. A Visual Studio-ban hozzon létre egy NET 6 konzolalkalmazást.<br>
![Egy NET 6 konzol alkalmazás projekt párbeszédpanelje](/_assets/showcases/docker/1.png)<br>
1. Telepítse a legújabb Aspose.CAD verziót a NuGet-ből.<br>
![Aspose.CAD a NuGet-on](/_assets/showcases/docker/2.png)<br>
1. Mivel az alkalmazást Linuxon fogja futtatni, szüksége lehet további betűtípusok telepítésére. A ttf-mscorefonts-installer telepítését javasoljuk.
1. Miután minden szükséges függőség hozzá van adva, írjon egy egyszerű programot, amely létrehoz egy ellipszist és képként menti el:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Vegye figyelembe, hogy a "TestOut" mappa van megadva kimeneti mappaként a kimeneti dokumentumok mentéséhez. Amikor az alkalmazást Dockerben futtatja, egy mappa a gazdagépen lesz csatolva ehhez a mappához a konténerben. Ez lehetővé teszi, hogy könnyen megtekintse az Aspose.CAD által a Docker konténerben generált kimenetet.

### Dockerfile konfigurálása

 A következő lépés a Dockerfile létrehozása és konfigurálása.

1. Hozza létre a Dockerfile-t, és helyezze a megoldásfájljával párhuzamosan a fájlt. Tartsa meg ezt a fájlnevet kiterjesztés nélkül (alapértelmezett).
1. A Dockerfile-ban adja meg:


{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

 A fenti egy egyszerű Dockerfile, amely a következő utasításokat tartalmazza:

- Az SDK képet, amelyet használni kell. Itt a Net 6 képet használják. A Docker letölti, amikor a build fut.
- Ezen kívül, lehet, hogy betűtípusokat kell telepítenie, mert az SDK képben nagyon kevés betűtípus található. Emellett használhat helyi betűtípusokat is, amelyeket a Docker képhez másol.
- A munkakönyvtár, amely a következő sorban van megadva.
- Az a parancs, amely mindent átmásol a konténerbe, publikálja az alkalmazást, és megadja a belépési pontot.


## Az alkalmazás buildelése és futtatása Dockerben
 
 Most az alkalmazás buildelhető és futtatható Dockerben. Nyisson meg egy tetszőleges parancssort, váltson át a mappába, ahol az alkalmazás található (a mappa, ahol a megoldás fájl és a Dockerfile található) és futtassa az alábbi parancsot:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

 Az első alkalommal, amikor ezt a parancsot végrehajtja, hosszabb időt vehet igénybe, mivel a Dockernek le kell töltenie a szükséges képeket. Miután az előző parancs befejeződött, futtassa a következő parancsot:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Figyeljen a mount argumentumra, mert, ahogy korábban említettük, egy mappa a gazdagépen csatlakozik a konténer mappájához, hogy könnyen láthassa az alkalmazás végrehajtásának eredményeit. A Linuxban az elérési utak nagybetűérzékenyek.
{{% /alert %}}

## További példák

További példákért arra, hogy hogyan használhatja az Aspose.CAD-ot Dockerben, lásd a [példák](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lásd még

- [Docker Desktop telepítése Windowsra](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop telepítése Macen](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Váltás Linux konténerekre](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opció
- A [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) további információi
