---
title: วิธีการเรียกใช้ภาพ Aspose.CAD Docker ในฟังก์ชัน Azure
type: docs
description: "เรียกใช้ภาพ Aspose.CAD Docker ในฟังก์ชัน Azure."
weight: 73
url: /th/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## สิ่งที่ต้องมี
- ต้องติดตั้ง Docker บนระบบของคุณ สำหรับข้อมูลเกี่ยวกับการติดตั้ง Docker บน Windows หรือ Mac ให้ดูที่ลิงก์ในส่วน "ดูเพิ่มเติม"
- Visual Studio 2022
- .NET 6 SDK ถูกใช้ในตัวอย่างนี้
- Postman

## ฟังก์ชัน Azure

ในตัวอย่างนี้ คุณจะสร้างฟังก์ชันการแปลงที่เรียบง่ายซึ่งแปลงไฟล์ CAD และบันทึกเป็นภาพ แอพพลิเคชั่นสามารถถูกสร้างใน Docker และเรียกใช้ในฟังก์ชัน Azure

## การสร้างฟังก์ชัน Azure

ในการสร้างฟังก์ชัน Azure ให้ทำตามขั้นตอนด้านล่าง:
1. เมื่อติดตั้ง Docker เสร็จแล้ว ให้ตรวจสอบให้แน่ใจว่าใช้ Linux Containers (ค่าเริ่มต้น) หากจำเป็นให้เลือกตัวเลือก Switch to Linux containers จากเมนู Docker Desktops
1. ใน Visual Studio ให้สร้างฟังก์ชัน Azure NET 6.<br>
![A NET 6 Azure Function project dialog](/_assets/showcases/azure/Create-project.png)<br>
1. ข้อมูลเพิ่มเติม.<br>
![A NET 6 Azure Function project dialog](/_assets/showcases/azure/Additional-information.png)<br>
1. ติดตั้ง Aspose.CAD เวอร์ชันล่าสุดจาก NuGet.<br>
![Aspose.CAD on NuGet](/_assets/showcases/azure/NuGet.png)<br>
1. เนื่องจากแอพพลิเคชั่นจะถูกเรียกใช้บน Linux คุณอาจต้องติดตั้งฟอนต์เพิ่มเติม คุณอาจต้องการ ttf-mscorefonts-installer
1. เมื่อเพิ่มความต้องการทั้งหมดแล้ว ให้เขียนโปรแกรมเรียบง่ายที่สร้างวงรีและบันทึกเป็นภาพ:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("ฟังก์ชัน HTTP C# ได้ประมวลผลคำขอ.");
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

### การกำหนดค่า Dockerfile

ขั้นตอนถัดไปคือการสร้างและกำหนดค่า Dockerfile ในโฟลเดอร์โปรเจกต์หลัก

1. สร้าง Dockerfile และวางไว้ถัดจากไฟล์โซลูชันของแอพพลิเคชั่นของคุณ เก็บชื่อไฟล์นี้โดยไม่มีนามสกุล (ค่าเริ่มต้น)
![Root project folder](/_assets/showcases/azure/root-folder.png)<br>
1. ใน Dockerfile ให้ระบุ:


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

ด้านบนคือ Dockerfile ที่เรียบง่ายซึ่งมีคำสั่งดังต่อไปนี้:

- รูปภาพ SDK ที่จะใช้ ที่นี่คือภาพ Net 6 Docker จะดาวน์โหลดเมื่อทำการสร้าง เวอร์ชันของ SDK ถูกระบุเป็นแท็ก
- หลังจากนั้นคุณอาจต้องติดตั้งฟอนต์เพราะรูประดับ SDK มีฟอนต์น้อยมาก นอกจากนี้คุณยังสามารถใช้ฟอนต์ท้องถิ่นที่คัดลอกจากรูประดับ docker
- ไดเร็กทอรีที่ทำงาน ซึ่งระบุในบรรทัดถัดไป
- คำสั่งในการคัดลอกทุกอย่างไปยังคอนเทนเนอร์ เผยแพร่แอพพลิเคชั่น และระบุจุดเชื่อมต่อ

## Docker Hub
1. เข้าสู่ระบบ Docker Hub
1. สร้าง Repository สาธารณะ

