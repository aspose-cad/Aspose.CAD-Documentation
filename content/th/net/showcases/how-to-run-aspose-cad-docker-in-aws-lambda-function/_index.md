---
title: วิธีรันภาพ Aspose.CAD Docker ในฟังก์ชัน AWS Lambda
type: docs
description: "รันภาพ Aspose.CAD Docker ในฟังก์ชัน AWS Lambda."
weight: 74
url: /th/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## ข้อกำหนดเบื้องต้น
- Docker ต้องติดตั้งบนระบบของคุณ สำหรับข้อมูลเกี่ยวกับวิธีการติดตั้ง Docker บน Windows หรือ Mac โปรดอ้างอิงไปที่ลิงก์ในส่วน “ดูเพิ่มเติม” 
- Visual Studio 2022
- AWS Toolkit สำหรับ Visual Studio 2022
- .NET 6 SDK จะถูกใช้ในตัวอย่าง
- Postman

## ฟังก์ชัน AWS Lambda

Lambda เป็นบริการการคอมพิวเตอร์ที่ช่วยให้คุณรันโค้ดโดยไม่ต้องจัดเตรียมหรือจัดการเซิร์ฟเวอร์ Lambda รันโค้ดของคุณบนโครงสร้างพื้นฐานการคอมพิวเตอร์ที่มีความพร้อมใช้งานสูงและดำเนินการทุกการบริหารจัดการของทรัพยากรการคอมพิวเตอร์รวมถึงการบำรุงรักษาเซิร์ฟเวอร์และระบบปฏิบัติการ การจัดเตรียมความสามารถและการสเกลอัตโนมัติ รวมถึงการบันทึก ด้วย Lambda คุณสามารถรันโค้ดสำหรับแอปพลิเคชันหรือบริการแบ็กเอนด์ประเภทใดก็ได้

## การสร้างฟังก์ชัน AWS Lambda

{{% alert color="primary" %}} 
โปรดตรวจสอบว่าคุณมีสิทธิ์เพียงพอในการสร้างฟังก์ชันและภาพ AWS Lambda ใน Amazon Elastic Container Registry
{{% /alert %}}

ในการสร้างโปรแกรมฟังก์ชัน AWS Lambda โปรดทำตามขั้นตอนด้านล่าง:
1. สร้างโปรเจค AWS Lambda.<br>
![ปุ่มสร้างฟังก์ชัน AWS](/_assets/showcases/aws/create-project.png)<br>
1. เลือก .NET 6 (Container Image) และคลิกปุ่ม 'Finish'.<br>
![ปุ่มสร้างฟังก์ชันคอนเทนเนอร์](/_assets/showcases/aws/create-container.png)<br>
1. เปิด AWS Explorer ใน Visual Studio (View->AWS Explorer).
1. เพิ่มโปรไฟล์ของข้อมูลประจำตัว AWS ใน AWS Explorer.<br>
![โปรไฟล์ข้อมูลประจำตัว](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. ป้อน Access Key ID และ Secret Access Key คุณสามารถรับกุญแจเหล่านี้ได้ในข้อมูลประจำตัวด้านความปลอดภัย หรือ ติดต่อผู้ดูแลระบบและขอไฟล์ CSV เพื่อการรับรอง.<br>
![การตั้งค่าโปรไฟล์บัญชี](/_assets/showcases/aws/account-profile.png)<br>
1. ติดตั้งไลบรารีล่าสุดจาก NuGet.<br>
![NuGet Manager](/_assets/showcases/aws/nuget-manager.png)<br>
1. ตัวอย่างโค้ดสำหรับการแปลงภาพ CAD เป็นไฟล์ PDF
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
1. แก้ไข DockerFile ตามใน <a href="#configuring-a-dockerfile">การกำหนดค่า Dockerfile</a> 
1. เริ่ม Docker Desktop
1. เผยแพร่ไปยัง AWS Lambda.<br>
![เผยแพร่ AWS Lambda](/_assets/showcases/aws/publish-aws.png)<br>
1. แก้ไขการตั้งค่าอัปโหลด.<br>
![อัปโหลด AWS Lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. คลิกปุ่ม 'Upload'.<br>
![อัปโหลด AWS Lambda ล่าสุด](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. ไปที่ AWS และเลือก Lambda.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. เลือกฟังก์ชันใหม่ของคุณและสร้าง URL ฟังก์ชัน.<br>
![การกำหนดค่า URL ฟังก์ชัน](/_assets/showcases/aws/create-function-url.png)<br>
1. เลือกประเภทการรับรอง
- AWS_IAM - ผู้ใช้และบทบาท IAM ที่ได้การรับรองเท่านั้นที่สามารถทำการร้องขอไปยัง URL ฟังก์ชันของคุณ
- NONE - Lambda จะไม่ดำเนินการรับรอง IAM ในการร้องขอไปยัง URL ฟังก์ชันของคุณ โดย URL เอ็นด์พอยท์จะเป็นสาธารณะ เว้นแต่คุณจะดำเนินการจัดการการรับรองของคุณในฟังก์ชัน

### การกำหนดค่า Dockerfile

 ขั้นตอนถัดไปคือการแก้ไขการกำหนดค่า Dockerfile ในโปรเจค

1. ใน Dockerfile ระบุ:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 ด้านบนคือ Dockerfile ที่เรียบง่ายซึ่งประกอบด้วยคำสั่งต่อไปนี้:

- รูปภาพ SDK ที่จะใช้ที่นี่คือรูปภาพ Net 6 Docker จะดาวน์โหลดเมื่อทำการสร้าง การเวอร์ชันของ SDK จะระบุเป็นแท็ก
- หลังจากนั้น คุณอาจต้องติดตั้งฟอนต์เพราะรูปภาพ SDK มีฟอนต์น้อยมาก นอกจากนี้ คุณยังสามารถใช้ฟอนต์ท้องถิ่นที่คัดลอกไปยังรูประบายภาพ Docker
- ไดเรกทอรีที่ทำงานซึ่งระบุในบรรทัดถัดไป
- คำสั่งในการคัดลอกทุกอย่างไปยังคอนเทนเนอร์ เผยแพร่แอปพลิเคชัน และระบุจุดเริ่มต้น

## ตัวอย่างการดำเนินการ

1. การตั้งค่า Postman.<br>
![เมนูภาพรวม](/_assets/showcases/aws/postman-settings.png)<br>
1. เลือกไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG ใดก็ได้
1. คลิกปุ่มส่ง.

{{% alert color="primary" %}} 
หากคำตอบสำเร็จ ให้คลิกบันทึกเป็นไฟล์และคุณจะได้รับไฟล์ที่แปลงแล้วในรูปแบบ PDF
{{% /alert %}}

## ตัวอย่างเพิ่มเติม

สำหรับตัวอย่างเพิ่มเติมเกี่ยวกับวิธีการใช้ Aspose.CAD ใน Docker ดูที่ [ตัวอย่าง](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## ดูเพิ่มเติม

- [ติดตั้ง AWS Toolkit สำหรับ Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [ติดตั้ง Docker Desktop บน Windows](https://docs.docker.com/docker-for-windows/install/)
- [ติดตั้ง Docker Desktop บน Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [สลับไปยังคอนเทนเนอร์ Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 
- ข้อมูลเพิ่มเติมเกี่ยวกับ [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
