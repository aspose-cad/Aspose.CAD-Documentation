---
title: Cách chạy hình ảnh Aspose.CAD Docker trong chức năng AWS Lambda
type: docs
description: "Chạy hình ảnh Aspose.CAD Docker trong chức năng AWS Lambda."
weight: 74
url: /vi/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Điều kiện tiên quyết
- Docker phải được cài đặt trên hệ thống của bạn. Để biết thông tin về cách cài đặt Docker trên Windows hoặc Mac, hãy tham khảo các liên kết trong phần “Xem thêm”.
- Visual Studio 2022.
- AWS Toolkit cho Visual Studio 2022.
- SDK NET 6 được sử dụng trong ví dụ.
- Postman

## Chức năng AWS Lambda

Lambda là một dịch vụ tính toán cho phép bạn chạy mã mà không cần cung cấp hoặc quản lý máy chủ. Lambda chạy mã của bạn trên một hạ tầng tính toán có độ sẵn sàng cao và thực hiện tất cả các công việc quản trị tài nguyên tính toán, bao gồm bảo trì máy chủ và hệ điều hành, cung cấp năng lực và tự động mở rộng, và ghi nhật ký. Với Lambda, bạn có thể chạy mã cho hầu hết mọi loại ứng dụng hoặc dịch vụ phía sau.

## Tạo chức năng AWS Lambda

{{% alert color="primary" %}} 
Hãy chắc chắn rằng bạn có quyền đủ để tạo các chức năng và hình ảnh AWS Lambda trong Amazon Elastic Container Registry.
{{% /alert %}}

Để tạo chương trình chức năng AWS Lambda, hãy làm theo các bước sau:
1. Tạo dự án AWS Lambda.<br>
![Nút tạo chức năng AWS](/_assets/showcases/aws/create-project.png)<br>
1. Chọn .NET 6(Hình ảnh Container) và nhấn nút 'Hoàn tất'.<br>
![Nút tạo chức năng container](/_assets/showcases/aws/create-container.png)<br>
1. Mở AWS Explorer trong Visual Studio (Xem->AWS Explorer).
1. Thêm hồ sơ xác thực AWS trong AWS Explorer.<br>
![Hồ sơ xác thực](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Nhập ID khóa truy cập và khóa truy cập bí mật, bạn có thể lấy những khóa này trong thông tin đăng ký bảo mật hoặc liên hệ với quản trị viên để nhận tệp csv cho xác thực.<br>
![Cài đặt hồ sơ tài khoản](/_assets/showcases/aws/account-profile.png)<br>
1. Cài đặt các thư viện mới nhất từ NuGet.<br>
![Trình quản lý NuGet](/_assets/showcases/aws/nuget-manager.png)<br>
1. Ví dụ mã để chuyển đổi hình ảnh cad thành tệp pdf.
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
1. Chỉnh sửa DockerFile như trong phần <a href="#configuring-a-dockerfile">Cấu hình Dockerfile</a>.
1. Khởi động Docker Desktop.
1. Xuất bản lên AWS Lambda.<br>
![Xuất bản aws lambda](/_assets/showcases/aws/publish-aws.png)<br>
1. Chỉnh sửa cấu hình tải lên.<br>
![Tải lên aws lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Nhấn nút 'Tải lên'.<br>
![Tải lên aws lambda hoàn tất](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Đi đến AWS và chọn Lambda.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Chọn chức năng mới của bạn và tạo url cho chức năng.<br>
![Cấu hình url chức năng](/_assets/showcases/aws/create-function-url.png)<br>
1. Chọn loại xác thực
- AWS_IAM - Chỉ người dùng và vai trò IAM được xác thực mới có thể thực hiện yêu cầu đến URL chức năng của bạn.
- NONE - Lambda sẽ không thực hiện xác thực IAM trên các yêu cầu đến URL chức năng của bạn. Điểm cuối URL sẽ công khai trừ khi bạn triển khai logic xác thực của riêng mình trong chức năng của bạn.

### Cấu hình Dockerfile

 Bước tiếp theo là chỉnh sửa cấu hình Dockerfile trong dự án.

1. Trong Dockerfile, chỉ định:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Trên đây là một Dockerfile đơn giản, chứa các hướng dẫn sau:

- Hình ảnh SDK sẽ được sử dụng. Ở đây là hình ảnh Net 6. Docker sẽ tải về khi xây dựng được thực thi. Phiên bản SDK được chỉ định dưới dạng thẻ.
- Sau đó, bạn có thể cần cài đặt Fonts vì hình ảnh SDK chứa rất ít phông chữ. Ngoài ra, bạn có thể sử dụng phông chữ cục bộ được sao chép vào hình ảnh docker.
- Thư mục làm việc, được chỉ định trong dòng tiếp theo.
- Lệnh để sao chép tất cả mọi thứ vào container, xuất bản ứng dụng và chỉ định điểm vào.

## Ví dụ thực thi

1. Cài đặt Postman.<br>
![Menu tổng quan](/_assets/showcases/aws/postman-settings.png)<br>
1. Chọn bất kỳ tệp DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG nào.
1. Nhấn nút gửi.

{{% alert color="primary" %}} 
Nếu phản hồi thành công, nhấn Lưu vào tệp và bạn sẽ nhận được tệp đã chuyển đổi ở định dạng pdf
{{% /alert %}}

## Thêm Ví dụ

Để có thêm mẫu cách bạn có thể sử dụng Aspose.CAD trong Docker, hãy xem [các ví dụ](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Xem Thêm.

- [Cài đặt AWS Toolkit cho Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Cài đặt Docker Desktop trên Windows](https://docs.docker.com/docker-for-windows/install/)
- [Cài đặt Docker Desktop trên Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Chuyển sang các container Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) tùy chọn
- Thông tin bổ sung về [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
