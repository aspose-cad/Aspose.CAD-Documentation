---
title: Как да стартирате Aspose.CAD Docker изображение в AWS Lambda функция
type: docs
description: "Стартиране на Aspose.CAD Docker изображение в AWS Lambda функция."
weight: 74
url: /bg/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Предварителни изисквания
- Docker трябва да бъде инсталиран на вашата система. За информация как да инсталирате Docker на Windows или Mac, се обърнете към връзките в секцията "Вижте също".
- Visual Studio 2022.
- AWS Toolkit за Visual Studio 2022.
- NET 6 SDK се използва в примера.
- Postman

## AWS Lambda Функция

Lambda е услуга за изчисление, която ви позволява да изпълнявате код без да предоставяте или управлявате сървъри. Lambda изпълнява вашия код на инфраструктура за изчисление с висока наличност и извършва цялата администрация на ресурсите за изчисление, включително поддръжка на сървъри и операционни системи, предоставяне на капацитет и автоматично мащабиране, и регистрация на дейностите. С Lambda можете да изпълнявате код за практически всякакъв тип приложение или бекенд услуга.

## Създаване на AWS Lambda Функция

{{% alert color="primary" %}} 
Убедете се, че имате достатъчни права за създаване на AWS Lambda функции и изображения в Amazon Elastic Container Registry.
{{% /alert %}}

За да създадете програмата за AWS Lambda функция, следвайте стъпките по-долу:
1. Създайте AWS Lambda проект.<br>
![Създаване на бутон за AWS функция](/cad/_assets/showcases/aws/create-project.png)<br>
1. Изберете .NET 6 (Container Image) и кликнете върху бутона 'Finish'.<br>
![Създаване на бутон за контейнерна функция](/cad/_assets/showcases/aws/create-container.png)<br>
1. Отворете AWS Explorer в Visual Studio (View->AWS Explorer).
1. Добавете AWS профил с удостоверения в AWS Explorer.<br>
![Профил на удостоверение](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Въведете Access Key ID и Secret Access Key, можете да получите тези ключове в Security credentials или да се свържете с администратора и да получите csv файл за удостоверяване.<br>
![Настройки на профил](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Инсталирайте последните библиотеки от NuGet.<br>
![Управител на NuGet](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Примерен код за конвертиране на CAD изображение в PDF файл.
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
1. Редактирайте DockerFile, както е описано в секцията <a href="#configuring-a-dockerfile">Конфигуриране на Dockerfile</a>.
1. Стартирайте Docker Desktop.
1. Публикувайте в AWS Lambda.<br>
![Публикуване в AWS lambda](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Редактирайте конфигурацията на качване.<br>
![Качване в aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Кликнете върху бутона 'Upload'.<br>
![Качване в aws lambda последно](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Отидете в AWS и изберете Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Изберете новата си функция и създайте URL на функцията.<br>
![Конфигурация на URL функция](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Изберете тип на удостоверение
- AWS_IAM - Само удостоверени IAM потребители и роли могат да правят искания към URL на вашата функция.
- NONE - Lambda няма да извършва IAM удостоверяване при искания към URL на вашата функция. URL краят ще бъде публичен, освен ако не внедрите собствена логика за удостоверяване във вашата функция.

### Конфигуриране на Dockerfile

Следващата стъпка е да редактирате конфигурацията на Dockerfile в проекта.

1. В Dockerfile, посочете:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

Горният Dockerfile е прост и съдържа следните инструкции:

- Образа на SDK, който ще се използва. Тук е образа на Net 6. Docker ще го изтегли, когато се стартира изграждането. Версията на SDK е посочена като таг.
- След това, може да е необходимо да инсталирате шрифтове, тъй като образа на SDK съдържа много малко шрифтове. Също така, можете да използвате локални шрифтове, копирани в образа на Docker.
- Работната директория, която е посочена в следващия ред.
- Командата за копиране на всичко в контейнера, публикуване на приложението и определяне на точката на вход.

## Пример за изпълнение

1. Настройки на Postman.<br>
![Преглед на менюто](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Изберете всеки DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG файл.
1. Кликнете върху бутона за изпращане.

{{% alert color="primary" %}} 
Ако отговорът е успешен, кликнете върху 'Запази в файл' и ще получите конвертирания файл в PDF формат
{{% /alert %}}

## Още Примери

За повече примери как можете да използвате Aspose.CAD в Docker, вижте [примерите](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Вижте Също.

- [Инсталирайте AWS Toolkit за Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Инсталирайте Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Инсталирайте Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Превключете на Linux контейнери](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Допълнителна информация за [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
