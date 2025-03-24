---
title: Cách chạy hình ảnh Aspose.CAD Docker trong Azure Function
type: docs
description: "Chạy hình ảnh Aspose.CAD Docker trong Azure Function."
weight: 71
url: /vi/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Các yêu cầu trước
- Docker phải được cài đặt trên hệ thống của bạn. Để biết thông tin về cách cài đặt Docker trên Windows hoặc Mac, hãy tham khảo các liên kết trong phần "Xem thêm".
- IntelliJ IDEA.
- Azure Toolkit cho IntelliJ.
- Postman.

## Azure Function

Trong ví dụ này, bạn tạo một hàm chuyển đổi đơn giản có thể chuyển đổi một tệp CAD và lưu nó dưới dạng hình ảnh. Ứng dụng sau đó có thể được xây dựng trong Docker và chạy trong Azure Function.

## Tạo Azure Function

Để tạo chương trình Azure Function, hãy làm theo các bước dưới đây:
1. Khi Docker đã được cài đặt, hãy đảm bảo rằng nó sử dụng Containers Linux (mặc định). Nếu cần, chọn tùy chọn Chuyển sang Containers Linux từ menu Docker Desktops.
1. Tạo dự án Azure Function trong IntelliJ IDEA.<br>
![Tạo dự án hàm azure](/cad/_assets/java/java-azure/create-function-ide-1.png)<br>
![Tạo dự án hàm azure-cuối](/cad/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->Đăng Nhập và chọn xác thực OAuth 2.0.<br>
![Đăng Nhập Azure](/cad/_assets/java/java-azure/sign-in-azure.png)<br>
1. Đăng nhập vào trình duyệt.
1. Chọn tên Đăng ký.
1. Thêm hỗ trợ docker.<br>
![Đăng Nhập Azure](/cad/_assets/java/java-azure/add-docker-support.png)<br>
1. Chỉnh sửa DockerFile như trong phần <a href="#configuring-a-dockerfile">Cấu hình một Dockerfile</a>.
1. Thêm các khối cho kho lưu trữ aspose.cad trong pom.xml.
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

1. Khi tất cả các phụ thuộc cần thiết đã được thêm vào, hãy viết một chương trình đơn giản tạo một hình elip và lưu nó thành hình ảnh:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Hàm này lắng nghe tại điểm cuối "/api/HttpExample". Có hai cách để gọi nó sử dụng lệnh "curl" trong bash:
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
        context.getLogger().info("Java HTTP trigger đã xử lý một yêu cầu.");

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

### Cấu hình một Dockerfile

 Bước tiếp theo là tạo và cấu hình Dockerfile trong thư mục gốc của dự án.

1. Trong Dockerfile, hãy chỉ định:
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

 Phần trên là một Dockerfile đơn giản, chứa các hướng dẫn sau:

- Hình ảnh SDK sẽ được sử dụng. Docker sẽ tải xuống hình ảnh này khi quá trình xây dựng được thực hiện. Phiên bản của SDK được xác định bằng một thẻ.
- Thư mục làm việc, được xác định trong dòng tiếp theo.
- Lệnh để sao chép mọi thứ vào container, xuất bản ứng dụng và chỉ định điểm vào.

## Docker Hub
1. Đăng nhập Docker Hub
1. Tạo kho lưu trữ công khai

## Xây dựng và Chạy Ứng dụng trong Docker
 
 Bây giờ ứng dụng có thể được xây dựng và chạy trong Docker. Mở cửa sổ lệnh mà bạn yêu thích, thay đổi thư mục đến thư mục có ứng dụng (thư mục nơi tệp giải pháp và Dockerfile được đặt) và chạy lệnh sau:


1. Lệnh dockerfile xây dựng trong console
{{< highlight plain >}}
//ví dụ
docker build -t <tên người dùng>/<tên kho lưu trữ> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. Lần đầu tiên bạn chạy lệnh này, có thể mất thời gian lâu hơn vì Docker cần tải xuống các hình ảnh cần thiết. Sau khi lệnh trước hoàn tất, chạy lệnh sau đây để đẩy hình ảnh lên docker hub.
{{< highlight plain >}}
//ví dụ
docker push <tên người dùng>/<tên kho lưu trữ>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Chạy dockerfile trong IDE và sau đó đẩy lên docker hub.<br>
![Chạy docker trong ide](/cad/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Nhập tên hình ảnh, như trong kho lưu trữ Docker HUb.<br>
![Chạy docker trong ide-tiếp theo](/cad/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Chờ cho đến khi xong.

## Azure

1. Đăng nhập Azure.
1. Chọn các dịch vụ Azure.
1. Chọn Function App và tạo một hàm.<br>
![Nút tạo hàm azure](/cad/_assets/java/java-azure/create-function-azure.png)<br>
1. Lặp lại các cài đặt cơ bản như trong hình bên dưới.<br>
![Cài đặt hàm azure](/cad/_assets/java/java-azure/create-function-settings.png)<br>
1. Nhấn 'Xem + tạo' -> Tạo.
1. Chờ cho đến khi triển khai hoàn tất.
1. Nhấn nút 'Đi đến tài nguyên'.<br>
![Nút tài nguyên](/cad/_assets/java/java-azure/go-to-resource.png)<br>
1. Dừng hàm aspose-cad-docker-example.<br>
![Dừng container](/cad/_assets/java/java-azure/stop-container.png)<br>
1. Đi đến menu trung tâm triển khai và thực hiện các cài đặt thích hợp.<br>
![Trung tâm triển khai](/cad/_assets/java/java-azure/deployment-center.png)<br>
1. Lưu cài đặt
1. Sao chép URL Webhook từ các cài đặt trung tâm triển khai.<br>
![URL Webhook](/cad/_assets/java/java-azure/webhook-url.png)<br>
1. Đi đến Docker Hub, chọn kho lưu trữ của bạn và chọn webhooks.
1. Dán 'URL Webhook' từ Azure vào URL webhook Docker Hub và đặt tên.<br>
![Cài đặt Webhook trong docker](/cad/_assets/java/java-azure/webhook.png)<br>
1. Nhấn nút tạo.
1. Trở lại tổng quan hàm azure và khởi động container.<br>
![Tổng quan menu](/cad/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Có thể mất vài phút cho hàm khởi động.
{{% /alert %}}

## Ví dụ thực thi

1. Cài đặt Postman.<br>
![Tổng quan menu](/cad/_assets/java/java-azure/postman-settings.png)<br>
1. Chọn bất kỳ tệp DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG nào.
1. Nhấn nút gửi.
1. Lưu kết quả
![Lưu phản hồi](/cad/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Nếu câu trả lời thành công, nhấn Lưu vào tệp và bạn sẽ nhận được tệp đã chuyển đổi ở định dạng png
{{% /alert %}}

## Nhiều Ví dụ

Để biết thêm các mẫu về cách bạn có thể sử dụng Aspose.CAD trong Docker, xem [các ví dụ](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Xem Thêm

- [Cài đặt Docker Desktop trên Windows](https://docs.docker.com/docker-for-windows/install/)
- [Cài đặt Docker Desktop trên Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Chuyển sang containers Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option
