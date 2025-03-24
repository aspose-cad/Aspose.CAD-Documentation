---
title: Як запустити Docker-образ Aspose.CAD у функції AWS Lambda
type: docs
description: "Запустіть Docker-образ Aspose.CAD у функції AWS Lambda."
weight: 74
url: /uk/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Попередні вимоги
- Docker повинен бути встановлений на вашій системі. Для отримання інформації про те, як встановити Docker на Windows або Mac, зверніть увагу на посилання в розділі “Дивіться також”.
- Visual Studio 2022.
- AWS Toolkit для Visual Studio 2022.
- У прикладі використовується .NET 6 SDK.
- Postman

## Функція AWS Lambda

Lambda — це обчислювальна служба, яка дозволяє вам запускати код без необхідності налаштовувати або керувати серверами. Lambda виконує ваш код на інфраструктурі високої доступності та виконує всі адміністративні роботи з обчислювальними ресурсами, включаючи обслуговування серверів і операційних систем, постачання потужностей і автоматичне масштабування, а також ведення журналів. За допомогою Lambda ви можете виконувати код практично для будь-якого типу програми або служби на задньому плані.

## Створення функції AWS Lambda

{{% alert color="primary" %}} 
Переконайтеся, що у вас є достатньо прав для створення функцій AWS Lambda та образів у реєстрі Amazon Elastic Container.
{{% /alert %}}

Щоб створити програму функції AWS Lambda, виконайте такі кроки:
1. Створіть проект AWS Lambda.<br>
![Створення кнопки функції AWS](/cad/_assets/showcases/aws/create-project.png)<br>
1. Виберіть .NET 6 (Контейнерний образ) і натисніть кнопку 'Завершити'.<br>
![Створення кнопки контейнерної функції](/cad/_assets/showcases/aws/create-container.png)<br>
1. Відкрийте AWS Explorer у Visual Studio (Перегляд->AWS Explorer).
1. Додайте профіль облікових даних AWS в AWS Explorer.<br>
![Профіль облікових даних](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Введіть ідентифікатор ключа доступу та секретний ключ доступу, ці ключі можна отримати в розділі Безпека облікових даних або зв'язатися з адміністратором та отримати файл csv для авторизації.<br>
![Налаштування профілю облікових записів](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Встановіть останні бібліотеки з NuGet.<br>
![Менеджер NuGet](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Приклад коду для конвертації зображення CAD у PDF-файл.
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
1. Внесіть зміни в DockerFile, як у розділі <a href="#configuring-a-dockerfile">Конфігурація Dockerfile</a>.
1. Запустіть Docker Desktop.
1. Опублікуйте в AWS Lambda.<br>
![Публікація AWS Lambda](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Відредагуйте конфігурацію завантаження.<br>
![Завантаження AWS Lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Натисніть кнопку 'Завантажити'.<br>
![Останнє завантаження AWS Lambda](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Перейдіть до AWS і виберіть Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Виберіть вашу нову функцію та створіть URL-функцію.<br>
![Налаштування URL-функції](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Виберіть тип автентифікації
- AWS_IAM - Тільки автентифіковані користувачі і ролі IAM можуть надсилати запити до вашого URL-функції.
- NONE - Lambda не виконуватиме автентифікацію IAM для запитів до вашого URL-функції. URL-ки буде публічним, якщо ви не реалізуєте власну логіку авторизації у вашій функції.

### Конфігурація Dockerfile

Наступний крок — відредагувати конфігурацію Dockerfile у проекті.

1. У Dockerfile вкажіть:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

Наведеного вище — це простий Dockerfile, який містить такі інструкції:

- Образ SDK, який буде використаний. Тут це образ Net 6. Docker завантажить його, коли буде запущено збірку. Версія SDK вказується як тег.
- Потім вам може знадобитися встановити шрифти, оскільки в образі SDK є дуже мало шрифтів. Також ви можете використовувати локальні шрифти, скопійовані в образ Docker.
- Робочий каталог, який вказується в наступному рядку.
- Команда для копіювання всього в контейнер, публікації програми та вказівки точки входу.

## Приклад виконання

1. Налаштування Postman.<br>
![Меню огляду](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Натисніть кнопку відправлення.

{{% alert color="primary" %}} 
Якщо відповідь успішна, натисніть Зберегти у файл, і ви отримаєте конвертований файл у форматі pdf
{{% /alert %}}

## Більше прикладів

Для отримання більше зразків того, як ви можете використовувати Aspose.CAD в Docker, перегляньте [приклади](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Дивіться також.

- [Встановіть AWS Toolkit для Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Встановіть Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Встановіть Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Переключення на контейнери Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) варіант
- Додаткова інформація про [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
