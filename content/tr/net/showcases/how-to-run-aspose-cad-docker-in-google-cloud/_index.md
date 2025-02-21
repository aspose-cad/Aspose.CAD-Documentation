---
title: Aspose.CAD Docker görüntüsünü Google Cloud'da çalıştırma
type: docs
description: "Aspose.CAD Docker görüntüsünü Google Cloud'da çalıştırma."
weight: 75
url: /tr/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Ön koşullar

- Sisteminizde Docker yüklü olmalıdır. Windows veya Mac'te Docker'ı nasıl yükleyeceğiniz hakkında bilgi için "Ayrıca Bakınız" bölümündeki bağlantılara bakın.
- Visual Studio 2022.
- Google CLI.
- Örnek olarak .NET Core 3.1 SDK kullanılmaktadır.
- Postman

## Google Cloud Run Fonksiyonu

Cloud Run, sunucusuz HTTP konteynerlerini dağıtma ve ölçeklendirme için makine sağlamadan, kümeleri yapılandırmadan veya otomatik ölçeklendirme ile ilgilenmeden kullanılan tamamen yönetilen bir hesaplama ortamıdır.

- Tedarikçi bağımlılığı yoktur - Cloud Run, standart OCI konteynerlerini alır ve standart Knative Serving API'sini uygular, böylece uygulamalarınızı kendi sunucularınıza veya herhangi bir bulut ortamına kolayca taşıyabilirsiniz. 
- Hızlı otomatik ölçeklendirme - Cloud Run'da dağıtılan mikro hizmetler, gelen istek sayısına bağlı olarak otomatik olarak ölçeklenir, bu nedenle tam teşekküllü bir Kubernetes kümesini yapılandırmanız veya yönetmeniz gerekmez. Cloud Run, isteğin olmadığı durumlarda kaynak kullanmaz, yani sıfıra ölçeklenir.
- Trafiği bölme - Cloud Run, birden fazla revizyon arasında trafiği bölmenizi sağlar, böylece canary dağıtımları veya blue/green dağıtımları gibi kademeli yayılımlar gerçekleştirebilirsiniz.
- Özel alan adları - Cloud Run'da özel alan adı eşleştirmesi yapabilir ve alanınız için bir TLS sertifikası sağlayacaktır. 
- Otomatik yedeklilik - Cloud Run otomatik yedeklilik sunar, böylece yüksek erişilebilirlik için birden fazla örnek oluşturmakla endişelenmenize gerek kalmaz.

Cloud Run ve Cloud Functions, Google Cloud’un sunucusuz altyapısında çalışan, otomatik ölçeklenebilen ve HTTP isteklerini veya olaylarını yöneten tamamen yönetilen hizmetlerdir. Ancak bazı önemli farklılıkları vardır:

- Cloud Functions, sınırlı bir programlama dillerinde yazılmış kod parçacıkları (fonksiyonlar) dağıtmanıza olanak tanırken, Cloud Run, seçtiğiniz programlama dilini kullanarak konteyner görüntüleri dağıtmanıza olanak tanır. 
- Cloud Run ayrıca uygulamanızdan herhangi bir araç veya sistem kütüphanesinin kullanılmasına izin verir; Cloud Functions özel yürütülebilir dosyalar kullanmanıza izin vermez. 
- Cloud Run, 60 dakikaya kadar daha uzun bir işlem zaman aşımı süresi sunar; Cloud Functions ile istek zaman aşımı en fazla 9 dakikaya ayarlanabilir. 
- Cloud Functions her bir fonksiyon örneğine bir seferde yalnızca bir istek gönderir. Cloud Run ise varsayılan olarak her bir konteyner örneğinde birden fazla eşzamanlı istek gönderecek şekilde yapılandırılmıştır. Bu, büyük hacim bekliyorsanız gecikmeyi azaltmaya ve maliyetleri düşürmeye yardımcı olur. 

## Google Cloud Function projesini oluşturma

{{% alert color="primary" %}} 
Google Cloud Run fonksiyonu ve görüntüleri oluşturmak için yeterli haklara sahip olduğunuzdan emin olun ve Artifact Registry deposu.
{{% /alert %}}

Google Cloud Function programını oluşturmak için aşağıdaki adımları izleyin:

