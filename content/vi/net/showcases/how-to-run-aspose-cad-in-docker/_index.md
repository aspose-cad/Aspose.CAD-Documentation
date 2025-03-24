---
title: Cách Chạy Aspose.CAD Trong Docker
type: docs
description: "Chạy Aspose.CAD trong một container Docker cho Linux, Windows Server và bất kỳ HĐH nào."
weight: 71
url: /vi/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Các yêu cầu tiên quyết
- Docker phải được cài đặt trên hệ thống của bạn. Để biết cách cài đặt Docker trên Windows hoặc Mac, hãy tham khảo các liên kết trong phần "Xem thêm".
- Visual Studio 2022.
- NET 6 SDK được sử dụng trong ví dụ này.

## Ứng dụng Hello World

Trong ví dụ này, bạn sẽ tạo một ứng dụng console Hello World đơn giản vẽ một hình ellipse và lưu nó dưới dạng hình ảnh. Ứng dụng có thể được xây dựng và chạy trong Docker.

## Tạo ứng dụng Console

Để tạo chương trình Hello World, hãy làm theo các bước dưới đây:
1. Sau khi đã cài đặt Docker, hãy đảm bảo rằng nó sử dụng Linux Containers (mặc định). Nếu cần, chọn tùy chọn Chuyển sang container Linux từ menu Docker Desktops.
1. Trong Visual Studio, tạo một ứng dụng console NET 6.<br>
![Hộp thoại dự án ứng dụng console NET 6](/cad/_assets/showcases/docker/1.png)<br>
1. Cài đặt phiên bản Aspose.CAD mới nhất từ NuGet.<br>
![Aspose.CAD trên NuGet](/cad/_assets/showcases/docker/2.png)<br>
1. Vì ứng dụng sẽ được chạy trên Linux, bạn có thể cần cài đặt thêm phông chữ. Bạn có thể sử dụng ttf-mscorefonts-installer.
1. Khi tất cả các phụ thuộc cần thiết đã được thêm, hãy viết một chương trình đơn giản tạo một hình ellipse và lưu nó dưới dạng hình ảnh:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Lưu ý rằng thư mục “TestOut” được chỉ định là thư mục đầu ra để lưu trữ các tài liệu đầu ra. Khi chạy ứng dụng trong Docker, một thư mục trên máy chủ sẽ được gán vào thư mục này trong container. Điều này sẽ cho phép bạn dễ dàng xem kết quả được tạo ra bởi Aspose.CAD trong container Docker.

### Cấu hình Dockerfile

Bước tiếp theo là tạo và cấu hình Dockerfile.

1. Tạo Dockerfile và đặt nó bên cạnh tệp giải pháp của ứng dụng của bạn. Giữ tên tệp này mà không có phần mở rộng (mặc định).
1. Trong Dockerfile, chỉ định:


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

Trên đây là một Dockerfile đơn giản, chứa các chỉ dẫn sau:

- Hình ảnh SDK để sử dụng. Ở đây là hình ảnh Net 6. Docker sẽ tải nó khi quá trình xây dựng được thực hiện. Phiên bản của SDK được chỉ định dưới dạng thẻ.
- Sau đó, bạn có thể cần cài đặt Phông chữ vì hình ảnh SDK chứa rất ít phông chữ. Bạn cũng có thể sử dụng các phông chữ cục bộ sao chép vào hình ảnh docker.
- Thư mục làm việc, được chỉ định trong dòng tiếp theo.
- Lệnh sao chép mọi thứ vào container, xuất bản ứng dụng và chỉ định điểm vào.

## Xây dựng và Chạy Ứng dụng trong Docker
 
 Bây giờ ứng dụng có thể được xây dựng và chạy trong Docker. Mở cửa sổ lệnh yêu thích của bạn, thay đổi thư mục sang thư mục chứa ứng dụng (thư mục nơi tệp giải pháp và Dockerfile được đặt) và chạy lệnh sau:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

Lần đầu tiên lệnh này được thực thi, có thể mất nhiều thời gian hơn, vì Docker cần tải các hình ảnh cần thiết. Khi lệnh trước đó đã hoàn tất, hãy chạy lệnh sau:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Lưu ý rằng tham số gán rất quan trọng, vì như đã đề cập trước đó, một thư mục trên máy chủ được gán vào thư mục của container, để dễ dàng xem kết quả thực thi ứng dụng. Đường dẫn trong Linux phân biệt chữ hoa chữ thường.
{{% /alert %}}

## Các Ví dụ Khác

Để biết thêm mẫu cách bạn có thể sử dụng Aspose.CAD trong Docker, hãy xem các [ví dụ](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Xem thêm

- [Cài đặt Docker Desktop trên Windows](https://docs.docker.com/docker-for-windows/install/)
- [Cài đặt Docker Desktop trên Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Chuyển sang các container Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 
- Thông tin bổ sung về [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
