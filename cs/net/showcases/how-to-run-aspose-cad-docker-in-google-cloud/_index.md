---
title: Jak spustit obraz Aspose.CAD Docker v Google Cloud
type: docs
description: "Spusťte obraz Aspose.CAD Docker v Google Cloud."
weight: 75
url: /cs/jak-spustit-aspose-cad-docker-obraz-v-google-cloud
---

## Předpoklady

- Docker musí být nainstalován na vašem systému. Pro informace o instalaci Dockeru na Windows nebo Mac se odkazujte na odkazy v sekci „Viz také“.
- Visual Studio 2022.
- Google CLI.
- V příkladu je použita SDK .NET Core 3.1.
- Postman

## Funkce Google Cloud Run

Cloud Run je plně spravované výpočetní prostředí pro nasazování a škálování bezprostředních HTTP kontejnerů bez starostí o provozování strojů, konfiguraci clusterů nebo automatické škálování.

- Žádný zámek dodavatele - Protože Cloud Run bere standardní OCI kontejnery a implementuje standardní Knative Serving API, můžete snadno přenést své aplikace na vlastní prostředí nebo jakýkoli jiný cloudový prostředí.
- Rychlé automatické škálování - Mikroslužby nasazené v Cloud Run se automaticky škálují v závislosti na počtu příchozích požadavků, aniž byste museli konfigurovat nebo spravovat plně vybavený Kubernetes cluster.
- Rozdělení provozu - Cloud Run umožňuje rozdělit provoz mezi několik revizí, takže můžete provádět postupné nasazení, jako jsou kanárová nasazení nebo modro/zelená nasazení.
- Vlastní domény - Můžete nastavit mapování vlastní domény v Cloud Run a systém automaticky zprovozní certifikát TLS pro vaši doménu.
- Automatická redundance - Cloud Run nabízí automatickou redundanci, takže se nemusíte starat o vytváření více instancí pro vysokou dostupnost.

Cloud Run a Cloud Functions jsou oba plně řízené služby běžící na serverless infrastruktuře Google Cloud, které se škálují automaticky a zpracovávají HTTP požadavky nebo události. Nicméně existují některé důležité rozdíly:

- Cloud Functions vám umožňuje nasadit úryvky kódu (funkce) napsané v omezeném souboru programovacích jazyků, zatímco Cloud Run umožňuje nasazení kontejnerových obrazů pomocí programovacího jazyka vašeho výběru.
- Cloud Run také podporuje použití jakéhokoli nástroje nebo systémové knihovny z vaší aplikace; Cloud Functions vám nedovoluje používat vlastní spustitelné soubory.
- Cloud Run nabízí delší dobu vypršení čekání na požadavky až 60 minut, zatímco s Cloud Functions lze doba vypršení požadavků nastavit až na 9 minut.
- Cloud Functions posílá pouze jeden požadavek najednou na každou instanci funkce, zatímco ve výchozím nastavení Cloud Run je konfigurován tak, aby posílal více souběžných požadavků na každou instanci kontejneru. To pomáhá zlepšit latenci a snížit náklady, pokud očekáváte velké objemy.

## Vytvoření projektu funkce Google Cloud

{{% alert color="primary" %}}
Ujistěte se, že máte dostatečná práva k vytvoření funkce Google Cloud Run a obrazů v repozitáři Artifact Registry.
{{% /alert %}}

K vytvoření programu funkce Google Cloud postupujte podle následujících kroků:

