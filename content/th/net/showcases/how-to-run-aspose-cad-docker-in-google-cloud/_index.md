---
title: วิธีการรันภาพด็อกเกอร์ Aspose.CAD ใน Google Cloud
type: docs
description: "รันภาพด็อกเกอร์ Aspose.CAD ใน Google Cloud."
weight: 75
url: /th/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## ข้อกำหนดเบื้องต้น

- ต้องติดตั้ง Docker บนระบบของคุณ สำหรับข้อมูลเกี่ยวกับวิธีติดตั้ง Docker บน Windows หรือ Mac ให้ดูที่ลิงก์ในหัวข้อ “ดูเพิ่มเติม”
- Visual Studio 2022
- Google CLI
- NET Core 3.1 SDK ใช้ในตัวอย่าง
- Postman

## ฟังก์ชั่น Google Cloud Run

Cloud Run เป็นสภาพแวดล้อมการคอมพิวเตอร์ที่จัดการอย่างเต็มที่สำหรับการปรับใช้และขยายคอนเทนเนอร์ HTTP แบบไม่มีเซิร์ฟเวอร์โดยไม่ต้องกังวลเกี่ยวกับการจัดเตรียมเครื่องจักร การกำหนดค่าโคลน หรือการปรับขยายอัตโนมัติ

- ไม่มีการล็อคผู้จำหน่าย - เนื่องจาก Cloud Run ใช้คอนเทนเนอร์ OCI มาตรฐานและใช้งาน API Knative Serving มาตรฐาน คุณสามารถพอร์ตแอปพลิเคชันของคุณไปยังสถานที่จัดเก็บหรือคลาวด์อื่นได้อย่างง่ายดาย
- การปรับขนาดอัตโนมัติที่รวดเร็ว - ไมโครเซอร์วิสที่ปรับใช้ใน Cloud Run จะปรับขนาดโดยอัตโนมัติตามจำนวนคำขอที่เข้าโดยไม่ต้องกำหนดค่าหรือติดตั้งคลัสเตอร์ Kubernetes ที่สมบูรณ์ Cloud Run สามารถปรับขนาดเป็นศูนย์นั่นคือไม่ใช้ทรัพยากรหากไม่มีคำขอ
- แบ่งการจราจร - Cloud Run ช่วยให้คุณแบ่งการจราจรระหว่างการแก้ไขหลายรายการ ดังนั้นคุณจึงสามารถดำเนินการปรับปรุงแบบค่อยเป็นค่อยไปเช่นการปรับใช้แทนที่แบบแคนารีหรือการปรับใช้สีน้ำเงิน/สีเขียว
- โดเมนที่กำหนดเอง - คุณสามารถตั้งค่าการแมพโดเมนที่กำหนดเองใน Cloud Run และมันจะจัดเตรียมใบรับรอง TLS สำหรับโดเมนของคุณ 
- ความซ้ำซ้อนอัตโนมัติ - Cloud Run มอบความซ้ำซ้อนอัตโนมัติทำให้คุณไม่ต้องกังวลเกี่ยวกับการสร้างหลายอินสแตนซ์เพื่อความพร้อมใช้งานสูง

Cloud Run และ Cloud Functions เป็นบริการที่จัดการอย่างเต็มที่ซึ่งทำงานบนโครงสร้างพื้นฐานแบบไม่มีเซิร์ฟเวอร์ของ Google Cloud มีการปรับขนาดอัตโนมัติและจัดการคำขอ HTTP หรือเหตุการณ์ แม้ว่าจะมีความแตกต่างที่สำคัญบางประการ:

