---
title: AWS Lambda Fonksiyonunda Aspose.CAD Docker Görüntüsünü Çalıştırma
type: docs
description: "AWS Lambda Fonksiyonunda Aspose.CAD Docker görüntüsünü çalıştırın."
weight: 74
url: /tr/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Ön Koşullar
- Sisteminizde Docker yüklü olmalıdır. Docker'ı Windows veya Mac'te nasıl yükleyeceğiniz hakkında bilgi için "Ayrıca Bakınız" bölümündeki bağlantılara bakın.
- Visual Studio 2022.
- Visual Studio 2022 için AWS Toolkit.
- Örnekte .NET 6 SDK kullanılmaktadır.
- Postman

## AWS Lambda Fonksiyonu

Lambda, kodu sunucu sağlama veya yönetme konusunda herhangi bir işlem yapmadan çalıştırmanızı sağlayan bir hesaplama hizmetidir. Lambda, kodunuzu yüksek kullanılabilirlikte bir hesaplama altyapısında çalıştırır ve sunucu ve işletim sistemi bakımı, kapasite sağlama ve otomatik ölçeklendirme gibi hesaplama kaynaklarının tüm yönetimini gerçekleştirir. Lambda ile virtually herhangi bir uygulama veya arka uç hizmeti için kod çalıştırabilirsiniz.

## AWS Lambda Fonksiyonunu Oluşturma

{{% alert color="primary" %}} 
AWS Lambda fonksiyonları ve Amazon Elastic Container Registry'de görüntüler oluşturmak için yeterli haklara sahip olduğunuzdan emin olun.
{{% /alert %}}

AWS Lambda Fonksiyon programını oluşturmak için aşağıdaki adımları izleyin:
1. AWS Lambda Projesi oluşturun.<br>
![AWS fonksiyonu oluşturma butonu](/_assets/showcases/aws/create-project.png)<br>
1. .NET 6 (Konteyner Görüntüsü) seçin ve 'Bitir' butonuna tıklayın.<br>
![Konteyner işlevini oluşturma butonu](/_assets/showcases/aws/create-container.png)<br>
1. Visual Studio'da AWS Explorer'ı açın (Görünüm->AWS Explorer).
1. AWS Explorer'da AWS kimlik bilgileri profilini ekleyin.<br>
![Kimlik bilgileri profili](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Erişim Anahtar ID'sini ve Gizli Erişim Anahtarını girin, bu anahtarları Güvenlik kimlik bilgileri bölümünde alabilir veya yöneticinizle iletişime geçip yetkilendirme için bir csv dosyası alabilirsiniz.<br>
![Hesap profili ayarları](/_assets/showcases/aws/account-profile.png)<br>
1. NuGet'ten en son kütüphaneleri yükleyin.<br>
![NuGet Yöneticisi](/_assets/showcases/aws/nuget-manager.png)<br>
1. CAD görüntüsünü PDF dosyasına dönüştürmek için kod örneği.
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
1. DockerFile'ı <a href="#configuring-a-dockerfile">Dockerfile'ı Yapılandırma</a> kısmındaki gibi düzenleyin.
1. Docker Desktop'u başlatın.
1. AWS Lambda’ya yayınlayın.<br>
![AWS lambda yayını](/_assets/showcases/aws/publish-aws.png)<br>
1. Yükleme yapılandırmasını düzenleyin.<br>
![AWS lambda yükleme](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. 'Yükle' butonuna tıklayın.<br>
![AWS lambda yükleme son](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. AWS'ye gidin ve Lambda'yı seçin.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Yeni işlevinizi seçin ve URL işlevi oluşturun.<br>
![Yapılandırma url işlevi](/_assets/showcases/aws/create-function-url.png)<br>
1. Kimlik doğrulama türünü seçin
- AWS_IAM - Yalnızca kimliği doğrulanmış IAM kullanıcıları ve rolleri, işlev URL'nize istek yapabilir.
- HİÇBİRİ - Lambda, işlev URL'nize yapılan isteklere IAM kimlik doğrulaması yapmayacaktır. URL uç noktası, işlevinizde kendi yetkilendirme mantığınızı uygulamazsanız genel olacaktır.

### Dockerfile'ı Yapılandırma

Bir sonraki adım, projedeki Dockerfile'ı yapılandırmaktır.

1. Dockerfile'da belirtin:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Yukarıdaki, aşağıdaki talimatları içeren basit bir Dockerfile'dır:

- Kullanılacak SDK görüntüsü. Burada .NET 6 görüntüsü bulunmaktadır. Docker, yapı çalıştırıldığında bunu indirecektir. SDK'nın sürümü bir etiket olarak belirtilmiştir.
- Daha sonra, SDK görüntüsünün çok az yazı tipi içerdiği için Yazı Tiplerini yüklemeniz gerekebilir. Ayrıca, docker görüntüsüne kopyalanmış yerel yazı tiplerini de kullanabilirsiniz.
- Bir sonraki satırda belirtilen çalışma dizini.
- Her şeyi konteynere kopyalamak, uygulamayı yayınlamak ve giriş noktasını belirtmek için komut.

## Uygulama Örneği

1. Postman ayarları.<br>
![Genel bakış menüsü](/_assets/showcases/aws/postman-settings.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Gönder butonuna tıklayın.

{{% alert color="primary" %}} 
Yanıt başarılıysa, dosyayı kaydet'e tıklayın ve dönüştürülmüş PDF formatındaki dosyayı alacaksınız.
{{% /alert %}}

## Daha Fazla Örnek

Docker'da Aspose.CAD'i nasıl kullanabileceğinize dair daha fazla örnek için [örneklere](https://github.com/aspose-cad/Aspose.CAD-Documentation) bakın.


## Ayrıca Bakınız.

- [Visual Studio 2022 için AWS Toolkit'i Yükleyin](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Windows'ta Docker Desktop'u Yükleme](https://docs.docker.com/docker-for-windows/install/)
- [Mac'te Docker Desktop'u Yükleme](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux konteynerlerine geçiş](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) seçeneği
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) hakkında ek bilgi
