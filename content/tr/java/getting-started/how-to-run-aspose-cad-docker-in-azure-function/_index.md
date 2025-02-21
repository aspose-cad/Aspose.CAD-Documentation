---
title: Azure Fonksiyonunda Aspose.CAD Docker Görüntüsünü Çalıştırma
type: docs
description: "Azure Fonksiyonunda Aspose.CAD Docker görüntüsünü çalıştırın."
weight: 71
url: /tr/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Gereksinimler
- Sisteminizde Docker kurulu olmalıdır. Windows veya Mac'te Docker'ın nasıl kurulacağı hakkında bilgi için "Ayrıca Bakınız" bölümündeki bağlantılara bakın.
- IntelliJ IDEA.
- IntelliJ için Azure Araç Takımı.
- Postman.

## Azure Fonksiyonu

Bu örnekte, bir CAD dosyasını dönüştüren ve bir görüntü olarak kaydeden basit bir dönüşüm fonksiyonu oluşturuyorsunuz. Uygulama daha sonra Docker'da inşa edilebilir ve Azure Fonksiyonu'nda çalıştırılabilir.

## Azure Fonksiyonunu Oluşturma

Azure Fonksiyon programını oluşturmak için aşağıdaki adımları izleyin:
1. Docker kurulduktan sonra, Linux Konteynerleri kullandığından emin olun (varsayılan). Gerekirse, Docker Masaüstü menüsünden Linux konteynerlerine geçiş seçeneğini seçin.
1. IntelliJ IDEA'da Azure Fonksiyon projesi oluşturun.<br>
![Azure fonksiyon projesi oluştur](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Azure fonksiyon projesi oluştur-sonuç](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Araçlar->Azure->Oturum Aç ve OAuth 2.0 kimlik doğrulamasını seçin.<br>
![Azure oturum aç](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Tarayıcıda oturum açın.
1. Abonelik adını seçin.
1. Docker desteği ekleyin.<br>
![Azure oturum aç](/_assets/java/java-azure/add-docker-support.png)<br>
1. <a href="#configuring-a-dockerfile">Dockerfile'ı Yapılandırma</a> bölümündeki gibi DockerFile'ı düzenleyin.
1. pom.xml dosyasına aspose.cad için depo blokları ekleyin.
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

1. Gerekli tüm bağımlılıklar eklendikten sonra, bir elips oluşturan ve bunu bir görüntü olarak kaydeden basit bir program yazın:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Bu işlev "/api/HttpExample" uç noktasında dinler. "curl" komutu ile iki şekilde çağrılabilir:
     * 1. curl -d "HTTP Gövdesi" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP tetikleyici bir isteği işledi.");

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

### Dockerfile'ı Yapılandırma

Bir sonraki adım, ana proje klasöründe Dockerfile'ı oluşturmak ve yapılandırmaktır.

1. Dockerfile'da şunları belirtin:
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

 Yukarıdaki, aşağıdaki talimatları içeren basit bir Dockerfile'dır:

- Kullanılacak SDK görüntüsü. Docker, yapı çalıştırıldığında bunu indirecektir. SDK'nın sürümü bir etiket olarak belirtilmiştir.
- Bir sonraki satırda belirtilen çalışma dizini.
- Her şeyi konteynıra kopyalama, uygulamayı yayınlama ve giriş noktasını belirleme komutu.

## Docker Hub
1. Docker Hub'a giriş yapın.
1. Kamu Deposu oluşturun.

## Uygulamayı Docker'da Oluşturma ve Çalıştırma
 
 Şimdi uygulama Docker'da inşa edilebilir ve çalıştırılabilir. Tercih ettiğiniz komut istemcisini açın, uygulamanın bulunduğu klasöre gidin (çözüm dosyasının ve Dockerfile'ın bulunduğu klasör) ve aşağıdaki komutu çalıştırın:


1. Konsolda dockerfile oluşturma komutu
{{< highlight plain >}}
//örnek
docker build -t <kullanıcı adı>/<depo adı> .

docker build -t kullanıcı/asposefunction .
{{< /highlight >}}
 
1. Bu komutu ilk çalıştırdığınızda, gerekli görüntüleri indirmek için Docker'ın daha uzun süre alabileceğini unutmayın. Önceki komut tamamlandıktan sonra, Docker hub'a görüntüyü yüklemek için aşağıdaki komutu çalıştırın.
{{< highlight plain >}}
//örnek
docker push <kullanıcı adı>/<depo adı>:tagname

docker push kullanıcı/aspose-cad-java:latest
{{< /highlight >}}

1. IDE'de dockerfile çalıştırın ve ardından docker hub'a itme işlemi yapın.<br>
![IDE'de docker çalıştır](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Görüntü adını, Docker Hub deposundaki gibi girin.<br>
![IDE'de docker çalıştır-sonraki](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Sonlanmayı bekleyin.

## Azure

1. Azure'a giriş yapın.
1. Azure hizmetlerini seçin.
1. Fonksiyon Uygulaması seçin ve bir fonksiyon oluşturun.<br>
![Azure fonksiyon oluştur butonu](/_assets/java/java-azure/create-function-azure.png)<br>
1. Aşağıdaki resimdeki gibi temel ayarları tekrarlayın.<br>
![Azure fonksiyon oluşturma ayarları](/_assets/java/java-azure/create-function-settings.png)<br>
1. 'Gözden Geçir + oluştur' -> Oluştur düğmesine tıklayın.
1. Dağıtımın tamamlanmasını bekleyin.
1. 'Kaynağa git' düğmesine tıklayın.<br>
![Kaynak butonu](/_assets/java/java-azure/go-to-resource.png)<br>
1. aspose-cad-docker-example fonksiyonunu durdurun.<br>
![Konteyneri durdur](/_assets/java/java-azure/stop-container.png)<br>
1. Dağıtım merkezi menüsüne gidin ve gerekli ayarları yapın.<br>
![Dağıtım merkezi](/_assets/java/java-azure/deployment-center.png)<br>
1. Ayarları kaydedin.
1. Dağıtım merkezi ayarlarından Webhook URL'sini kopyalayın.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Docker Hub'a gidin, deposunu seçin ve webhooks'u seçin.
1. Azure'dan Webhook url'sini Docker Hub webhook url'sine yapıştırın ve adını belirleyin.<br>
![Docker'daki Webhook ayarları](/_assets/java/java-azure/webhook.png)<br>
1. Oluştur düğmesine tıklayın.
1. Genel bakış Azure fonksiyonuna dönün ve konteyneri başlatın.<br>
![Genel bakış menüsü](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Fonksiyonun başlaması birkaç dakika sürebilir.
{{% /alert %}}

## Çalıştırma Örneği

1. Postman ayarları.<br>
![Genel bakış menüsü](/_assets/java/java-azure/postman-settings.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Gönder düğmesine tıklayın.
1. Sonucu kaydedin
![Yanıtı kaydet](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Eğer yanıt başarılı olursa, dosyayı kaydet butonuna tıklayın ve dönüştürülen dosyayı png formatında alacaksınız.
{{% /alert %}}

## Daha Fazla Örnek

Aspose.CAD'i Docker'da nasıl kullanabileceğinize dair daha fazla örnek için [örnekler](https://github.com/aspose-cad/Aspose.CAD-Documentation) sayfasına bakın.


## Ayrıca Bakınız

- [Windows için Docker Desktop'ı Yükleyin](https://docs.docker.com/docker-for-windows/install/)
- [Mac için Docker Desktop'ı Yükleyin](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Linux konteynerlerine geçiş](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) seçeneği
