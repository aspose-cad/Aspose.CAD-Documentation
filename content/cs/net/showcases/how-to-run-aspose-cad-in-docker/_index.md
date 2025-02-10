---
title: Jak spustit Aspose.CAD v Dockeru
type: docs
description: "Spusťte Aspose.CAD v kontejneru Docker pro Linux, Windows Server a jakýkoli jiný operační systém."
weight: 71
url: /cs/jak-spustit-aspose-cad-v-dockeru
---

## Předpoklady
- Docker musí být nainstalován ve vašem systému. Pokud chcete informace o instalaci Dockeru na Windows nebo Mac, podívejte se na odkazy v sekci „Viz také“.
- Visual Studio 2022.
- Verze NET 6 SDK je použita v tomto příkladu.

## Aplikace Hello World

V tomto příkladu vytvoříte jednoduchou konzolovou aplikaci Hello World, která kreslí elipsu a ukládá ji jako obrázek. Aplikace pak může být sestavena a spuštěna v Dockeru.

## Vytvoření konzolové aplikace

Chcete-li vytvořit program Hello World, postupujte podle níže uvedených kroků:
1. Jakmile je Docker nainstalován, ujistěte se, že používá linuxové kontejnery (výchozí). Pokud je to nutné, vyberte možnost Přepnout na Linuxové kontejnery z nabídky Docker Desktops.
1. V programu Visual Studio vytvořte konzolovou aplikaci NET 6.<br>
![Dialog s projektem konzolové aplikace NET 6](/_assets/1.png)<br>
1. Nainstalujte nejnovější verzi Aspose.CAD z NuGet.<br>
![Aspose.CAD v NuGet](/_assets/2.png)<br>
1. Jelikož aplikace bude spuštěna na Linuxu, může být nutné nainstalovat další písma. Můžete upřednostnit ttf-mscorefonts-installer.
1. Jakmile jsou přidány všechny potřebné závislosti, napište jednoduchý program, který vytvoří elipsu a uloží ji jako obrázek:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Všimněte si, že složka „TestOut“ je určena jako výstupní složka pro ukládání výstupních dokumentů. Při spuštění aplikace v Dockeru bude složka na hostitelském stroji připojena k této složce v kontejneru. To vám umožní snadno zobrazit výstup vygenerovaný pomocí Aspose.CAD v kontejneru Docker.

### Konfigurace Dockerfile

Dalším krokem je vytvořit a nakonfigurovat soubor Dockerfile.

1. Vytvořte soubor Dockerfile a umístěte ho vedle souboru řešení vaší aplikace. Tento název souboru ponechte bez přípony (výchozí).
1. V souboru Dockerfile zadejte:


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

Výše uvedený je jednoduchý Dockerfile, který obsahuje následující instrukce:

- Obrázek SDK, který se má použít. Zde se jedná o obrázek Net 6. Docker si jej stáhne při spuštění sestavení. Verze SDK je specifikována jako značka.
- Poté můžete potřebovat nainstalovat písma, protože obrázkový soubor SDK obsahuje velmi málo písem. Můžete také použít lokální fonty zkopírované do dockerového obrazu.
- Pracovní adresář, který je specifikován v dalším řádku.
- Příkaz k zkopírování všeho do kontejneru, k publikování aplikace a k určení vstupního bodu.


## Sestavení a spuštění aplikace v Dockeru
 
Nyní lze aplikaci sestavit a spustit v Dockeru. Otevřete svůj oblíbený příkazový řádek, změňte adresář na složku s aplikací (složka, kde je umístěn soubor s řešením a soubor Dockerfile) a spusťte následující příkaz:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

První spuštění tohoto příkazu může trvat déle, protože Docker potřebuje stáhnout požadované obrazy. Jakmile je předchozí příkaz dokončen, spusťte následující příkaz:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile z Dockeru
{{< /highlight >}}

{{% alert color="primary" %}} 
Věnujte pozornost argumentu mount, protože, jak bylo uvedeno dříve, složka na hostitelském počítači je připojena do složky kontejneru, abyste snadněji viděli výsledky provádění aplikace. Cesty v Linuxu rozlišují velká a malá písmena.
{{% /alert %}}

## Další příklady

Pro další ukázky toho, jak můžete použít Aspose.CAD v Dockeru, podívejte se na [příklady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Viz také

- [Nainstalujte Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Nainstalujte Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Přepnout na Linuxové kontejnery](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) možnost
- Další informace o [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