- Cloud Functions ช่วยให้คุณสามารถปรับใช้โค้ด (ฟังก์ชัน) ที่เขียนในชุดภาษาการเขียนโปรแกรมที่จำกัด ในขณะที่ Cloud Run ช่วยให้คุณสามารถปรับใช้ภาพคอนเทนเนอร์โดยใช้ภาษาที่คุณเลือก 
- Cloud Run ยังสนับสนุนการใช้เครื่องมือหรือตัวอย่างระบบจากแอปพลิเคชันของคุณในขณะที่ Cloud Functions ไม่อนุญาตให้คุณใช้ Executable ที่กำหนดเอง 
- Cloud Run เสนอระยะเวลาหมดอายุคำขอที่ยาวนานถึง 60 นาที ในขณะที่ Cloud Functions หมดเวลาคำขอสามารถตั้งค่าได้สูงสุดที่ 9 นาที 
- Cloud Functions จะส่งคำขอเพียงครั้งละหนึ่งครั้งไปยังแต่ละอินสแตนซ์ฟังก์ชันในขณะที่ค่าเริ่มต้น Cloud Run ถูกกำหนดให้ส่งคำขอพร้อมกันหลายรายการในแต่ละอินสแตนซ์คอนเทนเนอร์ ซึ่งช่วยปรับปรุงเวลาการตอบสนองและลดต้นทุนหากคุณคาดว่ามีปริมาณมาก 

## การสร้างโปรเจกต์ Google Cloud Function

{{% alert color="primary" %}} 
โปรดตรวจสอบว่าคุณมีสิทธิ์เพียงพอในการสร้างฟังก์ชัน Google Cloud Run และภาพในที่เก็บ Artifacts
{{% /alert %}}

ในการสร้างโปรแกรม Google Cloud Function ให้ทำตามขั้นตอนด้านล่าง:

1. ติดตั้ง .NET Core SDK 3.1
1. ติดตั้งแพ็คเกจเทมเพลต:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. ถัดไป ให้สร้างไดเร็กทอรีสำหรับโปรเจกต์ของคุณและใช้ dotnet new เพื่อสร้างฟังก์ชัน HTTP ใหม่:
{{< highlight plain >}}
mkdir AsposeFunctions //สร้างโฟลเดอร์
cd AsposeFunctions //ไปยังโฟลเดอร์ AsposeFunctions
dotnet new gcf-http //สร้างโปรเจกต์ Google Cloud Function ด้วยการเรียก HTTP
{{< /highlight >}}
{{% alert color="primary" %}} 
จะสร้าง AsposeFunctions.csproj และ Function.cs ในไดเร็กทอรีปัจจุบัน เปิด Function.cs เพื่อตรวจสอบโค้ดและให้ข้อความที่กำหนดเองหากคุณต้องการ
{{% /alert %}}
1. ตัวอย่างโค้ดสำหรับไฟล์ csproj (AsposeFunctions.csproj)
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
1. ตัวอย่างโค้ดสำหรับการแปลงภาพ CAD เป็นไฟล์ PNG (Function.cs)
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// ตรรกะสำหรับฟังก์ชันของคุณอยู่ที่นี่
        /// </summary>
        /// <param name="context">HTTP context ซึ่งมีคำขอและการตอบสนอง</param>
        /// <returns>งานที่เป็นตัวแทนของการทำงานแบบอะซิงโครนัส</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //ไฟล์ฟอร์ม
                var file = context.Request.Body; //ข้อมูลไบนารี
                
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
1. สร้างฟังก์ชันของคุณในเครื่องตามลำดับต่อไปนี้:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. เมื่อเซิร์ฟเวอร์ทำงานแล้ว ให้เรียกดูไปที่ http://localhost:8080 เพื่อติดต่อฟังก์ชัน กด Ctrl-C ในคอนโซลเพื่อหยุดเซิร์ฟเวอร์

## ปรับใช้ภาพด็อกเกอร์ไปยัง Google Cloud