1. .NET Core SDK 3.1'i yükleyin.
1. Şablon paketini yükleyin:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Ardından, projeniz için bir dizin oluşturun ve yeni bir HTTP fonksiyonu oluşturmak için dotnet new kullanın:
{{< highlight plain >}}
mkdir AsposeFunctions //kapsayıcı oluştur
cd AsposeFunctions //AsposeFunctions dizinine git
dotnet new gcf-http //http tetikleyici ile Google Cloud Function projesi oluştur
{{< /highlight >}}
{{% alert color="primary" %}} 
Bu, mevcut dizinde AsposeFunctions.csproj ve Function.cs dosyalarını oluşturur. Kodu gözden geçirmek için Function.cs'yi açın ve isterseniz özel bir mesaj sağlayın.
{{% /alert %}}
1. csproj dosyası örneği (AsposeFunctions.csproj).
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
1. CAD görüntüsünü PNG dosyasına dönüştürme kodu örneği (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Fonksiyonunuzun mantığı burada yer alıyor.
        /// </summary>
        /// <param name="context">İsteği ve yanıtı içeren HTTP bağlamı.</param>
        /// <returns>Asenkron işlemi temsil eden bir görev.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //form dosyası
                var file = context.Request.Body; //ikili veri
                
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
1. İşlevinizi yerel olarak aşağıdaki gibi oluşturun:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Sunucu çalışmaya başladığında, fonksiyonu çağırmak için http://localhost:8080 adresine gidin. Sunucuyu durdurmak için konsolda Ctrl-C tuşlarına basın.

## Docker görüntüsünü Google Cloud'a dağıtma

1. Google Cloud'a giriş yapın.
1. Yoksa bir proje oluşturun.
1. 'Artifact Registry'ye gidin ve bir depo oluşturun.<br>
![Artifact Repository Oluştur](/_assets/showcases/google/create-artifact-repository.png)<br>
1. Artifact Registry'de yeni depoyu seçin.
![Artifact deposunu seç](/_assets/showcases/google/select-artifact.png)<br>
1. 'KURULUM TALİMATLARI'na tıklayın ve 'Docker' yapılandırma komutunu kopyalayın.<br>
![KURULUM TALİMATLARI](/_assets/showcases/google/setup-instruction.png)<br>
1. Docker'ın yapılandırma dosyasına bir Docker credHelper girişi ekleyin veya dosya yoksa oluşturun.
{{< highlight plain >}}
//örnek
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Proje ana dizininde bir Dockerfile oluşturun ve DockerFile'ı <a href="#configuring-a-dockerfile">Dockerfile'ı Yapılandırma</a> bölümündeki gibi düzenleyin.
1. Docker Desktop'u başlatın.
1. Bulut deposu yoluyla docker görüntüsünü oluşturun.
{{< highlight plain >}}
//örnek
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Görüntüyü Google Cloud Artifact Registry'ye gönderin.
{{< highlight plain >}}
//örnek
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Google Cloud Run hizmeti oluşturma 

1. Cloud Run'a gidin.
1. Cloud Run hizmeti oluşturun.<br>
![Cloud Run hizmeti oluştur](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. Konteyner Görüntü URL alanında 'ARTIFACT REGISTRY' den konteyneri seçin.<br>
![Konteyner Görüntü URL'si](/_assets/showcases/google/container-url.png)<br>
1. Aşağıdaki ayarları kontrol edin.<br>
![Hizmet ayarları](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Dağıtımın tamamlanmasını bekleyin.
1. Dönüştürme uygulaması ile çalışmak için hizmet URL'si.<br>
![Hizmet url'si](/_assets/showcases/google/url-service.png)<br>

### Dockerfile'ı Yapılandırma

 Sonraki adım projenizde Dockerfile'ı düzenlemektir.

1. Dockerfile'da belirtin:

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

 Yukarıdaki, aşağıdaki talimatları içeren basit bir Dockerfile'dır:

- Kullanılacak SDK görüntüsü. Burada Net Core 3.1 görüntüsü kullanılır. Docker, yapı sırasında bunu indirecektir. SDK'nın sürümü bir etiket olarak belirtilmiştir.
- Daha sonra, SDK görüntüsü çok az yazı tipine sahip olduğundan yazı tiplerini yüklemeniz gerekebilir. Ayrıca, Docker görüntüsüne kopyalanmış yerel yazı tiplerini de kullanabilirsiniz.
- Bir sonraki satırda belirtilen çalışma dizini.
- Her şeyi konteynere kopyalama, uygulamayı yayınlama ve giriş noktası belirleme komutu.

## Uygulama örneği

1. Postman ayarları.<br>
![Genel görünüm menüsü](/_assets/showcases/google/postman-settings.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Gönder butonuna tıklayın.

{{% alert color="primary" %}} 
Cevap başarılıysa, “Dosyaya kaydet”e tıklayın ve dönüştürülmüş dosyayı PNG formatında alacaksınız.
{{% /alert %}}

## Daha Fazla Örnek

Aspose.CAD'i Docker'da nasıl kullanabileceğiniz hakkında daha fazla örnek için [örnekler](https://github.com/aspose-cad/Aspose.CAD-Documentation) sayfasına bakın.

## Ayrıca Bakınız.

- [Windows için Docker Desktop'ı Yükleyin](https://docs.docker.com/docker-for-windows/install/)
- [Mac için Docker Desktop'ı Yükleyin](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Linux konteynerlerine geçiş](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) seçeneği
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) hakkında ek bilgiler
