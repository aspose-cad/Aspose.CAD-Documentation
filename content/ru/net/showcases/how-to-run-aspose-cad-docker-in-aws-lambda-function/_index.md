---
title: Как запустить образ Aspose.CAD Docker в AWS Lambda Function
type: docs
description: "Запустите образ Aspose.CAD Docker в AWS Lambda Function."
weight: 74
url: /ru/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Требования
- Docker должен быть установлен в вашей системе. Для получения информации о том, как установить Docker на Windows или Mac, обратитесь к ссылкам в разделе «См. также».
- Visual Studio 2022.
- AWS Toolkit для Visual Studio 2022.
- В примере используется .NET 6 SDK.
- Postman

## AWS Lambda Function

Lambda — это вычислительный сервис, который позволяет запускать код без provisionning или управления серверами. Lambda запускает ваш код на высокодоступной вычислительной инфраструктуре и выполняет все административные задачи вычислительных ресурсов, включая обслуживание серверов и операционных систем, provisioning мощностей и автоматическое масштабирование, а также ведение логов. С помощью Lambda вы можете запускать код практически для любого типа приложения или бэкэнд-сервиса.

## Создание AWS Lambda Function

{{% alert color="primary" %}} 
Убедитесь, что у вас есть достаточные права для создания функций и образов AWS Lambda в Amazon Elastic Container Registry.
{{% /alert %}}

Чтобы создать программу AWS Lambda Function, выполните следующие шаги:
1. Создайте проект AWS Lambda.<br>
![Create AWS function button](/cad/_assets/showcases/aws/create-project.png)<br>
1. Выберите .NET 6 (Container Image) и нажмите кнопку 'Finish'.<br>
![Create container function button](/cad/_assets/showcases/aws/create-container.png)<br>
1. Откройте AWS Explorer в Visual Studio (View->AWS Explorer).
1. Добавьте профиль учетных данных AWS в AWS Explorer.<br>
![Credential profile](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Введите Access Key ID и Secret Access Key, вы можете получить эти ключи в разделе Безопасность или связаться с администратором и получить csv-файл для авторизации.<br>
![Acount profile settings](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Установите последние библиотеки из NuGet.<br>
![NuGet Manager](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Пример кода для конвертации cad-изображения в pdf-файл.
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
1. Отредактируйте DockerFile, как в разделе <a href="#configuring-a-dockerfile">Настройка Dockerfile</a>.
1. Запустите Docker Desktop.
1. Опубликуйте в AWS Lambda.<br>
![AWS lambda publish](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Измените конфигурацию загрузки.<br>
![Upload aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Нажмите кнопку 'Upload'.<br>
![Upload aws lambda last](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Перейдите в AWS и выберите Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Выберите вашу новую функцию и создайте URL функции.<br>
![Configuration url function](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Выберите тип аутентификации
- AWS_IAM - Только аутентифицированные пользователи и роли IAM могут отправлять запросы к вашему URL функции.
- NONE - Lambda не будет выполнять аутентификацию IAM для запросов к вашему URL функции. Конечная точка URL будет общедоступной, если вы не реализуете свою собственную логику авторизации в вашей функции.

### Настройка Dockerfile

Следующий шаг - отредактировать Dockerfile в проекте.

1. В Dockerfile укажите:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

Выше представлен простой Dockerfile, который содержит следующие инструкции:

- Используемый образ SDK. Здесь это образ Net 6. Docker загрузит его, когда будет запущена сборка. Версия SDK указывается в качестве тега.
- После этого вам, возможно, придется установить шрифты, поскольку образ SDK содержит очень мало шрифтов. Вы также можете использовать локальные шрифты, скопированные в образ docker.
- Рабочий каталог, который указывается в следующей строке.
- Команда для копирования всего в контейнер, публикации приложения и указания точки входа.

## Пример выполнения

1. Настройки Postman.<br>
![Overview menu](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Выберите любой файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Нажмите кнопку отправки.

{{% alert color="primary" %}} 
Если ответ успешен, нажмите «Сохранить в файл», и вы получите конвертированный файл в формате PDF
{{% /alert %}}

## Дополнительные примеры

Для получения дополнительных примеров использования Aspose.CAD в Docker смотрите [примеры](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## См. также.

- [Установите AWS Toolkit для Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Установите Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Установите Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Переключиться на контейнеры Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Дополнительная информация о [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