1. ล็อกอิน Google Cloud
1. สร้างโปรเจกต์หากยังไม่มี
1. ไปที่ 'Artifact Registry' และสร้างที่เก็บ<br>
![สร้างที่เก็บอาร์ติแฟค](/_assets/showcases/google/create-artifact-repository.png)<br>
1. เลือกที่เก็บใหม่ใน Artifact Registry
![เลือกที่เก็บอาร์ติแฟค](/_assets/showcases/google/select-artifact.png)<br>
1. คลิก 'SETUP INSTRUCTION' และคัดลอกคำสั่ง 'Configure Docker'<br>
![SETUP INSTRUCTION](/_assets/showcases/google/setup-instruction.png)<br>
1. เพิ่มรายการ Docker credHelper ลงในไฟล์กำหนดค่าของ Docker หรือสร้างไฟล์หากยังไม่มี
{{< highlight plain >}}
//ตัวอย่าง
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. สร้าง Dockerfile ในไดเร็กทอรีรากของโปรเจกต์และแก้ไข DockerFile ตามส่วน <a href="#configuring-a-dockerfile">การตั้งค่า Dockerfile</a>
1. เริ่ม Docker Desktop
1. สร้างภาพด็อกเกอร์ด้วยเส้นทางที่เก็บในคลาวด์
{{< highlight plain >}}
//ตัวอย่าง
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. ส่งภาพไปยัง Google Cloud Artifact Registry
{{< highlight plain >}}
//ตัวอย่าง
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## สร้างบริการ Google Cloud Run 

1. ไปที่ Cloud Run
1. สร้างบริการ Cloud Run<br>
![สร้างบริการ Cloud Run](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. ในช่อง URL รูปภาพคอนเทนเนอร์ ให้เลือกคอนเทนเนอร์จาก 'ARTIFACT REGISTRY'<br>
![URL รูปภาพคอนเทนเนอร์](/_assets/showcases/google/container-url.png)<br>
1. ตรวจสอบการตั้งค่าอื่น ๆ ตามภาพด้านล่าง<br>
![การตั้งค่าบริการ](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. รอการปรับใช้ให้เสร็จสิ้น
1. URL บริการในการทำงานกับแอปพลิเคชันการแปลง<br>
![Url บริการ](/_assets/showcases/google/url-service.png)<br>

### การตั้งค่า Dockerfile

ขั้นตอนถัดไปคือการแก้ไขการตั้งค่า Dockerfile ในโปรเจกต์

1. ใน Dockerfile ให้ระบุ:

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

ด้านบนเป็น Dockerfile ที่เรียบง่าย ซึ่งประกอบด้วยคำสั่งดังต่อไปนี้:

- หา SDK image ที่จะใช้ ที่นี่คือภาพ Net Core 3.1 Docker จะดาวน์โหลดเมื่อการสร้างถูกเรียกใช้งาน ใช้ SDK จะถูกระบุเป็นแท็ก
- หลังจากนั้นคุณอาจต้องติดตั้งฟอนต์ เนื่องจาก SDK image มีฟอนต์น้อยมาก นอกจากนี้คุณยังสามารถใช้ฟอนต์ท้องถิ่นที่คัดลอกไปยังภาพด็อกเกอร์ได้
- ไดเร็กทอรีทำงานซึ่งระบุในบรรทัดถัดไป
- คำสั่งในการคัดลอกทุกอย่างไปยังคอนเทนเนอร์ ตีพิมพ์แอปพลิเคชันและระบุจุดเริ่มต้น

## ตัวอย่างการดำเนินการ

1. การตั้งค่า Postman.<br>
![เมนูรวม](/_assets/showcases/google/postman-settings.png)<br>
1. เลือกไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG ใด ๆ
1. คลิกปุ่มส่ง

{{% alert color="primary" %}} 
หากคำตอบสำเร็จ คลิกบันทึกลงไฟล์ จากนั้นคุณจะได้รับไฟล์ที่แปลงเป็นรูปแบบ png
{{% /alert %}}

## ตัวอย่างเพิ่มเติม

สำหรับตัวอย่างเพิ่มเติมเกี่ยวกับวิธีการใช้ Aspose.CAD ใน Docker โปรดดูที่ [ตัวอย่าง](https://github.com/aspose-cad/Aspose.CAD-Documentation)

## ดูเพิ่มเติม

- [ติดตั้ง Docker Desktop บน Windows](https://docs.docker.com/docker-for-windows/install/)
- [ติดตั้ง Docker Desktop บน Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [เปลี่ยนไปใช้คอนเทนเนอร์ Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) ตัวเลือก
- ข้อมูลเพิ่มเติมเกี่ยวกับ [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
