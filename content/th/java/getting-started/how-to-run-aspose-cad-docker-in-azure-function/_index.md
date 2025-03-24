---
title: วิธีการเรียกใช้ภาพ Docker ของ Aspose.CAD ใน Azure Function
type: docs
description: "เรียกใช้ภาพ Docker ของ Aspose.CAD ใน Azure Function."
weight: 71
url: /th/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## ข้อกำหนดเบื้องต้น
- ต้องติดตั้ง Docker บนระบบของคุณ สำหรับข้อมูลเกี่ยวกับวิธีการติดตั้ง Docker บน Windows หรือ Mac โปรดดูที่ลิงก์ในส่วน “ดูเพิ่มเติม”
- IntelliJ IDEA.
- Azure Toolkit สำหรับ IntelliJ.
- Postman.

## Azure Function

ในตัวอย่างนี้ คุณจะสร้างฟังก์ชันการแปลงที่เรียบง่ายซึ่งจะแปลงไฟล์ CAD และบันทึกเป็นภาพ จากนั้นสามารถสร้างแอปพลิเคชันใน Docker และเรียกใช้ใน Azure Function

## การสร้าง Azure Function

เพื่อสร้างโปรแกรม Azure Function โปรดทำตามขั้นตอนด้านล่าง:
1. เมื่อติดตั้ง Docker แล้ว ให้แน่ใจว่าใช้ Linux Containers (ค่าเริ่มต้น) หากจำเป็นให้เลือกตัวเลือก Switch to Linux containers จากเมนู Docker Desktops
1. สร้างโปรเจ็กต์ Azure Function ใน IntelliJ IDEA.<br>
![Create azure function project](/cad/_assets/java/java-azure/create-function-ide-1.png)<br>
![Create azure function project-final](/cad/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->Sing In และเลือกการรับรองความถูกต้อง OAuth 2.0.<br>
![Azure sign In](/cad/_assets/java/java-azure/sign-in-azure.png)<br>
1. ลงชื่อเข้าใช้ในเบราว์เซอร์
1. เลือกชื่อสมาชิก
1. เพิ่มการสนับสนุน docker.<br>
![Azure sign In](/cad/_assets/java/java-azure/add-docker-support.png)<br>
1. แก้ไข DockerFile ตามที่ระบุใน <a href="#configuring-a-dockerfile">Configuring a Dockerfile</a> ส่วน.
1. เพิ่มบล็อกสำหรับที่เก็บ aspose.cad ใน pom.xml.
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

1. เมื่อต้องการเพิ่มการพึ่งพาที่จำเป็นทั้งหมด ให้เขียนโปรแกรมที่สร้างวงรีและบันทึกเป็นภาพ:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * ฟังก์ชันนี้ฟังที่เอนด์พอยต์ "/api/HttpExample" มีสองวิธีในการเรียกใช้โดยใช้คำสั่ง "curl" ใน bash:
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
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
        context.getLogger().info("Java HTTP trigger processed a request.");

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

### การกำหนดค่า Dockerfile

ขั้นตอนถัดไปคือการสร้างและกำหนดค่า Dockerfile ในโฟลเดอร์โปรเจ็กต์รูท

1. ใน Dockerfile ให้ระบุ:
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

ด้านบนเป็น Dockerfile ที่เรียบง่าย ซึ่งมีคำสั่งดังต่อไปนี้:

- ภาพ SDK ที่จะใช้ Docker จะดาวน์โหลดเมื่อสร้าง
- ไดเรกทอรีทำงานซึ่งระบุในบรรทัดถัดไป
- คำสั่งในการคัดลอกทุกอย่างไปยังคอนเทนเนอร์ เผยแพร่แอปพลิเคชันและระบุจุดเริ่มต้น

## Docker Hub
1. ลงชื่อเข้าใช้ Docker Hub
1. สร้างที่เก็บสาธารณะ

## การสร้างและเรียกใช้แอปพลิเคชันใน Docker
 
ตอนนี้แอปพลิเคชันสามารถสร้างและเรียกใช้ใน Docker ได้ เปิด Command Prompt ที่คุณชื่นชอบ เปลี่ยนไดเรกทอรีไปยังโฟลเดอร์ที่มีแอปพลิเคชัน (โฟลเดอร์ที่มีไฟล์โซลูชันและ Dockerfile อยู่) และเรียกใช้คำสั่งต่อไปนี้:


1. สร้างคำสั่ง dockerfile ในคอนโซล
{{< highlight plain >}}
//ตัวอย่าง
docker build -t <ชื่อผู้ใช้>/<ชื่อที่เก็บ> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. ครั้งแรกที่คุณเรียกใช้คำสั่งนี้ อาจใช้เวลานานกว่าเนื่องจาก Docker ต้องดาวน์โหลดภาพที่จำเป็น หลังจากที่คำสั่งก่อนหน้านี้เสร็จสิ้น ให้เรียกใช้คำสั่งต่อไปนี้เพื่อส่งภาพไปยัง Docker Hub
{{< highlight plain >}}
//ตัวอย่าง
docker push <ชื่อผู้ใช้>/<ชื่อที่เก็บ>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. เรียกใช้ dockerfile ใน IDE และหลังจากส่งไปยัง docker hub.<br>
![Run docker in ide](/cad/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. ป้อนชื่อของภาพตามที่ระบุในที่เก็บ Docker HUb.<br>
![Run docker in ide-next](/cad/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. รอให้เสร็จสิ้น

## Azure

1. ลงชื่อเข้าใช้ Azure
1. เลือกบริการ Azure
1. เลือก Function App และสร้างฟังก์ชัน.<br>
![Azure create function button](/cad/_assets/java/java-azure/create-function-azure.png)<br>
1. ทำตามการตั้งค่าพื้นฐานเหมือนในภาพด้านล่าง.<br>
![Azure create function settings](/cad/_assets/java/java-azure/create-function-settings.png)<br>
1. คลิก 'Review + create' -> สร้าง
1. รอให้การปรับใช้เสร็จสิ้น
1. คลิกปุ่ม 'Go to resorce'.<br>
![Resource button](/cad/_assets/java/java-azure/go-to-resource.png)<br>
1. หยุดฟังก์ชัน aspose-cad-docker-example.<br>
![Stop conteiner](/cad/_assets/java/java-azure/stop-container.png)<br>
1. ไปที่เมนูศูนย์ปรับใช้และทำการตั้งค่าที่เหมาะสม.<br>
![Deployment center](/cad/_assets/java/java-azure/deployment-center.png)<br>
1. บันทึกการตั้งค่า
1. คัดลอก Webhook URL จากการตั้งศูนย์ปรับใช้.<br>
![Webhook url](/cad/_assets/java/java-azure/webhook-url.png)<br>
1. ไปที่ Docker Hub เลือกที่เก็บของคุณและเลือก webhooks
1. วาง 'Webhook url' จาก Azure ลงใน Docker Hub webhook url และตั้งชื่อ.<br>
![Webhook settings in docker](/cad/_assets/java/java-azure/webhook.png)<br>
1. คลิกปุ่มสร้าง
1. กลับไปที่ฟังก์ชัน Azure overview และเริ่มคอนเทนเนอร์.<br>
![Overview menu](/cad/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
อาจใช้เวลาสักครู่ในการเริ่มฟังก์ชัน
{{% /alert %}}

## ตัวอย่างการดำเนินการ

1. การตั้งค่า Postman.<br>
![Overview menu](/cad/_assets/java/java-azure/postman-settings.png)<br>
1. เลือกไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG ใดๆ
1. คลิกปุ่มส่ง
1. บันทึกผลลัพธ์
![Save responce](/cad/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
หากคำตอบสำเร็จ คลิกบันทึกเป็นไฟล์และคุณจะได้รับไฟล์ที่แปลงแล้วในรูปแบบ png
{{% /alert %}}

## ตัวอย่างเพิ่มเติม

สำหรับตัวอย่างเพิ่มเติมเกี่ยวกับวิธีการใช้ Aspose.CAD ใน Docker โปรดดูที่ [ตัวอย่าง](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## ดูเพิ่มเติม

- [ติดตั้ง Docker Desktop บน Windows](https://docs.docker.com/docker-for-windows/install/)
- [ติดตั้ง Docker Desktop บน Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [เปลี่ยนเป็น Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) ตัวเลือก
