---
title: Aspose.CAD'i Docker'da Çalıştırma
type: docs
description: "Aspose.CAD'i Linux, Windows Server ve her türlü işletim sistemi için bir Docker konteynerinde çalıştırın."
weight: 71
url: /tr/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Ön Koşullar
- Sisteminizde Docker kurulmuş olmalıdır. Docker'ı Windows veya Mac'e nasıl kuracağınız hakkında bilgi için “Ayrıca Bakınız” bölümündeki bağlantılara bakın.
- Visual Studio 2022.
- Örnekte .NET 6 SDK'sı kullanılmıştır.

## Merhaba Dünya Uygulaması

Bu örnekte, bir elips çizen ve bunu bir görüntü olarak kaydeden basit bir Merhaba Dünya konsol uygulaması oluşturursunuz. Uygulama, Docker'da oluşturulup çalıştırılabilir.

## Konsol Uygulamasını Oluşturma

Merhaba Dünya programını oluşturmak için aşağıdaki adımları izleyin:
1. Docker yüklendikten sonra, Linux Konteynerlerini (varsayılan) kullandığından emin olun. Gerekirse, Docker Masaüstü menüsünden Linux konteynerlerine geçiş seçeneğini seçin.
1. Visual Studio'da bir .NET 6 konsol uygulaması oluşturun.<br>
![Bir .NET 6 konsol uygulama projesi iletişim kutusu](/_assets/showcases/docker/1.png)<br>
1. NuGet'ten en son Aspose.CAD sürümünü yükleyin.<br>
![Aspose.CAD NuGet'te](/_assets/showcases/docker/2.png)<br>
1. Uygulama Linux'ta çalıştırılacağından, ek fontlar yüklemeniz gerekebilir. ttf-mscorefonts-installer'ı tercih edebilirsiniz.
1. Tüm gerekli bağımlılıklar eklendikten sonra, bir elips oluşturan ve bunu bir görüntü olarak kaydeden basit bir program yazın:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

“TestOut” klasörü, çıktı belgelerini kaydetmek için çıktı klasörü olarak belirtilmiştir. Uygulama Docker'da çalıştırılırken, ana makinada bir klasör bu klasöre bağlanacaktır. Bu, Aspose.CAD tarafından Docker konteynerinde üretilen çıktıyı kolayca görüntülemenizi sağlar.

### Dockerfile'ı Yapılandırma

Sonraki adım, Dockerfile'ı oluşturmak ve yapılandırmaktır.

1. Dockerfile'ı oluşturun ve uygulamanızın çözüm dosyasının yanına yerleştirin. Bu dosya adını uzantısız (varsayılan) tutun.
1. Dockerfile'da şunları belirtin:


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

Yukarıdaki kod basit bir Dockerfile'dır ve şu talimatları içerir:

- Kullanılacak SDK görüntüsü. Burada .NET 6 görüntüsü kullanılıyor. Docker, oluşturma çalıştırıldığında bunu indirecektir. SDK'nın sürümü bir etiket olarak belirtilir.
- Daha sonra, Fontları yüklemeniz gerekebilir çünkü SDK görüntüsü çok az font içerir. Ayrıca, docker görüntüsüne kopyaladığınız yerel fontları da kullanabilirsiniz.
- Bir sonraki satırda belirtilen çalışma dizini.
- Her şeyi konteynere kopyalamak, uygulamayı yayınlamak ve giriş noktasını belirtme komutu.

## Docker'da Uygulamayı Derleme ve Çalıştırma

Artık uygulama Docker'da derlenip çalıştırılabilir. En sevdiğiniz komut istemcisini açın, dizini uygulama ile aynı klasöre (çözüm dosyasının ve Dockerfile'ın bulunduğu klasör) değiştirin ve aşağıdaki komutu çalıştırın:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

Bu komut ilk kez çalıştırıldığında daha uzun sürebilir, çünkü Docker gerekli görüntüleri indirmek zorundadır. Önceki komut tamamlandıktan sonra aşağıdaki komutu çalıştırın:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Mount argümanına dikkat edin, çünkü daha önce belirtildiği gibi, ana makinadaki bir klasör, konteynerin klasörüne bağlanmıştır, uygulama yürütme sonuçlarını kolayca görmek için. Linux'taki yollar büyük/küçük harfe duyarlıdır.
{{% /alert %}}

## Daha Fazla Örnek

Aspose.CAD'i Docker'da nasıl kullanabileceğinizle ilgili daha fazla örnek için [örnekler](https://github.com/aspose-cad/Aspose.CAD-Documentation) bölümüne bakın.

## Ayrıca Bakınız

- [Windows'ta Docker Desktop'ı Yükleyin](https://docs.docker.com/docker-for-windows/install/)
- [Mac'te Docker Desktop'ı Yükleyin](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux konteynerlerine geçiş](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) seçeneği
- [.NET Core SDK hakkında ek bilgi](https://hub.docker.com/_/microsoft-dotnet-sdk)
