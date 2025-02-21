---
title: Aspose.CAD Docker görüntüsünü Azure Function'da Çalıştırma
type: docs
description: "Aspose.CAD Docker görüntüsünü Azure Function'da çalıştırın."
weight: 73
url: /tr/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Ön Koşullar
- Docker sisteminizde kurulu olmalıdır. Docker'ı Windows veya Mac'te nasıl kuracağınıza dair bilgiler için "Ayrıca Bakınız" bölümündeki bağlantılara başvurun.
- Visual Studio 2022.
- Örnekte .NET 6 SDK kullanılmıştır.
- Postman

## Azure Function

Bu örnekte, bir CAD dosyasını dönüştüren ve bir görüntü olarak kaydeden basit bir dönüştürme fonksiyonu oluşturuyorsunuz. Uygulama daha sonra Docker'da oluşturulabilir ve Azure Function'da çalıştırılabilir.

## Azure Function Oluşturma

Azure Function programını oluşturmak için aşağıdaki adımları izleyin:
1. Docker kurulduktan sonra, Linux Konteynerlerini (varsayılan) kullandığından emin olun. Gerekirse, Docker Desktops menüsünden Linux konteynerlerine geçiş seçeneğini seçin.
1. Visual Studio'da bir .NET 6 Azure Function oluşturun.<br>
![Bir .NET 6 Azure Function proje iletişim kutusu](/_assets/showcases/azure/Create-project.png)<br>
1. Ek bilgi.<br>
![Bir .NET 6 Azure Function proje iletişim kutusu](/_assets/showcases/azure/Additional-information.png)<br>
1. NuGet'ten en son Aspose.CAD sürümünü yükleyin.<br>
![NuGet'te Aspose.CAD](/_assets/showcases/azure/NuGet.png)<br>
1. Uygulama Linux'ta çalışacağı için ek yazı tipleri kurmanız gerekebilir. ttf-mscorefonts-installer'i tercih edebilirsiniz.
1. Tüm gerekli bağımlılıklar eklendikten sonra, bir elips oluşturan ve bunu bir görüntü olarak kaydeden basit bir program yazın:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP tetikleyici fonksiyonu bir isteği işledi.");
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

### Dockerfile'ı Yapılandırma

Bir sonraki adım, kök proje klasöründe Dockerfile'ı oluşturmak ve yapılandırmaktır.

1. Dockerfile'ı oluşturun ve uygulamanızın çözüm dosyasının yanına yerleştirin. Bu dosya adını uzantı olmadan tutun (varsayılan).
![Kök proje klasörü](/_assets/showcases/azure/root-folder.png)<br>
1. Dockerfile'da, belirtin:


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

 Yukarıdaki basit bir Dockerfile'dır ve şu talimatları içerir:

- Kullanılacak SDK görüntüsü. Burada, .NET 6 görüntüsüdir. Docker, derleme çalıştırıldığında bunu indirecektir. SDK sürümü bir etiket olarak belirtilmiştir.
- Daha sonra, belgelerin çok az yazı tipi içerdiği için Yazı tiplerini yüklemeniz gerekebilir. Ayrıca, Docker görüntüsüne kopyalanmış yerel yazı tiplerini de kullanabilirsiniz.
- Bir sonraki satırda belirtilen çalışma dizini.
- Her şeyi konteynere kopyalamak, uygulamayı yayımlamak ve giriş noktasını belirtme komutu.

## Docker Hub
1. Docker Hub'a giriş yapın.
1. Kamu Deposu oluşturun.

## Uygulamayı Docker'da Oluşturma ve Çalıştırma
 
 Şimdi uygulama Docker'da oluşturulabilir ve çalıştırılabilir. Tercih ettiğiniz komut istemcisini açın, uygulamanızın bulunduğu (çözüm dosyası ve Dockerfile'ın yer aldığı) klasöre geçin ve aşağıdaki komutu çalıştırın:

{{< highlight plain >}}
//örnek
docker build -t <kullanıcı adı>/<depo adı> .

docker build -t kullanıcı/asposefunction .
{{< /highlight >}}
 
Bu komutu ilk kez çalıştırdığınızda, gerekli görüntüleri indirmek için Docker'ın biraz daha uzun sürmesi gerekebilir. Önceki komut tamamlandıktan sonra, görüntüyü docker hub'a yüklemek için aşağıdaki komutu çalıştırın:
 
{{< highlight plain >}}
//örnek
docker push <kullanıcı adı>/<depo adı>:tagname

docker push kullanıcı/asposefunction:latest
{{< /highlight >}}

## Azure

1. Azure'a giriş yapın.
1. Azure hizmetlerini seçin.
1. Function App seçin ve bir fonksiyon oluşturun.<br>
![Azure fonksiyon oluştur butonu](/_assets/showcases/azure/create-function.png)<br>
1. Aşağıdaki görüntüdeki gibi temel ayarları tekrarlayın.<br>
![Azure fonksiyon ayarları](/_assets/showcases/azure/create-function-setting.png)<br>
1. 'Gözden Geçir + oluştur' -> Oluştur'a tıklayın.
1. Dağıtımın tamamlanmasını bekleyin.
1. 'Kaynağa git' butonuna tıklayın.<br>
![Kaynak butonu](/_assets/showcases/azure/go-to-resource.png)<br>
1. aspose-cad-docker-example fonksiyonunu durdurun.<br>
![Konteyneri durdur](/_assets/showcases/azure/stop-container.png)<br>
1. Dağıtım merkezi menüsüne gidin ve gereken ayarları yapın.<br>
![Dağıtım merkezi](/_assets/showcases/azure/deployment-center.png)<br>
1. Ayarları kaydedin.
1. Dağıtım merkezi ayarlarından Webhook URL'sini kopyalayın.<br>
![Webhook url](/_assets/showcases/azure/webhook-url.png)<br>
1. Docker Hub'a gidin, deponuzu seçin ve webhooks'u seçin.
1. Azure'dan alınan 'Webhook url'ini Docker Hub webhook url'sine yapıştırın ve adlandırın.<br>
![Docker'daki Webhook ayarları](/_assets/showcases/azure/webhook.png)<br>
1. Oluştur butonuna tıklayın.
1. Genel bakış Azure fonksiyonuna geri dönün ve konteyneri başlatın.<br>
![Genel bakış menüsü](/_assets/showcases/azure/overview.png)<br>

## Çalışma örneği

1. Postman ayarları.<br>
![Genel bakış menüsü](/_assets/showcases/azure/postman-settings.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Gönder butonuna tıklayın.

{{% alert color="primary" %}} 
Cevap başarılı olursa, dosyayı kaydetmek için tıklayın ve png formatında dönüştürülmüş dosyayı alacaksınız.
{{% /alert %}}

## Daha Fazla Örnek

Aspose.CAD'ın Docker'da nasıl kullanılmasına dair daha fazla örnek için [örneklere](https://github.com/aspose-cad/Aspose.CAD-Documentation) bakın.


## Ayrıca Bakınız

- [Windows'ta Docker Desktop'u Kurun](https://docs.docker.com/docker-for-windows/install/)
- [Mac'te Docker Desktop'u Kurun](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux konteynerlerine geçiş](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) seçeneği
- [.NET Core SDK hakkında ek bilgi](https://hub.docker.com/_/microsoft-dotnet-sdk)