## การสร้างและเรียกใช้แอพพลิเคชั่นใน Docker

ตอนนี้แอพพลิเคชั่นสามารถถูกสร้างและเรียกใช้ใน Docker เปิดพรอมต์คำสั่งที่คุณชื่นชอบ เปลี่ยนไดเรกทอรีไปยังโฟลเดอร์ที่มีแอพพลิเคชั่น (โฟลเดอร์ที่มีไฟล์โซลูชันและ Dockerfile อยู่) และรันคำสั่งต่อไปนี้:

{{< highlight plain >}}
//ตัวอย่าง
docker build -t <ชื่อผู้ใช้>/<ชื่อ Repository> .

docker build -t user/asposefunction .
{{< /highlight >}}

ครั้งแรกที่คุณรันคำสั่งนี้ อาจใช้เวลานานกว่าเพราะ Docker ต้องดาวน์โหลดภาพที่จำเป็น เมื่อคำสั่งก่อนหน้านี้เสร็จสิ้นให้รันคำสั่งต่อไปนี้เพื่อดันภาพขึ้น Docker Hub:
 
{{< highlight plain >}}
//ตัวอย่าง
docker push <ชื่อผู้ใช้>/<ชื่อ Repository>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. เข้าสู่ระบบ Azure
1. เลือกบริการ Azure
1. เลือก Function App และสร้างฟังก์ชัน.<br>
![Azure create function button](/_assets/showcases/azure/create-function.png)<br>
1. ทำการตั้งค่าพื้นฐานซ้ำตามภาพด้านล่าง.<br>
![Azure create function settings](/_assets/showcases/azure/create-function-setting.png)<br>
1. คลิก 'Review + create' -> สร้าง
1. รอให้การสร้างเสร็จสิ้น
1. คลิกปุ่ม 'Go to resource'.<br>
![Resource button](/_assets/showcases/azure/go-to-resource.png)<br>
1. หยุดฟังก์ชัน aspose-cad-docker-example.<br>
![Stop conteiner](/_assets/showcases/azure/stop-container.png)<br>
1. ไปที่เมนูศูนย์การปรับใช้และทำการตั้งค่าที่เหมาะสม.<br>
![Deployment center](/_assets/showcases/azure/deployment-center.png)<br>
1. บันทึกการตั้งค่า
1. คัดลอก Webhook URL จากการตั้งค่าศูนย์การปรับใช้.<br>
![Webhook url](/_assets/showcases/azure/webhook-url.png)<br>
1. ไปที่ Docker Hub เลือก Repository ของคุณและเลือก webhooks
1. วาง 'Webhook url' จาก Azure ลงใน Webhook url ของ Docker Hub และตั้งชื่อ.<br>
![Webhook settings in docker](/_assets/showcases/azure/webhook.png)<br>
1. คลิกปุ่มสร้าง
1. กลับไปที่ฟังก์ชัน Azure โดยรวมและเริ่มคอนเทนเนอร์.<br>
![Overview menu](/_assets/showcases/azure/overview.png)<br>

## ตัวอย่างการทำงาน

1. การตั้งค่า Postman.<br>
![Overview menu](/_assets/showcases/azure/postman-settings.png)<br>
1. เลือกไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG ใด ๆ
1. คลิกปุ่มส่ง

{{% alert color="primary" %}} 
ถ้าคำตอบสำเร็จให้คลิกบันทึกเป็นไฟล์และคุณจะได้รับไฟล์ที่แปลงเป็นรูปแบบ png
{{% /alert %}}

## ตัวอย่างเพิ่มเติม

สำหรับตัวอย่างเพิ่มเติมเกี่ยวกับวิธีที่คุณสามารถใช้ Aspose.CAD ใน Docker โปรดดูที่ [ตัวอย่าง](https://github.com/aspose-cad/Aspose.CAD-Documentation)


## ดูเพิ่มเติม

- [ติดตั้ง Docker Desktop บน Windows](https://docs.docker.com/docker-for-windows/install/)
- [ติดตั้ง Docker Desktop บน Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [ตัวเลือกสลับไปยัง Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- ข้อมูลเพิ่มเติมเกี่ยวกับ [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
