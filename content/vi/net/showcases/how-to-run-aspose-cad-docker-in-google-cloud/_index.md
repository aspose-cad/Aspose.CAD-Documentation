---
title: Cách chạy hình ảnh Docker Aspose.CAD trên Google Cloud
type: docs
description: "Chạy hình ảnh Docker Aspose.CAD trên Google Cloud."
weight: 75
url: /vi/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Các yêu cầu trước

- Docker phải được cài đặt trên hệ thống của bạn. Để biết thông tin về cách cài đặt Docker trên Windows hoặc Mac, hãy tham khảo các liên kết trong phần “Xem Thêm”.
- Visual Studio 2022.
- Google CLI.
- SDK .NET Core 3.1 được sử dụng trong ví dụ.
- Postman

## Chức năng Chạy Google Cloud

Cloud Run là một môi trường tính toán được quản lý hoàn toàn để triển khai và mở rộng các container HTTP không có máy chủ mà không cần lo lắng về việc cung cấp máy, cấu hình cụm hoặc tự động mở rộng.

- Không bị khóa vào nhà cung cấp - Bởi vì Cloud Run sử dụng các container OCI tiêu chuẩn và thực hiện API Knative Serving tiêu chuẩn, bạn có thể dễ dàng di chuyển các ứng dụng của mình tới môi trường trên đám mây hoặc bất kỳ môi trường đám mây nào khác.
- Tự động mở rộng nhanh - Các microservices triển khai trong Cloud Run tự động mở rộng dựa trên số lượng yêu cầu đến, mà không cần bạn phải cấu hình hoặc quản lý cụm Kubernetes hoàn chỉnh. Cloud Run mở rộng xuống 0—tức là, không sử dụng tài nguyên—nếu không có yêu cầu nào.
- Chia sẻ lưu lượng - Cloud Run cho phép bạn chia sẻ lưu lượng giữa nhiều phiên bản, vì vậy bạn có thể thực hiện các triển khai dần dần như triển khai canary hoặc triển khai blue/green.
- Tên miền tùy chỉnh - Bạn có thể thiết lập ánh xạ tên miền tùy chỉnh trong Cloud Run và nó sẽ cấp phát một chứng chỉ TLS cho tên miền của bạn.
- Tự động dự phòng - Cloud Run cung cấp khả năng dự phòng tự động để bạn không phải lo lắng về việc tạo nhiều phiên bản cho khả năng khả dụng cao.

Cloud Run và Cloud Functions đều là các dịch vụ được quản lý hoàn toàn chạy trên cơ sở hạ tầng không có máy chủ của Google Cloud, tự động mở rộng và xử lý các yêu cầu HTTP hoặc sự kiện. Tuy nhiên, chúng có một số khác biệt quan trọng:

- Cloud Functions cho phép bạn triển khai các đoạn mã (hàm) được viết bằng một tập hợp các ngôn ngữ lập trình hạn chế, trong khi Cloud Run cho phép bạn triển khai hình ảnh container bằng ngôn ngữ lập trình mà bạn chọn.
- Cloud Run cũng hỗ trợ việc sử dụng bất kỳ công cụ hoặc thư viện hệ thống nào từ ứng dụng của bạn; Cloud Functions không cho phép bạn sử dụng các tệp thực thi tùy chỉnh.
- Cloud Run cung cấp thời gian chờ yêu cầu lâu hơn lên đến 60 phút, trong khi Cloud Functions có thể thiết lập thời gian chờ yêu cầu tối đa lên tới 9 phút.
- Cloud Functions chỉ gửi một yêu cầu một lần cho mỗi phiên bản hàm, trong khi mặc định Cloud Run được cấu hình để gửi nhiều yêu cầu đồng thời trên mỗi phiên bản container. Điều này hữu ích để cải thiện độ trễ và giảm chi phí nếu bạn dự đoán lượng lớn yêu cầu.

## Tạo dự án Chức năng Google Cloud

{{% alert color="primary" %}} 
Đảm bảo bạn có đủ quyền để tạo chức năng và hình ảnh Google Cloud Run trong kho Artifact Registry.
{{% /alert %}}

Để tạo chương trình Chức năng Google Cloud, hãy làm theo các bước dưới đây:

