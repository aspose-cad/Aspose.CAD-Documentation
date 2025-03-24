---
title: Cách Chạy Hình ảnh Docker Aspose.CAD trong Azure Function
type: docs
description: "Chạy hình ảnh Docker Aspose.CAD trong Azure Function."
weight: 73
url: /vi/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Các yêu cầu cần thiết
- Docker phải được cài đặt trên hệ thống của bạn. Để biết thông tin về cách cài đặt Docker trên Windows hoặc Mac, hãy tham khảo các liên kết trong phần “Xem thêm”.
- Visual Studio 2022.
- SDK NET 6 được sử dụng trong ví dụ.
- Postman

## Azure Function

Trong ví dụ này, bạn tạo một hàm chuyển đổi đơn giản để chuyển đổi một tệp CAD và lưu nó dưới dạng hình ảnh. Ứng dụng sau đó có thể được xây dựng trong Docker và chạy trong Azure Function.

## Tạo Azure Function

Để tạo chương trình Azure Function, hãy làm theo các bước dưới đây:
1. Khi Docker đã được cài đặt, hãy đảm bảo rằng nó sử dụng Containers Linux (mặc định). Nếu cần, chọn tùy chọn Chuyển sang containers Linux từ menu Docker Desktops.
1. Trong Visual Studio, tạo một Azure Function NET 6.<br>
![Hộp thoại dự án Azure Function NET 6](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Thông tin bổ sung.<br>
![Hộp thoại dự án Azure Function NET 6](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Cài đặt phiên bản Aspose.CAD mới nhất từ NuGet.<br>
![Aspose.CAD trên NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Vì ứng dụng sẽ chạy trên Linux, bạn có thể cần cài đặt thêm các phông chữ. Bạn có thể chọn ttf-mscorefonts-installer.
1. Khi tất cả các phụ thuộc cần thiết đã được thêm vào, hãy viết một chương trình đơn giản tạo một hình ellipse và lưu nó dưới dạng hình ảnh:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Hàm kích hoạt HTTP C# đã xử lý một yêu cầu.");
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

### Cấu hình Dockerfile

 Bước tiếp theo là tạo và cấu hình Dockerfile trong thư mục gốc của dự án.

1. Tạo Dockerfile và đặt nó cạnh tệp giải pháp của ứng dụng của bạn. Giữ tên tệp này mà không có phần mở rộng (mặc định).
![Thư mục dự án gốc](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Trong Dockerfile, chỉ định:


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

 Trên đây là một Dockerfile đơn giản, chứa các chỉ dẫn sau:

- Hình ảnh SDK sẽ được sử dụng. Ở đây nó là hình ảnh Net 6. Docker sẽ tải xuống khi quá trình biên dịch được thực hiện. Phiên bản SDK được chỉ định dưới dạng một thẻ.
- Sau đó, bạn có thể cần cài đặt các phông chữ vì hình ảnh SDK chứa rất ít phông chữ. Ngoài ra, bạn có thể sử dụng các phông chữ cục bộ sao chép vào hình ảnh docker.
- Thư mục làm việc, được chỉ định trong dòng tiếp theo.
- Lệnh sao chép mọi thứ vào container, xuất bản ứng dụng và chỉ định điểm đầu vào.

## Docker Hub
1. Đăng nhập vào Docker Hub
1. Tạo kho lưu trữ công khai

## Xây dựng và Chạy Ứng dụng trong Docker
 
 Bây giờ ứng dụng có thể được xây dựng và chạy trong Docker. Mở dấu nhắc lệnh mà bạn yêu thích, chuyển thư mục đến thư mục chứa ứng dụng (thư mục nơi có tệp giải pháp và Dockerfile) và chạy lệnh sau:

{{< highlight plain >}}
//ví dụ
docker build -t <tên người dùng>/<tên kho lưu trữ> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
Lần đầu tiên bạn chạy lệnh này, có thể mất nhiều thời gian hơn vì Docker cần tải xuống các hình ảnh cần thiết. Sau khi lệnh trước được hoàn thành, hãy chạy lệnh sau để đẩy hình ảnh lên docker hub:
 
{{< highlight plain >}}
//ví dụ
docker push <tên người dùng>/<tên kho lưu trữ>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Đăng nhập vào Azure.
1. Chọn dịch vụ Azure.
1. Chọn Function App và tạo một hàm.<br>
![Nút tạo hàm Azure](/cad/_assets/showcases/azure/create-function.png)<br>
1. Lặp lại các cài đặt cơ bản như trong hình bên dưới.<br>
![Cài đặt hàm Azure tạo](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Nhấp vào 'Đánh giá + tạo' -> Tạo.
1. Chờ cho quá trình triển khai hoàn tất.
1. Nhấp vào nút 'Đi tới tài nguyên'.<br>
![Nút tài nguyên](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Dừng hàm aspose-cad-docker-example.<br>
![Dừng container](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Đi đến menu trung tâm triển khai và thực hiện các cài đặt thích hợp.<br>
![Trung tâm triển khai](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Lưu cài đặt
1. Sao chép URL Webhook từ cài đặt trung tâm triển khai.<br>
![URL Webhook](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Đi đến Docker Hub, chọn kho lưu trữ của bạn và chọn webhooks.
1. Dán 'URL Webhook' từ Azure vào url webhook Docker Hub và đặt tên.<br>
![Cài đặt webhook trong docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Nhấp vào nút tạo.
1. Quay lại chức năng tổng quan azure và khởi động container.<br>
![Menu tổng quan](/cad/_assets/showcases/azure/overview.png)<br>

## Ví dụ thực hiện

1. Cài đặt Postman.<br>
![Cài đặt Postman](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Chọn bất kỳ tệp DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG nào.
1. Nhấn nút gửi.

{{% alert color="primary" %}} 
Nếu câu trả lời thành công, nhấn Lưu vào tệp và bạn sẽ nhận được tệp đã chuyển đổi ở định dạng png
{{% /alert %}}

## Thêm ví dụ

Để biết thêm các mẫu về cách bạn có thể sử dụng Aspose.CAD trong Docker, hãy xem [các ví dụ](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Xem thêm

- [Cài đặt Docker Desktop trên Windows](https://docs.docker.com/docker-for-windows/install/)
- [Cài đặt Docker Desktop trên Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Chuyển sang containers Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) tùy chọn
- Thông tin bổ sung về [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
