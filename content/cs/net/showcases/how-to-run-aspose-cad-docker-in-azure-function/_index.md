---
title: Jak spustit obraz Aspose.CAD Docker v Azure Function
type: docs
description: "Spusťte obraz Aspose.CAD Docker v Azure Function."
weight: 73
url: /cs/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Předpoklady
- Na vašem systému musí být nainstalován Docker. Pokud potřebujete informace o tom, jak nainstalovat Docker na Windows nebo Mac, podívejte se na odkazy v sekci „Viz také“.
- Visual Studio 2022.
- V příkladu je použito NET 6 SDK.
- Postman

## Azure Function

V tomto příkladu vytvoříte jednoduchou konverzní funkci, která převede soubor CAD a uloží ho jako obrázek. Aplikace pak může být postavena v Dockeru a spuštěna v Azure Function.

## Vytvoření Azure Function

Pro vytvoření programu Azure Function postupujte podle následujících kroků:
1. Jakmile je nainstalován Docker, ujistěte se, že používá kontejnery Linux (výchozí). Pokud je to nutné, vyberte možnost „Přepnout na kontejnery Linux“ z nabídky programu Docker Desktop.
1. V programu Visual Studio vytvořte Azure Function pro NET 6.<br>
![Dialogové okno pro vytvoření projektu Azure Function pro NET 6](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Další informace.<br>
![Dialogové okno pro vytvoření projektu Azure Function pro NET 6](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Nainstalujte nejnovější verzi Aspose.CAD z NuGet.<br>
![Aspose.CAD na NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Protože aplikace bude spuštěna na Linuxu, může být nutné nainstalovat další písma. Můžete upřednostňovat například „ttf-mscorefonts-installer“.
1. Jakmile jsou přidány všechny potřebné závislosti, napište jednoduchý program, který vytvoří elipsu a uloží ji jako obrázek:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Funkce pro zpracování požadavku HTTP v jazyce C# byla spuštěna.");
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

### Konfigurace souboru Dockerfile

Dalším krokem je vytvoření a konfigurace souboru Dockerfile v kořenovém adresáři projektu.

1. Vytvořte soubor Dockerfile a umístěte ho vedle souboru se řešením vaší aplikace. Uchovejte tento soubor bez přípony (výchozí).
![Kořenový adresář projektu](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Ve souboru Dockerfile určete:


{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 JAK základ
PRACOVNÍ ADRESÁŘ /domovská stránka/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 JAK postavit
PRACOVNÍ ADRESÁŘ /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
PRACOVNÍ ADRESÁŘ "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM postavit JAK zveřejnit
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM základna JAK konečný
PRACOVNÍ ADRESÁŘ /domovská stránka/site/wwwroot
COPY --from=publikovat /app/publish .
ENV AzureWebJobsScriptRoot=/domovská stránka/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

Výše uvedený je jednoduchý soubor Dockerfile, který obsahuje následující pokyny:

- Obraz SDK, který se má použít. Zde je to obraz Net 6. Docker si jej stáhne při spuštění sestavení. Verze SDK je specifikována jako značka.
- Poté můžete potřebovat nainstalovat písma, protože obraz SDK obsahuje velmi málo písem. Také můžete použít lokální písma zkopírovaná do obrazu Docker.
- Pracovní adresář, který je uveden v dalším řádku.
- Příkaz pro zkopírování všeho do kontejneru, publikování aplikace a specifikování vstupního bodu.

## Docker Hub
1. Přihlaste se do Docker Hub.
1. Vytvořte veřejný Repozitář

## Sestavení a Spuštění Aplikace v Dockeru
 
 Nyní může být aplikace sestavena a spuštěna v Dockeru. Otevřete oblíbený příkazový řádek, změňte adresář na složku s aplikací (složka, kde jsou umístěny soubor se řešením a Dockerfile) a spusťte následující příkaz:

{{< highlight plain >}}
//příklad
docker build -t <uživatelské jméno>/<název repozitáře> .

docker build -t uzivatel/asposefunction .
{{< /highlight >}}
 
První spuštění tohoto příkazu může trvat déle, protože Docker potřebuje stáhnout nezbytné obrazy. Po dokončení předchozího příkazu spusťte následující příkaz k odeslání obrazu do Docker Hubu:
 
{{< highlight plain >}}
//příklad
docker push <uživatelské jméno>/<název repozitáře>:tagname

docker push uzivatel/asposefunction:latest
{{< /highlight >}}

## Azure

1. Přihlaste se do Azure.
1. Vyberte služby služby Azure.
1. Vyberte funkci App a vytvořte funkci.<br>
![Tlačítko pro vytvoření funkce v Azure](/cad/_assets/showcases/azure/create-function.png)<br>
1. Zopakujte základní nastavení jako na následujícím obrázku.<br>
![Nastavení vytvoření funkce v Azure](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Klikněte na „Zkontrolovat + vytvořit“ -> Vytvořit.
1. Počkejte na dokončení nasazení.
1. Klikněte na tlačítko „Přejít na zdroj“.br>
![Tlačítko Zdroj](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Zastavte funkci aspose-cad-docker-example.<br>
![Zastavit kontejner](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Přejděte do nabídky centra nasazení a proveďte příslušná nastavení.<br>
![Centrum nasazení](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Uložte nastavení
1. Zkopírujte odkaz Webhooku ze nastavení centra nasazení.<br>
![Odkaz Webhooku](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Přejděte na Docker Hub, vyberte váš repozitář a vyberte webové háčky.
1. Vložte „Odkaz Webhook“ z Azure do odkazu webového háčku Docker Hub a nastavte jméno.<br>
![Nastavení webového háčku v Dockeru](/cad/_assets/showcases/azure/webhook.png)<br>
1. Klikněte na tlačítko vytvořit.
1. Vraťte se do přehledu Azure funkce a spusťte kontejner.<br>
![Nabídka Přehled](/cad/_assets/showcases/azure/overview.png)<br>

## Příklad spuštění

1. Nastavení Postmanu.<br>
![Nastavení Postmanu](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Vyberte libovolný soubor DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Klikněte na tlačítko odeslat.

{{% alert color="primary" %}} 
Pokud je odpověď úspěšná, klikněte na Uložit do souboru a obdržíte konvertovaný soubor ve formátu png
{{% /alert %}}

## Další příklady

Pro více vzorů, jak můžete použít Aspose.CAD v Dockeru, podívejte se na [příklady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Viz také

- [Instalace Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalace Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Možnost „Přepnout na kontejnery Linux“ ([Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers))
- Další informace o [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