1. Cài đặt SDK .NET Core 3.1.
1. Cài đặt gói mẫu:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Tiếp theo, tạo một thư mục cho dự án của bạn, và sử dụng dotnet new để tạo một chức năng HTTP mới:
{{< highlight plain >}}
mkdir AsposeFunctions //tạo thư mục
cd AsposeFunctions //vào thư mục AsposeFunctions
dotnet new gcf-http //tạo dự án Google Cloud Function với bộ kích hoạt http
{{< /highlight >}}
{{% alert color="primary" %}} 
Điều này sẽ tạo ra AsposeFunctions.csproj và Function.cs trong thư mục hiện tại. Mở Function.cs để xem xét mã, và cung cấp một thông điệp tùy chỉnh nếu bạn muốn.
{{% /alert %}}
1. Ví dụ mã cho tệp csproj (AsposeFunctions.csproj).
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
1. Ví dụ mã để chuyển đổi hình ảnh cad thành tệp png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logic cho hàm của bạn nằm ở đây.
        /// </summary>
        /// <param name="context">Ngữ cảnh HTTP, chứa yêu cầu và phản hồi.</param>
        /// <returns>Một tác vụ đại diện cho hoạt động không đồng bộ.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //tệp từ biểu mẫu
                var file = context.Request.Body; //dữ liệu nhị phân
                
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
1. Xây dựng chức năng của bạn cục bộ như sau:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Một khi máy chủ đang chạy, hãy truy cập vào http://localhost:8080 để gọi chức năng. Nhấn Ctrl-C trong console để dừng máy chủ.

## Triển khai hình ảnh docker lên Google Cloud

1. Đăng nhập Google Cloud.
1. Tạo một dự án nếu nó không tồn tại.
1. Đi đến 'Artifact Registry' và tạo một kho.<br>
![Tạo Kho Artifacts](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. Chọn kho mới trong Artifact Registry.
![Chọn kho artifact](/cad/_assets/showcases/google/select-artifact.png)<br>
1. Nhấp vào 'HƯỚNG DẪN THIẾT LẬP' và sao chép lệnh 'Cấu hình Docker'.<br>
![HƯỚNG DẪN THIẾT LẬP](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. Thêm một mục credHelper Docker vào tệp cấu hình Docker, hoặc tạo tệp nếu nó không tồn tại.
{{< highlight plain >}}
//ví dụ
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Tạo một Dockerfile trong thư mục gốc của dự án và chỉnh sửa DockerFile như trong phần <a href="#configuring-a-dockerfile">Cấu hình một Dockerfile</a>.
1. Khởi động Docker Desktop.
1. Xây dựng hình ảnh docker với đường dẫn kho đám mây.
{{< highlight plain >}}
//ví dụ
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Đẩy hình ảnh lên Google Cloud Artifact Registry
{{< highlight plain >}}
//ví dụ
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Tạo dịch vụ Google Cloud Run 

1. Đi đến Cloud Run.
1. Tạo dịch vụ Cloud Run.<br>
![Tạo dịch vụ Cloud Run](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. Trong trường URL Hình ảnh Container, chọn container từ 'ARTIFACT REGISTRY'.<br>
![URL Hình ảnh Container](/cad/_assets/showcases/google/container-url.png)<br>
1. Kiểm tra các cài đặt khác như bên dưới.<br>
![Cài đặt dịch vụ](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Chờ cho việc triển khai hoàn tất.
1. URL dịch vụ để làm việc với ứng dụng chuyển đổi.<br>
![Url dịch vụ](/cad/_assets/showcases/google/url-service.png)<br>

### Cấu hình một Dockerfile

Bước tiếp theo là chỉnh sửa cấu hình Dockerfile trong dự án.

1. Trong Dockerfile, chỉ định:

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
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

Trên đây là một Dockerfile đơn giản, chứa các hướng dẫn sau:

- Hình ảnh SDK để sử dụng. Ở đây là hình ảnh Net Core 3.1. Docker sẽ tải nó khi việc xây dựng được thực hiện. Phiên bản SDK được chỉ định dưới dạng một nhãn.
- Sau đó, bạn có thể cần cài đặt font chữ vì hình ảnh SDK chứa rất ít font. Ngoài ra, bạn có thể sử dụng các font chữ cục bộ sao chép vào hình ảnh docker.
- Thư mục làm việc, được chỉ định trong dòng tiếp theo.
- Lệnh để sao chép mọi thứ vào container, xuất bản ứng dụng, và chỉ định điểm nhập.

## Ví dụ thực thi

1. Cài đặt Postman.<br>
![Menu tổng quan](/cad/_assets/showcases/google/postman-settings.png)<br>
1. Chọn bất kỳ tệp DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG nào.
1. Nhấp vào nút gửi.

{{% alert color="primary" %}} 
Nếu câu trả lời thành công, nhấp vào Lưu vào tệp và bạn sẽ nhận được tệp đã được chuyển đổi ở định dạng png
{{% /alert %}}

## Thêm Ví dụ

Để biết thêm các mẫu về cách bạn có thể sử dụng Aspose.CAD trong Docker, xem [các ví dụ](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Xem Thêm.

- [Cài đặt Docker Desktop trên Windows](https://docs.docker.com/docker-for-windows/install/)
- [Cài đặt Docker Desktop trên Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Chuyển sang các container Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) tùy chọn
- Thông tin bổ sung về [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
