---
title: วิธีการรัน Aspose.CAD ใน Docker
type: docs
description: "รัน Aspose.CAD ในคอนเทนเนอร์ Docker สำหรับ Linux, Windows Server และระบบปฏิบัติการใด ๆ"
weight: 71
url: /th/net/showcases/how-to-run-aspose-cad-in-docker/
---

## สิ่งที่ต้องมี
- ต้องติดตั้ง Docker บนระบบของคุณ สำหรับข้อมูลเกี่ยวกับวิธีการติดตั้ง Docker บน Windows หรือ Mac โปรดดูที่ลิงก์ในส่วน "ดูเพิ่มเติม"
- Visual Studio 2022
- NET 6 SDK ถูกใช้ในตัวอย่างนี้

## แอปพลิเคชัน Hello World

ในตัวอย่างนี้ คุณจะสร้างแอปพลิเคชัน Console Hello World ง่าย ๆ ที่วาดวงรีและบันทึกเป็นภาพ แอปพลิเคชันสามารถสร้างและรันใน Docker ได้

## การสร้างแอปพลิเคชัน Console

เพื่อสร้างโปรแกรม Hello World ให้ปฏิบัติตามขั้นตอนด้านล่าง:
1. เมื่อติดตั้ง Docker เสร็จสมบูรณ์ ให้แน่ใจว่าได้เลือกใช้ Linux Containers (ค่าเริ่มต้น) ถ้าจำเป็นให้เลือกตัวเลือก Switch to Linux containers จากเมนู Docker Desktop
1. ใน Visual Studio ให้สร้างแอปพลิเคชัน Console NET 6<br>
![A NET 6 console application project dialog](/_assets/showcases/docker/1.png)<br>
1. ติดตั้ง Aspose.CAD เวอร์ชันล่าสุดจาก NuGet<br>
![Aspose.CAD on NuGet](/_assets/showcases/docker/2.png)<br>
1. เนื่องจากแอปพลิเคชันจะทำงานบน Linux คุณอาจต้องติดตั้งแบบอักษรเพิ่มเติม คุณอาจต้องการ ttf-mscorefonts-installer
1. เมื่อเพิ่ม dependencies ที่จำเป็นทั้งหมดแล้ว ให้เขียนโปรแกรมง่าย ๆ ที่สร้างวงรีและบันทึกเป็นภาพ:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

โปรดทราบว่าหมวด "TestOut" ถูกกำหนดเป็นโฟลเดอร์ผลลัพธ์สำหรับการบันทึกเอกสารที่สร้างขึ้น เมื่อรันแอปพลิเคชันใน Docker โฟลเดอร์ในเครื่องโฮสต์จะถูกเชื่อมต่อกับโฟลเดอร์นี้ในคอนเทนเนอร์ ซึ่งจะทำให้คุณสามารถดูผลลัพธ์ที่สร้างโดย Aspose.CAD ในคอนเทนเนอร์ Docker ได้อย่างง่ายดาย

### การกำหนดค่า Dockerfile

ขั้นตอนถัดไปคือการสร้างและกำหนดค่า Dockerfile

1. สร้าง Dockerfile และวางไว้ข้างไฟล์โซลูชันของแอปพลิเคชันของคุณ เก็บชื่อไฟล์นี้โดยไม่ต้องมีนามสกุล (ค่าเริ่มต้น)
1. ใน Dockerfile ให้ระบุ:


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

ด้านบนนี้คือ Dockerfile ง่าย ๆ ซึ่งประกอบด้วยคำสั่งดังต่อไปนี้:

- ภาพ SDK ที่จะใช้งาน ที่นี่คือภาพ Net 6 Docker จะดาวน์โหลดเมื่อเริ่มสร้าง ภาพ SDK จะถูกระบุเป็นแท็ก
- หลังจากนั้น คุณอาจต้องติดตั้ง แบบอักษร เนื่องจากภาพ SDK มีแบบอักษรน้อยมาก นอกจากนี้ คุณยังสามารถใช้แบบอักษรในท้องถิ่นที่คัดลอกจากภาพ docker ได้
- โฟลเดอร์ทำงาน ที่ระบุไว้ในบรรทัดถัดไป
- คำสั่งในการคัดลอกทุกอย่างไปยังคอนเทนเนอร์ ทำการเผยแพร่แอปพลิเคชัน และระบุจุดเริ่มต้น


## การสร้างและรันแอปพลิเคชันใน Docker
 
ในตอนนี้แอปพลิเคชันสามารถสร้างและรันใน Docker ได้ เปิด Command Prompt ที่คุณชื่นชอบ เปลี่ยนไปยังโฟลเดอร์ที่มีแอปพลิเคชัน (โฟลเดอร์ที่มีไฟล์โซลูชันและ Dockerfile อยู่) และรันคำสั่งต่อไปนี้:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

ครั้งแรกที่สั่งคำสั่งนี้อาจใช้เวลานานขึ้น เนื่องจาก Docker ต้องดาวน์โหลดภาพที่ต้องการ เมื่อคำสั่งก่อนหน้าสำเร็จแล้ว ให้รันคำสั่งต่อไปนี้:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
โปรดให้ความสนใจกับอาร์กิวเมนต์ mount เนื่องจากตามที่กล่าวไว้ก่อนหน้านี้ โฟลเดอร์ในเครื่องโฮสต์จะถูกเชื่อมโยงกับโฟลเดอร์ในคอนเทนเนอร์เพื่อให้คุณสามารถดูผลลัพธ์ที่เกิดจากการดำเนินการของแอปพลิเคชันได้ง่าย เส้นทางใน Linux มีความไวต่อขนาดตัวอักษร
{{% /alert %}}

## ตัวอย่างเพิ่มเติม

สำหรับตัวอย่างเพิ่มเติมเกี่ยวกับวิธีการใช้ Aspose.CAD ใน Docker โปรดดูที่ [ตัวอย่าง](https://github.com/aspose-cad/Aspose.CAD-Documentation)


## ดูเพิ่มเติม

- [ติดตั้ง Docker Desktop บน Windows](https://docs.docker.com/docker-for-windows/install/)
- [ติดตั้ง Docker Desktop บน Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [เปลี่ยนไปใช้ Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) ตัวเลือก
- ข้อมูลเพิ่มเติมเกี่ยวกับ [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
