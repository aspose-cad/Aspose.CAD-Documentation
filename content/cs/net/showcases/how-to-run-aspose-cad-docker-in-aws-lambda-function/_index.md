---
title: Jak spustit obraz Aspose.CAD Docker v AWS Lambda funkci
type: docs
description: "Spusťte obraz Aspose.CAD Docker v AWS Lambda funkci."
weight: 74
url: /cs/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Předpoklady
- Musíte mít nainstalován Docker na vašem systému. Pokud chcete informace o tom, jak nainstalovat Docker ve Windows nebo Mac, podívejte se na odkazy v sekci „Viz také“.
- Visual Studio 2022.
- AWS Toolkit pro Visual Studio 2022.
- V příkladu je použit .NET 6 SDK.
- Postman

## AWS Lambda Funkce

Lambda je výpočetní služba, která vám umožňuje spouštět kód bez nutnosti provozovat nebo spravovat servery. Lambda spouští váš kód na infrastruktuře s vysokou dostupností a provádí veškerou správu výpočetních zdrojů včetně údržby serverů a operačního systému, provozování kapacity a automatického škálování a logování. S Lambdou můžete spouštět kód pro prakticky jakoukoli aplikaci nebo backendovou službu.

## Vytváření AWS Lambda Funkce

{{% alert color="primary" %}} 
Ujistěte se, že máte dostatečná oprávnění ke vytvoření funkcí AWS Lambda a obrazů v Amazon Elastic Container Registry.
{{% /alert %}}

Chcete-li vytvořit program pro AWS Lambda Funkci, postupujte podle níže uvedených kroků:
1. Vytvořte projekt AWS Lambda.<br>
![Tlačítko vytvoření funkce AWS](/cad/_assets/showcases/aws/create-project.png)<br>
1. Vyberte .NET 6 (Obraz kontejneru) a klikněte na tlačítko 'Dokončit'.<br>
![Tlačítko vytvoření kontejnerové funkce](/cad/_assets/showcases/aws/create-container.png)<br>
1. Otevřete průzkumníka AWS ve Visual Studiu (Zobrazení-> Průzkumník AWS).
1. Přidejte profil přístupových údajů AWS do průzkumníka AWS.<br>
![Profil přístupových údajů](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Zadejte Identifikační ID klíče a tajný přístupový klíč, tyto klíče můžete získat v bezpečnostních přístupech nebo kontaktujte administrátora a získejte soubor CSV pro autorizaci.<br>
![Nastavení profilu účtu](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Nainstalujte nejnovější knihovny z NuGet.<br>
![Správce NuGet](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Ukázkový kód pro převod obrázku CAD na soubor PDF.
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
1. Editujte soubor DockerFile podle sekce <a href="#nastavení-dockerfile">Nastavení Dockerfile</a>.
1. Spusťte Docker Desktop.
1. Publikujte do AWS Lambda.<br>
![Publikovat AWS lambda](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Upravte konfiguraci nahrání.<br>
![Nahrát AWS lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Klikněte na tlačítko 'Nahrát'.<br>
![Nahrát AWS lambda poslední](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Přejděte do prostředí AWS a vyberte Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Vyberte vaši novou funkci a vytvořte funkci pro vytvoření URL adresy.<br>
![Nastavení funkce url adresy](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Zvolte typ ověření
- AWS_IAM - Pouze ověření IAM uživatelů a rolí můžou zasílat požadavky na URL adresu vaší funkce.
- NONE - Lambda nebude provádět ověření IAM u požadavků na URL funkce. Koncový bod URL bude veřejný, pokud neimplementujete vlastní logiku autorizace ve vaší funkci.

### Nastavení Dockerfile

Dalším krokem je upravit konfiguraci Dockerfile v projektu.

1. V Dockerfile specifikujte:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

Výše uvedený je jednoduchý Dockerfile, který obsahuje tyto pokyny:

- Obrázek SDK, který se má použít. Zde je to obraz Net 6. Docker si ho stáhne při spuštění sestavení. Verze SDK je specifikována jako štítek.
- Poté můžete potřebovat nainstalovat písma, protože obrázek SDK obsahuje velmi málo písem. Také můžete použít lokální písma zkopírovaná do obrazu Docker.
- Pracovní adresář, který je specifikován v následujícím řádku.
- Příkaz pro zkopírování všeho do kontejneru, publikování aplikace a specifikaci vstupního bodu.

## Příklad spuštění

1. Nastavení v Postmanu.<br>
![Nastavení Postmanu](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Vyberte libovolný soubor DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Klikněte na tlačítko odeslat.

{{% alert color="primary" %}} 
Pokud odpověď bude úspěšná, klikněte na Uložit do souboru a dostanete konvertovaný soubor ve formátu PDF.
{{% /alert %}}

## Další příklady

Pro více ukázek, jak můžete použít Aspose.CAD v Dockeru, podívejte se na [příklady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Viz také

- [Instalace AWS Toolkit pro Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022) 
- [Instalace Docker Desktop ve Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalace Docker Desktop v Macu](https://docs.docker.com/docker-for-mac/install/) 
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies) 
- Možnost přepnutí na linuxové kontejnery [Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Další informace o [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
