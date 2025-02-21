---
title: Як запустити Docker-образ Aspose.CAD в Azure Function
type: docs
description: "Запустіть Docker-образ Aspose.CAD в Azure Function."
weight: 71
url: /uk/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Попередні вимоги
- Docker повинен бути встановлений на вашій системі. Для отримання інформації про те, як встановити Docker на Windows або Mac, зверніться до посилань у розділі "Дивіться також".
- IntelliJ IDEA.
- Azure Toolkit для IntelliJ.
- Postman.

## Azure Function

У цьому прикладі ви створюєте просту функцію конвертації, яка конвертує CAD-файл і зберігає його як зображення. Додаток можна буде зібрати в Docker і запустити в Azure Function.

## Створення Azure Function

Щоб створити програму Azure Function, виконайте наведені нижче кроки:
1. Після встановлення Docker переконайтеся, що він використовує контейнері Linux (за умовчанням). Якщо це необхідно, виберіть опцію Switch to Linux containers у меню Docker Desktops.
1. Створіть проект Azure Function в IntelliJ IDEA.<br>
![Create azure function project](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Create azure function project-final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. У меню Tools->Azure->Sing In виберіть автентифікацію OAuth 2.0.<br>
![Azure sign In](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Увійдіть у браузер.
1. Виберіть ім'я підписки.
1. Додайте підтримку Docker.<br>
![Azure sign In](/_assets/java/java-azure/add-docker-support.png)<br>
1. Відредагуйте DockerFile, як у розділі <a href="#configuring-a-dockerfile">Налаштування Dockerfile</a>.
1. Додайте блоки для репозиторію aspose.cad у pom.xml.
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

1. Коли всі необхідні залежності додані, напишіть просту програму, яка створює еліпс і зберігає його як зображення:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Ця функція слухає за кінцевою точкою "/api/HttpExample". Два способи виклику за допомогою команди "curl" у bash:
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

### Налаштування Dockerfile

 Наступним кроком є створення та налаштування Dockerfile у кореневій папці проекту.

1. У Dockerfile вкажіть:
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

 Викладений вище Dockerfile є простим і містить такі інструкції:

- Образ SDK, який буде використовуватися. Docker завантажить його, коли буде запущено збірку. Версія SDK вказується як тег.
- Папка робочого каталогу, яка вказується в наступному рядку.
- Команда для копіювання всього в контейнер, публікація додатку та вказівка точки входу.

## Docker Hub
1. Увійдіть у Docker Hub
1. Створіть загальнодоступний репозиторій

## Побудова та запуск програми в Docker
 
 Тепер додаток можна зібрати та запустити в Docker. Відкрийте улюблений командний рядок, змініть каталог до папки з додатком (папка, де розташований файл рішення та Dockerfile) і запустіть таку команду:


1. Команда побудови dockerfile в консолі
{{< highlight plain >}}
//приклад
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. Перший раз, коли ви запускаєте цю команду, це може зайняти більше часу, оскільки Docker повинен завантажити необхідні образи. Після завершення попередньої команди запустіть наступну команду для відправлення образу на docker hub.
{{< highlight plain >}}
//приклад
docker push <user name>/<repository name>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Запустіть dockerfile в IDE і після відправки до docker hub.<br>
![Run docker in ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Введіть ім'я образу, як у репозиторії Docker Hub.<br>
![Run docker in ide-next](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Чекайте закінчення.

## Azure

1. Увійдіть в Azure.
1. Виберіть послуги Azure.
1. Виберіть Function App і створіть функцію.<br>
![Azure create function button](/_assets/java/java-azure/create-function-azure.png)<br>
1. Повторіть основні налаштування, як на зображенні нижче.<br>
![Azure create function settings](/_assets/java/java-azure/create-function-settings.png)<br>
1. Натисніть 'Review + create' -> Create.
1. Чекайте завершення розгортання.
1. Натисніть кнопку 'Go to resource'.<br>
![Resource button](/_assets/java/java-azure/go-to-resource.png)<br>
1. Зупиніть функцію aspose-cad-docker-example.<br>
![Stop conteiner](/_assets/java/java-azure/stop-container.png)<br>
1. Перейдіть до меню центру розгортання та налаштуйте відповідні параметри.<br>
![Deployment center](/_assets/java/java-azure/deployment-center.png)<br>
1. Збережіть налаштування
1. Скопіюйте URL-адресу Webhook із налаштувань центру розгортання.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Перейдіть до Docker Hub, виберіть свій репозиторій і виберіть вебхуки.
1. Вставте 'Webhook url' з Azure у URL-адресу вебхука Docker Hub і вкажіть ім'я.<br>
![Webhook settings in docker](/_assets/java/java-azure/webhook.png)<br>
1. Натисніть кнопку створення.
1. Поверніться до огляду функції azure і запустіть контейнер.<br>
![Overview menu](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Це може зайняти кілька хвилин, поки функція запуститься.
{{% /alert %}}

## Приклад виконання

1. Налаштування Postman.<br>
![Overview menu](/_assets/java/java-azure/postman-settings.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Натисніть кнопку відправки.
1. Збережіть результат
![Save responce](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Якщо відповідь успішна, натисніть Зберегти у файл, і ви отримаєте конвертований файл у форматі png.
{{% /alert %}}

## Більше прикладів

Для отримання додаткових прикладів використання Aspose.CAD у Docker дивіться [приклади](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Дивіться також

- [Встановіть Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Встановіть Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Переключитися на контейнері Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
