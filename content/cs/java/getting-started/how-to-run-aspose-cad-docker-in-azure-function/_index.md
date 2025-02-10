---
title: Jak spustit obraz Aspose.CAD Docker v Azure Function
type: docs
description: "Spusťte obraz Aspose.CAD Docker v Azure Function."
weight: 71
url: /cs/jak-spustit-obraz-aspose-cad-docker-v-azure-function
---

## Předpoklady
- Docker musí být nainstalován na vašem systému. Informace o instalaci Dockeru na Windows nebo Mac naleznete v odkazech v sekci "Viz také".
- IntelliJ IDEA.
- Azure Toolkit pro IntelliJ.
- Postman.

## Azure Function

V tomto příkladu vytvoříte jednoduchou konverzní funkci, která převede soubor CAD a uloží jej jako obrázek. Aplikace může být následně sestavena v Dockeru a spuštěna v Azure Function.

## Vytvoření Azure Function

Pro vytvoření programu Azure Function postupujte podle následujících kroků:
1. Jakmile je nainstalován Docker, ujistěte se, že používá kontejnery Linux (výchozí). Pokud je to nutné, z nabídky Docker Desktop vyberte možnost Přepnout na linuxové kontejnery.
1. Vytvoříte projekt Azure Function v IntelliJ IDEA.<br>
![Vytvoření projektu Azure Function](/_assets/create-function-ide-1.png)<br>
![Vytvoření projektu Azure Function - finální](/_assets/create-function-ide-2.png)<br>
1. Nástroje-> Azure-> Přihlásit se a vybrat ověření OAuth 2.0.<br>
![Přihlášení do Azure](/_assets/sign-in-azure.png)<br>
1. Přihlaste se v prohlížeči.
1. Vyberte název odběru.
1. Přidejte podporu Dockeru.<br>
![Přihlášení do Azure](/_assets/add-docker-support.png)<br>
1. Upravte soubor Dockerfile, jak je uvedeno v sekci <a href="#configuring-a-dockerfile">Konfigurace Dockerfile</a>.
1. Přidejte bloky pro repozitář aspose.cad do souboru pom.xml.
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

1. Jakmile budou přidány všechny požadované závislosti, napište jednoduchý program, který vytvoří elipsu a uloží ji jako obrázek:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Tato funkce poslouchá na koncovém bodě "/api/HttpExample". Dvě způsoby, jak ji vyvolat pomocí příkazu "curl" v bashi:
     * 1. curl -d "HTTP tělo" {vaše hostitelka}/api/HttpExample
     * 2. curl "{vaše hostitelka}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP příkaz zpracoval požadavek.");

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

### Konfigurace Dockerfile

Dalším krokem je vytvoření a konfigurace souboru Dockerfile ve složce kořenového projektu.

1. V souboru Dockerfile uveďte:
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build Jako installer-env

COPY . /src/jazyk-funkce-java
RUN cd /src/jazyk-funkce-java && \
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

Výše uvedený je jednoduchý Dockerfile, který obsahuje následující pokyny:

- Obrázek SDK, který se má použít. Docker jej stáhne při spuštění sestavení. Verze SDK je specifikována jako značka.
- Pracovní adresář, který je specifikován v následujícím řádku.
- Příkaz k zkopírování všeho do kontejneru, publikování aplikace a specifikaci vstupního bodu.

## Docker Hub
1. Přihlašte se do Docker Hubu
1. Vytvořte veřejný repozitář

## Sestavení a spuštění aplikace v Dockeru

Nyní lze aplikaci sestavit a spustit v Dockeru. Otevřete oblíbený příkazový řádek, změňte adresář na složku se aplikací (složka, kde je umístěn soubor řešení a Dockerfile) a spusťte následující příkaz:


1. Příkaz sestavení souboru Dockerfile v konzoli
{{< highlight plain >}}
//příklad
docker build -t <jméno uživatele>/<název repozitáře> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. Při prvním spuštění tohoto příkazu může trvat déle, protože Docker musí stáhnout potřebné obrazy. Poté, co předchozí příkaz dokončí, spusťte následující příkaz pro zaslání obrazu do Docker Hubu.
{{< highlight plain >}}
//příklad
docker push <jméno uživatele>/<název repozitáře>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Spusťte soubor Dockerfile v IDE a po zaslání do Docker Hubu.<br>
![Spuštění Dockeru v IDE](/_assets/docker-run-in-ide.png)<br>
1. Zadejte název obrazu, jako je uvedeno v repozitáři Docker Hubu.<br>
![Spuštění Dockeru v IDE - pokračování](/_assets/docker-run-in-ide-1.png)<br>
1. Počkejte na dokončení.

## Azure

1. Přihlásit se do Azure.
1. Vyberte služby Azure.
1. Vyberte Funkci aplikace a vytvořte funkci.<br>
![Tlačítko Vytvořit funkci v Azure](/_assets/create-function-azure.png)<br>
1. Opakujte základní nastavení, jak je znázorněno na následujícím obrázku.<br>
![Nastavení vytvoření funkce v Azure](/_assets/create-function-settings.png)<br>
1. Klepněte na 'Zkontrolovat + vytvořit' -> Vytvořit.
1. Počkejte na dokončení nasazení.
1. Klepněte na tlačítko 'Přejít na zdroj'.<br>
![Tlačítko zdroje](/_assets/go-to-resource.png)<br>
1. Zastavte funkci aspose-cad-docker-example.<br>
![Zastavení kontejneru](/_assets/stop-container.png)<br>
1. Přejděte do nabídky střediska pro nasazení a proveďte příslušná nastavení.<br>
![Středisko pro nasazení](/_assets/deployment-center.png)<br>
1. Uložte nastavení
1. Zkopírujte Webhook URL ze nastavení střediska pro nasazení.<br>
![Webhook URL](/_assets/webhook-url.png)<br>
1. Přejděte do Docker Hubu, vyberte svůj repozitář a vyberte webhooks.
1. Vložte „Webhook url“ z Azure do pole "Webhook url" v Docker Hubu a nastavte název.<br>
![Nastavení webhooku v Dockeru](/_assets/webhook.png)<br>
1. Klepněte na tlačítko vytvořit.
1. Vraťte se zpět na přehled funkce Azure a spusťte kontejner.<br>
![Přehled menu](/_assets/overview.png)<br>
{{% alert color="primary" %}} 
Může trvat několik minut, než funkce začne fungovat.
{{% /alert %}}

## Příklad provedení

1. Nastavení Postmana.<br>
![Přehled menu](/_assets/postman-settings.png)<br>
1. Vyberte jakýkoliv soubor DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Klepněte na tlačítko odeslat.
1. Uložte výsledek
![Uložení odpovědi](/_assets/response-postman.png)<br>

{{% alert color="primary" %}} 
Pokud je odpověď úspěšná, klepněte na Uložit do souboru a obdržíte konvertovaný soubor ve formátu png
{{% /alert %}}

## Další příklady

Pro více ukázek, jak můžete použít Aspose.CAD v Dockeru, podívejte se na [příklady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Viz také

- [Instalace Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalace Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- Možnost přepnutí na linuxové kontejnery v [Dockeru pro Windows](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