1. Nainstalujte .NET Core SDK 3.1.
1. Nainstalujte šablonový balíček:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Dále vytvořte adresář pro váš projekt a použijte příkaz dotnet new ke vytvoření nového HTTP funkce:
{{< highlight plain >}}
mkdir AsposeFunctions //vytvořit složku
cd AsposeFunctions //přejít do složky AsposeFunctions
dotnet new gcf-http //vytvořit projekt funkce Google Cloud s HTTP spouštěčem
{{< /highlight >}}
{{% alert color="primary" %}}
Tímto vytvoříte AsposeFunctions.csproj a Function.cs v aktuálním adresáři. Otevřete Function.cs k prohlížení kódu a případně zadejte vlastní zprávu.
{{% /alert %}}
1. Příklad kódu pro soubor csproj (AsposeFunctions.csproj).
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
1. Příklad kódu pro převod obrázku cad na soubor png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logika vaší funkce zde.
        /// </summary>
        /// <param name="context">HTTP kontext obsahující požadavek a odpověď.</param>
        /// <returns>Úloha představující asynchronní operaci.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //formulářový soubor
                var file = context.Request.Body; //binární data
                
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
1. Spusťte vaši funkci lokálně následovně:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Jakmile je server spuštěn, přejděte na http://localhost:8080 k volání funkce. Stiskněte Ctrl-C v konzoli pro zastavení serveru.

## Nasazení obrazu dockeru do Google Cloud

1. Přihlaste se do Google Cloud.
1. Vytvořte projekt, pokud neexistuje.
1. Přejděte do „Artifact Registry“ a vytvořte repozitář.<br>
![Vytvoření úložiště Artifact](create-artifact-repository.png)<br>
1. Vyberte nový repozitář v Artefaktového registru.
![Vyberte artefaktové úložiště](select-artifact.png)<br>
1. Klepněte na „SADA PŘÍKAZŮ“ a zkopírujte příkaz „Konfigurovat Docker“.<br>
![SADA PŘÍKAZŮ](setup-instruction.png)<br>
1. Přidejte záznam credHelper pro Docker do konfiguračního souboru Dockeru nebo vytvořte soubor, pokud neexistuje.
{{< highlight plain >}}
//příklad
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Vytvořte ve složce kořenového adresáře projektu soubor Dockerfile a upravte jej podle části <a href="#konfigurace-dockerfile">Konfigurace Dockerfile</a>.
1. Spusťte Docker Desktop.
1. Sestavte dockerový obraz s cestou k cloudovému repozitáři.
{{< highlight plain >}}
//příklad
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Odešlete obraz do úložiště Google Cloud Artifact Registry
{{< highlight plain >}}
//příklad
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Vytvoření služby Google Cloud Run

1. Přejděte do služby Cloud Run.
1. Vytvořte službu Cloud Run.<br>
![Vytvoření služby Cloud Run](create-cloud-run-service.png)<br>
1. V poli URL obrázku kontejneru vyberte kontejner z „ARTIFAKTOVÉHO REGISTRU“. <br>
![URL obrázku kontejneru](container-url.png)<br>
1. Zkontrolujte další nastavení níže.<br>
![Nastavení služby](cloud-run-service-settings.png)<br>
1. Počkejte na dokončení nasazení.
1. URL služby k práci s aplikací konverze.<br>
![URL služby](url-service.png)<br>

### Konfigurace Dockerfile

 Dalším krokem je upravit konfiguraci Dockerfile v projektu.

1. V souboru Dockerfile upřesněte:

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

 Výše uvedený je jednoduchý Dockerfile, který obsahuje následující instrukce:

- Obrázek SDK, který má být použit. Zde je to obraz Net Core 3.1. Když se spustí sestavení, Docker jej stáhne. Verze SDK je zadána jako značka.
- Poté můžete potřebovat nainstalovat písma, protože obraz SDK obsahuje velmi málo písem. Můžete také použít lokální písma zkopírovaná do dockerového obrazu.
- Pracovní adresář, který je specifikován v následujícím řádku.
- Příkaz k zkopírování všeho do kontejneru, publikaci aplikace a specifikaci vstupního bodu.

## Příklad provedení

1. Nastavení Postmanu.<br>
![Přehled menu](postman-settings.png)<br>
1. Vyberte libovolný soubor DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Klepněte na tlačítko odeslat.

{{% alert color="primary" %}} 
Pokud je odpověď úspěšná, klepněte na Uložit do souboru a obdržíte převedený soubor ve formátu png
{{% /alert %}}

## Další příklady

Pro další ukázky, jak můžete použít Aspose.CAD v Dockeru, navštivte [příklady](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Viz Také.

- [Instalace Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalace Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- Možnost [přepínání mezi kontejnery Windows a Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Další informace o [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)